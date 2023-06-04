﻿namespace EnglishFlashcards
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
            this.Game = new System.Windows.Forms.TabControl();
            this.Dictionary = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textEnglish = new System.Windows.Forms.TextBox();
            this.textPolish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listStageFive = new System.Windows.Forms.ListBox();
            this.listStageFour = new System.Windows.Forms.ListBox();
            this.listStageThree = new System.Windows.Forms.ListBox();
            this.listStageTwo = new System.Windows.Forms.ListBox();
            this.listStageOne = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRandomEng = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEngland = new System.Windows.Forms.TextBox();
            this.txtPoland = new System.Windows.Forms.TextBox();
            this.btnRandomPl = new System.Windows.Forms.Button();
            this.listUsa = new System.Windows.Forms.ListBox();
            this.listPoland = new System.Windows.Forms.ListBox();
            this.Game.SuspendLayout();
            this.Dictionary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Game
            // 
            this.Game.Controls.Add(this.Dictionary);
            this.Game.Controls.Add(this.tabPage2);
            this.Game.Controls.Add(this.tabPage1);
            this.Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Game.Location = new System.Drawing.Point(0, 0);
            this.Game.Name = "Game";
            this.Game.SelectedIndex = 0;
            this.Game.Size = new System.Drawing.Size(826, 438);
            this.Game.TabIndex = 0;
            // 
            // Dictionary
            // 
            this.Dictionary.BackColor = System.Drawing.Color.CadetBlue;
            this.Dictionary.Controls.Add(this.label9);
            this.Dictionary.Controls.Add(this.textNumber);
            this.Dictionary.Controls.Add(this.label8);
            this.Dictionary.Controls.Add(this.label7);
            this.Dictionary.Controls.Add(this.textEnglish);
            this.Dictionary.Controls.Add(this.textPolish);
            this.Dictionary.Controls.Add(this.label1);
            this.Dictionary.Controls.Add(this.btnRemove);
            this.Dictionary.Controls.Add(this.btnModify);
            this.Dictionary.Controls.Add(this.btnAdd);
            this.Dictionary.Controls.Add(this.dataGridView1);
            this.Dictionary.Location = new System.Drawing.Point(4, 29);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Padding = new System.Windows.Forms.Padding(3);
            this.Dictionary.Size = new System.Drawing.Size(818, 405);
            this.Dictionary.TabIndex = 0;
            this.Dictionary.Text = "Slownik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(25, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "Numer fiszki:";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(332, 53);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(459, 26);
            this.textNumber.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(25, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Polskie znaczenie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(25, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Angielskie znaczenie:";
            // 
            // textEnglish
            // 
            this.textEnglish.Location = new System.Drawing.Point(332, 130);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.Size = new System.Drawing.Size(459, 26);
            this.textEnglish.TabIndex = 6;
            // 
            // textPolish
            // 
            this.textPolish.Location = new System.Drawing.Point(332, 93);
            this.textPolish.Name = "textPolish";
            this.textPolish.Size = new System.Drawing.Size(459, 26);
            this.textPolish.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ilosc fiszek w bazie danych:";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Location = new System.Drawing.Point(305, 359);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 38);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Usun";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Location = new System.Drawing.Point(162, 359);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(137, 38);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Edytuj";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(19, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.listStageFive);
            this.tabPage2.Controls.Add(this.listStageFour);
            this.tabPage2.Controls.Add(this.listStageThree);
            this.tabPage2.Controls.Add(this.listStageTwo);
            this.tabPage2.Controls.Add(this.listStageOne);
            this.tabPage2.Controls.Add(this.btnPlay);
            this.tabPage2.Controls.Add(this.btnInformation);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(284, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fiszek w pojemniku 1: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(540, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fiszek w pojemniku 1: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(181, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fiszek w pojemniku 1: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(449, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fiszek w pojemniku 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fiszek w pojemniku 1: ";
            // 
            // listStageFive
            // 
            this.listStageFive.FormattingEnabled = true;
            this.listStageFive.ItemHeight = 20;
            this.listStageFive.Location = new System.Drawing.Point(452, 285);
            this.listStageFive.Name = "listStageFive";
            this.listStageFive.Size = new System.Drawing.Size(230, 104);
            this.listStageFive.TabIndex = 6;
            // 
            // listStageFour
            // 
            this.listStageFour.FormattingEnabled = true;
            this.listStageFour.ItemHeight = 20;
            this.listStageFour.Location = new System.Drawing.Point(184, 285);
            this.listStageFour.Name = "listStageFour";
            this.listStageFour.Size = new System.Drawing.Size(230, 104);
            this.listStageFour.TabIndex = 5;
            // 
            // listStageThree
            // 
            this.listStageThree.FormattingEnabled = true;
            this.listStageThree.ItemHeight = 20;
            this.listStageThree.Location = new System.Drawing.Point(543, 117);
            this.listStageThree.Name = "listStageThree";
            this.listStageThree.Size = new System.Drawing.Size(230, 104);
            this.listStageThree.TabIndex = 4;
            // 
            // listStageTwo
            // 
            this.listStageTwo.FormattingEnabled = true;
            this.listStageTwo.ItemHeight = 20;
            this.listStageTwo.Location = new System.Drawing.Point(287, 117);
            this.listStageTwo.Name = "listStageTwo";
            this.listStageTwo.Size = new System.Drawing.Size(230, 104);
            this.listStageTwo.TabIndex = 3;
            // 
            // listStageOne
            // 
            this.listStageOne.FormattingEnabled = true;
            this.listStageOne.ItemHeight = 20;
            this.listStageOne.Location = new System.Drawing.Point(36, 117);
            this.listStageOne.Name = "listStageOne";
            this.listStageOne.Size = new System.Drawing.Size(230, 104);
            this.listStageOne.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlay.Location = new System.Drawing.Point(36, 25);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(143, 35);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Graj";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInformation.Location = new System.Drawing.Point(539, 25);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(143, 35);
            this.btnInformation.TabIndex = 0;
            this.btnInformation.Text = "Informacje";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.btnRandomEng);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtEngland);
            this.tabPage1.Controls.Add(this.txtPoland);
            this.tabPage1.Controls.Add(this.btnRandomPl);
            this.tabPage1.Controls.Add(this.listUsa);
            this.tabPage1.Controls.Add(this.listPoland);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 405);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Test";
            // 
            // btnRandomEng
            // 
            this.btnRandomEng.Location = new System.Drawing.Point(19, 294);
            this.btnRandomEng.Name = "btnRandomEng";
            this.btnRandomEng.Size = new System.Drawing.Size(257, 43);
            this.btnRandomEng.TabIndex = 7;
            this.btnRandomEng.Text = "Losuj angielskie";
            this.btnRandomEng.UseVisualStyleBackColor = true;
            this.btnRandomEng.Click += new System.EventHandler(this.btnRandomEng_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(106, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 31);
            this.label11.TabIndex = 6;
            this.label11.Text = "ENG:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(106, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "PL:";
            // 
            // txtEngland
            // 
            this.txtEngland.Location = new System.Drawing.Point(19, 166);
            this.txtEngland.Name = "txtEngland";
            this.txtEngland.Size = new System.Drawing.Size(257, 26);
            this.txtEngland.TabIndex = 4;
            // 
            // txtPoland
            // 
            this.txtPoland.Location = new System.Drawing.Point(19, 68);
            this.txtPoland.Name = "txtPoland";
            this.txtPoland.Size = new System.Drawing.Size(257, 26);
            this.txtPoland.TabIndex = 3;
            // 
            // btnRandomPl
            // 
            this.btnRandomPl.Location = new System.Drawing.Point(19, 232);
            this.btnRandomPl.Name = "btnRandomPl";
            this.btnRandomPl.Size = new System.Drawing.Size(257, 43);
            this.btnRandomPl.TabIndex = 2;
            this.btnRandomPl.Text = "Losuj polskie";
            this.btnRandomPl.UseVisualStyleBackColor = true;
            this.btnRandomPl.Click += new System.EventHandler(this.btnRandomPl_Click);
            // 
            // listUsa
            // 
            this.listUsa.FormattingEnabled = true;
            this.listUsa.ItemHeight = 20;
            this.listUsa.Location = new System.Drawing.Point(554, 33);
            this.listUsa.Name = "listUsa";
            this.listUsa.Size = new System.Drawing.Size(197, 304);
            this.listUsa.TabIndex = 1;
            // 
            // listPoland
            // 
            this.listPoland.FormattingEnabled = true;
            this.listPoland.ItemHeight = 20;
            this.listPoland.Location = new System.Drawing.Point(309, 33);
            this.listPoland.Name = "listPoland";
            this.listPoland.Size = new System.Drawing.Size(197, 304);
            this.listPoland.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 438);
            this.Controls.Add(this.Game);
            this.Name = "Form1";
            this.Text = "Fiszki angielskie";
            this.Game.ResumeLayout(false);
            this.Dictionary.ResumeLayout(false);
            this.Dictionary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Game;
        private System.Windows.Forms.TabPage Dictionary;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listStageFive;
        private System.Windows.Forms.ListBox listStageFour;
        private System.Windows.Forms.ListBox listStageThree;
        private System.Windows.Forms.ListBox listStageTwo;
        private System.Windows.Forms.ListBox listStageOne;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textEnglish;
        private System.Windows.Forms.TextBox textPolish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listUsa;
        private System.Windows.Forms.ListBox listPoland;
        private System.Windows.Forms.TextBox txtEngland;
        private System.Windows.Forms.TextBox txtPoland;
        private System.Windows.Forms.Button btnRandomPl;
        private System.Windows.Forms.Button btnRandomEng;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

