namespace Interets.New.logic
{
    using Logic;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    public class SuitePointsGraphiquesConvertor
    {
        private readonly ChartParameters _chartParams;
        private readonly MaxYofPointsDonneesCalculator _maxYofPointsDonneesCalculator;

        public SuitePointsGraphiquesConvertor(
            ChartParameters chartParams, 
            MaxYofPointsDonneesCalculator maxYofPointsDonneesCalculator)
        {
            _chartParams = chartParams;
            _maxYofPointsDonneesCalculator = maxYofPointsDonneesCalculator;
        }

        public IEnumerable<Point> Convert(ICollection<PointDonnees> donnees)
        {
            var xScaleFactor = GetxScaleFactor(donnees);
            var yScaleFactor = GetyScaleFactor(donnees);

            return
                from pointDonnees in donnees.OrderBy(d => d.X)
                let x = (int)(pointDonnees.X * xScaleFactor)
                let y = _chartParams.PanelHeight - (int)(pointDonnees.Y * yScaleFactor)
                select new Point(x, y);
        }

        private double GetyScaleFactor(IEnumerable<PointDonnees> donnees)
        {
            var maxY = donnees.Max(d => d.Y);
            var maxHeightOnY = _maxYofPointsDonneesCalculator.Calculate();
            return (_chartParams.PanelHeight / maxY) * (maxY / maxHeightOnY);
        }

        private double GetxScaleFactor(IEnumerable<PointDonnees> donnees)
        {
            return _chartParams.PanelWidth / donnees.Max(d => d.X);
        }
    }
}
