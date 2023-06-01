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
        public Employee Employee { get; set; }
        public EmployeeInfo EmployeeInfo { get; set; }

        public bool ReadFlag { get; set; }

        private List<string> mainWorks;
        private List<string> jobs;
        private List<string> sci_jobs;
        public CreateForm()
        {
            InitializeComponent();
        }
        #region Методы
        private async void CreateForm_Load(object sender, EventArgs e)
        {
            if (!ReadFlag)
            {
                SwitchReadMode(ReadFlag);
                tbPhone.Mask = "+7 (000) 000 00-00";
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
                if (cmbJob.Items.Count > 0)
                {
                    cmbJob.SelectedIndex = 0;
                    cmbMainWork.SelectedIndex = 0;
                    cmbSciJob.SelectedIndex = 0;
                }
            }
            else if (ReadFlag)
            {
                SwitchReadMode(true);
            }


        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            /*Hide();*/
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
                if (!ReadFlag)
                {
                    Employee employee = new Employee(tbFName.Text, tbMName.Text, tbLName.Text,
                       tbEmail.Text, !chbPhoneEnable.Checked ? null : tbPhone.Text);


                    var gradeId = Ranks.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name.Last();

                    employee.Id = await EmployeeViewModel.AddEmployee(employee);
                    EmployeeInfo employeeInfo = new EmployeeInfo(employee.Id, await MainController.GetId("jobs", "name", cmbJob.Text), Int32.Parse(gradeId.ToString()),
                        await MainController.GetId("sci_jobs", "name", cmbSciJob.Text),
                        await MainController.GetId("main_work", "name", cmbMainWork.Text));

                    await EmployeeViewModel.AddEmplyeeInfo(employeeInfo);

                    Employee = employee;
                    EmployeeInfo = employeeInfo;

                    MessageBox.Show($"Пользователь {employee.L_name} {employee.F_name} {employee.Mid_name}" +
                        $" успешно добавлен", "Успешно");

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    Employee.L_name = tbLName.Text;
                    Employee.Email = tbEmail.Text;
                    Employee.Phone = !chbPhoneEnable.Checked ? null : tbPhone.Text;
                    Employee.F_name = tbFName.Text;
                    Employee.Mid_name = tbMName.Text == "" ? null : tbMName.Text;


                    var gradeId = Ranks.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name.Last();

                    EmployeeInfo.RankId = Int32.Parse(gradeId.ToString());
                    EmployeeInfo.MainWorkId = await MainController.GetId("main_work", "name", cmbMainWork.Text);
                    EmployeeInfo.SciJobId = await MainController.GetId("sci_jobs", "name", cmbSciJob.Text);
                    EmployeeInfo.JobId = await MainController.GetId("jobs", "name", cmbJob.Text);

                    await EmployeeViewModel.UpdateEmployee(Employee);
                    await EmployeeViewModel.UpdateEmplyeeInfo(EmployeeInfo);

                    MessageBox.Show($"Пользователь {Employee.L_name} {Employee.F_name} {Employee.Mid_name}" +
                        $" успешно изменён", "Успешно");

                    DialogResult = DialogResult.OK;
                }

            }

        }

        private void chbPhoneEnable_CheckedChanged(object sender, EventArgs e)
        {
            tbPhone.Enabled = chbPhoneEnable.Checked;
        }



        #endregion



        private async void CreateForm_Shown(object sender, EventArgs e)
        {
            if (ReadFlag)
            {
                cmbJob.SelectedIndex = cmbJob.Items.IndexOf(await ComboBoxViewModel.GetData("jobs", "name", EmployeeInfo.JobId));
                cmbMainWork.SelectedIndex = cmbMainWork.Items.IndexOf(await ComboBoxViewModel.GetData("main_work", "name", EmployeeInfo.MainWorkId));
                cmbSciJob.SelectedIndex = cmbSciJob.Items.IndexOf(await ComboBoxViewModel.GetData("sci_jobs", "name", EmployeeInfo.SciJobId));
            }
            /*else
            {
                await LoadComboBoxes();
            }*/
        }

        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*e.Cancel = true;
            this.Hide();*/
        }

        private void SwitchReadMode(bool mode)
        {
            if (mode)
            {
                btnSave.Enabled = !mode;

                tbLName.ReadOnly = mode;
                tbMName.ReadOnly = mode;
                tbFName.ReadOnly = mode;
                tbEmail.ReadOnly = mode;
                tbPhone.ReadOnly = mode;


                tbLName.Text = Employee.L_name;
                tbFName.Text = Employee.F_name;
                tbMName.Text = Employee.Mid_name;
                tbEmail.Text = Employee.Email;

                chbPhoneEnable.Enabled = !mode;

                cmbJob.Enabled = !mode;
                cmbSciJob.Enabled = !mode;
                cmbMainWork.Enabled = !mode;

                Ranks.Enabled = !mode;

                btnChange.Visible = mode;

                if (Employee.Phone != null && Employee.Phone != "")
                {
                    tbPhone.Mask = "";
                    chbPhoneEnable.Checked = true;
                    tbPhone.Text = Employee.Phone;
                }
                else
                {
                    chbPhoneEnable.Checked = false;
                }


                switch (EmployeeInfo.RankId)
                {
                    case 1:
                        rb1.Checked = true; break;
                    case 2:
                        rb2.Checked = true; break;
                    case 3:
                        rb3.Checked = true; break;
                    case 4:
                        rb4.Checked = true; break;
                    default:
                        break;
                }
            }
            else
            {
                btnSave.Enabled = !mode;

                tbLName.ReadOnly = mode;
                tbMName.ReadOnly = mode;
                tbFName.ReadOnly = mode;
                tbEmail.ReadOnly = mode;
                tbPhone.ReadOnly = mode;

                chbPhoneEnable.Enabled = !mode;

                cmbJob.Enabled = !mode;
                cmbSciJob.Enabled = !mode;
                cmbMainWork.Enabled = !mode;

                Ranks.Enabled = !mode;
                btnChange.Visible = mode;
            }
        }

        public async Task LoadComboBoxes()
        {
            var list = await ComboBoxViewModel.GetData("main_work", "name");
            cmbMainWork.DataSource = list;
            cmbMainWork.SelectedIndex = 0;
            list = await ComboBoxViewModel.GetData("jobs", "name");
            cmbJob.DataSource = list;
            cmbJob.SelectedIndex = 0;
            list = await ComboBoxViewModel.GetData("sci_jobs", "name");
            cmbSciJob.DataSource = list;
            cmbSciJob.SelectedIndex = 0;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            SwitchReadMode(false);
            btnChange.Visible = false;
        }
    }
}
