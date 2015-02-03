namespace Interets.New.logic
{
    using System.Collections.Generic;
    using Logic;

    public class SuitePointsCotisation
    {
        private readonly DonneesSaisies _donneesSaisies;

        public SuitePointsCotisation(DonneesSaisies donneesSaisies)
        {
            _donneesSaisies = donneesSaisies;
        }

        public IEnumerable<PointDonnees> Generate()
        {
            for (var i = 0; i <= _donneesSaisies.AnneesContrat; i++)
            {
                yield return new PointDonnees(i, i * 12 * _donneesSaisies.PrimeMensuelle);
            }
        }
    }
}
