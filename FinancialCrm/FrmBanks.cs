using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        private readonly FinancialCrmDbEntities _context;
        public FrmBanks(FinancialCrmDbEntities context)
        {
            _context = context;
            InitializeComponent();
        }
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            #region Bakiye İşlemleri
            string currency = " ₺";
            // ZiraatBank Balance
            var ziraatBankBalance = _context.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + currency;

            // Vakıfbank Balance
            var vakifbankBalance = _context.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            lblVakifbankBalance.Text = vakifbankBalance.ToString() + currency;

            // Isbank Balance
            var isbankBalance = _context.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
            lblIsBankBalance.Text = isbankBalance.ToString() + currency;
            #endregion

            #region Banka İşlemleri
            // Bank Transactions

            var bankProcess1 = _context.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Skip(0)
                .Take(1)
                .FirstOrDefault();

            lblBankProcess.Text =
                $"İşlem Açıklaması : {bankProcess1.Description} | " +
                $"Tutar : {bankProcess1.Amount:C2} {currency}  | " +
                $"Tarih : {bankProcess1.ProcessDate:dd.MM.yyyy}";

            var bankProcess2 = _context.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Skip(1)
                .Take(1)
                .FirstOrDefault();

            lblBankProcess2.Text =
                $"İşlem Açıklaması : {bankProcess2.Description} | " +
                $"Tutar : {bankProcess2.Amount:C2} {currency}  | " +
                $"Tarih : {bankProcess2.ProcessDate:dd.MM.yyyy}";

            var bankProcess3 = _context.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Skip(2)
                .Take(1)
                .FirstOrDefault();

            lblBankProcess3.Text =
                $"İşlem Açıklaması : {bankProcess3.Description} | " +
                $"Tutar : {bankProcess3.Amount:C2} {currency}  | " +
                $"Tarih : {bankProcess3.ProcessDate:dd.MM.yyyy}";

            var bankProcess4 = _context.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Skip(3)
                .Take(1)
                .FirstOrDefault();

            lblBankProcess4.Text =
                $"İşlem Açıklaması : {bankProcess4.Description} | " +
                $"Tutar : {bankProcess4.Amount:C2} {currency}  | " +
                $"Tarih : {bankProcess4.ProcessDate:dd.MM.yyyy}";

            var bankProcess5 = _context.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Skip(4)
                .Take(1)
                .FirstOrDefault();

            lblBankProcess5.Text =
                $"İşlem Açıklaması : {bankProcess5.Description} | " +
                $"Tutar : {bankProcess5.Amount:C2} {currency}  | " +
                $"Tarih : {bankProcess5.ProcessDate:dd.MM.yyyy}";
            #endregion
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling(_context);
            frmBilling.Show();
            this.Hide();
        }

        private void btnDirectToFrmBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBilling frmBilling = new FrmBilling(_context);
            frmBilling.Show();
            
        }

        private void btnDirectToBankProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBilling frmBilling = new FrmBilling(_context);
            frmBilling.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBilling frmBilling = new FrmBilling(_context);
            frmBilling.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBanks frmBanks = new FrmBanks(_context);
            frmBanks.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDashboard frmDashboard = new FrmDashboard(_context);
            frmDashboard.Show();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmDashboard frmDashboard = new FrmDashboard(_context);
            frmDashboard.ShowDialog();
        }
    }
}
