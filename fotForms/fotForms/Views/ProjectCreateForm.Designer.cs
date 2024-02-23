namespace fotForms.Views
{
    partial class ProjectCreateForm
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
            bntCancel = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            chbIsFinished = new CheckBox();
            tableProps = new TableLayoutPanel();
            tbClName = new TextBox();
            tbCode = new TextBox();
            tbName = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutBeginDate = new TableLayoutPanel();
            label1 = new Label();
            dateBegin = new DateTimePicker();
            tbEmail = new TextBox();
            tableLayoutEndDate = new TableLayoutPanel();
            label2 = new Label();
            dateEnd = new DateTimePicker();
            panel2 = new Panel();
            btnChange = new Button();
            panel1.SuspendLayout();
            tableProps.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutBeginDate.SuspendLayout();
            tableLayoutEndDate.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bntCancel
            // 
            bntCancel.Dock = DockStyle.Left;
            bntCancel.Location = new Point(20, 5);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(94, 31);
            bntCancel.TabIndex = 1;
            bntCancel.Text = "Отмена";
            bntCancel.UseVisualStyleBackColor = true;
            bntCancel.Click += bntCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.Location = new Point(254, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 487);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 5, 20, 5);
            panel1.Size = new Size(368, 41);
            panel1.TabIndex = 4;
            // 
            // chbIsFinished
            // 
            chbIsFinished.AutoSize = true;
            chbIsFinished.Dock = DockStyle.Fill;
            chbIsFinished.Location = new Point(3, 3);
            chbIsFinished.Name = "chbIsFinished";
            chbIsFinished.Size = new Size(162, 31);
            chbIsFinished.TabIndex = 2;
            chbIsFinished.Text = "Проект закончен";
            chbIsFinished.UseVisualStyleBackColor = true;
            chbIsFinished.CheckedChanged += chbIsFinished_CheckedChanged;
            // 
            // tableProps
            // 
            tableProps.ColumnCount = 1;
            tableProps.ColumnStyles.Add(new ColumnStyle());
            tableProps.Controls.Add(tbClName, 0, 2);
            tableProps.Controls.Add(tbCode, 0, 1);
            tableProps.Controls.Add(tbName, 0, 0);
            tableProps.Controls.Add(tableLayoutPanel2, 0, 5);
            tableProps.Controls.Add(tableLayoutBeginDate, 0, 4);
            tableProps.Controls.Add(tbEmail, 0, 3);
            tableProps.Controls.Add(tableLayoutEndDate, 0, 6);
            tableProps.Dock = DockStyle.Top;
            tableProps.Location = new Point(0, 0);
            tableProps.Name = "tableProps";
            tableProps.Padding = new Padding(10, 10, 10, 0);
            tableProps.RowCount = 10;
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0519733F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0519753F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0519753F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0519733F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 9.913345F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0519753F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5831385F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 5.8548007F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0519753F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0519733F));
            tableProps.Size = new Size(368, 437);
            tableProps.TabIndex = 3;
            // 
            // tbClName
            // 
            tbClName.Dock = DockStyle.Fill;
            tbClName.Location = new Point(13, 99);
            tbClName.MaxLength = 30;
            tbClName.Name = "tbClName";
            tbClName.PlaceholderText = "Имя заказчика";
            tbClName.Size = new Size(342, 27);
            tbClName.TabIndex = 2;
            // 
            // tbCode
            // 
            tbCode.Dock = DockStyle.Fill;
            tbCode.Location = new Point(13, 56);
            tbCode.MaxLength = 30;
            tbCode.Name = "tbCode";
            tbCode.PlaceholderText = "Код проекта";
            tbCode.Size = new Size(342, 27);
            tbCode.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Dock = DockStyle.Fill;
            tbName.Location = new Point(13, 13);
            tbName.MaxLength = 30;
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Название проекта";
            tbName.Size = new Size(342, 27);
            tbName.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1228065F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8771935F));
            tableLayoutPanel2.Controls.Add(chbIsFinished, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(13, 227);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(342, 37);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutBeginDate
            // 
            tableLayoutBeginDate.ColumnCount = 2;
            tableLayoutBeginDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1228065F));
            tableLayoutBeginDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8771935F));
            tableLayoutBeginDate.Controls.Add(label1, 0, 0);
            tableLayoutBeginDate.Controls.Add(dateBegin, 1, 0);
            tableLayoutBeginDate.Dock = DockStyle.Fill;
            tableLayoutBeginDate.Location = new Point(13, 185);
            tableLayoutBeginDate.Name = "tableLayoutBeginDate";
            tableLayoutBeginDate.RowCount = 1;
            tableLayoutBeginDate.RowStyles.Add(new RowStyle());
            tableLayoutBeginDate.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutBeginDate.Size = new Size(342, 36);
            tableLayoutBeginDate.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 10);
            label1.Margin = new Padding(3, 10, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 26);
            label1.TabIndex = 14;
            label1.Text = "Дата начала проекта";
            // 
            // dateBegin
            // 
            dateBegin.Dock = DockStyle.Fill;
            dateBegin.Location = new Point(171, 3);
            dateBegin.Name = "dateBegin";
            dateBegin.Size = new Size(168, 27);
            dateBegin.TabIndex = 15;
            // 
            // tbEmail
            // 
            tbEmail.Dock = DockStyle.Fill;
            tbEmail.Location = new Point(13, 142);
            tbEmail.MaxLength = 100;
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Почта заказчика: email@example.ru";
            tbEmail.Size = new Size(342, 27);
            tbEmail.TabIndex = 4;
            // 
            // tableLayoutEndDate
            // 
            tableLayoutEndDate.ColumnCount = 2;
            tableLayoutEndDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1228065F));
            tableLayoutEndDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8771935F));
            tableLayoutEndDate.Controls.Add(label2, 0, 0);
            tableLayoutEndDate.Controls.Add(dateEnd, 1, 0);
            tableLayoutEndDate.Dock = DockStyle.Fill;
            tableLayoutEndDate.Location = new Point(13, 270);
            tableLayoutEndDate.Name = "tableLayoutEndDate";
            tableLayoutEndDate.RowCount = 1;
            tableLayoutEndDate.RowStyles.Add(new RowStyle());
            tableLayoutEndDate.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutEndDate.Size = new Size(342, 52);
            tableLayoutEndDate.TabIndex = 14;
            tableLayoutEndDate.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 10);
            label2.Margin = new Padding(3, 10, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 42);
            label2.TabIndex = 14;
            label2.Text = "Дата окончания проекта";
            // 
            // dateEnd
            // 
            dateEnd.Dock = DockStyle.Fill;
            dateEnd.Location = new Point(171, 3);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(168, 27);
            dateEnd.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnChange);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 446);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 5, 20, 5);
            panel2.Size = new Size(368, 41);
            panel2.TabIndex = 5;
            // 
            // btnChange
            // 
            btnChange.Dock = DockStyle.Right;
            btnChange.Location = new Point(254, 5);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(94, 31);
            btnChange.TabIndex = 0;
            btnChange.Text = "Изменить";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // ProjectCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tableProps);
            Name = "ProjectCreateForm";
            Padding = new Padding(0, 0, 0, 10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Управление проектами";
            Load += ProjectCreateForm_Load;
            panel1.ResumeLayout(false);
            tableProps.ResumeLayout(false);
            tableProps.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutBeginDate.ResumeLayout(false);
            tableLayoutBeginDate.PerformLayout();
            tableLayoutEndDate.ResumeLayout(false);
            tableLayoutEndDate.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button bntCancel;
        public Button btnSave;
        private Panel panel1;
        private CheckBox chbIsFinished;
        private TableLayoutPanel tableProps;
        private TextBox tbClName;
        private TextBox tbCode;
        private TextBox tbName;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutBeginDate;
        private Label label1;
        private DateTimePicker dateBegin;
        private TextBox tbEmail;
        private TableLayoutPanel tableLayoutEndDate;
        private Label label2;
        private DateTimePicker dateEnd;
        private Panel panel2;
        public Button btnChange;
    }
}