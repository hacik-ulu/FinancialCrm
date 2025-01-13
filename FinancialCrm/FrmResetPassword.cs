using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmResetPassword : Form
    {
        private readonly FinancialCrmDbEntities _context;  
        public FrmResetPassword(FinancialCrmDbEntities context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = txtResetPasswordUsername.Text.Trim();
            string newPassword = txtResetPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz.",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var user = _context.Users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                MessageBox.Show("Bu kullanıcı adı ile kayıtlı bir kullanıcı bulunmamaktadır.",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Şifreyi ve şifre doğrulamasını giriniz.",
                                "Eksik Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar deneyin.",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            user.Password = newPassword;
            _context.SaveChanges();

            MessageBox.Show("Şifreniz başarıyla güncellenmiştir.",
                            "Başarılı",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Hide();

            FrmLogin frmLogin = new FrmLogin(_context);
            frmLogin.ShowDialog();
        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtResetPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
            txtConfirmPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';

        }
    }

}
