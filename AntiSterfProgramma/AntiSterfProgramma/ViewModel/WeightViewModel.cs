using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiSterfProgramma.ViewModel
{
    public partial class WeightViewModel
    {
        public ISeries[] Weight { get; set; }
        = new ISeries[]
        {
            new LineSeries<double>
            {
                Name = "Weight",
                
                Values = new double[] { 79.4, 78.8, 78.5, 78.2, 77.8, 77.2, 77.4, 78,8, 76.5, 50},
                GeometrySize = 24,
                Fill = LiveChartsSkiaSharp.DefaultPaint,
                TooltipLabelFormatter = (infoPoint) => $"{infoPoint.Context.Series.Name}: {infoPoint.PrimaryValue}Kg"
            }
        };

        public Axis[] XAxes { get; set; } =
        {
            new Axis
            {
                Name = "Days of the week",
                NameTextSize = 36,
                MinLimit = 0,
                MaxLimit = 7,
                ForceStepToMin = true,
                MinStep = 1,
                TextSize = 36,
                SeparatorsPaint = new SolidColorPaint
                {
                    Color = SKColors.Gray,
                    StrokeThickness = 3
                }
            }
        };

        public Axis[] YAxes { get; set; } =
        {
            new Axis
            {
                Name = "Weight in Kg",
                NameTextSize = 28,
                MinLimit = 74,
                MaxLimit = 84,
                ForceStepToMin = true,
                MinStep = 1,
                TextSize = 28,
                SeparatorsPaint = new SolidColorPaint
                {
                    Color = SKColors.Gray,
                    StrokeThickness = 3,
                    PathEffect = new DashEffect(new float[] { 3, 3 })
                }
            }
        };
    }
}
