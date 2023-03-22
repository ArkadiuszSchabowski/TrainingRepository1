namespace TestKalkulator
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
            label1 = new Label();
            Btn1 = new Button();
            Btn8 = new Button();
            Btn9 = new Button();
            Btn0 = new Button();
            BtnDivision = new Button();
            BtnMultiplication = new Button();
            BtnSubstraction = new Button();
            BtnAddition = new Button();
            BtnResult = new Button();
            BtnClear = new Button();
            Btn7 = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            Btn3 = new Button();
            Btn2 = new Button();
            tbScreen = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 24);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 0;
            label1.Text = "Witaj Świnko!";
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.Red;
            Btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn1.ForeColor = Color.White;
            Btn1.Location = new Point(12, 77);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(75, 37);
            Btn1.TabIndex = 1;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += OnBtnNumberClick;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.Red;
            Btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn8.ForeColor = Color.White;
            Btn8.Location = new Point(93, 163);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(75, 37);
            Btn8.TabIndex = 2;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += OnBtnNumberClick;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.Red;
            Btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn9.ForeColor = Color.White;
            Btn9.Location = new Point(174, 163);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(75, 37);
            Btn9.TabIndex = 3;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += OnBtnNumberClick;
            // 
            // Btn0
            // 
            Btn0.BackColor = Color.Red;
            Btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn0.ForeColor = Color.White;
            Btn0.Location = new Point(12, 206);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(156, 37);
            Btn0.TabIndex = 4;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += OnBtnNumberClick;
            // 
            // BtnDivision
            // 
            BtnDivision.BackColor = Color.Red;
            BtnDivision.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDivision.ForeColor = Color.White;
            BtnDivision.Location = new Point(255, 206);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(75, 37);
            BtnDivision.TabIndex = 5;
            BtnDivision.Text = "/";
            BtnDivision.UseVisualStyleBackColor = false;
            BtnDivision.Click += OnBtnOperationClick;
            // 
            // BtnMultiplication
            // 
            BtnMultiplication.BackColor = Color.Red;
            BtnMultiplication.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMultiplication.ForeColor = Color.White;
            BtnMultiplication.Location = new Point(255, 163);
            BtnMultiplication.Name = "BtnMultiplication";
            BtnMultiplication.Size = new Size(75, 37);
            BtnMultiplication.TabIndex = 6;
            BtnMultiplication.Text = "*";
            BtnMultiplication.UseVisualStyleBackColor = false;
            BtnMultiplication.Click += OnBtnOperationClick;
            // 
            // BtnSubstraction
            // 
            BtnSubstraction.BackColor = Color.Red;
            BtnSubstraction.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSubstraction.ForeColor = Color.White;
            BtnSubstraction.Location = new Point(255, 120);
            BtnSubstraction.Name = "BtnSubstraction";
            BtnSubstraction.Size = new Size(75, 37);
            BtnSubstraction.TabIndex = 7;
            BtnSubstraction.Text = "-";
            BtnSubstraction.UseVisualStyleBackColor = false;
            BtnSubstraction.Click += OnBtnOperationClick;
            // 
            // BtnAddition
            // 
            BtnAddition.BackColor = Color.Red;
            BtnAddition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddition.ForeColor = Color.White;
            BtnAddition.Location = new Point(255, 77);
            BtnAddition.Name = "BtnAddition";
            BtnAddition.Size = new Size(75, 37);
            BtnAddition.TabIndex = 8;
            BtnAddition.Text = "+";
            BtnAddition.UseVisualStyleBackColor = false;
            BtnAddition.Click += OnBtnOperationClick;
            // 
            // BtnResult
            // 
            BtnResult.BackColor = Color.Red;
            BtnResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnResult.ForeColor = Color.White;
            BtnResult.Location = new Point(255, 324);
            BtnResult.Name = "BtnResult";
            BtnResult.Size = new Size(75, 37);
            BtnResult.TabIndex = 9;
            BtnResult.Text = "=";
            BtnResult.UseVisualStyleBackColor = false;
            BtnResult.Click += OnBtnResultClick;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.Red;
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClear.ForeColor = Color.White;
            BtnClear.Location = new Point(53, 324);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 37);
            BtnClear.TabIndex = 10;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += OnBtnClearClick;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.Red;
            Btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn7.ForeColor = Color.White;
            Btn7.Location = new Point(12, 163);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(75, 37);
            Btn7.TabIndex = 11;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += OnBtnNumberClick;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.Red;
            Btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn6.ForeColor = Color.White;
            Btn6.Location = new Point(174, 120);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(75, 37);
            Btn6.TabIndex = 12;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += OnBtnNumberClick;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.Red;
            Btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn5.ForeColor = Color.White;
            Btn5.Location = new Point(93, 120);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(75, 37);
            Btn5.TabIndex = 13;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += OnBtnNumberClick;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.Red;
            Btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn4.ForeColor = Color.White;
            Btn4.Location = new Point(12, 120);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(75, 37);
            Btn4.TabIndex = 14;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += OnBtnNumberClick;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.Red;
            Btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn3.ForeColor = Color.White;
            Btn3.Location = new Point(174, 77);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(75, 37);
            Btn3.TabIndex = 15;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += OnBtnNumberClick;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.Red;
            Btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn2.ForeColor = Color.White;
            Btn2.Location = new Point(93, 77);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(75, 37);
            Btn2.TabIndex = 16;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += OnBtnNumberClick;
            // 
            // tbScreen
            // 
            tbScreen.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbScreen.Location = new Point(16, 269);
            tbScreen.Name = "tbScreen";
            tbScreen.Size = new Size(314, 35);
            tbScreen.TabIndex = 17;
            tbScreen.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(356, 385);
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
            Text = "Swinski Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Btn1;
        private Button Btn8;
        private Button Btn9;
        private Button Btn0;
        private Button BtnDivision;
        private Button BtnMultiplication;
        private Button BtnSubstraction;
        private Button BtnAddition;
        private Button BtnResult;
        private Button BtnClear;
        private Button Btn7;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button Btn3;
        private Button Btn2;
        private TextBox tbScreen;
    }
}