namespace Interets.New.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using logic;

    public class MaxYofPointsDonneesCalculator
    {
        private readonly IEnumerable<PointDonnees[]> _tabs;

        public MaxYofPointsDonneesCalculator(params PointDonnees[][] tabs)
        {
            _tabs = tabs;
        }

        public double Calculate()
        {
            return _tabs.SelectMany(tab => tab.Select(t => t.Y)).Max(e => e);
        }
    }
}
