using fotForms.Models;
using fotForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotForms.Views
{
    public partial class ProjectCreateForm : Form
    {
        public Project Project { get; set; }
        public bool ReadFlag = false;
        public ProjectCreateForm()
        {
            InitializeComponent();
        }

        private void ProjectCreateForm_Load(object sender, EventArgs e)
        {
            if (!ReadFlag)
            {
                SwitchReadMode(ReadFlag);

                tbClName.Clear();
                tbCode.Clear();
                tbEmail.Clear();
                tbName.Clear();

                dateBegin.Text = System.DateTime.Now.ToString();

                chbIsFinished.Checked = false;

                dateEnd.Text = System.DateTime.Now.ToString();
                tableLayoutEndDate.Hide();
            }
            else
            {
                SwitchReadMode(ReadFlag);
            }
        }

        private void SwitchReadMode(bool mode)
        {
            if (mode)
            {
                btnChange.Visible = mode;

                tbName.ReadOnly = mode;
                tbCode.ReadOnly = mode;
                tbEmail.ReadOnly = mode;
                tbClName.ReadOnly = mode;

                dateBegin.Enabled = !mode;
                chbIsFinished.Enabled = !mode;
                dateEnd.Enabled = !mode;

                tbName.Text = Project.Name;
                tbCode.Text = Project.Code;
                tbClName.Text = Project.ClientName;
                tbEmail.Text = Project.ClientEmail;

                dateBegin.Text = Project.BeginDate.ToString();
                chbIsFinished.Checked = Project.IsFinished;
                dateEnd.Text = Project.EndDate.ToString();

                btnSave.Enabled = !mode;
            }
            else
            {
                btnChange.Visible = mode;

                tbName.ReadOnly = mode;
                tbCode.ReadOnly = mode;
                tbEmail.ReadOnly = mode;
                tbClName.ReadOnly = mode;

                dateBegin.Enabled = !mode;
                chbIsFinished.Enabled = !mode;
                dateEnd.Enabled = !mode;

                btnSave.Enabled = !mode;
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                await Task.Run(() =>
                MessageBox.Show("Поле \"Название проекта\" не может быть пустым", "Внимание"));
            }
            else if (tbCode.Text.Length == 0)
            {
                await Task.Run(() =>
                MessageBox.Show("Поле \"Код проекта\" не может быть пустым", "Внимание"));
            }
            else if (tbClName.Text.Length == 0)
            {
                await Task.Run(() =>
                MessageBox.Show("Поле \"Имя заказчика\" не может быть пустым", "Внимание"));
            }
            else if (tbEmail.Text.Length == 0)
            {
                await Task.Run(() =>
                MessageBox.Show("Поле \"Почта заказчика\" не может быть пустым", "Внимание"));
            }

            else if (chbIsFinished.Checked && DateTime.Compare(DateTime.Parse(dateEnd.Text), DateTime.Parse(dateBegin.Text)) < 0)
            {
                await Task.Run(() =>
                MessageBox.Show("Дата окончания проекта не может быть раньше даты начала", "Внимание"));
            }
            else
            {
                if (!ReadFlag)
                {
                    Project project = new Project
                        (tbName.Text, tbCode.Text, tbClName.Text, tbEmail.Text, chbIsFinished.Checked, DateTime.Parse(dateBegin.Text),
                        chbIsFinished.Checked ? DateTime.Parse(dateEnd.Text) : null);

                    project.Id = await ProjectViewModel.AddProject(project);

                    this.Project = project;

                    MessageBox.Show($"Проект {project.Name}" +
                        $" успешно добавлен", "Успешно");

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    this.Project.Name = tbName.Text;
                    this.Project.Code = tbCode.Text;
                    this.Project.ClientName = tbClName.Text;
                    this.Project.ClientEmail = tbEmail.Text;
                    this.Project.IsFinished = chbIsFinished.Checked;
                    this.Project.BeginDate = DateTime.Parse(dateBegin.Text);
                    if (this.Project.IsFinished)
                    {
                        this.Project.EndDate = DateTime.Parse(dateEnd.Text);
                    }
                    else
                    {
                        this.Project.EndDate = null;
                    }

                    await ProjectViewModel.UpdateProject(Project);

                    MessageBox.Show($"Проект {Project.Name}" +
                        $" успешно изменён", "Успешно");

                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void chbIsFinished_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutEndDate.Visible = chbIsFinished.Checked;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            SwitchReadMode(false);
            btnChange.Visible = false;
        }
    }
}
