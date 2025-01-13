using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using BCrypt.Net; 

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        private readonly FinancialCrmDbEntities _context;
        public FrmLogin(FinancialCrmDbEntities context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre bilgilerini giriniz.",
                                "Eksik Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Kullanıcı adı alanı boş bırakılamaz. Lütfen doldurun.",
                                "Eksik Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz. Lütfen doldurun.",
                                "Eksik Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var user = _context.Users.FirstOrDefault(x => x.Username == txtUsername.Text);
            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı hatalı. Lütfen tekrar deneyiniz.",
                                "Hatalı Kullanıcı Adı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!BCrypt.Net.BCrypt.Verify(txtPassword.Text, user.Password)) // Hash'li şifreyi doğrulama
            {
                MessageBox.Show("Şifre hatalı. Lütfen tekrar deneyiniz.",
                                 "Hatalı Şifre",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Giriş başarılı! Hoş geldiniz.",
                            "Başarılı",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Hide();
            FrmDashboard frmDashboard = new FrmDashboard(_context);
            frmDashboard.ShowDialog();

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkmak istediğinize emin misiniz?",
                                         "Çıkış",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            FrmResetPassword resetPasswordForm = new FrmResetPassword(_context);
            resetPasswordForm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            FrmRegister frmRegister = new FrmRegister(_context);
            frmRegister.ShowDialog();
        }
    }
}

// Yönlendirme yap basarı durumunda.