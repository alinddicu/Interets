using System;
using System.Collections.Generic;
using System.Text;

namespace Interets.New
{
    public class Calcul
    {
        // http://www.ecogesam.ac-aix-marseille.fr/Resped/Gestion/mathfi/mathfin1.html

        // Vn = a(1+i/12)puissance(N*12)-1)/i
        public static double CalculerCumulSurPeriode
            (
            double cotisationMensuelle,
            double tauxAnnuel,
            int periodeDeCalcul
            )
        {
            double i = tauxAnnuel / 100 / 12;
            return cotisationMensuelle * (Math.Pow((1 + i), periodeDeCalcul * 12) - 1) / i;
        }

        public static double CalculerGain
            (
            double cumulSurPeriode,
            double fraisDebut
            )
        {
            return cumulSurPeriode - fraisDebut;
        }

        public static double CotisationRecalc(double cumulSurPeriode, int periodeDeCalcul)
        {
            return cumulSurPeriode / (12 * periodeDeCalcul);
        }

        public static double RendementFinal
            (
            double fraisDebut,
            double cotisationMensuelle,
            double cumulSurPeriode,
            int periodeDeCalcul
            )
        {
            return ((cumulSurPeriode - fraisDebut) / (12 * periodeDeCalcul * cotisationMensuelle)) * 100;
        }

        public static double RendementAnnuelFinal
            (
            double fraisDebut,
            double cotisationMensuelle,
            double cumulSurPeriode,
            int periodeDeCalcul
            )
        {
            return ((cumulSurPeriode - fraisDebut) / (periodeDeCalcul * cotisationMensuelle)) * 100 / 12;
        }

        public static double DureeAmmortisementFrais
            (
            double fraisDebut,
            double cotisationMensuelle,
            double tauxAnnuel
            )
        {
            double i = tauxAnnuel / 100 / 12;
            return Math.Log((i + fraisDebut) / cotisationMensuelle + 1) / Math.Log(1 + i);
        }
    }
}
