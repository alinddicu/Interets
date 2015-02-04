namespace Interets.New.Chart
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Drawing;
    using Logic;

    public class Traceur
    {
        private readonly Graphics _graphics;
        private readonly SuitePointsForChartConvertor _convertor;
        private readonly Pen[] _pens;

        public Traceur(
            Graphics graphics, 
            SuitePointsForChartConvertor convertor,
            params Pen[] pens)
        {
            _graphics = graphics;
            _convertor = convertor;
            _pens = pens;
        }

        public void Trace(params PointDonnees[][] listePoints)
        {
            for (var i = 0; i < listePoints.Count(); i++)
            {
                PrintPoints(_convertor.Convert(listePoints[i]).ToArray(), _pens[i]);
            }
        }

        private void PrintPoints(IList<Point> chartPoints, Pen pen)
        {
            var lastPoint = chartPoints[0];
            for (var i = 1; i < chartPoints.Count(); i++)
            {
                var point = chartPoints[i];
                _graphics.DrawLine(pen, lastPoint.X, lastPoint.Y, point.X, point.Y);
                lastPoint = point;
            }
        }
    }
}
