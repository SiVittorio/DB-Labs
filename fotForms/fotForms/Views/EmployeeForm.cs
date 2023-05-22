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

namespace fotForms.Views
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private async void EmployeeForm_Load(object sender, EventArgs e)
        {
            List<Employee> list = await EmployeeViewModel.GetEmployeesName();

            foreach (Employee emp in list)
            {
                listEmployees.Items.Add(new ListViewItem(new string[] { emp.Id.ToString(), emp.l_name, emp.f_name, emp.m_name }));
            }

        }
    }
}
