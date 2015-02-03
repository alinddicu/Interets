namespace Interets.New.Logic
{
    using Logic;

    public class Calculette
    {
        private readonly FormuleGain _formuleGain;
        private readonly DonneesSaisies _donneesSaisies;

        public Calculette(FormuleGain formuleGain, DonneesSaisies donneesSaisies)
        {
            _formuleGain = formuleGain;
            _donneesSaisies = donneesSaisies;
        }

        public ResultatCalcul Calculer()
        {
            var gainBrut = GetGainBrut();
            var gainNet = gainBrut - _donneesSaisies.FraisGlobaux;
            var rendemmentGlobal = GetRendemmentGlobal(gainNet);

            return new ResultatCalcul(gainBrut, gainNet, rendemmentGlobal);
        }

        private double GetRendemmentGlobal(double gainNet)
        {
            var cotisation = _donneesSaisies.PrimeMensuelle * _donneesSaisies.AnneesContrat * 12;
            return gainNet / cotisation;
        }

        private double GetGainBrut()
        {
            return _formuleGain.Calculer(
                _donneesSaisies.InteretsMoyensNetsAnnuels, 
                _donneesSaisies.PrimeMensuelle, 
                _donneesSaisies.AnneesContrat);
        }
    }
}
