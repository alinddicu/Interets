namespace Interets.New.Logic
{
    public class ChartParameters
    {
        public ChartParameters(int panelWidth, int panelHeight)
        {
            PanelWidth = panelWidth;
            PanelHeight = panelHeight;
        }

        public int PanelWidth { get; private set; }

        public int PanelHeight { get; private set; }
    }
}
