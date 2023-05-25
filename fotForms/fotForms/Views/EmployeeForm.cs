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
        public EmployeeForm()
        {
            InitializeComponent();
            listEmployees.GetType()
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(listEmployees, true, null);
        }

        private async void EmployeeForm_Load(object sender, EventArgs e)
        {
            List<Employee> list = await EmployeeViewModel.GetEmployeesName();
            progressBar1.Maximum = list.Count;

            await Task.Run(() => AddEmployeeInList(list));

            progressBar1.Hide();

        }
        private void AddEmployeeInList(List<Employee> list)
        {
            foreach (Employee emp in list)
            {
                //listEmployees.Items.Add(new ListViewItem(new string[] { emp.Id.ToString(), emp.l_name, emp.f_name, emp.m_name }));
                listEmployees.Invoke(new Action(() =>
                {
                    listEmployees.Items.Add(new ListViewItem(new string[] { emp.Id.ToString(), emp.l_name, emp.f_name, emp.m_name }));
                    progressBar1.PerformStep();
                }));
            }
        }
    }
}
