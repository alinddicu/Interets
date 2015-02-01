namespace Interets.New.Logic
{
    public class ResultatCalcul
    {
        public ResultatCalcul(double gainBrut, double gainNet, double rendementGlobal)
        {
            GainBrut = gainBrut;
            GainNet = gainNet;
            RendementGlobal = rendementGlobal;
        }

        public double RendementGlobal { get; private set; }

        public double GainNet { get; private set; }

        public double GainBrut { get; private set; }
    }
}
