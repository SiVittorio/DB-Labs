using fotForms.Models;
using fotForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace fotForms.Views
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private async void CreateForm_Load(object sender, EventArgs e)
        {
            var list = await ComboBoxViewModel.GetData("jobs", "name");
            foreach (var item in list)
            {
                cmbJob.Items.Add(item);
            }
            cmbJob.SelectedIndex = 0;
            list = await ComboBoxViewModel.GetData("sci_jobs", "name");
            foreach (var item in list)
            {
                cmbSciJob.Items.Add(item);
            }
            cmbSciJob.SelectedIndex = 0;
            list = await ComboBoxViewModel.GetData("main_work", "name");
            foreach (var item in list)
            {
                cmbMainWork.Items.Add(item);
            }
            cmbMainWork.SelectedIndex = 0;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (tbLName.Text.Length == 0)
            {
                await Task.Run(() => MessageBox.Show("Поле \"Фамилия\" не может быть пустым", "Внимание"));
            }
            else if (tbFName.Text.Length == 0)
            {
                await Task.Run(() =>
                    MessageBox.Show("Поле \"Имя\" не может быть пустым", "Внимание"));
            }
            else if (tbEmail.Text.Length == 0)
            {
                await Task.Run(() => MessageBox.Show("Введите электронную почту сотрудника", "Внимание"));
            }
            else if (!rb1.Checked && !rb2.Checked && !rb3.Checked && !rb4.Checked)
            {
                await Task.Run(() => MessageBox.Show("Выберите ранг для сотрудника", "Внимание"));
            }
            else if (chbPhoneEnable.Checked && !tbPhone.MaskFull)
            {
                await Task.Run(() => MessageBox.Show("Номер телефона не может содержать пробелы", "Внимание"));
            }
            else
            {
                Employee employee = new Employee(tbFName.Text, tbMName.Text, tbLName.Text,
                        tbEmail.Text, tbPhone.Text);


                var gradeId = Ranks.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name.Last();


                EmployeeInfo employeeInfo = new EmployeeInfo(await EmployeeViewModel.AddEmployee(employee), await MainController.GetId("jobs", "name", cmbJob.Text), Int32.Parse(gradeId.ToString()),
                    await MainController.GetId("sci_jobs", "name", cmbSciJob.Text),
                    await MainController.GetId("main_work", "name", cmbMainWork.Text));

                await EmployeeViewModel.AddEmplyeeInfo(employeeInfo);

                MessageBox.Show($"Пользователь {employee.L_name} {employee.F_name} {employee.Mid_name}" +
                    $" успешно добавлен", "Успешно");

                tbPhone.Clear();
                tbFName.Clear();
                tbLName.Clear();
                tbMName.Clear();
                tbEmail.Clear();
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                chbPhoneEnable.Checked = false;
                cmbJob.SelectedIndex = 0;
                cmbMainWork.SelectedIndex = 0;
                cmbSciJob.SelectedIndex = 0;

            }

        }

        private void chbPhoneEnable_CheckedChanged(object sender, EventArgs e)
        {
            tbPhone.Enabled = chbPhoneEnable.Checked;
        }
    }
}
