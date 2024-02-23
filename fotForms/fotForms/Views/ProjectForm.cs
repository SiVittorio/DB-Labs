using fotForms.Models;
using fotForms.ViewModels;
using Npgsql;
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
    public partial class ProjectForm : Form
    {
        public ProjectCreateForm projectCreateForm = new ProjectCreateForm();
        public List<Project> projects;
        public ProjectForm()
        {
            InitializeComponent();
            listProjects.GetType()
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(listProjects, true, null);
        }

        private async void ProjectForm_Load(object sender, EventArgs e)
        {

        }

        public void AddProjectInList(List<Project> list)
        {
            foreach (Project prj in list)
            {
                listProjects.Invoke(new Action(() =>
                {
                    listProjects.Items.Add(new ListViewItem(new string[] { prj.Id.ToString(), prj.Name, prj.Code, prj.IsFinished ? "Да" : "Нет" }));

                }));
            }
        }

        private void ProjectForm_Activated(object sender, EventArgs e)
        {
            Owner.Enabled = false;
        }

        private void ProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            Owner.Enabled = true;
            Owner.Activate();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            projectCreateForm.ReadFlag = false;
            if (projectCreateForm.ShowDialog() == DialogResult.OK)
            {
                listProjects.Items.Add(new ListViewItem
                    (new string[] { projectCreateForm.Project.Id.ToString(), projectCreateForm.Project.Name, projectCreateForm.Project.Code, projectCreateForm.Project.IsFinished ? "Да" : "Нет" }));
                listProjects.Items[listProjects.Items.Count - 1].Selected = true;
                listProjects.EnsureVisible(listProjects.Items.Count - 1);
            }
        }

        private async void btnView_Click(object sender, EventArgs e)
        {
            var items = listProjects.SelectedItems;
            if (listProjects.SelectedIndices.Count > 0)
            {

                projectCreateForm.Project = await ProjectViewModel.GetProject(Int32.Parse(items[0].SubItems[0].Text));

                projectCreateForm.ReadFlag = true;
                if (projectCreateForm.ShowDialog() == DialogResult.OK)
                {
                    items[0].SubItems[1].Text = projectCreateForm.Project.Name;
                    items[0].SubItems[2].Text = projectCreateForm.Project.Code;
                    items[0].SubItems[3].Text = projectCreateForm.Project.IsFinished ? "Да" : "Нет";
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент для просмотра", "Сотрудник не выбран");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var items = listProjects.SelectedItems;
            if (listProjects.SelectedIndices.Count > 0)
            {

                if (MessageBox.Show("Вы уверены?", "Подтвердите удаление", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (await ProjectViewModel.DeleteEmployee(Int32.Parse(items[0].SubItems[0].Text)))
                    {
                        listProjects.Items.RemoveAt(listProjects.SelectedIndices[0]);
                        MessageBox.Show("Проект удален", "Успешно");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Сотрудник не выбран");
            }
        }
    }
}
