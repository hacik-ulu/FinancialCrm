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
    public partial class FrmBankDetails : Form
    {
        private readonly FinancialCrmDbEntities _context;  
        public FrmBankDetails(FinancialCrmDbEntities context)
        {
            _context = context;
            InitializeComponent();
        }

        private void FrmBankDetails_Load(object sender, EventArgs e)
        {
            var banks = _context.BankDetails.ToList();

            cbBankList.DataSource = banks;
            cbBankList.DisplayMember = "BankName";
            cbBankList.ValueMember = "BankID";

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void cbBankList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBank = cbBankList.SelectedItem as BankDetails;

            if (selectedBank != null)
            {
                int selectedBankID = selectedBank.BankID;

                var selectedBankDetails = _context.BankDetails
                                                    .Where(b => b.BankID == selectedBankID)
                                                    .ToList();

                dataGridView1.DataSource = selectedBankDetails;
            }
        }





    }
}
