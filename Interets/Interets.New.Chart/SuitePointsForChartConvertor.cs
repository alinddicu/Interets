namespace Interets.New.Chart
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using Logic;

    public class SuitePointsForChartConvertor
    {
        private readonly ChartParameters _chartParams;
        private readonly MaxYofPointsDonneesCalculator _maxYofPointsDonneesCalculator;

        public SuitePointsForChartConvertor(
            ChartParameters chartParams,
            MaxYofPointsDonneesCalculator maxYofPointsDonneesCalculator)
        {
            _chartParams = chartParams;
            _maxYofPointsDonneesCalculator = maxYofPointsDonneesCalculator;
        }

        public IEnumerable<Point> Convert(ICollection<PointDonnees> donnees)
        {
            var xScaleFactor = GetxScaleFactor(donnees);
            var yScaleFactor = GetyScaleFactor();

            return
                from pointDonnees in donnees.OrderBy(d => d.X)
                let x = (int)(pointDonnees.X * xScaleFactor) + _chartParams.HorizontalMargin
                let y = _chartParams.PanelHeight - _chartParams.VerticalMargin - (int)(pointDonnees.Y * yScaleFactor)
                select new Point(x, y);
        }

        private double GetyScaleFactor()
        {
            var maxHeightOnY = _maxYofPointsDonneesCalculator.Calculate();
            return (_chartParams.PanelHeight - 2 * _chartParams.VerticalMargin) / maxHeightOnY;
        }

        private double GetxScaleFactor(IEnumerable<PointDonnees> donnees)
        {
            return (_chartParams.PanelWidth - 2 * _chartParams.HorizontalMargin) / donnees.Max(d => d.X);
        }
    }
}
