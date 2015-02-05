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
            _chartParameters = new ChartParameters(_chart.Width, _chart.Height, 15, 15);
        }

        private void TracerChart()
        {
            var gainNetData = new SuitePointsGainNetGenerator(new FormuleGainBrut(), _donneesSaisies).Generate().ToArray();
            var formuleCotisation = new FormuleCotisation(_donneesSaisies);
            var cotisationData = new SuitePointsCotisationGenerator(formuleCotisation, _donneesSaisies).Generate().ToArray();
            var maxYCalc = new MaxYofPointsDonneesCalculator(gainNetData, cotisationData);
            var pointsForChartConvertor = new SuitePointsForChartConvertor(_chartParameters, maxYCalc);

            var traceur = new Traceur(_graphics, pointsForChartConvertor, new Pen(Color.Green), new Pen(Color.Blue));
            traceur.Trace(gainNetData, cotisationData);
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
            var calculette = new Calculette(new FormuleGainBrut(), new FormuleCotisation(_donneesSaisies), _donneesSaisies);
            var resultatCalcul = calculette.Calculer();

            textBoxGainNet.Text = resultatCalcul.GainNet.ToString("#.##");
            textBoxGainBrut.Text = resultatCalcul.GainBrut.ToString("#.##");
            textBoxCotisation.Text = resultatCalcul.Cotisation.ToString("#.##");
        }

        private static void CentrerForm(Form form)
        {
            form.Location = new Point(
            Screen.PrimaryScreen.Bounds.Width / 2 - form.Width / 2,
            Screen.PrimaryScreen.Bounds.Height / 2 - form.Height / 2);
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            CentrerForm(this);
        }
    }
}
