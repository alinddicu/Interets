namespace Interets.New.Logic
{
    public class Calculette
    {
        private readonly FormuleGainBrut _formuleGainBrut;
        private readonly DonneesSaisies _donneesSaisies;

        public Calculette(FormuleGainBrut formuleGainBrut, DonneesSaisies donneesSaisies)
        {
            _formuleGainBrut = formuleGainBrut;
            _donneesSaisies = donneesSaisies;
        }

        public ResultatCalcul Calculer()
        {
            var gainBrut = GetGainBrut();
            var gainNet = gainBrut - _donneesSaisies.FraisGlobaux;
            var rendemmentGlobal = GetRendemmentGlobal(gainNet);

            return new ResultatCalcul(gainBrut, gainNet, rendemmentGlobal, 0);
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
