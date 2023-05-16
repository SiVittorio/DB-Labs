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
            employeeInfo = new ListBox();
            SuspendLayout();
            // 
            // getEmployeeBtn
            // 
            getEmployeeBtn.Location = new Point(102, 43);
            getEmployeeBtn.Name = "getEmployeeBtn";
            getEmployeeBtn.Size = new Size(173, 29);
            getEmployeeBtn.TabIndex = 0;
            getEmployeeBtn.Text = "Инфо о сотруднике";
            getEmployeeBtn.UseVisualStyleBackColor = true;
            getEmployeeBtn.Click += getEmployeeBtn_Click;
            // 
            // employeeInfo
            // 
            employeeInfo.FormattingEnabled = true;
            employeeInfo.ItemHeight = 20;
            employeeInfo.Location = new Point(102, 91);
            employeeInfo.Name = "employeeInfo";
            employeeInfo.Size = new Size(173, 104);
            employeeInfo.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 258);
            Controls.Add(employeeInfo);
            Controls.Add(getEmployeeBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button getEmployeeBtn;
        private ListBox employeeInfo;
    }
}