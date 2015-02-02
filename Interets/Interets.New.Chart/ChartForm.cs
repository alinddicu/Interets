namespace Interets.New.Chart
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using logic;

    public partial class ChartForm : Form
    {
        private readonly Graphics _graphics;

        public ChartForm()
        {
            InitializeComponent();

            _graphics = pictureBox1.CreateGraphics();
        }

        private void FillChart()
        {
            var gainNetData = new SuitePointsGainNetGenerator().Generate(3, 100, 16).ToArray();
            var cotisationData = new SuitePointsCotisation().Generate(100, 16).ToArray();
            var maxY = new[] { gainNetData.Max(d => d.Y), cotisationData.Max(d => d.Y) }.Max(d => d);
            var graphiquesGenerator = new SuitePointsGraphiquesConvertor(pictureBox1.Width, pictureBox1.Height, maxY);

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
