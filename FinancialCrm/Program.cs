using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmBanks(new FinancialCrmDbEntities()));
            //Application.Run(new FrmBilling(new FinancialCrmDbEntities()));
            //Application.Run(new FrmDashboard(new FinancialCrmDbEntities()));
            //Application.Run(new FrmLogin( new FinancialCrmDbEntities()));
            //Application.Run(new FrmExpense(new FinancialCrmDbEntities()));
            Application.Run(new FrmBankDetails(new FinancialCrmDbEntities()));


        }
    }
}

