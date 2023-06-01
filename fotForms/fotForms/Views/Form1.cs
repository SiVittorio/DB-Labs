using fotForms.ViewModels;
using fotForms.Models;
using System.Windows.Forms;

namespace fotForms.Views
{
    public partial class Form1 : Form
    {
        private EmployeeForm employeeForm;
        private ProjectForm projectForm;

        private Dictionary<string, double> fotYear;
        private Dictionary<KeyValuePair<int, int>, double> fotMonth;
        public Form1()
        {
            InitializeComponent();
            employeeForm = new EmployeeForm();
            projectForm = new ProjectForm();

        }

        private void getEmployeeBtn_Click(object sender, EventArgs e)
        {
            //Employee employee = MainController.GetEmployee(Int32.Parse(employeeIdBox.Text));

            //employeeInfo.Items.Add(employee.Id + employee.m_name);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            //this.Hide();

            employeeForm.Show(this);

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            fotYear = await TitleScreenViewModel.GetFotYear();
            fotMonth = await TitleScreenViewModel.GetFotMonth();

            monthCalendar1.MinDate = new DateTime(Int32.Parse(fotYear.First().Key), 1, 1);
            monthCalendar1.MaxDate = new DateTime(Int32.Parse(fotYear.Last().Key), 1, 1);

            tbFotYear.Text = Math.Round(fotYear[monthCalendar1.SelectionRange.Start.Year.ToString()]).ToString();
            tbFotMonth.Text = Math.Round(fotMonth
             [new KeyValuePair<int, int>(monthCalendar1.SelectionRange.Start.Year, monthCalendar1.SelectionRange.Start.Month)]).ToString();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            projectForm.Show(this);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tbFotYear.Text = Math.Round(fotYear[monthCalendar1.SelectionRange.Start.Year.ToString()]).ToString();
            tbFotMonth.Text = Math.Round(fotMonth
              [new KeyValuePair<int, int>(monthCalendar1.SelectionRange.Start.Year, monthCalendar1.SelectionRange.Start.Month)]).ToString();
        }
    }
}