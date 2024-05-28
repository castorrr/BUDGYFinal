using LiveChartsCore.Defaults;
using LiveChartsCore;
using System.Collections.ObjectModel;
using LiveChartsCore.SkiaSharpView;

namespace BUDGY_2._0
{
    public partial class Analytics : UserControl
    {
        public ISeries[] Series { get; set; }

        public Analytics()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlCharts.Controls.Clear();
            GlobalVariables.Flag = 1;
            BudgetAnalytics b = new BudgetAnalytics();
            pnlCharts.Controls.Add(b);
            b.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlCharts.Controls.Clear();
            GlobalVariables.Flag = 2;
            ExpensesAnalytics b = new ExpensesAnalytics();
            pnlCharts.Controls.Add(b);
            b.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalVariables.Flag = 3;
            SavingsAnalytics b = new SavingsAnalytics();
            pnlCharts.Controls.Add(b);
            b.BringToFront();
        }
    }
}
