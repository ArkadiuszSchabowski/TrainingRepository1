namespace EnglishFlashcards
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtPolish = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnRandomEng = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEngland = new System.Windows.Forms.TextBox();
            this.txtPoland = new System.Windows.Forms.TextBox();
            this.btnRandomPl = new System.Windows.Forms.Button();
            this.listEngland = new System.Windows.Forms.ListBox();
            this.listPoland = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Game.SuspendLayout();
            this.Dictionary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Game
            // 
            this.Game.Controls.Add(this.Dictionary);
            this.Game.Controls.Add(this.tabPage2);
            this.Game.Controls.Add(this.tabPage1);
            this.Game.Controls.Add(this.tabPage3);
            this.Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Game.Location = new System.Drawing.Point(0, 0);
            this.Game.Name = "Game";
            this.Game.SelectedIndex = 0;
            this.Game.Size = new System.Drawing.Size(860, 438);
            this.Game.TabIndex = 0;
            // 
            // Dictionary
            // 
            this.Dictionary.BackColor = System.Drawing.Color.ForestGreen;
            this.Dictionary.Controls.Add(this.panel4);
            this.Dictionary.Controls.Add(this.panel3);
            this.Dictionary.Controls.Add(this.panel2);
            this.Dictionary.Controls.Add(this.panel1);
            this.Dictionary.Location = new System.Drawing.Point(4, 29);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Padding = new System.Windows.Forms.Padding(3);
            this.Dictionary.Size = new System.Drawing.Size(852, 405);
            this.Dictionary.TabIndex = 0;
            this.Dictionary.Text = "Slownik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Numer fiszki:";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumber.Location = new System.Drawing.Point(251, 1);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(137, 26);
            this.txtNumber.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Polskie znaczenie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(409, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Angielskie znaczenie:";
            // 
            // txtEnglish
            // 
            this.txtEnglish.BackColor = System.Drawing.SystemColors.Control;
            this.txtEnglish.Location = new System.Drawing.Point(657, 41);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(137, 26);
            this.txtEnglish.TabIndex = 6;
            // 
            // txtPolish
            // 
            this.txtPolish.BackColor = System.Drawing.SystemColors.Control;
            this.txtPolish.Location = new System.Drawing.Point(251, 41);
            this.txtPolish.Name = "txtPolish";
            this.txtPolish.Size = new System.Drawing.Size(137, 26);
            this.txtPolish.TabIndex = 5;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCount.Location = new System.Drawing.Point(244, 12);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(405, 33);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Ilosc fiszek w bazie danych:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Location = new System.Drawing.Point(321, 18);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 38);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Usun";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.ForestGreen;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Location = new System.Drawing.Point(167, 18);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(137, 38);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Edytuj";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(24, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 105);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(295, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fiszek w pojemniku 2: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(528, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fiszek w pojemniku 3: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(165, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fiszek w pojemniku 4: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(432, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fiszek w pojemniku 5: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(39, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fiszek w pojemniku 1: ";
            // 
            // listStageFive
            // 
            this.listStageFive.BackColor = System.Drawing.SystemColors.Control;
            this.listStageFive.FormattingEnabled = true;
            this.listStageFive.ItemHeight = 25;
            this.listStageFive.Location = new System.Drawing.Point(421, 206);
            this.listStageFive.Name = "listStageFive";
            this.listStageFive.Size = new System.Drawing.Size(230, 79);
            this.listStageFive.TabIndex = 6;
            // 
            // listStageFour
            // 
            this.listStageFour.BackColor = System.Drawing.SystemColors.Control;
            this.listStageFour.FormattingEnabled = true;
            this.listStageFour.ItemHeight = 25;
            this.listStageFour.Location = new System.Drawing.Point(153, 206);
            this.listStageFour.Name = "listStageFour";
            this.listStageFour.Size = new System.Drawing.Size(230, 79);
            this.listStageFour.TabIndex = 5;
            // 
            // listStageThree
            // 
            this.listStageThree.BackColor = System.Drawing.SystemColors.Control;
            this.listStageThree.FormattingEnabled = true;
            this.listStageThree.ItemHeight = 25;
            this.listStageThree.Location = new System.Drawing.Point(532, 71);
            this.listStageThree.Name = "listStageThree";
            this.listStageThree.Size = new System.Drawing.Size(197, 79);
            this.listStageThree.TabIndex = 4;
            // 
            // listStageTwo
            // 
            this.listStageTwo.BackColor = System.Drawing.SystemColors.Control;
            this.listStageTwo.FormattingEnabled = true;
            this.listStageTwo.ItemHeight = 25;
            this.listStageTwo.Location = new System.Drawing.Point(284, 71);
            this.listStageTwo.Name = "listStageTwo";
            this.listStageTwo.Size = new System.Drawing.Size(212, 79);
            this.listStageTwo.TabIndex = 3;
            // 
            // listStageOne
            // 
            this.listStageOne.BackColor = System.Drawing.SystemColors.Control;
            this.listStageOne.FormattingEnabled = true;
            this.listStageOne.ItemHeight = 25;
            this.listStageOne.Location = new System.Drawing.Point(27, 71);
            this.listStageOne.Name = "listStageOne";
            this.listStageOne.Size = new System.Drawing.Size(213, 79);
            this.listStageOne.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage1.Controls.Add(this.btnCheck);
            this.tabPage1.Controls.Add(this.lblAverage);
            this.tabPage1.Controls.Add(this.lblIncorrect);
            this.tabPage1.Controls.Add(this.lblCorrect);
            this.tabPage1.Controls.Add(this.btnAddWord);
            this.tabPage1.Controls.Add(this.btnRandomEng);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtEngland);
            this.tabPage1.Controls.Add(this.txtPoland);
            this.tabPage1.Controls.Add(this.btnRandomPl);
            this.tabPage1.Controls.Add(this.listEngland);
            this.tabPage1.Controls.Add(this.listPoland);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 405);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Test";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCheck.Location = new System.Drawing.Point(19, 147);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(257, 43);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Sprawdz";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAverage.Location = new System.Drawing.Point(321, 62);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(390, 31);
            this.lblAverage.TabIndex = 11;
            this.lblAverage.Text = "Procent dobrych odpowiedzi:";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIncorrect.Location = new System.Drawing.Point(321, 31);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(297, 31);
            this.lblIncorrect.TabIndex = 10;
            this.lblIncorrect.Text = "Blednych odpowiedzi:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCorrect.Location = new System.Drawing.Point(321, 0);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(337, 31);
            this.lblCorrect.TabIndex = 9;
            this.lblCorrect.Text = "Poprawnych odpowiedzi:";
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddWord.Location = new System.Drawing.Point(19, 294);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(257, 43);
            this.btnAddWord.TabIndex = 8;
            this.btnAddWord.Text = "Dodaj Slowko";
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRandomEng
            // 
            this.btnRandomEng.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRandomEng.Location = new System.Drawing.Point(19, 245);
            this.btnRandomEng.Name = "btnRandomEng";
            this.btnRandomEng.Size = new System.Drawing.Size(257, 43);
            this.btnRandomEng.TabIndex = 7;
            this.btnRandomEng.Text = "Losuj angielskie";
            this.btnRandomEng.UseVisualStyleBackColor = false;
            this.btnRandomEng.Click += new System.EventHandler(this.btnRandomEng_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(106, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 31);
            this.label11.TabIndex = 6;
            this.label11.Text = "ENG:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(106, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "PL:";
            // 
            // txtEngland
            // 
            this.txtEngland.BackColor = System.Drawing.SystemColors.Control;
            this.txtEngland.Location = new System.Drawing.Point(19, 109);
            this.txtEngland.Name = "txtEngland";
            this.txtEngland.Size = new System.Drawing.Size(257, 26);
            this.txtEngland.TabIndex = 4;
            // 
            // txtPoland
            // 
            this.txtPoland.BackColor = System.Drawing.SystemColors.Control;
            this.txtPoland.Location = new System.Drawing.Point(19, 38);
            this.txtPoland.Name = "txtPoland";
            this.txtPoland.Size = new System.Drawing.Size(257, 26);
            this.txtPoland.TabIndex = 3;
            // 
            // btnRandomPl
            // 
            this.btnRandomPl.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRandomPl.Location = new System.Drawing.Point(19, 196);
            this.btnRandomPl.Name = "btnRandomPl";
            this.btnRandomPl.Size = new System.Drawing.Size(257, 43);
            this.btnRandomPl.TabIndex = 2;
            this.btnRandomPl.Text = "Losuj polskie";
            this.btnRandomPl.UseVisualStyleBackColor = false;
            this.btnRandomPl.Click += new System.EventHandler(this.btnRandomPl_Click);
            // 
            // listEngland
            // 
            this.listEngland.BackColor = System.Drawing.SystemColors.Control;
            this.listEngland.FormattingEnabled = true;
            this.listEngland.ItemHeight = 20;
            this.listEngland.Location = new System.Drawing.Point(566, 126);
            this.listEngland.Name = "listEngland";
            this.listEngland.Size = new System.Drawing.Size(197, 204);
            this.listEngland.TabIndex = 1;
            // 
            // listPoland
            // 
            this.listPoland.BackColor = System.Drawing.SystemColors.Control;
            this.listPoland.FormattingEnabled = true;
            this.listPoland.ItemHeight = 20;
            this.listPoland.Location = new System.Drawing.Point(327, 126);
            this.listPoland.Name = "listPoland";
            this.listPoland.Size = new System.Drawing.Size(197, 204);
            this.listPoland.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPolish);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.txtEnglish);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(19, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 113);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(20, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 135);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnModify);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(19, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 67);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Controls.Add(this.lblCount);
            this.panel4.Location = new System.Drawing.Point(20, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 54);
            this.panel4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Poziom Jezykowy:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "A1",
            "A2",
            "B1",
            "B2",
            "C1",
            "C2"});
            this.comboBox1.Location = new System.Drawing.Point(251, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.listStageThree);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listStageFive);
            this.groupBox1.Controls.Add(this.listStageFour);
            this.groupBox1.Controls.Add(this.listStageTwo);
            this.groupBox1.Controls.Add(this.listStageOne);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(19, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 311);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twoje pojemniki:";
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInformation.Location = new System.Drawing.Point(607, 13);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(143, 35);
            this.btnInformation.TabIndex = 0;
            this.btnInformation.Text = "Informacje";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlay.Location = new System.Drawing.Point(27, 13);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(143, 35);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Graj";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnInformation);
            this.panel5.Controls.Add(this.btnPlay);
            this.panel5.Location = new System.Drawing.Point(19, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(767, 64);
            this.panel5.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(852, 405);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Kategoria";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 438);
            this.Controls.Add(this.Game);
            this.Name = "Form1";
            this.Text = "Fiszki angielskie";
            this.Game.ResumeLayout(false);
            this.Dictionary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Game;
        private System.Windows.Forms.TabPage Dictionary;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCount;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtPolish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listEngland;
        private System.Windows.Forms.ListBox listPoland;
        private System.Windows.Forms.TextBox txtEngland;
        private System.Windows.Forms.TextBox txtPoland;
        private System.Windows.Forms.Button btnRandomPl;
        private System.Windows.Forms.Button btnRandomEng;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

