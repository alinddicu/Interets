namespace Interets.New.Logic
{
    using System.Collections.Generic;

    public class SuitePointsGainNetGenerator
    {
        private readonly FormuleGainBrut _formuleGainBrut;
        private readonly DonneesSaisies _donneesSaisies;

        public SuitePointsGainNetGenerator(FormuleGainBrut formuleGainBrut, DonneesSaisies donneesSaisies)
        {
            _formuleGainBrut = formuleGainBrut;
            _donneesSaisies = donneesSaisies;
        }

        public IEnumerable<PointDonnees> Generate()
        {
            for (var x = 1; x <= _donneesSaisies.AnneesContrat; x++)
            {
                var gain = _formuleGainBrut.Calculer(_donneesSaisies.InteretsMoyensNetsAnnuels, _donneesSaisies.PrimeMensuelle, x);
                yield return new PointDonnees(x, gain);
            }
        }
    }
}
