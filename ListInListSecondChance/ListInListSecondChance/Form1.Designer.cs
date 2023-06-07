namespace ListInListSecondChance
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAddListCountry = new System.Windows.Forms.Button();
            this.btnAddContractor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(67, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 238);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(390, 39);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(285, 238);
            this.listBox2.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(67, 283);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(125, 33);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display Contractors";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAddListCountry
            // 
            this.btnAddListCountry.Location = new System.Drawing.Point(67, 375);
            this.btnAddListCountry.Name = "btnAddListCountry";
            this.btnAddListCountry.Size = new System.Drawing.Size(125, 33);
            this.btnAddListCountry.TabIndex = 3;
            this.btnAddListCountry.Text = "Add Country";
            this.btnAddListCountry.UseVisualStyleBackColor = true;
            this.btnAddListCountry.Click += new System.EventHandler(this.btnAddListCountry_Click);
            // 
            // btnAddContractor
            // 
            this.btnAddContractor.Location = new System.Drawing.Point(390, 375);
            this.btnAddContractor.Name = "btnAddContractor";
            this.btnAddContractor.Size = new System.Drawing.Size(125, 33);
            this.btnAddContractor.TabIndex = 4;
            this.btnAddContractor.Text = "Add Contractor";
            this.btnAddContractor.UseVisualStyleBackColor = true;
            this.btnAddContractor.Click += new System.EventHandler(this.btnAddContractor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(390, 349);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddContractor);
            this.Controls.Add(this.btnAddListCountry);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAddListCountry;
        private System.Windows.Forms.Button btnAddContractor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

