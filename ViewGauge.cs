using System.Collections.Generic;
using LiveChartsCore;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore.SkiaSharpView.Extensions;

namespace ViewModelsSamples.Pies.Gauge1
{
    public partial class ViewGauge : ObservableObject
    {
        public int Percentage { get; set; } = 0;
        public IEnumerable<ISeries> Series { get; set; }

        public ViewGauge()
        {
            // Initialize the Series property dynamically inside the constructor
            Series = GaugeGenerator.BuildSolidGauge(
                new GaugeItem(
                    Percentage,
                    series =>
                    {
                        series.MaxRadialColumnWidth = 50;
                        series.DataLabelsSize = 50;
                    }));
        }
    }
}
