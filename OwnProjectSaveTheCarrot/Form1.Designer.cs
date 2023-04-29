namespace OwnProjectSaveTheCarrot
{
    partial class PigGame
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelMissed = new System.Windows.Forms.Label();
            this.GuineaPig = new System.Windows.Forms.PictureBox();
            this.Carrot2 = new System.Windows.Forms.PictureBox();
            this.Carrot3 = new System.Windows.Forms.PictureBox();
            this.Carrot1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GuineaPig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrot1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(22, 20);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(47, 13);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score: 0";
            // 
            // labelMissed
            // 
            this.labelMissed.AutoSize = true;
            this.labelMissed.Location = new System.Drawing.Point(224, 20);
            this.labelMissed.Name = "labelMissed";
            this.labelMissed.Size = new System.Drawing.Size(52, 13);
            this.labelMissed.TabIndex = 5;
            this.labelMissed.Text = "Missed: 0";
            // 
            // GuineaPig
            // 
            this.GuineaPig.Image = global::OwnProjectSaveTheCarrot.Properties.Resources.guineapig;
            this.GuineaPig.Location = new System.Drawing.Point(90, 362);
            this.GuineaPig.Name = "GuineaPig";
            this.GuineaPig.Size = new System.Drawing.Size(161, 95);
            this.GuineaPig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GuineaPig.TabIndex = 3;
            this.GuineaPig.TabStop = false;
            // 
            // Carrot2
            // 
            this.Carrot2.Image = global::OwnProjectSaveTheCarrot.Properties.Resources.carrot;
            this.Carrot2.Location = new System.Drawing.Point(179, 42);
            this.Carrot2.Name = "Carrot2";
            this.Carrot2.Size = new System.Drawing.Size(72, 67);
            this.Carrot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carrot2.TabIndex = 2;
            this.Carrot2.TabStop = false;
            this.Carrot2.Tag = "carrot";
            // 
            // Carrot3
            // 
            this.Carrot3.Image = global::OwnProjectSaveTheCarrot.Properties.Resources.carrot;
            this.Carrot3.Location = new System.Drawing.Point(323, 42);
            this.Carrot3.Name = "Carrot3";
            this.Carrot3.Size = new System.Drawing.Size(72, 67);
            this.Carrot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carrot3.TabIndex = 1;
            this.Carrot3.TabStop = false;
            this.Carrot3.Tag = "carrot";
            // 
            // Carrot1
            // 
            this.Carrot1.Image = global::OwnProjectSaveTheCarrot.Properties.Resources.carrot;
            this.Carrot1.Location = new System.Drawing.Point(22, 42);
            this.Carrot1.Name = "Carrot1";
            this.Carrot1.Size = new System.Drawing.Size(72, 67);
            this.Carrot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carrot1.TabIndex = 0;
            this.Carrot1.TabStop = false;
            this.Carrot1.Tag = "carrot";
            // 
            // PigGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 469);
            this.Controls.Add(this.labelMissed);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.GuineaPig);
            this.Controls.Add(this.Carrot2);
            this.Controls.Add(this.Carrot3);
            this.Controls.Add(this.Carrot1);
            this.MaximizeBox = false;
            this.Name = "PigGame";
            this.Text = "Swinkowa Gra";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.GuineaPig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carrot1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Carrot1;
        private System.Windows.Forms.PictureBox Carrot3;
        private System.Windows.Forms.PictureBox Carrot2;
        private System.Windows.Forms.PictureBox GuineaPig;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelMissed;
    }
}

