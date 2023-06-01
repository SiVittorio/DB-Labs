using fotForms.Models;
using fotForms.ViewModels;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fotForms.Views
{
    public partial class EmployeeForm : Form
    {
        private CreateForm createForm = new CreateForm();
        public EmployeeForm()
        {
            InitializeComponent();
            listEmployees.GetType()
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(listEmployees, true, null);
        }

        private async void EmployeeForm_Load(object sender, EventArgs e)
        {


        }
        private void AddEmployeeInList(List<Employee> list)
        {
            foreach (Employee emp in list)
            {
                //listEmployees.Items.Add(new ListViewItem(new string[] { emp.Id.ToString(), emp.l_name, emp.f_name, emp.m_name }));
                listEmployees.Invoke(new Action(() =>
                {
                    listEmployees.Items.Add(new ListViewItem(new string[] { emp.Id.ToString(), emp.L_name, emp.F_name, emp.Mid_name }));
                    progressBar1.PerformStep();
                }));
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            createForm.ReadFlag = false;
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                listEmployees.Items.Add(new ListViewItem
                (new string[] { createForm.Employee.Id.ToString(), createForm.Employee.L_name, createForm.Employee.F_name, createForm.Employee.Mid_name }));
                listEmployees.Items[listEmployees.Items.Count - 1].Selected = true;
                listEmployees.EnsureVisible(listEmployees.Items.Count - 1);
            }
        }

        private async void EmployeeForm_Shown(object sender, EventArgs e)
        {
            await createForm.LoadComboBoxes();

            List<Employee> list = await EmployeeViewModel.GetEmployeesName();

            progressBar1.Maximum = list.Count;

            await Task.Run(() => AddEmployeeInList(list));

            progressBar1.Hide();
        }

        private void EmployeeForm_Activated(object sender, EventArgs e)
        {
            Owner.Enabled = false;
        }

        private void EmployeeForm_Deactivate(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            Owner.Enabled = true;
            Owner.Activate();
        }




        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var items = listEmployees.SelectedItems;
            if (listEmployees.SelectedIndices.Count > 0)
            {

                if (MessageBox.Show("Вы уверены?", "Подтвердите удаление", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (await EmployeeViewModel.DeleteEmployee(Int32.Parse(items[0].SubItems[0].Text)))
                    {
                        listEmployees.Items.RemoveAt(listEmployees.SelectedIndices[0]);
                        MessageBox.Show("Пользователь удален", "Успешно");
                    }
                }

            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Сотрудник не выбран");
            }
        }

        private async void btnView_Click(object sender, EventArgs e)
        {
            var items = listEmployees.SelectedItems;
            if (listEmployees.SelectedIndices.Count > 0)
            {

                createForm.Employee = await EmployeeViewModel.GetEmployee(Int32.Parse(items[0].SubItems[0].Text));
                createForm.EmployeeInfo = await EmployeeViewModel.GetEmployeeInfo(Int32.Parse(items[0].SubItems[0].Text));


                createForm.ReadFlag = true;
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    items[0].SubItems[1].Text = createForm.Employee.L_name;
                    items[0].SubItems[2].Text = createForm.Employee.F_name;
                    items[0].SubItems[3].Text = createForm.Employee.Mid_name;
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент для просмотра", "Сотрудник не выбран");
            }


            

        }
        /*public void AddNewItem(Employee emp)
{
listEmployees.Items.Add(new ListViewItem(new string[] { emp.Id.ToString(), emp.L_name, emp.F_name, emp.Mid_name }));
}*/
    }
}
