using fotForms.Models;
using fotForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotForms.Views
{
    public partial class LoadingForm : Form
    {
        private Form1 MainForm = new Form1();
        public LoadingForm()
        {
            InitializeComponent();
        }

        private async void LoadingForm_Load(object sender, EventArgs e)
        {
            await MainForm.employeeForm.createForm.LoadComboBoxes();
            label1.Text = "Загрузка данных о пользователях";
            MainForm.employeeForm.employees = await EmployeeViewModel.GetEmployeesName();
            progressBar1.Value = 25;
            label1.Text = "Загрузка таблицы пользователей";
            nint dummy = MainForm.employeeForm.Handle;
            await Task.Run(() => MainForm.employeeForm.AddEmployeeInList(MainForm.employeeForm.employees));
            progressBar1.Value = 50;
            label1.Text = "Загрузка данных о проектах";
            MainForm.projectForm.projects = await ProjectViewModel.GetProjectsInList();
            progressBar1.Value = 75;
            dummy = MainForm.projectForm.Handle;
            progressBar1.Value = 100;
            label1.Text = "Загрузка таблицы проектов";
            await Task.Run(() => MainForm.projectForm.AddProjectInList(MainForm.projectForm.projects));
            

            this.Hide();
            MainForm.ShowDialog(this);
            this.Close();
        }
    }
}
