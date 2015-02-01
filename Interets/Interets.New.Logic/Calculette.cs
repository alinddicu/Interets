namespace Interets.New.Logic
{
    using System;

    public class Calculette
    {
        private readonly double _interetsMoyensNetsAnnuels;
        private readonly double _primeMensuelle;
        private readonly double _fraisGlobaux;
        private readonly double _anneesContrat;

        public Calculette(double interetsMoyensNetsAnnuels, double primeMensuelle, int anneesContrat, double fraisGlobaux)
        {
            _interetsMoyensNetsAnnuels = interetsMoyensNetsAnnuels;
            _primeMensuelle = primeMensuelle;
            _anneesContrat = anneesContrat;
            _fraisGlobaux = fraisGlobaux;
        }

        public ResultatCalcul Calculer()
        {
            var gainBrut = GetGainBrut();
            var gainNet = gainBrut - _fraisGlobaux;
            var rendemmentGlobal = GetRendemmentGlobal(gainNet);

            return new ResultatCalcul(gainBrut, gainNet, rendemmentGlobal);
        }

        private double GetRendemmentGlobal(double gainNet)
        {
            var cotisation = _primeMensuelle*_anneesContrat*12;
            return gainNet / cotisation;
        }

        private double GetGainBrut()
        {
            // Vn = p*(1+i/12)puissance(N*12)-1)/i
            // p = primeMensuelle
            // N = nombre d'années
            // i = intérêts mensuels
            var i = _interetsMoyensNetsAnnuels / 100 / 12;
            return _primeMensuelle * (Math.Pow((1 + i), _anneesContrat * 12) - 1) / i;
        }
    }
}
