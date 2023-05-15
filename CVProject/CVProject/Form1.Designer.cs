namespace CVProject
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
            this.btnAddContractor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSaveInformation = new System.Windows.Forms.Button();
            this.BtnRemoveContractor = new System.Windows.Forms.Button();
            this.BtnEditInformation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btnAddContractor
            // 
            this.btnAddContractor.Location = new System.Drawing.Point(29, 222);
            this.btnAddContractor.Name = "btnAddContractor";
            this.btnAddContractor.Size = new System.Drawing.Size(195, 26);
            this.btnAddContractor.TabIndex = 1;
            this.btnAddContractor.Text = "Dodaj Kontrahenta";
            this.btnAddContractor.UseVisualStyleBackColor = true;
            this.btnAddContractor.Click += new System.EventHandler(this.BtnAddContractor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kraj:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(360, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 403);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacje:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnEditInformation);
            this.groupBox2.Controls.Add(this.BtnSaveInformation);
            this.groupBox2.Controls.Add(this.BtnRemoveContractor);
            this.groupBox2.Controls.Add(this.btnAddContractor);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(9, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 433);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrahenci:";
            // 
            // BtnSaveInformation
            // 
            this.BtnSaveInformation.Location = new System.Drawing.Point(29, 331);
            this.BtnSaveInformation.Name = "BtnSaveInformation";
            this.BtnSaveInformation.Size = new System.Drawing.Size(195, 26);
            this.BtnSaveInformation.TabIndex = 3;
            this.BtnSaveInformation.Text = "Zapisz Informacje";
            this.BtnSaveInformation.UseVisualStyleBackColor = true;
            this.BtnSaveInformation.Click += new System.EventHandler(this.BtnSaveInformation_Click);
            // 
            // BtnRemoveContractor
            // 
            this.BtnRemoveContractor.Location = new System.Drawing.Point(29, 261);
            this.BtnRemoveContractor.Name = "BtnRemoveContractor";
            this.BtnRemoveContractor.Size = new System.Drawing.Size(195, 26);
            this.BtnRemoveContractor.TabIndex = 2;
            this.BtnRemoveContractor.Text = "Usun Kontrahenta";
            this.BtnRemoveContractor.UseVisualStyleBackColor = true;
            this.BtnRemoveContractor.Click += new System.EventHandler(this.BtnRemoveContractor_Click);
            // 
            // BtnEditInformation
            // 
            this.BtnEditInformation.Location = new System.Drawing.Point(29, 293);
            this.BtnEditInformation.Name = "BtnEditInformation";
            this.BtnEditInformation.Size = new System.Drawing.Size(195, 26);
            this.BtnEditInformation.TabIndex = 4;
            this.BtnEditInformation.Text = "Edytuj Informacje";
            this.BtnEditInformation.UseVisualStyleBackColor = true;
            this.BtnEditInformation.Click += new System.EventHandler(this.btnEditInformation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddContractor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSaveInformation;
        private System.Windows.Forms.Button BtnRemoveContractor;
        private System.Windows.Forms.Button BtnEditInformation;
    }
}

