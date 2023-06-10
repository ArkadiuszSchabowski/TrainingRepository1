namespace Serializacja4
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbLabel = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.tbPerson = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(362, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLabel.Location = new System.Drawing.Point(12, 25);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(94, 25);
            this.lbLabel.TabIndex = 2;
            this.lbLabel.Text = "Ksiazka:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbName.Location = new System.Drawing.Point(12, 78);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(81, 25);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Osoba:";
            // 
            // tbBook
            // 
            this.tbBook.Location = new System.Drawing.Point(8, 56);
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(194, 20);
            this.tbBook.TabIndex = 4;
            // 
            // tbPerson
            // 
            this.tbPerson.Location = new System.Drawing.Point(9, 106);
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Size = new System.Drawing.Size(193, 20);
            this.tbPerson.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 273);
            this.Controls.Add(this.tbPerson);
            this.Controls.Add(this.tbBook);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.TextBox tbPerson;
    }
}

