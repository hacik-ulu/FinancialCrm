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
    public partial class FrmDashboard : Form
    {
        private readonly FinancialCrmDbEntities _context;
        int count = 0;
        public FrmDashboard(FinancialCrmDbEntities context)
        {
            _context = context;
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = _context.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastBankProcessAmount = _context.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).
                Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

            // Chart1
            var bankData = _context.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Bakiyeler");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            // Chart2
            var billData = _context.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType=System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Timer
            ++count;
            if (count % 4 == 1)
            {
                var electricityBill = _context.Bills.Where(x => x.BillTitle == "Elektrik Faturası").
                    Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = electricityBill.ToString() + " ₺";
            }
            if (count % 4 == 2)
            {
                var naturalGasBill = _context.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").
                    Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = naturalGasBill.ToString() + " ₺";
            }
            if (count % 4 == 3)
            {
                var waterBill = _context.Bills.Where(x => x.BillTitle == "Su Faturası").
                    Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = waterBill.ToString() + " ₺";
            }
            if (count % 4 == 0)
            {
                var internetBill = _context.Bills.Where(x => x.BillTitle == "İnternet Faturası").
                    Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = internetBill.ToString() + " ₺";
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBanks frmBanks = new FrmBanks(_context);
            frmBanks.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBilling frmBilling = new FrmBilling(_context);
            frmBilling.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin(_context);
            frmLogin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBanks frmBanks = new FrmBanks(_context);
            frmBanks.Show();
        }

       
    }
}
