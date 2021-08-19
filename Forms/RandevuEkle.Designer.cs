namespace RandevuYazılımSistemi
{
    partial class RandevuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuEkle));
            this.pictureBox_Kapat = new System.Windows.Forms.PictureBox();
            this.buttonRandevu = new System.Windows.Forms.Button();
            this.labelOnay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOnay2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Kapat
            // 
            this.pictureBox_Kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Kapat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Kapat.Image")));
            this.pictureBox_Kapat.Location = new System.Drawing.Point(575, 12);
            this.pictureBox_Kapat.Name = "pictureBox_Kapat";
            this.pictureBox_Kapat.Size = new System.Drawing.Size(39, 38);
            this.pictureBox_Kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Kapat.TabIndex = 0;
            this.pictureBox_Kapat.TabStop = false;
            this.pictureBox_Kapat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Kapat_MouseClick);
            this.pictureBox_Kapat.MouseLeave += new System.EventHandler(this.pictureBox_Kapat_MouseLeave);
            this.pictureBox_Kapat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Kapat_MouseMove);
            // 
            // buttonRandevu
            // 
            this.buttonRandevu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRandevu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.buttonRandevu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRandevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandevu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandevu.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonRandevu.Location = new System.Drawing.Point(260, 134);
            this.buttonRandevu.Name = "buttonRandevu";
            this.buttonRandevu.Size = new System.Drawing.Size(122, 33);
            this.buttonRandevu.TabIndex = 1;
            this.buttonRandevu.Text = "Randevu Al";
            this.buttonRandevu.UseVisualStyleBackColor = false;
            this.buttonRandevu.Click += new System.EventHandler(this.buttonRandevu_Click);
            // 
            // labelOnay
            // 
            this.labelOnay.AutoSize = true;
            this.labelOnay.BackColor = System.Drawing.Color.White;
            this.labelOnay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOnay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(137)))));
            this.labelOnay.Location = new System.Drawing.Point(294, 65);
            this.labelOnay.Name = "labelOnay";
            this.labelOnay.Size = new System.Drawing.Size(50, 18);
            this.labelOnay.TabIndex = 2;
            this.labelOnay.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelOnay2
            // 
            this.labelOnay2.AutoSize = true;
            this.labelOnay2.BackColor = System.Drawing.Color.White;
            this.labelOnay2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOnay2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(137)))));
            this.labelOnay2.Location = new System.Drawing.Point(294, 106);
            this.labelOnay2.Name = "labelOnay2";
            this.labelOnay2.Size = new System.Drawing.Size(50, 18);
            this.labelOnay2.TabIndex = 5;
            this.labelOnay2.Text = "label1";
            // 
            // RandevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 179);
            this.Controls.Add(this.labelOnay2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelOnay);
            this.Controls.Add(this.buttonRandevu);
            this.Controls.Add(this.pictureBox_Kapat);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandevuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandevuEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Kapat;
        private System.Windows.Forms.Button buttonRandevu;
        private System.Windows.Forms.Label labelOnay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelOnay2;
    }
}