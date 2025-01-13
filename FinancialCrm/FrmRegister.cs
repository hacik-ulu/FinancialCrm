using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmRegister : Form
    {
        private readonly FinancialCrmDbEntities _context;

        public FrmRegister(FinancialCrmDbEntities context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingUser = _context.Users.FirstOrDefault(x => x.Username == username || x.EmailAddress == email);
            if (existingUser != null)
            {
                MessageBox.Show("Kullanıcı adı veya email zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            var user = new Users
            {
                Username = username,
                EmailAddress = email,
                Password = hashedPassword,
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            MessageBox.Show("Hesap başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            FrmLogin frmLogin = new FrmLogin(_context);
            frmLogin.ShowDialog();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                cbShowPassword.Text = "Şifreyi Gizle";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                cbShowPassword.Text = "Şifreyi Göster";
            }
        }
    }
}
