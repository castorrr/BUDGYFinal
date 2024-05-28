using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.WinForms;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using ViewModelsSamples.Bars.Spacing;
using System.Data.OleDb;


namespace BUDGY_2._0
{
    public partial class View : UserControl
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\cprogs\\OOP2\\BUDGY 2.0\\bin\\Debug\\BUDGY DATABASE.accdb";
        public View()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(50, 50);
            GetTotalBudget();
            var viewModel = new ViewModel();

            var cartesianChart = new CartesianChart
            {
                Series = viewModel.Series,

                // out of livecharts properties...
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(50, 50),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            Controls.Add(cartesianChart);
        }

        private void View_Load(object sender, EventArgs e)
        {
            
        }

        private void GetTotalBudget()
        {
            string query;
            for (int month = 1; month <= 12; month++)
            {
                if (GlobalVariables.Flag == 1)
                    query = $"SELECT SUM(Budget) FROM BudgetHistory WHERE Month(Date) = {month}";
                else if(GlobalVariables.Flag == 2)
                    query = $"SELECT SUM(Savings) FROM SavingsHistory WHERE Month(Date) = {month}";
                else
                    query = $"SELECT SUM(ExpensesPrice) FROM ExpensesHistory WHERE Month(Date) = {month}";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            GlobalVariables.MonthlyBudgets[month - 1] = Convert.ToDecimal(result);
                        }
                        else
                        {
                            GlobalVariables.MonthlyBudgets[month - 1] = 0;
                        }

                        connection.Close();
                    }
                }
            }
        }
    }
}
