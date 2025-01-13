namespace FinancialCrm
{
    partial class FrmResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResetPassword));
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.lblResetPasswordUsername = new System.Windows.Forms.Label();
            this.txtResetPassword = new System.Windows.Forms.TextBox();
            this.txtResetPasswordUsername = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbShowPassword.Location = new System.Drawing.Point(660, 157);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(111, 22);
            this.cbShowPassword.TabIndex = 16;
            this.cbShowPassword.Text = "Şifreyi Göster";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResetPassword.ForeColor = System.Drawing.Color.White;
            this.lblResetPassword.Location = new System.Drawing.Point(450, 89);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(41, 21);
            this.lblResetPassword.TabIndex = 15;
            this.lblResetPassword.Text = "Şifre";
            // 
            // lblResetPasswordUsername
            // 
            this.lblResetPasswordUsername.AutoSize = true;
            this.lblResetPasswordUsername.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResetPasswordUsername.ForeColor = System.Drawing.Color.White;
            this.lblResetPasswordUsername.Location = new System.Drawing.Point(450, 56);
            this.lblResetPasswordUsername.Name = "lblResetPasswordUsername";
            this.lblResetPasswordUsername.Size = new System.Drawing.Size(95, 21);
            this.lblResetPasswordUsername.TabIndex = 14;
            this.lblResetPasswordUsername.Text = "Kullanıcı Adı";
            // 
            // txtResetPassword
            // 
            this.txtResetPassword.Location = new System.Drawing.Point(577, 91);
            this.txtResetPassword.Name = "txtResetPassword";
            this.txtResetPassword.PasswordChar = '*';
            this.txtResetPassword.Size = new System.Drawing.Size(189, 20);
            this.txtResetPassword.TabIndex = 13;
            // 
            // txtResetPasswordUsername
            // 
            this.txtResetPasswordUsername.Location = new System.Drawing.Point(577, 56);
            this.txtResetPasswordUsername.Name = "txtResetPasswordUsername";
            this.txtResetPasswordUsername.Size = new System.Drawing.Size(189, 20);
            this.txtResetPasswordUsername.TabIndex = 12;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Silver;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnChangePassword.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(170)))), ((int)(((byte)(34)))));
            this.btnChangePassword.Location = new System.Drawing.Point(577, 194);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(191, 33);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Şifreyi Değiştir";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(450, 122);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(123, 21);
            this.lblConfirmPassword.TabIndex = 21;
            this.lblConfirmPassword.Text = "Yeni Şifre Tekrarı";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(577, 124);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(189, 20);
            this.txtConfirmPassword.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 275);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FrmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.lblResetPassword);
            this.Controls.Add(this.lblResetPasswordUsername);
            this.Controls.Add(this.txtResetPassword);
            this.Controls.Add(this.txtResetPasswordUsername);
            this.Controls.Add(this.btnChangePassword);
            this.Name = "FrmResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.Label lblResetPasswordUsername;
        private System.Windows.Forms.TextBox txtResetPassword;
        private System.Windows.Forms.TextBox txtResetPasswordUsername;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}