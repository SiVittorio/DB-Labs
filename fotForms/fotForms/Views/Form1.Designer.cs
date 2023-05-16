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
            getEmployeeBtn = new Button();
            employeeIdBox = new TextBox();
            tableEmployees = new TableLayoutPanel();
            listView1 = new ListView();
            tableEmployees.SuspendLayout();
            SuspendLayout();
            // 
            // getEmployeeBtn
            // 
            getEmployeeBtn.Location = new Point(305, 91);
            getEmployeeBtn.Name = "getEmployeeBtn";
            getEmployeeBtn.Size = new Size(173, 29);
            getEmployeeBtn.TabIndex = 0;
            getEmployeeBtn.Text = "Инфо о сотруднике";
            getEmployeeBtn.UseVisualStyleBackColor = true;
            getEmployeeBtn.Click += getEmployeeBtn_Click;
            // 
            // employeeIdBox
            // 
            employeeIdBox.Location = new Point(305, 58);
            employeeIdBox.Name = "employeeIdBox";
            employeeIdBox.Size = new Size(173, 27);
            employeeIdBox.TabIndex = 2;
            // 
            // tableEmployees
            // 
            tableEmployees.ColumnCount = 7;
            tableEmployees.ColumnStyles.Add(new ColumnStyle());
            tableEmployees.ColumnStyles.Add(new ColumnStyle());
            tableEmployees.ColumnStyles.Add(new ColumnStyle());
            tableEmployees.ColumnStyles.Add(new ColumnStyle());
            tableEmployees.ColumnStyles.Add(new ColumnStyle());
            tableEmployees.ColumnStyles.Add(new ColumnStyle());
            tableEmployees.ColumnStyles.Add(new ColumnStyle());
            tableEmployees.Controls.Add(listView1, 6, 0);
            tableEmployees.Location = new Point(12, 126);
            tableEmployees.Name = "tableEmployees";
            tableEmployees.RowCount = 2;
            tableEmployees.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5525742F));
            tableEmployees.RowStyles.Add(new RowStyle(SizeType.Percent, 77.4474258F));
            tableEmployees.Size = new Size(729, 311);
            tableEmployees.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 64);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 482);
            Controls.Add(tableEmployees);
            Controls.Add(employeeIdBox);
            Controls.Add(getEmployeeBtn);
            Name = "Form1";
            Text = "Form1";
            tableEmployees.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getEmployeeBtn;
        private TextBox employeeIdBox;
        private TableLayoutPanel tableEmployees;
        private ListView listView1;
    }
}