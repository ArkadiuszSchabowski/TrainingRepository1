namespace CalculatorWindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn7 = new System.Windows.Forms.Button();
            this.tbScreen = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.LightGreen;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn7.Location = new System.Drawing.Point(14, 65);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 47);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // tbScreen
            // 
            this.tbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbScreen.Location = new System.Drawing.Point(12, 12);
            this.tbScreen.Multiline = true;
            this.tbScreen.Name = "tbScreen";
            this.tbScreen.Size = new System.Drawing.Size(397, 40);
            this.tbScreen.TabIndex = 1;
            this.tbScreen.Text = "727272772";
            this.tbScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.Color.Magenta;
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddition.Location = new System.Drawing.Point(257, 65);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 47);
            this.btnAddition.TabIndex = 2;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnOperationClick);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.LightGreen;
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnComma.Location = new System.Drawing.Point(176, 224);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(75, 47);
            this.btnComma.TabIndex = 3;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.LightGreen;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn0.Location = new System.Drawing.Point(14, 224);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(156, 47);
            this.btn0.TabIndex = 4;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightGreen;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn3.Location = new System.Drawing.Point(176, 171);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 47);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightGreen;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2.Location = new System.Drawing.Point(95, 171);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 47);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightGreen;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.Location = new System.Drawing.Point(14, 171);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 47);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LightGreen;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn6.Location = new System.Drawing.Point(176, 118);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 47);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightGreen;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn5.Location = new System.Drawing.Point(95, 118);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 47);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightGreen;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn4.Location = new System.Drawing.Point(14, 118);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 47);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LightGreen;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn9.Location = new System.Drawing.Point(176, 65);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 47);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LightGreen;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn8.Location = new System.Drawing.Point(95, 65);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 47);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnNumberClick);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Magenta;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDivision.Location = new System.Drawing.Point(338, 118);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 47);
            this.btnDivision.TabIndex = 13;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnOperationClick);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.Magenta;
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMultiplication.Location = new System.Drawing.Point(338, 65);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(75, 47);
            this.btnMultiplication.TabIndex = 14;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnOperationClick);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackColor = System.Drawing.Color.Magenta;
            this.btnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSubtraction.Location = new System.Drawing.Point(257, 118);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(75, 47);
            this.btnSubtraction.TabIndex = 15;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            this.btnSubtraction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnOperationClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(257, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 47);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnClearClick);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Orange;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResult.Location = new System.Drawing.Point(257, 171);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(152, 47);
            this.btnResult.TabIndex = 18;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBtnResultClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 281);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.tbScreen);
            this.Controls.Add(this.btn7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox tbScreen;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnResult;
    }
}

