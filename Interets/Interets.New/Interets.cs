namespace Interets.New
{
    using System.Globalization;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Interets : Form
    {
        private Graphics g;
        private readonly Pen _styloX = new Pen(Color.Green, 2F);
        private readonly Pen _styloY = new Pen(Color.Red, 2F);
        private readonly Pen _styloFrais = new Pen(Color.White, 2F);

        private double _fraisDebut;
        private double _cotisationMensuelle;
        private double _tauxAnnuel;
        private int _periodeDeCalcul;
        private double _cumulSurPeriode;


        private const int DecalageTraitGrad = 2;
        private int _maxX;
        private int _maxY;
        private const int MargeX = 10;
        private const int MargeY = 11;

        public Interets()
        {
            StyloBleu = new Pen(Color.Blue, 2F);
            StyloNoir = new Pen(Color.Black, 2F);
            InitializeComponent();
            InitVariables();
            Calculer();
            // Dessiner
            InitAxeEvolTemps();
            GraduerX();
        }

        private Pen StyloBleu { set;  get; }

        private Pen StyloNoir { set;  get; }

        private void InitVariables()
        {
            _maxX = pictureBoxEvolTemps.Width;
            _maxY = pictureBoxEvolTemps.Height;
            g = pictureBoxEvolTemps.CreateGraphics();
        }

        private void Interets_Load(object sender, EventArgs e)
        {
            CentrerForm(this);
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            Calculer();
            Dessiner();
        }

        private void Dessiner()
        {
            pictureBoxEvolTemps.Refresh();
            InitAxeEvolTemps();
            GraduerX();
            GraduerY();
            Legende();
            TracerFrais();
        }

        private void Calculer()
        {
            _fraisDebut = Convert.ToDouble(textBoxFraisInit.Text);
            _cotisationMensuelle = Convert.ToDouble(textBoxCotisation.Text);
            _tauxAnnuel = Convert.ToDouble(textBoxTauxAnnuel.Text);
            _periodeDeCalcul = Convert.ToInt32(textBoxPeriodeCalcul.Text);
            _cumulSurPeriode = Calcul.CalculerCumulSurPeriode(_cotisationMensuelle, _tauxAnnuel, _periodeDeCalcul);

            textBoxCumulSurPeriode.Text = _cumulSurPeriode.ToString("#.##");
            textBoxGain.Text = Calcul.CalculerGain(_cumulSurPeriode, _fraisDebut).ToString("#.##");
            textBoxCotisationRecalc.Text = Calcul.CotisationRecalc(_cumulSurPeriode, _periodeDeCalcul).ToString("#.##");
            textBoxRendementGlobal.Text = Calcul.RendementFinal(_fraisDebut, _cotisationMensuelle, _cumulSurPeriode, _periodeDeCalcul).ToString("#.##");
            textBoxRendAnnuelGlob.Text = Calcul.RendementAnnuelFinal(_fraisDebut, _cotisationMensuelle, _cumulSurPeriode, _periodeDeCalcul).ToString("#.##");
        }

        private void InitAxeEvolTemps()
        {
            var ys = new Point[2];
            ys[0].X = MargeX;
            ys[0].Y = 0;
            ys[1].X = MargeX;
            ys[1].Y = _maxY;
            TranslaterTabPoints(ref ys);
            g.DrawLine(_styloX, ys[0], ys[1]);

            var xs = new Point[2];
            xs[0].X = 0;
            xs[0].Y = MargeY;
            xs[1].X = _maxX;
            xs[1].Y = MargeY;
            TranslaterTabPoints(ref xs);
            g.DrawLine(_styloY, xs[0], xs[1]);
        }

        private void TranslaterPoint(ref Point p)
        {
            p.Y = _maxY - p.Y;
        }

        private void TranslaterTabPoints(ref Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                TranslaterPoint(ref points[i]);
            }
        }

        private void GraduerX()
        {
            var nombrePoints = _periodeDeCalcul + 1;
            var points1 = new Point[nombrePoints];
            var points2 = new Point[nombrePoints];

            for (var i = 0; i < nombrePoints; i++)
            {
                points1[i] = new Point(MargeX + (_maxX - MargeX) * i / nombrePoints, MargeY - DecalageTraitGrad);
                points2[i] = new Point(MargeX + (_maxX - MargeX) * i / nombrePoints, MargeY + DecalageTraitGrad);
            }

            TranslaterTabPoints(ref points1);
            TranslaterTabPoints(ref points2);
            for (var i = 0; i < nombrePoints; i++)
            {
                g.DrawLine(_styloY, points1[i], points2[i]);
                if (i > 0)
                {
                    g.DrawString(i.ToString(CultureInfo.InvariantCulture), new Font(DEFAULT_FONT, 8), new SolidBrush(Color.Red), points2[i].X - 5, points2[i].Y + 2);
                }
            }
        }

        private static int DenominateurAxeX()
        {
            return 10000;
        }

        private void GraduerY()
        {
            var nombrePoints = (int)Math.Ceiling(_cumulSurPeriode / DenominateurAxeX());
            nombrePoints++;
            var points1 = new Point[nombrePoints];
            var points2 = new Point[nombrePoints];

            for (var i = 0; i < nombrePoints; i++)
            {
                points1[i] = new Point(MargeX - DecalageTraitGrad, MargeY + (_maxY - MargeY) * i / nombrePoints);
                points2[i] = new Point(MargeX + DecalageTraitGrad, MargeY + (_maxY - MargeY) * i / nombrePoints);
            }

            TranslaterTabPoints(ref points1);
            TranslaterTabPoints(ref points2);
            for (int i = 0; i < nombrePoints; i++)
            {
                g.DrawLine(_styloX, points1[i], points2[i]);
                if (i > 0)
                {
                    g.DrawString(i.ToString(CultureInfo.InvariantCulture), new Font(DEFAULT_FONT, 8), new SolidBrush(Color.Green), points2[i].X - 13, points2[i].Y - 5);
                }
            }
        }

        private void Legende()
        {
            g.DrawString("ans", new Font(DEFAULT_FONT, 10), new SolidBrush(Color.Red), _maxX - 3 * MargeX, _maxY - 3 * MargeY);
            g.DrawString("€", new Font(DEFAULT_FONT, 10), new SolidBrush(Color.Green), 2 * MargeX, MargeY);
        }

        private void TracerFrais()
        {
            var traceFrais = new Point[2];
            traceFrais[0].X = MargeX;
            traceFrais[0].Y = (int)((_fraisDebut / _cumulSurPeriode) * (_maxY - MargeY));
            traceFrais[1].X = _maxX - MargeX;
            traceFrais[1].Y = traceFrais[0].Y;
            TranslaterTabPoints(ref traceFrais);
            g.DrawLine(_styloFrais, traceFrais[0], traceFrais[1]);
        }

        private static void CentrerForm(Form form)
        {
            form.Location = new Point(
            Screen.PrimaryScreen.Bounds.Width / 2 - form.Width / 2,
            Screen.PrimaryScreen.Bounds.Height / 2 - form.Height / 2);
        }
    }
}