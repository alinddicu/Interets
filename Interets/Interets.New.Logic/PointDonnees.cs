namespace Interets.New.Logic
{
    using System.Globalization;

    public struct PointDonnees
    {
        public PointDonnees(double x, double y)
            : this()
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "x:{0}, y:{1}", X, Y);
        }
    }
}
