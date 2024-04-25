using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using ViewModelsSamples.Pies.Gauge1;

namespace BUDGY_2._0
{
    public partial class Gauge : UserControl
    {
        private readonly PieChart pieChart;

        public Gauge()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(50, 50);

            var viewModel = new ViewGauge();

            pieChart = new PieChart
            {
                Series = viewModel.Series,
                InitialRotation = -90,
                MinValue = 0,
                MaxValue = 100,

                // out of livecharts properties...
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(50, 50),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            Controls.Add(pieChart);
        }

        private void Gauge_Load(object sender, EventArgs e)
        {

        }
    }
}
