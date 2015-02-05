namespace Interets.New.Logic
{
    public class ChartParameters
    {
        public ChartParameters(int panelWidth, int panelHeight)
        {
            PanelWidth = panelWidth;
            PanelHeight = panelHeight;
            HorizontalMargin = 10;
            VerticalMargin = 10;
        }

        public int PanelWidth { get; private set; }

        public int PanelHeight { get; private set; }

        public int HorizontalMargin {get; private set;}

        public int VerticalMargin { get; private set; }
    }
}
