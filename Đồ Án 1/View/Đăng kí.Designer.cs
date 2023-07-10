
namespace Đồ_Án_1.View
{
    partial class Đăng_kí
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
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPasswork = new System.Windows.Forms.TextBox();
            this.txtEPasswork = new System.Windows.Forms.TextBox();
            this.btRegiter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(259, 33);
            this.txtAccount.Multiline = true;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(233, 39);
            this.txtAccount.TabIndex = 0;
            // 
            // txtPasswork
            // 
            this.txtPasswork.Location = new System.Drawing.Point(259, 93);
            this.txtPasswork.Multiline = true;
            this.txtPasswork.Name = "txtPasswork";
            this.txtPasswork.Size = new System.Drawing.Size(233, 39);
            this.txtPasswork.TabIndex = 1;
            // 
            // txtEPasswork
            // 
            this.txtEPasswork.Location = new System.Drawing.Point(259, 152);
            this.txtEPasswork.Multiline = true;
            this.txtEPasswork.Name = "txtEPasswork";
            this.txtEPasswork.Size = new System.Drawing.Size(233, 39);
            this.txtEPasswork.TabIndex = 2;
            // 
            // btRegiter
            // 
            this.btRegiter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRegiter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegiter.Location = new System.Drawing.Point(302, 229);
            this.btRegiter.Name = "btRegiter";
            this.btRegiter.Size = new System.Drawing.Size(120, 68);
            this.btRegiter.TabIndex = 3;
            this.btRegiter.Text = "Đăng Kí";
            this.btRegiter.UseVisualStyleBackColor = true;
            this.btRegiter.Click += new System.EventHandler(this.btRegiter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập Lại Mật Khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Đồ_Án_1.Properties.Resources.pngtree_fried_chicken_crispy_chicken_drumstick_cartoon_clipart_png_image_2965831;
            this.pictureBox1.Location = new System.Drawing.Point(518, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Đăng_kí
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(669, 309);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegiter);
            this.Controls.Add(this.txtEPasswork);
            this.Controls.Add(this.txtPasswork);
            this.Controls.Add(this.txtAccount);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Đăng_kí";
            this.Text = "ĐĂNG KÍ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Đăng_kí_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Đăng_kí_FormClosed);
            this.Load += new System.EventHandler(this.Đăng_kí_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPasswork;
        private System.Windows.Forms.TextBox txtEPasswork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRegiter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}