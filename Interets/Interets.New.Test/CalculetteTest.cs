namespace Interets.New.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class CalculetteTest
    {
        private Calculette _calculette;

        [TestMethod]
        public void WhenTauxIs3AndNoFraisThenResultsAreCorrect()
        {
            _calculette = new Calculette(3, 100, 1, 0);

            var result = _calculette.Calculer();

            Check.That(Math.Round(result.GainBrut, 2)).IsEqualTo(1216.64).And.IsEqualTo(Math.Round(result.GainNet, 2));
            Check.That(Math.Round(result.RendementGlobal, 3)).IsEqualTo(1.014);
        }

        [TestMethod]
        public void WhenTauxIs3AndFraisIs5ThenResultsAreCorrect()
        {
            _calculette = new Calculette(3, 100, 1, 5);

            var result = _calculette.Calculer();

            Check.That(Math.Round(result.GainBrut, 2)).IsEqualTo(1216.64);
            Check.That(Math.Round(result.GainNet, 2)).IsEqualTo(1216.64 - 5);
            Check.That(Math.Round(result.RendementGlobal, 3)).IsEqualTo(1.01);
        }
    }
}
