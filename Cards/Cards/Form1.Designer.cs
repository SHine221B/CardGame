namespace Cards
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAgain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bAgain
            // 
            this.bAgain.BackColor = System.Drawing.Color.Brown;
            this.bAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAgain.Location = new System.Drawing.Point(210, 387);
            this.bAgain.Name = "bAgain";
            this.bAgain.Size = new System.Drawing.Size(142, 40);
            this.bAgain.TabIndex = 3;
            this.bAgain.Text = "Play Again";
            this.bAgain.UseVisualStyleBackColor = false;
            this.bAgain.Click += new System.EventHandler(this.bAgain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Znajdź asa serce:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.Brown;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bClear.Location = new System.Drawing.Point(476, 12);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 40);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Brown;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bExit.Location = new System.Drawing.Point(12, 12);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 40);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(473, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "score:";
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lScore.ForeColor = System.Drawing.Color.White;
            this.lScore.Location = new System.Drawing.Point(526, 64);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(18, 19);
            this.lScore.TabIndex = 8;
            this.lScore.Text = "0";
            this.lScore.Click += new System.EventHandler(this.lScore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cards.Properties.Resources.Back;
            this.pictureBox1.Location = new System.Drawing.Point(53, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 200);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cards.Properties.Resources.Back;
            this.pictureBox3.Location = new System.Drawing.Point(367, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 200);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cards.Properties.Resources.Back;
            this.pictureBox2.Location = new System.Drawing.Point(210, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 200);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(420, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "M. Sominka @2018";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAgain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bAgain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

