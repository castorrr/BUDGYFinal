using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace ViewModelsSamples.Bars.Spacing
{
    public partial class ViewModel : ObservableObject
    {
        public ISeries[] Series { get; set; }
        public Axis[] XAxes { get; set; }
        public Axis[] YAxes { get; set; }

        public ViewModel()
        {
            // Initialize the Series array with series for each mont
            InitializeSeries();
        }

        private void InitializeSeries()
        {
            Series = new ISeries[12];

            for (int i = 0; i < 12; i++)
            {
                Series[i] = CreateColumnSeries(Convert.ToDouble(GlobalVariables.MonthlyBudgets[i]), GetMonthName(i + 1));
            }
        }

        private ColumnSeries<double> CreateColumnSeries(double value, string monthName)
        {
            return new ColumnSeries<double>
            {
                Values = new ObservableCollection<double> { value },
                Padding = 0,
                Name = monthName,
                MaxBarWidth = 500,
                DataLabelsPaint = new SolidColorPaint (SKColors.White)
            };
        }

        // Helper method to get the name of the month based on its index
        private string GetMonthName(int month)
        {
            return new DateTime(2022, month, 1).ToString("MMMM");
        }

       

    }
}
