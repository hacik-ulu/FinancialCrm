namespace FinancialCrm
{
    partial class FrmExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnUpdateExpense = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbExpenseCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnExpenseList = new System.Windows.Forms.Button();
            this.txtBillingPeriod = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtBillingAmount = new System.Windows.Forms.Label();
            this.txtExpenseTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpenseId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateExpense
            // 
            this.btnUpdateExpense.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateExpense.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExpense.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnUpdateExpense.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateExpense.Location = new System.Drawing.Point(438, 165);
            this.btnUpdateExpense.Name = "btnUpdateExpense";
            this.btnUpdateExpense.Size = new System.Drawing.Size(135, 31);
            this.btnUpdateExpense.TabIndex = 12;
            this.btnUpdateExpense.Text = "Gider Güncelleme";
            this.btnUpdateExpense.UseVisualStyleBackColor = false;
            this.btnUpdateExpense.Click += new System.EventHandler(this.btnUpdateExpense_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.cbExpenseCategory);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnUpdateExpense);
            this.panel2.Controls.Add(this.btnDeleteExpense);
            this.panel2.Controls.Add(this.btnAddExpense);
            this.panel2.Controls.Add(this.btnExpenseList);
            this.panel2.Controls.Add(this.txtBillingPeriod);
            this.panel2.Controls.Add(this.txtExpenseAmount);
            this.panel2.Controls.Add(this.txtBillingAmount);
            this.panel2.Controls.Add(this.txtExpenseTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtExpenseId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(206, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 211);
            this.panel2.TabIndex = 5;
            // 
            // cbExpenseCategory
            // 
            this.cbExpenseCategory.FormattingEnabled = true;
            this.cbExpenseCategory.Location = new System.Drawing.Point(106, 109);
            this.cbExpenseCategory.Name = "cbExpenseCategory";
            this.cbExpenseCategory.Size = new System.Drawing.Size(467, 21);
            this.cbExpenseCategory.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(470, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tarih:";
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteExpense.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExpense.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteExpense.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteExpense.Location = new System.Drawing.Point(301, 165);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(113, 31);
            this.btnDeleteExpense.TabIndex = 11;
            this.btnDeleteExpense.Text = "Gider Sil";
            this.btnDeleteExpense.UseVisualStyleBackColor = false;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.Transparent;
            this.btnAddExpense.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddExpense.ForeColor = System.Drawing.Color.Black;
            this.btnAddExpense.Location = new System.Drawing.Point(165, 165);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(113, 31);
            this.btnAddExpense.TabIndex = 10;
            this.btnAddExpense.Text = "Yeni Gider";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnExpenseList
            // 
            this.btnExpenseList.BackColor = System.Drawing.Color.Transparent;
            this.btnExpenseList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExpenseList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpenseList.ForeColor = System.Drawing.Color.Black;
            this.btnExpenseList.Location = new System.Drawing.Point(33, 165);
            this.btnExpenseList.Name = "btnExpenseList";
            this.btnExpenseList.Size = new System.Drawing.Size(113, 27);
            this.btnExpenseList.TabIndex = 9;
            this.btnExpenseList.Text = "Gider Listesi\r\n";
            this.btnExpenseList.UseVisualStyleBackColor = false;
            this.btnExpenseList.Click += new System.EventHandler(this.btnExpenseList_Click);
            // 
            // txtBillingPeriod
            // 
            this.txtBillingPeriod.AutoSize = true;
            this.txtBillingPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillingPeriod.Location = new System.Drawing.Point(33, 109);
            this.txtBillingPeriod.Name = "txtBillingPeriod";
            this.txtBillingPeriod.Size = new System.Drawing.Size(67, 19);
            this.txtBillingPeriod.TabIndex = 6;
            this.txtBillingPeriod.Text = "Kategori:";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.BackColor = System.Drawing.Color.Khaki;
            this.txtExpenseAmount.Location = new System.Drawing.Point(103, 77);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(470, 20);
            this.txtExpenseAmount.TabIndex = 5;
            // 
            // txtBillingAmount
            // 
            this.txtBillingAmount.AutoSize = true;
            this.txtBillingAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillingAmount.Location = new System.Drawing.Point(33, 77);
            this.txtBillingAmount.Name = "txtBillingAmount";
            this.txtBillingAmount.Size = new System.Drawing.Size(52, 19);
            this.txtBillingAmount.TabIndex = 4;
            this.txtBillingAmount.Text = "Ücreti:";
            // 
            // txtExpenseTitle
            // 
            this.txtExpenseTitle.BackColor = System.Drawing.Color.Khaki;
            this.txtExpenseTitle.Location = new System.Drawing.Point(103, 42);
            this.txtExpenseTitle.Name = "txtExpenseTitle";
            this.txtExpenseTitle.Size = new System.Drawing.Size(470, 20);
            this.txtExpenseTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gider Adı:";
            // 
            // txtExpenseId
            // 
            this.txtExpenseId.BackColor = System.Drawing.Color.Khaki;
            this.txtExpenseId.Location = new System.Drawing.Point(103, 8);
            this.txtExpenseId.Name = "txtExpenseId";
            this.txtExpenseId.Size = new System.Drawing.Size(470, 20);
            this.txtExpenseId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gider Id:";
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(23, 77);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(147, 39);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(23, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(23, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(23, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(23, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 39);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(23, 302);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 39);
            this.button7.TabIndex = 6;
            this.button7.Text = "Ayarlar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(23, 347);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 39);
            this.button8.TabIndex = 7;
            this.button8.Text = "Çıkış Yap";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(280, 563);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 474);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 701);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1053, 131);
            this.dataGridView1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.Controls.Add(this.chart2);
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(206, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1056, 459);
            this.panel4.TabIndex = 15;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(33, 188);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(394, 247);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(583, 188);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(423, 247);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            // 
            // FrmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1258, 689);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmExpense";
            this.Text = "Gider Formu";
            this.Load += new System.EventHandler(this.FrmExpense_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnExpenseList;
        private System.Windows.Forms.Label txtBillingPeriod;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Label txtBillingAmount;
        private System.Windows.Forms.TextBox txtExpenseTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpenseId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbExpenseCategory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}