namespace Interets.New.logic
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    public class SuitePointsGraphiquesConvertor
    {
        private readonly int _panelWidth;
        private readonly int _panelHeight;
        private readonly double _maxHeightOnY;

        public SuitePointsGraphiquesConvertor(int panelWidth, int panelHeight, double maxHeightOnY)
        {
            _panelWidth = panelWidth;
            _panelHeight = panelHeight;
            _maxHeightOnY = maxHeightOnY;
        }

        public IEnumerable<Point> Convert(ICollection<PointDonnees> donnees)
        {
            var xScaleFactor = GetxScaleFactor(donnees);
            var yScaleFactor = GetyScaleFactor(donnees);

            return
                from pointDonnees in donnees.OrderBy(d => d.X)
                let x = (int)(pointDonnees.X * xScaleFactor)
                let y = _panelHeight - (int)(pointDonnees.Y * yScaleFactor)
                select new Point(x, y);

        }

        private double GetyScaleFactor(IEnumerable<PointDonnees> donnees)
        {
            var maxY = donnees.Max(d => d.Y);
            return (_panelHeight / maxY) * (maxY / _maxHeightOnY);
        }

        private double GetxScaleFactor(IEnumerable<PointDonnees> donnees)
        {
            return _panelWidth / donnees.Max(d => d.X);
        }
    }
}
