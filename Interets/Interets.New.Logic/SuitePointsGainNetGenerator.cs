namespace Interets.New.logic
{
    using System.Collections.Generic;
    using Logic;

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
            for (var x = 0; x <= _donneesSaisies.AnneesContrat; x++)
            {
                var gain = _formuleGain.Calculer(_donneesSaisies.InteretsMoyensNetsAnnuels, _donneesSaisies.PrimeMensuelle, x);
                yield return new PointDonnees(x, gain);
            }
        }
    }
}
