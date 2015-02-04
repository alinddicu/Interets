namespace Interets.New.Logic
{
    public class Calculette
    {
        private readonly FormuleGainBrut _formuleGainBrut;
        private readonly FormuleCotisation _formuleCotisation;
        private readonly DonneesSaisies _donneesSaisies;

        public Calculette(
            FormuleGainBrut formuleGainBrut,
            FormuleCotisation formuleCotisation,
            DonneesSaisies donneesSaisies)
        {
            _formuleGainBrut = formuleGainBrut;
            _formuleCotisation = formuleCotisation;
            _donneesSaisies = donneesSaisies;
        }

        public ResultatCalcul Calculer()
        {
            var gainBrut = GetGainBrut();
            var gainNet = gainBrut - _donneesSaisies.FraisGlobaux;
            var rendemmentGlobal = GetRendemmentGlobal(gainNet);
            var cotisation = _formuleCotisation.Calculer(_donneesSaisies.AnneesContrat * 12);

            return new ResultatCalcul(gainBrut, gainNet, rendemmentGlobal, cotisation);
        }

        private double GetRendemmentGlobal(double gainNet)
        {
            var cotisation = _donneesSaisies.PrimeMensuelle * _donneesSaisies.AnneesContrat * 12;
            return gainNet / cotisation;
        }

        private double GetGainBrut()
        {
            return _formuleGainBrut.Calculer(
                _donneesSaisies.InteretsMoyensNetsAnnuels,
                _donneesSaisies.PrimeMensuelle,
                _donneesSaisies.AnneesContrat);
        }
    }
}
