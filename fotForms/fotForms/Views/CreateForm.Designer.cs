namespace fotForms.Views
{
    partial class CreateForm
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
            cmbSciJob = new ComboBox();
            Ranks = new TableLayoutPanel();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            rb4 = new RadioButton();
            cmbJob = new ComboBox();
            tbLName = new TextBox();
            tbFName = new TextBox();
            tbMName = new TextBox();
            tbEmail = new TextBox();
            tableProps = new TableLayoutPanel();
            cmbMainWork = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            chbPhoneEnable = new CheckBox();
            tbPhone = new MaskedTextBox();
            panel1 = new Panel();
            bntCancel = new Button();
            btnSave = new Button();
            Ranks.SuspendLayout();
            tableProps.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSciJob
            // 
            cmbSciJob.Dock = DockStyle.Fill;
            cmbSciJob.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSciJob.FormattingEnabled = true;
            cmbSciJob.Location = new Point(13, 348);
            cmbSciJob.Name = "cmbSciJob";
            cmbSciJob.Size = new Size(342, 28);
            cmbSciJob.TabIndex = 8;
            // 
            // Ranks
            // 
            Ranks.ColumnCount = 4;
            Ranks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Ranks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Ranks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Ranks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Ranks.Controls.Add(rb1, 0, 0);
            Ranks.Controls.Add(rb2, 1, 0);
            Ranks.Controls.Add(rb3, 2, 0);
            Ranks.Controls.Add(rb4, 3, 0);
            Ranks.Dock = DockStyle.Fill;
            Ranks.Location = new Point(13, 308);
            Ranks.Name = "Ranks";
            Ranks.RowCount = 1;
            Ranks.RowStyles.Add(new RowStyle());
            Ranks.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Ranks.Size = new Size(342, 34);
            Ranks.TabIndex = 7;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Dock = DockStyle.Fill;
            rb1.Location = new Point(3, 3);
            rb1.Name = "rb1";
            rb1.Size = new Size(79, 28);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "Ранг 1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Dock = DockStyle.Fill;
            rb2.Location = new Point(88, 3);
            rb2.Name = "rb2";
            rb2.Size = new Size(79, 28);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "Ранг 2";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Dock = DockStyle.Fill;
            rb3.Location = new Point(173, 3);
            rb3.Name = "rb3";
            rb3.Size = new Size(79, 28);
            rb3.TabIndex = 2;
            rb3.TabStop = true;
            rb3.Text = "Ранг 3";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Dock = DockStyle.Fill;
            rb4.Location = new Point(258, 3);
            rb4.Name = "rb4";
            rb4.Size = new Size(81, 28);
            rb4.TabIndex = 3;
            rb4.TabStop = true;
            rb4.Text = "Ранг 4";
            rb4.UseVisualStyleBackColor = true;
            // 
            // cmbJob
            // 
            cmbJob.Dock = DockStyle.Fill;
            cmbJob.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJob.FormattingEnabled = true;
            cmbJob.Location = new Point(13, 265);
            cmbJob.Name = "cmbJob";
            cmbJob.Size = new Size(342, 28);
            cmbJob.TabIndex = 6;
            // 
            // tbLName
            // 
            tbLName.Dock = DockStyle.Fill;
            tbLName.Location = new Point(13, 13);
            tbLName.MaxLength = 30;
            tbLName.Name = "tbLName";
            tbLName.PlaceholderText = "Фамилия";
            tbLName.Size = new Size(342, 27);
            tbLName.TabIndex = 0;
            // 
            // tbFName
            // 
            tbFName.Dock = DockStyle.Fill;
            tbFName.Location = new Point(13, 55);
            tbFName.MaxLength = 30;
            tbFName.Name = "tbFName";
            tbFName.PlaceholderText = "Имя";
            tbFName.Size = new Size(342, 27);
            tbFName.TabIndex = 1;
            // 
            // tbMName
            // 
            tbMName.Dock = DockStyle.Fill;
            tbMName.Location = new Point(13, 97);
            tbMName.MaxLength = 30;
            tbMName.Name = "tbMName";
            tbMName.PlaceholderText = "Отчество";
            tbMName.Size = new Size(342, 27);
            tbMName.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.Dock = DockStyle.Fill;
            tbEmail.Location = new Point(13, 139);
            tbEmail.MaxLength = 100;
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "email@example.ru";
            tbEmail.Size = new Size(342, 27);
            tbEmail.TabIndex = 4;
            // 
            // tableProps
            // 
            tableProps.ColumnCount = 1;
            tableProps.ColumnStyles.Add(new ColumnStyle());
            tableProps.Controls.Add(tbEmail, 0, 3);
            tableProps.Controls.Add(tbMName, 0, 2);
            tableProps.Controls.Add(tbFName, 0, 1);
            tableProps.Controls.Add(tbLName, 0, 0);
            tableProps.Controls.Add(cmbJob, 0, 6);
            tableProps.Controls.Add(Ranks, 0, 7);
            tableProps.Controls.Add(cmbSciJob, 0, 8);
            tableProps.Controls.Add(cmbMainWork, 0, 4);
            tableProps.Controls.Add(tableLayoutPanel2, 0, 5);
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
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2901745F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 9.43266F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0519753F));
            tableProps.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0519733F));
            tableProps.Size = new Size(368, 437);
            tableProps.TabIndex = 0;
            // 
            // cmbMainWork
            // 
            cmbMainWork.Dock = DockStyle.Fill;
            cmbMainWork.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMainWork.FormattingEnabled = true;
            cmbMainWork.Location = new Point(13, 181);
            cmbMainWork.Name = "cmbMainWork";
            cmbMainWork.Size = new Size(342, 28);
            cmbMainWork.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1228065F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8771935F));
            tableLayoutPanel2.Controls.Add(chbPhoneEnable, 0, 0);
            tableLayoutPanel2.Controls.Add(tbPhone, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(13, 223);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(342, 36);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // chbPhoneEnable
            // 
            chbPhoneEnable.AutoSize = true;
            chbPhoneEnable.Dock = DockStyle.Fill;
            chbPhoneEnable.Location = new Point(3, 3);
            chbPhoneEnable.Name = "chbPhoneEnable";
            chbPhoneEnable.Size = new Size(162, 30);
            chbPhoneEnable.TabIndex = 2;
            chbPhoneEnable.Text = "Есть телефон";
            chbPhoneEnable.UseVisualStyleBackColor = true;
            chbPhoneEnable.CheckedChanged += chbPhoneEnable_CheckedChanged;
            // 
            // tbPhone
            // 
            tbPhone.Dock = DockStyle.Fill;
            tbPhone.Enabled = false;
            tbPhone.Location = new Point(171, 3);
            tbPhone.Mask = "+7 (000) 000 00-00";
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(168, 27);
            tbPhone.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 512);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 5, 20, 5);
            panel1.Size = new Size(368, 41);
            panel1.TabIndex = 1;
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
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 563);
            Controls.Add(panel1);
            Controls.Add(tableProps);
            Name = "CreateForm";
            Padding = new Padding(0, 0, 0, 10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateForm";
            FormClosing += CreateForm_FormClosing;
            Load += CreateForm_Load;
            Shown += CreateForm_Shown;
            Ranks.ResumeLayout(false);
            Ranks.PerformLayout();
            tableProps.ResumeLayout(false);
            tableProps.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbSciJob;
        private TableLayoutPanel Ranks;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3;
        private RadioButton rb4;
        private ComboBox cmbJob;
        private TextBox tbLName;
        private TextBox tbFName;
        private TextBox tbMName;
        private TextBox tbEmail;
        private TableLayoutPanel tableProps;
        private Panel panel1;
        private Button bntCancel;
        private ComboBox cmbMainWork;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox chbPhoneEnable;
        private MaskedTextBox tbPhone;
        public Button btnSave;
    }
}