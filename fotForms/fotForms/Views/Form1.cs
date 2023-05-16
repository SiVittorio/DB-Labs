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
            MainController.GetEmployee(1);
        }
    }
}