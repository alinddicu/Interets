using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interets
{
    public partial class Interets : Form
    {
        private const string DEFAULT_FONT = "Verdana";
        private System.Drawing.Graphics g;
        private System.Drawing.Pen styloBleu = new System.Drawing.Pen(Color.Blue, 2F);
        private System.Drawing.Pen styloNoir = new System.Drawing.Pen(Color.Black, 2F);
        private System.Drawing.Pen styloX = new System.Drawing.Pen(Color.Green, 2F);
        private System.Drawing.Pen styloY = new System.Drawing.Pen(Color.Red, 2F);
        private System.Drawing.Pen styloFrais = new System.Drawing.Pen(Color.White, 2F);

        private double fraisDebut;
        private double cotisationMensuelle;
        private double tauxAnnuel;
        private int periodeDeCalcul;
        private double cumulSurPeriode;


        private int decalageTraitGrad = 2;
        private int maxX = 0;
        private int maxY = 0;
        private int margeX = 10;
        private int margeY = 11;

        public Interets()
        {
            InitializeComponent();
            InitVariables();
            Calculer();
            // Dessiner
            InitAxeEvolTemps();
            GraduerX();
        }

        private void InitVariables()
        {
            maxX = this.pictureBoxEvolTemps.Width;
            maxY = this.pictureBoxEvolTemps.Height;
            this.g = pictureBoxEvolTemps.CreateGraphics();
        }

        private void Interets_Load(object sender, EventArgs e)
        {
            Utils.CentrerForm(this);
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
            this.fraisDebut = Convert.ToDouble(this.textBoxFraisInit.Text);
            this.cotisationMensuelle = Convert.ToDouble(this.textBoxCotisation.Text);
            this.tauxAnnuel = Convert.ToDouble(this.textBoxTauxAnnuel.Text);
            this.periodeDeCalcul = Convert.ToInt32(this.textBoxPeriodeCalcul.Text);
            this.cumulSurPeriode = Calcul.CalculerCumulSurPeriode(cotisationMensuelle, tauxAnnuel, periodeDeCalcul);

            this.textBoxCumulSurPeriode.Text = cumulSurPeriode.ToString("#.##");
            this.textBoxGain.Text = Calcul.CalculerGain(cumulSurPeriode, fraisDebut).ToString("#.##");
            this.textBoxCotisationRecalc.Text = Calcul.CotisationRecalc(cotisationMensuelle, cumulSurPeriode, periodeDeCalcul).ToString("#.##");
            this.textBoxRendementGlobal.Text = Calcul.RendementFinal(fraisDebut, cotisationMensuelle, cumulSurPeriode, periodeDeCalcul).ToString("#.##");
            this.textBoxRendAnnuelGlob.Text = Calcul.RendementAnnuelFinal(fraisDebut, cotisationMensuelle, cumulSurPeriode, periodeDeCalcul).ToString("#.##");
        }

        private void InitAxeEvolTemps()
        {
            System.Drawing.Point[] ys = new System.Drawing.Point[2];
            ys[0].X = margeX;
            ys[0].Y = 0;
            ys[1].X = margeX;
            ys[1].Y = maxY;
            TranslaterTabPoints(ref ys);
            this.g.DrawLine(styloX, ys[0], ys[1]);

            System.Drawing.Point[] xs = new System.Drawing.Point[2];
            xs[0].X = 0;
            xs[0].Y = margeY;
            xs[1].X = maxX;
            xs[1].Y = margeY;
            TranslaterTabPoints(ref xs);
            this.g.DrawLine(styloY, xs[0], xs[1]);
        }

        private void TranslaterPoint(ref System.Drawing.Point p)
        {
            p.Y = this.maxY - p.Y;
        }

        private void TranslaterTabPoints(ref System.Drawing.Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                TranslaterPoint(ref points[i]);
            }
        }

        private void GraduerX()
        {
            int nombrePoints = this.periodeDeCalcul + 1;
            System.Drawing.Point[] points1 = new System.Drawing.Point[nombrePoints];
            System.Drawing.Point[] points2 = new System.Drawing.Point[nombrePoints];

            for (int i = 0; i < nombrePoints; i++)
            {
                points1[i] = new Point(margeX + (maxX - margeX) * i / nombrePoints, margeY - decalageTraitGrad);
                points2[i] = new Point(margeX + (maxX - margeX) * i / nombrePoints, margeY + decalageTraitGrad);
            }

            TranslaterTabPoints(ref points1);
            TranslaterTabPoints(ref points2);
            for (int i = 0; i < nombrePoints; i++)
            {
                this.g.DrawLine(styloY, points1[i], points2[i]);
                if (i > 0)
                {
                    this.g.DrawString(i.ToString(), new Font(DEFAULT_FONT, 8), new System.Drawing.SolidBrush(System.Drawing.Color.Red), points2[i].X - 5, points2[i].Y + 2);
                }
            }
        }

        private int DenominateurAxeX()
        {
            return 10000;
        }

        private void GraduerY()
        {
            int nombrePoints = (int)Math.Ceiling(this.cumulSurPeriode / (double)DenominateurAxeX());
            nombrePoints++;
            System.Drawing.Point[] points1 = new System.Drawing.Point[nombrePoints];
            System.Drawing.Point[] points2 = new System.Drawing.Point[nombrePoints];

            for (int i = 0; i < nombrePoints; i++)
            {
                points1[i] = new Point(margeX - decalageTraitGrad, margeY + (maxY - margeY) * i / nombrePoints);
                points2[i] = new Point(margeX + decalageTraitGrad, margeY + (maxY - margeY) * i / nombrePoints);
            }

            TranslaterTabPoints(ref points1);
            TranslaterTabPoints(ref points2);
            for (int i = 0; i < nombrePoints; i++)
            {
                this.g.DrawLine(styloX, points1[i], points2[i]);
                if (i > 0)
                {
                    this.g.DrawString(i.ToString(), new Font(DEFAULT_FONT, 8), new System.Drawing.SolidBrush(System.Drawing.Color.Green), points2[i].X - 13, points2[i].Y - 5);
                }
            }
        }

        private void Legende()
        {
            this.g.DrawString("ans", new Font(DEFAULT_FONT, 10), new System.Drawing.SolidBrush(System.Drawing.Color.Red), maxX - 3 * margeX, maxY - 3 * margeY);
            this.g.DrawString("€", new Font(DEFAULT_FONT, 10), new System.Drawing.SolidBrush(System.Drawing.Color.Green), 2 * margeX, margeY);
        }

        private void TracerFrais()
        {
            System.Drawing.Point[] traceFrais = new System.Drawing.Point[2];
            traceFrais[0].X = margeX;
            traceFrais[0].Y = (int)((fraisDebut / cumulSurPeriode) * (maxY - margeY));
            traceFrais[1].X = maxX - margeX;
            traceFrais[1].Y = traceFrais[0].Y;
            TranslaterTabPoints(ref traceFrais);
            this.g.DrawLine(styloFrais, traceFrais[0], traceFrais[1]);
        }
    }
}