namespace SQLProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMySql = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelBarCode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.comboBoxMemberType = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelMemberType = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelMemberID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelMySql);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 65);
            this.panel1.TabIndex = 0;
            // 
            // labelMySql
            // 
            this.labelMySql.AutoSize = true;
            this.labelMySql.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMySql.Location = new System.Drawing.Point(230, 16);
            this.labelMySql.Name = "labelMySql";
            this.labelMySql.Size = new System.Drawing.Size(372, 31);
            this.labelMySql.TabIndex = 0;
            this.labelMySql.Text = "MySQL Connection Tutorial";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtBarCode);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.labelBarCode);
            this.panel2.Location = new System.Drawing.Point(6, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 57);
            this.panel2.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(393, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 31);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(630, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(173, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // labelBarCode
            // 
            this.labelBarCode.AutoSize = true;
            this.labelBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelBarCode.Location = new System.Drawing.Point(6, 12);
            this.labelBarCode.Name = "labelBarCode";
            this.labelBarCode.Size = new System.Drawing.Size(136, 31);
            this.labelBarCode.TabIndex = 1;
            this.labelBarCode.Text = "Bar Code";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txtFirstName);
            this.panel3.Controls.Add(this.txtSurname);
            this.panel3.Controls.Add(this.txtPostCode);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtAdress);
            this.panel3.Controls.Add(this.txtMobile);
            this.panel3.Controls.Add(this.txtMemberID);
            this.panel3.Controls.Add(this.comboBoxMemberType);
            this.panel3.Controls.Add(this.comboBoxGender);
            this.panel3.Controls.Add(this.labelMemberType);
            this.panel3.Controls.Add(this.labelEmail);
            this.panel3.Controls.Add(this.labelPostCode);
            this.panel3.Controls.Add(this.labelGender);
            this.panel3.Controls.Add(this.labelMobile);
            this.panel3.Controls.Add(this.labelAdress);
            this.panel3.Controls.Add(this.labelFirstName);
            this.panel3.Controls.Add(this.labelSurname);
            this.panel3.Controls.Add(this.labelMemberID);
            this.panel3.Location = new System.Drawing.Point(6, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 109);
            this.panel3.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 20);
            this.txtFirstName.TabIndex = 17;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(95, 72);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(155, 20);
            this.txtSurname.TabIndex = 16;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(639, 10);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(164, 20);
            this.txtPostCode.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(639, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(335, 6);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(173, 20);
            this.txtAdress.TabIndex = 13;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(335, 68);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(173, 20);
            this.txtMobile.TabIndex = 12;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(95, 12);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(155, 20);
            this.txtMemberID.TabIndex = 11;
            // 
            // comboBoxMemberType
            // 
            this.comboBoxMemberType.FormattingEnabled = true;
            this.comboBoxMemberType.Location = new System.Drawing.Point(639, 72);
            this.comboBoxMemberType.Name = "comboBoxMemberType";
            this.comboBoxMemberType.Size = new System.Drawing.Size(164, 21);
            this.comboBoxMemberType.TabIndex = 10;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(336, 35);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(172, 21);
            this.comboBoxGender.TabIndex = 9;
            // 
            // labelMemberType
            // 
            this.labelMemberType.AutoSize = true;
            this.labelMemberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMemberType.Location = new System.Drawing.Point(521, 72);
            this.labelMemberType.Name = "labelMemberType";
            this.labelMemberType.Size = new System.Drawing.Size(103, 16);
            this.labelMemberType.TabIndex = 8;
            this.labelMemberType.Text = "Member Type";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(523, 41);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 16);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "E-Mail";
            // 
            // labelPostCode
            // 
            this.labelPostCode.AutoSize = true;
            this.labelPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostCode.Location = new System.Drawing.Point(523, 10);
            this.labelPostCode.Name = "labelPostCode";
            this.labelPostCode.Size = new System.Drawing.Size(79, 16);
            this.labelPostCode.TabIndex = 6;
            this.labelPostCode.Text = "Post Code";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGender.Location = new System.Drawing.Point(272, 40);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(58, 16);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Gender";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMobile.Location = new System.Drawing.Point(272, 72);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(54, 16);
            this.labelMobile.TabIndex = 4;
            this.labelMobile.Text = "Mobile";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdress.Location = new System.Drawing.Point(272, 7);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(56, 16);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "Adress";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(3, 40);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(78, 16);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "FirstName";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSurname.Location = new System.Drawing.Point(3, 72);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(68, 16);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname";
            // 
            // labelMemberID
            // 
            this.labelMemberID.AutoSize = true;
            this.labelMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMemberID.Location = new System.Drawing.Point(3, 7);
            this.labelMemberID.Name = "labelMemberID";
            this.labelMemberID.Size = new System.Drawing.Size(82, 16);
            this.labelMemberID.TabIndex = 0;
            this.labelMemberID.Text = "Member ID";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(6, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 91);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(816, 72);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnDisplay);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Location = new System.Drawing.Point(6, 352);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(825, 77);
            this.panel5.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(673, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(511, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 28);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(335, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(169, 21);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(142, 28);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBarCode.Location = new System.Drawing.Point(148, 10);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(225, 31);
            this.txtBarCode.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 436);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Member ID";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMySql;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelBarCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.ComboBox comboBoxMemberType;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelMemberType;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelMemberID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBarCode;
    }
}

