namespace RandevuYazılımSistemi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEnter = new System.Windows.Forms.PictureBox();
            this.buttonEnterHover = new System.Windows.Forms.PictureBox();
            this.buttonKayıt0 = new System.Windows.Forms.PictureBox();
            this.buttonKayıt1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEnterHover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonKayıt0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonKayıt1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(174, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yonetici Giriş Ekranı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonKayıt1);
            this.groupBox1.Controls.Add(this.buttonKayıt0);
            this.groupBox1.Controls.Add(this.buttonEnterHover);
            this.groupBox1.Controls.Add(this.buttonEnter);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(86, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AcceptsTab = true;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPassword.Location = new System.Drawing.Point(88, 96);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(212, 26);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // textBoxTC
            // 
            this.textBoxTC.AcceptsTab = true;
            this.textBoxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTC.Location = new System.Drawing.Point(88, 43);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(212, 26);
            this.textBoxTC.TabIndex = 3;
            this.textBoxTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnter.Image")));
            this.buttonEnter.Location = new System.Drawing.Point(116, 134);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(120, 34);
            this.buttonEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonEnter.TabIndex = 8;
            this.buttonEnter.TabStop = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            this.buttonEnter.MouseLeave += new System.EventHandler(this.buttonEnter_MouseLeave);
            // 
            // buttonEnterHover
            // 
            this.buttonEnterHover.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnterHover.Image")));
            this.buttonEnterHover.Location = new System.Drawing.Point(116, 134);
            this.buttonEnterHover.Name = "buttonEnterHover";
            this.buttonEnterHover.Size = new System.Drawing.Size(120, 34);
            this.buttonEnterHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonEnterHover.TabIndex = 9;
            this.buttonEnterHover.TabStop = false;
            this.buttonEnterHover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonEnterHover_MouseMove);
            // 
            // buttonKayıt0
            // 
            this.buttonKayıt0.Image = ((System.Drawing.Image)(resources.GetObject("buttonKayıt0.Image")));
            this.buttonKayıt0.Location = new System.Drawing.Point(6, 174);
            this.buttonKayıt0.Name = "buttonKayıt0";
            this.buttonKayıt0.Size = new System.Drawing.Size(120, 30);
            this.buttonKayıt0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonKayıt0.TabIndex = 10;
            this.buttonKayıt0.TabStop = false;
            this.buttonKayıt0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonKayıt0_MouseMove);
            // 
            // buttonKayıt1
            // 
            this.buttonKayıt1.Image = ((System.Drawing.Image)(resources.GetObject("buttonKayıt1.Image")));
            this.buttonKayıt1.Location = new System.Drawing.Point(6, 174);
            this.buttonKayıt1.Name = "buttonKayıt1";
            this.buttonKayıt1.Size = new System.Drawing.Size(120, 30);
            this.buttonKayıt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonKayıt1.TabIndex = 11;
            this.buttonKayıt1.TabStop = false;
            this.buttonKayıt1.Click += new System.EventHandler(this.buttonKayıt1_Click);
            this.buttonKayıt1.MouseLeave += new System.EventHandler(this.buttonKayıt1_MouseLeave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEnterHover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonKayıt0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonKayıt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox buttonEnter;
        private System.Windows.Forms.PictureBox buttonEnterHover;
        private System.Windows.Forms.PictureBox buttonKayıt1;
        private System.Windows.Forms.PictureBox buttonKayıt0;
    }
}