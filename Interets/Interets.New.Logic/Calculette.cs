namespace Interets.New.Logic
{
    using logic;

    public class Calculette
    {
        private readonly double _interetsMoyensNetsAnnuels;
        private readonly double _primeMensuelle;
        private readonly double _fraisGlobaux;
        private readonly double _anneesContrat;

        private readonly FormuleGain _formuleGain;

        public Calculette(FormuleGain formuleGain, double interetsMoyensNetsAnnuels, double primeMensuelle, int anneesContrat, double fraisGlobaux)
        {
            _formuleGain = formuleGain;
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
            var cotisation = _primeMensuelle * _anneesContrat * 12;
            return gainNet / cotisation;
        }

        private double GetGainBrut()
        {
            return _formuleGain.Calculer(_interetsMoyensNetsAnnuels, _primeMensuelle, _anneesContrat);
        }
    }
}
