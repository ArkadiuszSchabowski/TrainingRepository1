﻿namespace SwineczkaProgramujeKalkulator
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
            tbScreen = new TextBox();
            Btn2 = new Button();
            Btn3 = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Btn7 = new Button();
            BtnClear = new Button();
            BtnResult = new Button();
            BtnAddition = new Button();
            BtnSubstraction = new Button();
            BtnMultiplication = new Button();
            BtnDivision = new Button();
            Btn0 = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn1 = new Button();
            label1 = new Label();
            BtnComma = new Button();
            SuspendLayout();
            // 
            // tbScreen
            // 
            tbScreen.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbScreen.Location = new Point(21, 276);
            tbScreen.Name = "tbScreen";
            tbScreen.Size = new Size(314, 35);
            tbScreen.TabIndex = 35;
            tbScreen.TextAlign = HorizontalAlignment.Right;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.Red;
            Btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn2.ForeColor = Color.White;
            Btn2.Location = new Point(98, 84);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(75, 37);
            Btn2.TabIndex = 34;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += OnBtnNumberClick;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.Red;
            Btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn3.ForeColor = Color.White;
            Btn3.Location = new Point(179, 84);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(75, 37);
            Btn3.TabIndex = 33;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += OnBtnNumberClick;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.Red;
            Btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn4.ForeColor = Color.White;
            Btn4.Location = new Point(17, 127);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(75, 37);
            Btn4.TabIndex = 32;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += OnBtnNumberClick;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.Red;
            Btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn5.ForeColor = Color.White;
            Btn5.Location = new Point(98, 127);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(75, 37);
            Btn5.TabIndex = 31;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += OnBtnNumberClick;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.Red;
            Btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn6.ForeColor = Color.White;
            Btn6.Location = new Point(179, 127);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(75, 37);
            Btn6.TabIndex = 30;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += OnBtnNumberClick;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.Red;
            Btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn7.ForeColor = Color.White;
            Btn7.Location = new Point(17, 170);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(75, 37);
            Btn7.TabIndex = 29;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += OnBtnNumberClick;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.Red;
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClear.ForeColor = Color.White;
            BtnClear.Location = new Point(179, 331);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 37);
            BtnClear.TabIndex = 28;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += OnBtnClearClick;
            // 
            // BtnResult
            // 
            BtnResult.BackColor = Color.Red;
            BtnResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnResult.ForeColor = Color.White;
            BtnResult.Location = new Point(260, 331);
            BtnResult.Name = "BtnResult";
            BtnResult.Size = new Size(75, 37);
            BtnResult.TabIndex = 27;
            BtnResult.Text = "=";
            BtnResult.UseVisualStyleBackColor = false;
            BtnResult.Click += OnBtnResultClick;
            // 
            // BtnAddition
            // 
            BtnAddition.BackColor = Color.Red;
            BtnAddition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddition.ForeColor = Color.White;
            BtnAddition.Location = new Point(260, 84);
            BtnAddition.Name = "BtnAddition";
            BtnAddition.Size = new Size(75, 37);
            BtnAddition.TabIndex = 26;
            BtnAddition.Text = "+";
            BtnAddition.UseVisualStyleBackColor = false;
            BtnAddition.Click += OnBtnOperationClick;
            // 
            // BtnSubstraction
            // 
            BtnSubstraction.BackColor = Color.Red;
            BtnSubstraction.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSubstraction.ForeColor = Color.White;
            BtnSubstraction.Location = new Point(260, 127);
            BtnSubstraction.Name = "BtnSubstraction";
            BtnSubstraction.Size = new Size(75, 37);
            BtnSubstraction.TabIndex = 25;
            BtnSubstraction.Text = "-";
            BtnSubstraction.UseVisualStyleBackColor = false;
            BtnSubstraction.Click += OnBtnOperationClick;
            // 
            // BtnMultiplication
            // 
            BtnMultiplication.BackColor = Color.Red;
            BtnMultiplication.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMultiplication.ForeColor = Color.White;
            BtnMultiplication.Location = new Point(260, 170);
            BtnMultiplication.Name = "BtnMultiplication";
            BtnMultiplication.Size = new Size(75, 37);
            BtnMultiplication.TabIndex = 24;
            BtnMultiplication.Text = "*";
            BtnMultiplication.UseVisualStyleBackColor = false;
            BtnMultiplication.Click += OnBtnOperationClick;
            // 
            // BtnDivision
            // 
            BtnDivision.BackColor = Color.Red;
            BtnDivision.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDivision.ForeColor = Color.White;
            BtnDivision.Location = new Point(260, 213);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(75, 37);
            BtnDivision.TabIndex = 23;
            BtnDivision.Text = "/";
            BtnDivision.UseVisualStyleBackColor = false;
            BtnDivision.Click += OnBtnOperationClick;
            // 
            // Btn0
            // 
            Btn0.BackColor = Color.Red;
            Btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn0.ForeColor = Color.White;
            Btn0.Location = new Point(17, 213);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(156, 37);
            Btn0.TabIndex = 22;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += OnBtnNumberClick;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.Red;
            Btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn9.ForeColor = Color.White;
            Btn9.Location = new Point(179, 170);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(75, 37);
            Btn9.TabIndex = 21;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += OnBtnNumberClick;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.Red;
            Btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn8.ForeColor = Color.White;
            Btn8.Location = new Point(98, 170);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(75, 37);
            Btn8.TabIndex = 20;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += OnBtnNumberClick;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.Red;
            Btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn1.ForeColor = Color.White;
            Btn1.Location = new Point(17, 84);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(75, 37);
            Btn1.TabIndex = 19;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += OnBtnNumberClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 31);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 18;
            label1.Text = "Witaj Świnko!";
            // 
            // BtnComma
            // 
            BtnComma.BackColor = Color.Red;
            BtnComma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnComma.ForeColor = Color.White;
            BtnComma.Location = new Point(179, 213);
            BtnComma.Name = "BtnComma";
            BtnComma.Size = new Size(75, 37);
            BtnComma.TabIndex = 36;
            BtnComma.Text = ",";
            BtnComma.UseVisualStyleBackColor = false;
            BtnComma.Click += OnBtnNumberClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(353, 398);
            Controls.Add(BtnComma);
            Controls.Add(tbScreen);
            Controls.Add(Btn2);
            Controls.Add(Btn3);
            Controls.Add(Btn4);
            Controls.Add(Btn5);
            Controls.Add(Btn6);
            Controls.Add(Btn7);
            Controls.Add(BtnClear);
            Controls.Add(BtnResult);
            Controls.Add(BtnAddition);
            Controls.Add(BtnSubstraction);
            Controls.Add(BtnMultiplication);
            Controls.Add(BtnDivision);
            Controls.Add(Btn0);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbScreen;
        private Button Btn2;
        private Button Btn3;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button Btn7;
        private Button BtnClear;
        private Button BtnResult;
        private Button BtnAddition;
        private Button BtnSubstraction;
        private Button BtnMultiplication;
        private Button BtnDivision;
        private Button Btn0;
        private Button Btn9;
        private Button Btn8;
        private Button Btn1;
        private Label label1;
        private Button BtnComma;
    }
}