namespace Interets.New.logic
{
    public struct PointDonnees
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public PointDonnees(double x, double y)
            : this()
        {
            X = x;
            Y = y;
        }
    }
}
