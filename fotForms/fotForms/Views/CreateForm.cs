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
            Employee employee = new Employee(tbFName.Text, tbMName.Text, tbLName.Text,
                tbEmail.Text, tbPhone.Text);

            EmployeeInfo employeeInfo = new EmployeeInfo(0, await MainController.GetId("jobs", "name", cmbJob.Text), 0,
                await MainController.GetId("sci_jobs", "name", cmbSciJob.Text),
                await MainController.GetId("main_work", "name", cmbMainWork.Text));
        }
    }
}
