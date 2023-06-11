namespace WindowsFormsApp2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblContractor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbRouteNumber = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblRouteNumber = new System.Windows.Forms.Label();
            this.tbContractor = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1132, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(124, 27);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(76, 41);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Usun";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountry.Location = new System.Drawing.Point(441, 12);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(56, 25);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Kraj:";
            // 
            // lblContractor
            // 
            this.lblContractor.AutoSize = true;
            this.lblContractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContractor.Location = new System.Drawing.Point(10, 7);
            this.lblContractor.Name = "lblContractor";
            this.lblContractor.Size = new System.Drawing.Size(123, 25);
            this.lblContractor.TabIndex = 4;
            this.lblContractor.Text = "Kontrahent:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 84);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(394, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Moto-Profil App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.tbPhone);
            this.panel2.Controls.Add(this.lblPhone);
            this.panel2.Controls.Add(this.tbPostCode);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.tbRouteNumber);
            this.panel2.Controls.Add(this.lblPostCode);
            this.panel2.Controls.Add(this.tbAdress);
            this.panel2.Controls.Add(this.lblAdress);
            this.panel2.Controls.Add(this.cboCountry);
            this.panel2.Controls.Add(this.tbBarCode);
            this.panel2.Controls.Add(this.lblBarCode);
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Controls.Add(this.lblRouteNumber);
            this.panel2.Controls.Add(this.lblCountry);
            this.panel2.Controls.Add(this.tbContractor);
            this.panel2.Controls.Add(this.lblContractor);
            this.panel2.Location = new System.Drawing.Point(13, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 168);
            this.panel2.TabIndex = 8;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPhone.Location = new System.Drawing.Point(223, 61);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(160, 31);
            this.tbPhone.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhone.Location = new System.Drawing.Point(15, 64);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 25);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Telefon:";
            // 
            // tbPostCode
            // 
            this.tbPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPostCode.Location = new System.Drawing.Point(992, 66);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(160, 31);
            this.tbPostCode.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(441, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // tbRouteNumber
            // 
            this.tbRouteNumber.Enabled = false;
            this.tbRouteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRouteNumber.Location = new System.Drawing.Point(607, 115);
            this.tbRouteNumber.Name = "tbRouteNumber";
            this.tbRouteNumber.Size = new System.Drawing.Size(160, 31);
            this.tbRouteNumber.TabIndex = 15;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPostCode.Location = new System.Drawing.Point(822, 66);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(154, 25);
            this.lblPostCode.TabIndex = 14;
            this.lblPostCode.Text = "Kod Pocztowy:";
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdress.Location = new System.Drawing.Point(991, 12);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(160, 31);
            this.tbAdress.TabIndex = 13;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdress.Location = new System.Drawing.Point(824, 15);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(74, 25);
            this.lblAdress.TabIndex = 12;
            this.lblAdress.Text = "Adres:";
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "",
            "Polska",
            "Litwa",
            "Wlochy",
            "Czechy",
            "Niemcy",
            "Francja"});
            this.cboCountry.Location = new System.Drawing.Point(606, 4);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(160, 33);
            this.cboCountry.TabIndex = 11;
            // 
            // tbBarCode
            // 
            this.tbBarCode.Enabled = false;
            this.tbBarCode.Font = new System.Drawing.Font("CCode39", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBarCode.Location = new System.Drawing.Point(223, 101);
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(160, 40);
            this.tbBarCode.TabIndex = 10;
            this.tbBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBarCode.Location = new System.Drawing.Point(17, 113);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(152, 25);
            this.lblBarCode.TabIndex = 9;
            this.lblBarCode.Text = "Kod kreskowy:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(606, 63);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(160, 31);
            this.tbEmail.TabIndex = 8;
            // 
            // lblRouteNumber
            // 
            this.lblRouteNumber.AutoSize = true;
            this.lblRouteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRouteNumber.Location = new System.Drawing.Point(440, 118);
            this.lblRouteNumber.Name = "lblRouteNumber";
            this.lblRouteNumber.Size = new System.Drawing.Size(141, 25);
            this.lblRouteNumber.TabIndex = 7;
            this.lblRouteNumber.Text = "Numer Trasy:";
            // 
            // tbContractor
            // 
            this.tbContractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbContractor.Location = new System.Drawing.Point(223, 9);
            this.tbContractor.Name = "tbContractor";
            this.tbContractor.Size = new System.Drawing.Size(160, 31);
            this.tbContractor.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(13, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 244);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.tbSearch);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Location = new System.Drawing.Point(12, 574);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1164, 84);
            this.panel4.TabIndex = 10;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSearch.Location = new System.Drawing.Point(334, 29);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(454, 31);
            this.tbSearch.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.lblCount);
            this.panel5.Location = new System.Drawing.Point(12, 522);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1165, 46);
            this.panel5.TabIndex = 11;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCount.Location = new System.Drawing.Point(10, 10);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(388, 31);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Ilosc aktualnych kontrahentow:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1195, 685);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Aplikacja: Moto Profil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblContractor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbBarCode;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblRouteNumber;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.TextBox tbContractor;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbRouteNumber;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblCount;
    }
}

