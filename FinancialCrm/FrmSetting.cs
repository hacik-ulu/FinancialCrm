using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSetting : Form
    {
        private readonly FinancialCrmDbEntities _context;

        public FrmSetting(FinancialCrmDbEntities context)
        {
            _context = context;
            InitializeComponent();
            txtPassword.PasswordChar = '*'; // Şifre alanını gizli başlat
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string email = txtEmail.Text;

                var user = _context.Users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                {
                    MessageBox.Show("Bu kullanıcı adıyla kayıtlı bir kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Email boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(password))
                {
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    user.Password = hashedPassword;
                }

                user.EmailAddress = email;
                user.Username = username;

                _context.SaveChanges();
                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Şifre alanını göster veya gizle
            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }

        private void linkLableDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmDashboard frmDashboard = new FrmDashboard(_context);
            frmDashboard.ShowDialog();
        }
    }
}
