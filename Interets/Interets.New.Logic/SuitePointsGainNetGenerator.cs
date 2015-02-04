namespace Interets.New.Logic
{
    using System.Collections.Generic;

    public class SuitePointsGainNetGenerator
    {
        private readonly FormuleGain _formuleGain;
        private readonly DonneesSaisies _donneesSaisies;

        public SuitePointsGainNetGenerator(FormuleGain formuleGain, DonneesSaisies donneesSaisies)
        {
            _formuleGain = formuleGain;
            _donneesSaisies = donneesSaisies;
        }

        public IEnumerable<PointDonnees> Generate()
        {
            for (var x = 1; x <= _donneesSaisies.AnneesContrat; x++)
            {
                var gain = _formuleGain.Calculer(_donneesSaisies.InteretsMoyensNetsAnnuels, _donneesSaisies.PrimeMensuelle, x);
                yield return new PointDonnees(x, gain);
            }
        }
    }
}
