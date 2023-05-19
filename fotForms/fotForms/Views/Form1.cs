using fotForms.ViewModels;
using fotForms.Models;
using System.Windows.Forms;

namespace fotForms.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getEmployeeBtn_Click(object sender, EventArgs e)
        {
            //Employee employee = MainController.GetEmployee(Int32.Parse(employeeIdBox.Text));

            //employeeInfo.Items.Add(employee.Id + employee.m_name);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            //this.Hide();
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
            employeeForm.Location = this.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCurDate.Text = "Текущая дата: " + DateTime.Now.ToString("d");
        }
    }
}