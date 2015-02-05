namespace Interets.New.Logic
{
    public class ChartParameters
    {
        public ChartParameters(
            int panelWidth, 
            int panelHeight,
            int horizontalMargin,
            int verticalMargin)
        {
            PanelWidth = panelWidth;
            PanelHeight = panelHeight;
            HorizontalMargin = horizontalMargin;
            VerticalMargin = verticalMargin;
        }

        public int PanelWidth { get; private set; }

        public int PanelHeight { get; private set; }

        public int HorizontalMargin {get; private set;}

        public int VerticalMargin { get; private set; }
    }
}
