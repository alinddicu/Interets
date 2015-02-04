namespace Interets.New.Logic
{
    using System.Collections.Generic;

    public class SuitePointsCotisationGenerator
    {
        private readonly DonneesSaisies _donneesSaisies;
        private readonly FormuleCotisation _formuleCotisation;

        public SuitePointsCotisationGenerator(
            FormuleCotisation formuleCotisation, 
            DonneesSaisies donneesSaisies)
        {
            _formuleCotisation = formuleCotisation;
            _donneesSaisies = donneesSaisies;
        }

        public IEnumerable<PointDonnees> Generate()
        {
            for (var i = 0; i <= _donneesSaisies.AnneesContrat * 12; i++)
            {
                yield return new PointDonnees(i, _formuleCotisation.Calculer(i));
            }
        }
    }
}
