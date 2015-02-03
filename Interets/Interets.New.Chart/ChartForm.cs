namespace Interets.New.Chart
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using logic;
    using Logic;

    public partial class ChartForm : Form
    {
        private readonly Graphics _graphics;
        private readonly ChartParameters _chartParameters;

        public ChartForm()
        {
            InitializeComponent();

            _graphics = _chart.CreateGraphics();
            _chartParameters = new ChartParameters(_chart.Width, _chart.Height);
        }

        private void FillChart()
        {
            var donneesSaisies = new DonneesSaisies(3, 100, 16, 0);
            var gainNetData = new SuitePointsGainNetGenerator(new FormuleGain(), donneesSaisies).Generate().ToArray();
            var cotisationData = new SuitePointsCotisation(donneesSaisies).Generate().ToArray();
            var maxYCalc = new MaxYofPointsDonneesCalculator(gainNetData, cotisationData);
            var graphiquesGenerator = new SuitePointsGraphiquesConvertor(_chartParameters, maxYCalc);

            var gainPoints = graphiquesGenerator.Convert(gainNetData);
            var cotisationPoints = graphiquesGenerator.Convert(cotisationData);

            PrintPoints(gainPoints, new Pen(Color.Green));
            PrintPoints(cotisationPoints, new Pen(Color.Blue));
        }

        private void PrintPoints(IEnumerable<Point> gainPoints, Pen pen)
        {
            var lastPoint = new Point(0, 0);
            foreach (var point in gainPoints)
            {
                _graphics.DrawLine(pen, lastPoint.X, lastPoint.Y, point.X, point.Y);
                lastPoint = point;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FillChart();
        }
    }
}
