namespace fotForms.Views
{
    partial class ProjectForm
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
            listProjects = new ListView();
            colID = new ColumnHeader();
            colPrjName = new ColumnHeader();
            colPrjCode = new ColumnHeader();
            colIsFinished = new ColumnHeader();
            btnCreate = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDelete = new Button();
            btnView = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listProjects
            // 
            listProjects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listProjects.Columns.AddRange(new ColumnHeader[] { colID, colPrjName, colPrjCode, colIsFinished });
            listProjects.FullRowSelect = true;
            listProjects.GridLines = true;
            listProjects.Location = new Point(12, 173);
            listProjects.MultiSelect = false;
            listProjects.Name = "listProjects";
            listProjects.Size = new Size(858, 268);
            listProjects.TabIndex = 5;
            listProjects.UseCompatibleStateImageBehavior = false;
            listProjects.View = View.Details;
            // 
            // colID
            // 
            colID.Text = "ID";
            colID.Width = 0;
            // 
            // colPrjName
            // 
            colPrjName.Text = "Название проекта";
            colPrjName.Width = 300;
            // 
            // colPrjCode
            // 
            colPrjCode.Text = "Код проекта";
            colPrjCode.Width = 300;
            // 
            // colIsFinished
            // 
            colIsFinished.Text = "Закончен";
            colIsFinished.Width = 300;
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
            groupBox1.TabIndex = 7;
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
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(listProjects);
            Controls.Add(groupBox1);
            MinimumSize = new Size(900, 500);
            Name = "ProjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список проектов";
            Activated += ProjectForm_Activated;
            FormClosing += ProjectForm_FormClosing;
            Load += ProjectForm_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public ListView listProjects;
        private ColumnHeader colID;
        private ColumnHeader colPrjName;
        private ColumnHeader colPrjCode;
        private ColumnHeader colIsFinished;
        private Button btnCreate;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDelete;
        private Button btnView;
    }
}