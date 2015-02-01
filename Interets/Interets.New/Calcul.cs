namespace Interets.New
{

    using System;

    public static class Calcul
    {
        // http://www.ecogesam.ac-aix-marseille.fr/Resped/Gestion/mathfi/mathfin1.html

        // Vn = a(1+i/12)puissance(N*12)-1)/i
        // a = annuité
        public static double CalculerCumulSurPeriode(
            double annuite,
            double tauxAnnuel,
            int periodeDeCalcul)
        {
            var i = tauxAnnuel / 100 / 12;
            return annuite * (Math.Pow((1 + i), periodeDeCalcul * 12) - 1) / i;
        }

        public static double CalculerGain(double cumulSurPeriode, double fraisDebut)
        {
            return cumulSurPeriode - fraisDebut;
        }

        public static double CotisationRecalc(double cumulSurPeriode, double periodeDeCalcul)
        {
            return cumulSurPeriode / (12 * periodeDeCalcul);
        }

        public static double RendementFinal(
            double fraisDebut,
            double cotisationMensuelle,
            double cumulSurPeriode,
            int periodeDeCalcul)
        {
            return ((cumulSurPeriode - fraisDebut) / (12 * periodeDeCalcul * cotisationMensuelle)) * 100;
        }

        public static double RendementAnnuelFinal(
            double fraisDebut,
            double cotisationMensuelle,
            double cumulSurPeriode,
            int periodeDeCalcul)
        {
            return ((cumulSurPeriode - fraisDebut) / (periodeDeCalcul * cotisationMensuelle)) * 100 / 12;
        }
    }
}
