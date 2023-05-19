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
            colLastName = new ColumnHeader();
            colFirstName = new ColumnHeader();
            colMiddleName = new ColumnHeader();
            SuspendLayout();
            // 
            // listEmployees
            // 
            listEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listEmployees.Columns.AddRange(new ColumnHeader[] { colLastName, colFirstName, colMiddleName });
            listEmployees.Location = new Point(12, 121);
            listEmployees.Name = "listEmployees";
            listEmployees.Size = new Size(558, 240);
            listEmployees.TabIndex = 1;
            listEmployees.UseCompatibleStateImageBehavior = false;
            listEmployees.View = View.Details;
            // 
            // colLastName
            // 
            colLastName.Text = "Фамилия";
            colLastName.Width = 180;
            // 
            // colFirstName
            // 
            colFirstName.Text = "Имя";
            colFirstName.Width = 180;
            // 
            // colMiddleName
            // 
            colMiddleName.Text = "Отчество";
            colMiddleName.Width = 180;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
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
    }
}