namespace fotForms.Views
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnEmployees = new Button();
            btnProjects = new Button();
            groupButtons = new GroupBox();
            groupAnalysisInfo = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            tbFotYear = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tbFotMonth = new TextBox();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            groupButtons.SuspendLayout();
            groupAnalysisInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // btnEmployees
            // 
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.Location = new Point(3, 23);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(219, 29);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Сотрудники";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnProjects
            // 
            btnProjects.Dock = DockStyle.Top;
            btnProjects.Location = new Point(3, 52);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(219, 29);
            btnProjects.TabIndex = 2;
            btnProjects.Text = "Проекты";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // groupButtons
            // 
            groupButtons.Controls.Add(btnProjects);
            groupButtons.Controls.Add(btnEmployees);
            groupButtons.Dock = DockStyle.Left;
            groupButtons.Location = new Point(0, 0);
            groupButtons.Name = "groupButtons";
            groupButtons.Size = new Size(225, 481);
            groupButtons.TabIndex = 3;
            groupButtons.TabStop = false;
            // 
            // groupAnalysisInfo
            // 
            groupAnalysisInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupAnalysisInfo.Controls.Add(tableLayoutPanel1);
            groupAnalysisInfo.Location = new Point(225, 0);
            groupAnalysisInfo.Name = "groupAnalysisInfo";
            groupAnalysisInfo.Size = new Size(551, 481);
            groupAnalysisInfo.TabIndex = 4;
            groupAnalysisInfo.TabStop = false;
            groupAnalysisInfo.Text = "Информация";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.0800743F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9199257F));
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 0);
            tableLayoutPanel1.Controls.Add(monthCalendar1, 1, 0);
            tableLayoutPanel1.Location = new Point(6, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(537, 449);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(322, 213);
            splitContainer1.SplitterDistance = 104;
            splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbFotYear);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 104);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // tbFotYear
            // 
            tbFotYear.Dock = DockStyle.Right;
            tbFotYear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbFotYear.Location = new Point(169, 23);
            tbFotYear.Name = "tbFotYear";
            tbFotYear.ReadOnly = true;
            tbFotYear.RightToLeft = RightToLeft.Yes;
            tbFotYear.Size = new Size(150, 39);
            tbFotYear.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 0;
            label1.Text = "ФОТ за год:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbFotMonth);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 105);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // tbFotMonth
            // 
            tbFotMonth.Dock = DockStyle.Right;
            tbFotMonth.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbFotMonth.Location = new Point(169, 23);
            tbFotMonth.MinimumSize = new Size(150, 39);
            tbFotMonth.Name = "tbFotMonth";
            tbFotMonth.ReadOnly = true;
            tbFotMonth.RightToLeft = RightToLeft.Yes;
            tbFotMonth.Size = new Size(150, 39);
            tbFotMonth.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(171, 32);
            label2.TabIndex = 0;
            label2.Text = "ФОТ за месяц:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Dock = DockStyle.Top;
            monthCalendar1.Location = new Point(337, 9);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 481);
            Controls.Add(groupAnalysisInfo);
            Controls.Add(groupButtons);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 528);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ФОТ";
            Load += Form1_Load;
            groupButtons.ResumeLayout(false);
            groupAnalysisInfo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnEmployees;
        private Button btnProjects;
        private GroupBox groupButtons;
        private GroupBox groupAnalysisInfo;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private TextBox tbFotYear;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tbFotMonth;
        private Label label2;
        private MonthCalendar monthCalendar1;
    }
}