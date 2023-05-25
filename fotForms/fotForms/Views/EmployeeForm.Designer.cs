namespace fotForms.Views
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listEmployees = new ListView();
            colID = new ColumnHeader();
            colLastName = new ColumnHeader();
            colFirstName = new ColumnHeader();
            colMiddleName = new ColumnHeader();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // listEmployees
            // 
            listEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listEmployees.Columns.AddRange(new ColumnHeader[] { colID, colLastName, colFirstName, colMiddleName });
            listEmployees.FullRowSelect = true;
            listEmployees.Location = new Point(12, 176);
            listEmployees.MultiSelect = false;
            listEmployees.Name = "listEmployees";
            listEmployees.Size = new Size(858, 242);
            listEmployees.TabIndex = 1;
            listEmployees.UseCompatibleStateImageBehavior = false;
            listEmployees.View = View.Details;
            // 
            // colID
            // 
            colID.Text = "ID";
            colID.Width = 0;
            // 
            // colLastName
            // 
            colLastName.Text = "Фамилия";
            colLastName.Width = 300;
            // 
            // colFirstName
            // 
            colFirstName.Text = "Имя";
            colFirstName.Width = 300;
            // 
            // colMiddleName
            // 
            colMiddleName.Text = "Отчество";
            colMiddleName.Width = 300;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 424);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(882, 29);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 2;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(progressBar1);
            Controls.Add(listEmployees);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listEmployees;
        private ColumnHeader colLastName;
        private ColumnHeader colFirstName;
        private ColumnHeader colMiddleName;
        private ColumnHeader colID;
        private ProgressBar progressBar1;
    }
}