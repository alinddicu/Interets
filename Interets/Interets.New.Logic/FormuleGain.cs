namespace Interets.New.logic
{
    using System;

    public class FormuleGain
    {
        public double Calculer(double interetsMoyensNetsAnnuels, double primeMensuelle, double anneesContrat)
        {
            // Vn = p*(1+i/12)puissance(N*12)-1)/i

            // p = primeMensuelle
            // N = nombre d'années
            // i = intérêts mensuels

            var i = interetsMoyensNetsAnnuels / 100 / 12;
            return primeMensuelle * (Math.Pow((1 + i), anneesContrat * 12) - 1) / i;
        }
    }
}
