namespace Interets.New.Logic
{
    using System.Collections.Generic;

    public class SuitePointsCotisationGenerator
    {
        private readonly DonneesSaisies _donneesSaisies;

        public SuitePointsCotisationGenerator(DonneesSaisies donneesSaisies)
        {
            _donneesSaisies = donneesSaisies;
        }

        public IEnumerable<PointDonnees> Generate()
        {
            for (var i = 0; i <= _donneesSaisies.AnneesContrat * 12; i++)
            {
                yield return new PointDonnees(i, i * _donneesSaisies.PrimeMensuelle);
            }
        }
    }
}
