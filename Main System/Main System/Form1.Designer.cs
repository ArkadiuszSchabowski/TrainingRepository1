﻿namespace Main_System
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
            this.DisplayContractors = new System.Windows.Forms.Button();
            this.btn_CancelOrders = new System.Windows.Forms.Button();
            this.TakeOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AvailableOrders = new System.Windows.Forms.CheckedListBox();
            this.DowloadedOrders = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DisplayContractors
            // 
            this.DisplayContractors.Location = new System.Drawing.Point(12, 337);
            this.DisplayContractors.Name = "DisplayContractors";
            this.DisplayContractors.Size = new System.Drawing.Size(265, 27);
            this.DisplayContractors.TabIndex = 1;
            this.DisplayContractors.Text = "Wyswietl kontrahentow wybranego kraju";
            this.DisplayContractors.UseVisualStyleBackColor = true;
            this.DisplayContractors.Click += new System.EventHandler(this.DisplayContractors_Click);
            // 
            // btn_CancelOrders
            // 
            this.btn_CancelOrders.Location = new System.Drawing.Point(305, 100);
            this.btn_CancelOrders.Name = "btn_CancelOrders";
            this.btn_CancelOrders.Size = new System.Drawing.Size(120, 41);
            this.btn_CancelOrders.TabIndex = 2;
            this.btn_CancelOrders.Text = "Anuluj zamowienie";
            this.btn_CancelOrders.UseVisualStyleBackColor = true;
            this.btn_CancelOrders.Click += new System.EventHandler(this.CancelOrders_Click);
            // 
            // TakeOrders
            // 
            this.TakeOrders.Location = new System.Drawing.Point(305, 51);
            this.TakeOrders.Name = "TakeOrders";
            this.TakeOrders.Size = new System.Drawing.Size(120, 43);
            this.TakeOrders.TabIndex = 3;
            this.TakeOrders.Text = "Przyjmij zamowienie";
            this.TakeOrders.UseVisualStyleBackColor = true;
            this.TakeOrders.Click += new System.EventHandler(this.TakeOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(489, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pobrane zamowienia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zamowienia do pobrania:";
            // 
            // AvailableOrders
            // 
            this.AvailableOrders.FormattingEnabled = true;
            this.AvailableOrders.Location = new System.Drawing.Point(12, 40);
            this.AvailableOrders.Name = "AvailableOrders";
            this.AvailableOrders.Size = new System.Drawing.Size(265, 289);
            this.AvailableOrders.TabIndex = 7;
            // 
            // DowloadedOrders
            // 
            this.DowloadedOrders.FormattingEnabled = true;
            this.DowloadedOrders.Location = new System.Drawing.Point(494, 40);
            this.DowloadedOrders.Name = "DowloadedOrders";
            this.DowloadedOrders.Size = new System.Drawing.Size(265, 289);
            this.DowloadedOrders.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(298, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 199);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(773, 388);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DowloadedOrders);
            this.Controls.Add(this.AvailableOrders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TakeOrders);
            this.Controls.Add(this.btn_CancelOrders);
            this.Controls.Add(this.DisplayContractors);
            this.Name = "Form1";
            this.Text = "System obslugi kontrahentow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DisplayContractors;
        private System.Windows.Forms.Button btn_CancelOrders;
        private System.Windows.Forms.Button TakeOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox AvailableOrders;
        private System.Windows.Forms.CheckedListBox DowloadedOrders;
        private System.Windows.Forms.ListBox listBox1;
    }
}

