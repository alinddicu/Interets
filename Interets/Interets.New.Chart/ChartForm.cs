namespace Interets.New.Chart
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Logic;

    public partial class ChartForm : Form
    {
        private readonly Graphics _graphics;
        private readonly ChartParameters _chartParameters;
        private DonneesSaisies _donneesSaisies;

        public ChartForm()
        {
            InitializeComponent();

            _graphics = _chart.CreateGraphics();
            _chartParameters = new ChartParameters(_chart.Width, _chart.Height);
        }

        private void TracerChart()
        {
            var gainNetData = new SuitePointsGainNetGenerator(new FormuleGain(), _donneesSaisies).Generate().ToArray();
            var cotisationData = new SuitePointsCotisationGenerator(_donneesSaisies).Generate().ToArray();
            var maxYCalc = new MaxYofPointsDonneesCalculator(gainNetData, cotisationData);
            var graphiquesGenerator = new SuitePointsGraphiquesConvertor(_chartParameters, maxYCalc);

            var gainPoints = graphiquesGenerator.Convert(gainNetData);
            var cotisationPoints = graphiquesGenerator.Convert(cotisationData);

            _graphics.Clear(_chart.BackColor);
            PrintPoints(gainPoints.ToArray(), new Pen(Color.Green));
            PrintPoints(cotisationPoints.ToArray(), new Pen(Color.Blue));
        }

        private void PrintPoints(IList<Point> gainPoints, Pen pen)
        {
            var lastPoint = gainPoints[0];
            for (var i = 1; i < gainPoints.Count(); i++)
            {
                var point = gainPoints[i];
                _graphics.DrawLine(pen, lastPoint.X, lastPoint.Y, point.X, point.Y);
                lastPoint = point;
            }
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            ConvertirSaisie();
            Remplir();
            TracerChart();
        }

        private void ConvertirSaisie()
        {
            _donneesSaisies = new DonneesSaisiesConvertor(textBoxTaux.Text, textBoxPrimeMensuelle.Text, textBoxDuree.Text, textBoxFraisGlobaux.Text).Convert();
        }

        private void Remplir()
        {
            var calculette = new Calculette(new FormuleGain(), _donneesSaisies);
            var resultatCalcul = calculette.Calculer();

            textBoxGainNet.Text = resultatCalcul.GainNet.ToString("#.##");
            //textBoxCotisation.Text = resultatCalcul..ToString("#.##");
        }
    }
}
