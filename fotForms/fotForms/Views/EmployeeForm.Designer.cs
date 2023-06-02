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
            btnCreate = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDelete = new Button();
            btnView = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listEmployees
            // 
            listEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listEmployees.Columns.AddRange(new ColumnHeader[] { colID, colLastName, colFirstName, colMiddleName });
            listEmployees.FullRowSelect = true;
            listEmployees.GridLines = true;
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
            // btnCreate
            // 
            btnCreate.Dock = DockStyle.Fill;
            btnCreate.Location = new Point(3, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(267, 28);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Добавить";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(30, 0, 30, 10);
            groupBox1.Size = new Size(882, 64);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnDelete, 0, 0);
            tableLayoutPanel1.Controls.Add(btnView, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCreate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(822, 34);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(549, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(270, 28);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.Dock = DockStyle.Fill;
            btnView.Location = new Point(276, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(267, 28);
            btnView.TabIndex = 4;
            btnView.Text = "Просмотр";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(progressBar1);
            Controls.Add(listEmployees);
            Controls.Add(groupBox1);
            MinimumSize = new Size(900, 500);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список сотрудников";
            Activated += EmployeeForm_Activated;
            Deactivate += EmployeeForm_Deactivate;
            FormClosing += EmployeeForm_FormClosing;
            Load += EmployeeForm_Load;
            Shown += EmployeeForm_Shown;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader colLastName;
        private ColumnHeader colFirstName;
        private ColumnHeader colMiddleName;
        private ColumnHeader colID;
        private ProgressBar progressBar1;
        private Button btnCreate;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDelete;
        private Button btnView;
        public ListView listEmployees;
    }
}