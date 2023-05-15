namespace TabControlTraining
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Panel1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contractorsList = new System.Windows.Forms.ListBox();
            this.btnAddContractor = new System.Windows.Forms.Button();
            this.btnSaveInformation = new System.Windows.Forms.Button();
            this.btnRemoveContractor = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.routeNumber = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textRouteNumber = new System.Windows.Forms.TextBox();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.contactDetails = new System.Windows.Forms.GroupBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.Label();
            this.eMail = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.countryList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.countryListAccepted = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Information.SuspendLayout();
            this.contactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Panel1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.contactDetails);
            this.Panel1.Controls.Add(this.Information);
            this.Panel1.Controls.Add(this.btnRemoveContractor);
            this.Panel1.Controls.Add(this.btnSaveInformation);
            this.Panel1.Controls.Add(this.btnAddContractor);
            this.Panel1.Controls.Add(this.groupBox1);
            this.Panel1.Location = new System.Drawing.Point(4, 22);
            this.Panel1.Name = "Panel1";
            this.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.Panel1.Size = new System.Drawing.Size(833, 431);
            this.Panel1.TabIndex = 0;
            this.Panel1.Text = "Kontrahenci";
            this.Panel1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.countryListAccepted);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.countryList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(833, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zamowienia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contractorsList);
            this.groupBox1.Location = new System.Drawing.Point(20, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ListaKontrahentow";
            // 
            // contractorsList
            // 
            this.contractorsList.FormattingEnabled = true;
            this.contractorsList.Location = new System.Drawing.Point(6, 23);
            this.contractorsList.Name = "contractorsList";
            this.contractorsList.Size = new System.Drawing.Size(331, 316);
            this.contractorsList.TabIndex = 0;
            // 
            // btnAddContractor
            // 
            this.btnAddContractor.Location = new System.Drawing.Point(20, 374);
            this.btnAddContractor.Name = "btnAddContractor";
            this.btnAddContractor.Size = new System.Drawing.Size(115, 30);
            this.btnAddContractor.TabIndex = 1;
            this.btnAddContractor.Text = "Dodaj";
            this.btnAddContractor.UseVisualStyleBackColor = true;
            this.btnAddContractor.Click += new System.EventHandler(this.btnAddContractor_Click);
            // 
            // btnSaveInformation
            // 
            this.btnSaveInformation.Location = new System.Drawing.Point(151, 374);
            this.btnSaveInformation.Name = "btnSaveInformation";
            this.btnSaveInformation.Size = new System.Drawing.Size(95, 30);
            this.btnSaveInformation.TabIndex = 2;
            this.btnSaveInformation.Text = "Zapisz";
            this.btnSaveInformation.UseVisualStyleBackColor = true;
            this.btnSaveInformation.Click += new System.EventHandler(this.btnSaveInformation_Click);
            // 
            // btnRemoveContractor
            // 
            this.btnRemoveContractor.Location = new System.Drawing.Point(265, 374);
            this.btnRemoveContractor.Name = "btnRemoveContractor";
            this.btnRemoveContractor.Size = new System.Drawing.Size(92, 30);
            this.btnRemoveContractor.TabIndex = 3;
            this.btnRemoveContractor.Text = "Usun";
            this.btnRemoveContractor.UseVisualStyleBackColor = true;
            this.btnRemoveContractor.Click += new System.EventHandler(this.btnRemoveContractor_Click);
            // 
            // Information
            // 
            this.Information.Controls.Add(this.textCountry);
            this.Information.Controls.Add(this.textRouteNumber);
            this.Information.Controls.Add(this.textName);
            this.Information.Controls.Add(this.routeNumber);
            this.Information.Controls.Add(this.country);
            this.Information.Controls.Add(this.name);
            this.Information.Location = new System.Drawing.Point(413, 34);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(363, 127);
            this.Information.TabIndex = 4;
            this.Information.TabStop = false;
            this.Information.Text = "Informacje";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(20, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(104, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Nazwa Kontrahenta:";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(20, 60);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(89, 13);
            this.country.TabIndex = 1;
            this.country.Text = "Kraj Kontrahenta:";
            // 
            // routeNumber
            // 
            this.routeNumber.AutoSize = true;
            this.routeNumber.Location = new System.Drawing.Point(20, 85);
            this.routeNumber.Name = "routeNumber";
            this.routeNumber.Size = new System.Drawing.Size(66, 13);
            this.routeNumber.TabIndex = 2;
            this.routeNumber.Text = "Numer trasy:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(146, 31);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(167, 20);
            this.textName.TabIndex = 4;
            // 
            // textRouteNumber
            // 
            this.textRouteNumber.Location = new System.Drawing.Point(146, 85);
            this.textRouteNumber.Name = "textRouteNumber";
            this.textRouteNumber.Size = new System.Drawing.Size(167, 20);
            this.textRouteNumber.TabIndex = 6;
            // 
            // textCountry
            // 
            this.textCountry.Location = new System.Drawing.Point(146, 60);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(167, 20);
            this.textCountry.TabIndex = 7;
            // 
            // contactDetails
            // 
            this.contactDetails.Controls.Add(this.textEmail);
            this.contactDetails.Controls.Add(this.eMail);
            this.contactDetails.Controls.Add(this.textAdress);
            this.contactDetails.Controls.Add(this.phone);
            this.contactDetails.Controls.Add(this.textPhone);
            this.contactDetails.Controls.Add(this.adress);
            this.contactDetails.Location = new System.Drawing.Point(420, 200);
            this.contactDetails.Name = "contactDetails";
            this.contactDetails.Size = new System.Drawing.Size(355, 148);
            this.contactDetails.TabIndex = 5;
            this.contactDetails.TabStop = false;
            this.contactDetails.Text = "Dane Kontaktowe";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(154, 56);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(167, 20);
            this.textEmail.TabIndex = 13;
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(154, 81);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(167, 20);
            this.textAdress.TabIndex = 12;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(154, 27);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(167, 20);
            this.textPhone.TabIndex = 11;
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(28, 81);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(37, 13);
            this.adress.TabIndex = 10;
            this.adress.Text = "Adres:";
            // 
            // eMail
            // 
            this.eMail.AutoSize = true;
            this.eMail.Location = new System.Drawing.Point(28, 56);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(38, 13);
            this.eMail.TabIndex = 9;
            this.eMail.Text = "E-mail:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(28, 32);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(46, 13);
            this.phone.TabIndex = 8;
            this.phone.Text = "Telefon:";
            // 
            // countryList
            // 
            this.countryList.FormattingEnabled = true;
            this.countryList.Location = new System.Drawing.Point(20, 20);
            this.countryList.Name = "countryList";
            this.countryList.Size = new System.Drawing.Size(295, 342);
            this.countryList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Przyjmij wszystko";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Usun kraj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // countryListAccepted
            // 
            this.countryListAccepted.FormattingEnabled = true;
            this.countryListAccepted.Location = new System.Drawing.Point(513, 26);
            this.countryListAccepted.Name = "countryListAccepted";
            this.countryListAccepted.Size = new System.Drawing.Size(289, 342);
            this.countryListAccepted.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 457);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.contactDetails.ResumeLayout(false);
            this.contactDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox contactDetails;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label eMail;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.TextBox textRouteNumber;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label routeNumber;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btnRemoveContractor;
        private System.Windows.Forms.Button btnSaveInformation;
        private System.Windows.Forms.Button btnAddContractor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox contractorsList;
        private System.Windows.Forms.ListBox countryList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox countryListAccepted;
    }
}