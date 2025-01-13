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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCrm
{
    public partial class FrmExpense : Form
    {
        private readonly FinancialCrmDbEntities _context;
        public FrmExpense(FinancialCrmDbEntities context)
        {
            _context = context;
            InitializeComponent();
        }
        private void FrmExpense_Load(object sender, EventArgs e)
        {
            LoadCategories();
            DbSearch();

            var spendingData = _context.Spendings.Select(x => new
            {
                x.SpendingTitle,
                x.SpendingAmount
            }).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("Harcama Miktarları");
            foreach (var item in spendingData)
            {
                series.Points.AddXY(item.SpendingTitle, item.SpendingAmount);
            }

            var categorySpendingData = _context.Spendings
                .GroupBy(x => x.Categories.CategoryName)  
                .Select(g => new
                {
                    CategoryName = g.Key,
                    TotalAmount = g.Sum(x => x.SpendingAmount)
                }).ToList();

            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Harcama Kategorileri");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2["PieLabelStyle"] = "Inside";  

            decimal totalSpendingAmount = (decimal)categorySpendingData.Sum(x => x.TotalAmount); 
            int index = 0; 
            foreach (var item in categorySpendingData)
            {
                decimal percentage = (decimal)((item.TotalAmount / totalSpendingAmount) * 100);

                series2.Points.AddXY(item.CategoryName, item.TotalAmount);
                series2.Points[index].Label = string.Format("{0} ({1:0.00}%)", item.CategoryName, percentage);

                index++; 
            }

        }
        private void btnExpenseList_Click(object sender, EventArgs e)
        {
            DbSearch();
        }
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (cbExpenseCategory.SelectedValue == null || string.IsNullOrEmpty(txtExpenseTitle.Text) || string.IsNullOrEmpty(txtExpenseAmount.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var expense = new Spendings
                {
                    SpendingTitle = txtExpenseTitle.Text,
                    SpendingAmount = decimal.Parse(txtExpenseAmount.Text),
                    SpendingDate = dateTimePicker1.Value,
                    CategoryId = (int)cbExpenseCategory.SelectedValue
                };

                _context.Spendings.Add(expense);
                _context.SaveChanges();

                MessageBox.Show("Harcama başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DbSearch();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DbSearch()
        {
            var values = _context.Spendings
                .Select(s => new
                {
                    s.SpendingId,
                    s.SpendingTitle,
                    s.SpendingAmount,
                    s.SpendingDate,
                    s.Categories.CategoryName
                })
                .ToList();

            dataGridView1.DataSource = values;
        }
        private void LoadCategories()
        {
            var categories = _context.Categories.ToList();
            cbExpenseCategory.DisplayMember = "CategoryName";
            cbExpenseCategory.ValueMember = "CategoryId";
            cbExpenseCategory.DataSource = categories;
        }
        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            int deletedToValue = int.Parse(txtExpenseId.Text);
            _context.Spendings.Remove(_context.Spendings.Find(deletedToValue));
            _context.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı!");
            DbSearch();
        }
        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {
            if (cbExpenseCategory.SelectedValue == null || string.IsNullOrEmpty(txtExpenseTitle.Text) || string.IsNullOrEmpty(txtExpenseAmount.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {  
                int selectedExpenseId = txtExpenseId.Text.Length > 0 ? int.Parse(txtExpenseId.Text) : 0;

                var expense = _context.Spendings.FirstOrDefault(s => s.SpendingId == selectedExpenseId);
                if (expense == null)
                {
                    MessageBox.Show("Seçilen harcama bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                expense.SpendingTitle = txtExpenseTitle.Text;
                expense.SpendingAmount = decimal.Parse(txtExpenseAmount.Text);
                expense.SpendingDate = dateTimePicker1.Value;
                expense.CategoryId = (int)cbExpenseCategory.SelectedValue;

                _context.SaveChanges();

                MessageBox.Show("Harcama başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DbSearch(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
