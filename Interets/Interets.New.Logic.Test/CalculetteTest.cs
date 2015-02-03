﻿namespace Interets.New.Test
{
    using System;
    using Logic;
    using logic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class CalculetteTest
    {
        private static readonly FormuleGain FormuleGain = new FormuleGain();

        private Calculette _calculette;
        private DonneesSaisies _donneesSaisies;

        [TestMethod]
        public void WhenTauxIs3AndNoFraisThenResultsAreCorrect()
        {
            _donneesSaisies = new DonneesSaisies(3, 100, 1, 0);
            _calculette = new Calculette(FormuleGain, _donneesSaisies);

            var result = _calculette.Calculer();

            Check.That(Math.Round(result.GainBrut, 2)).IsEqualTo(1216.64).And.IsEqualTo(Math.Round(result.GainNet, 2));
            Check.That(Math.Round(result.RendementGlobal, 3)).IsEqualTo(1.014);
        }

        [TestMethod]
        public void WhenTauxIs3AndFraisIs5ThenResultsAreCorrect()
        {
            _donneesSaisies = new DonneesSaisies(3, 100, 1, 5);
            _calculette = new Calculette(new FormuleGain(), _donneesSaisies);

            var result = _calculette.Calculer();

            Check.That(Math.Round(result.GainBrut, 2)).IsEqualTo(1216.64);
            Check.That(Math.Round(result.GainNet, 2)).IsEqualTo(1216.64 - 5);
            Check.That(Math.Round(result.RendementGlobal, 3)).IsEqualTo(1.01);
        }
    }
}
