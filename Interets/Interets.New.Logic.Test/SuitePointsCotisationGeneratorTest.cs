namespace Interets.New.Test
{
    using System.Linq;
    using Logic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class SuitePointsCotisationGeneratorTest
    {
        private SuitePointsCotisationGenerator _generator;

        [TestMethod]
        public void WhenGenerateCotisationDataThenDataIsCorrect()
        {
            const double primeMensuelle = 100.0;
            const int anneesContrat = 1;
            var donneesSaisies = new DonneesSaisies(0, primeMensuelle, anneesContrat, 0);
            _generator = new SuitePointsCotisationGenerator(donneesSaisies);

            var donnees = _generator.Generate().ToArray();
            Check.That(donnees).HasSize(anneesContrat * 13);

            var lastX = 0.0;
            var lastY = 0.0;
            for (var i = 1; i < donnees.Length; i++)
            {
                var x = donnees[i].X;
                var y = donnees[i].Y;
                Check.That(x - lastX).IsEqualTo(1d);
                Check.That(y - lastY).IsEqualTo(primeMensuelle);
                lastX = x;
                lastY = y;
            }
        }
    }
}
