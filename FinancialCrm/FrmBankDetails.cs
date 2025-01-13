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

        private int counter = 0;
        private Timer timer;

        private void FrmBankDetails_Load(object sender, EventArgs e)
        {
            var banks = _context.BankDetails.ToList();

            cbBankList.DataSource = banks;
            cbBankList.DisplayMember = "BankName";
            cbBankList.ValueMember = "BankID";

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.BackgroundColor = Color.White;


            chart1.Series.Clear();

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "InterestRates",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            chart1.Series.Add(series);

            foreach (var bank in banks)
            {
                series.Points.AddXY(bank.BankName, bank.InterestRate);
            }

            series.Label = "#PERCENT";
            series.LegendText = "#VALX";

            chart1.Titles.Clear();
            chart1.Titles.Add("Bankalara Göre Faiz Oranları");
            chart1.Legends[0].Enabled = true;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;



            chart2.Series.Clear(); 

            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Müşteri Sayısı",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            };

            chart2.Series.Add(series2);

            foreach (var bank in banks)
            {
                series2.Points.AddXY(bank.BankName, bank.CustomerCount);
            }

            chart2.Titles.Clear();
            chart2.Titles.Add("Bankalara Göre Müşteri Sayısı");
            chart2.Legends[0].Enabled = true;
            chart2.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += (s, es) => UpdateBankDetails(banks);
            timer.Start();

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

        private void UpdateBankDetails(List<BankDetails> banks)
        {
            if (banks.Count > 0)
            {
                var bank = banks[counter % banks.Count]; 
                lblBank.Text = bank.BankName;          
                lblRate.Text = $"{bank.InterestRate}%"; 
                counter++;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDashboard frmDashboard = new FrmDashboard(_context);
            frmDashboard.ShowDialog();
        }
    }
}
