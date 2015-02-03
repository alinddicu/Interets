namespace Interets.New.Test
{
    using Logic;
    using logic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class MaxYofPointsDonneesCalculatorTest
    {
        private MaxYofPointsDonneesCalculator _calc;

        [TestMethod]
        public void Given2TabsWith100MaxWhenCalculateThenMaxIs100()
        {
            var tab1 = new[] { new PointDonnees(1, 1.1), new PointDonnees(2, 2.2) };
            var tab2 = new[] { new PointDonnees(2, -1.1), new PointDonnees(4, 100) };

            _calc = new MaxYofPointsDonneesCalculator(tab1, tab2);
            Check.That(_calc.Calculate()).IsEqualTo(100);
        }
    }
}
