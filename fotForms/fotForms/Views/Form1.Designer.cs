﻿namespace fotForms.Views
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
            labelCurDate = new Label();
            groupButtons.SuspendLayout();
            groupAnalysisInfo.SuspendLayout();
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
            btnEmployees.Location = new Point(6, 26);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(105, 29);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Сотрудники";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnProjects
            // 
            btnProjects.Location = new Point(6, 76);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(105, 29);
            btnProjects.TabIndex = 2;
            btnProjects.Text = "Проекты";
            btnProjects.UseVisualStyleBackColor = true;
            // 
            // groupButtons
            // 
            groupButtons.Controls.Add(btnProjects);
            groupButtons.Controls.Add(btnEmployees);
            groupButtons.Location = new Point(12, 12);
            groupButtons.Name = "groupButtons";
            groupButtons.Size = new Size(117, 330);
            groupButtons.TabIndex = 3;
            groupButtons.TabStop = false;
            // 
            // groupAnalysisInfo
            // 
            groupAnalysisInfo.Controls.Add(labelCurDate);
            groupAnalysisInfo.Location = new Point(135, 12);
            groupAnalysisInfo.Name = "groupAnalysisInfo";
            groupAnalysisInfo.Size = new Size(435, 330);
            groupAnalysisInfo.TabIndex = 4;
            groupAnalysisInfo.TabStop = false;
            groupAnalysisInfo.Text = "Информация";
            // 
            // labelCurDate
            // 
            labelCurDate.AutoSize = true;
            labelCurDate.ImageAlign = ContentAlignment.MiddleRight;
            labelCurDate.Location = new Point(251, 307);
            labelCurDate.Name = "labelCurDate";
            labelCurDate.RightToLeft = RightToLeft.No;
            labelCurDate.Size = new Size(178, 20);
            labelCurDate.TabIndex = 0;
            labelCurDate.Text = "Текущая дата: 01.01.2023";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(582, 353);
            Controls.Add(groupAnalysisInfo);
            Controls.Add(groupButtons);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            groupButtons.ResumeLayout(false);
            groupAnalysisInfo.ResumeLayout(false);
            groupAnalysisInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnEmployees;
        private Button btnProjects;
        private GroupBox groupButtons;
        private GroupBox groupAnalysisInfo;
        private Label labelCurDate;
    }
}