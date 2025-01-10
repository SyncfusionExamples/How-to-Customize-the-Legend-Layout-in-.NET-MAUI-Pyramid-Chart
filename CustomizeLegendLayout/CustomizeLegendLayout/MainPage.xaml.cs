using CommunityToolkit.Maui.Layouts;
using Microsoft.Maui.Layouts;
using Syncfusion.Maui.Charts;
using Syncfusion.Maui.Core;
using System.Globalization;

namespace CustomizeLegendLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.7;
        }
    }
}
