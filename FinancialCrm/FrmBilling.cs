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
    public partial class FrmBilling : Form
    {
        private readonly FinancialCrmDbEntities _context;
        public FrmBilling(FinancialCrmDbEntities context)
        {
            _context = context;
            InitializeComponent();
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            DbSearch();
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            DbSearch();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            var billing = new Bills
            {
                BillTitle = txtBillTitle.Text,
                BillAmount = decimal.Parse(txtBillAmount.Text),
                BillPeriod = txtBillPeriod.Text
            };
            _context.Bills.Add(billing);
            _context.SaveChanges();
            MessageBox.Show("Ödeme işlemi başarılı!");

            DbSearch();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int deletedToValue = int.Parse(txtBillId.Text);
            _context.Bills.Remove(_context.Bills.Find(deletedToValue));
            _context.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı!");
            DbSearch(); 
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int billId = int.Parse(txtBillId.Text);
            var billing = _context.Bills.FirstOrDefault(b => b.BillId == billId);

            billing.BillTitle = txtBillTitle.Text;
            billing.BillAmount = decimal.Parse(txtBillAmount.Text);
            billing.BillPeriod = txtBillingPeriod.Text;

            _context.SaveChanges();
            MessageBox.Show("Ödeme işlemi başarıyla güncellendi!");
            DbSearch();
        }

        private void DbSearch()
        {
            var values = _context.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks(_context);
            frmBanks.Show();
            this.Hide();
        }
    }
}
