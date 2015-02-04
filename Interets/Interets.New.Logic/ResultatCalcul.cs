namespace Interets.New.Logic
{
    public class ResultatCalcul
    {
        public ResultatCalcul(double gainBrut, double gainNet, double rendementGlobal, double cotisation)
        {
            GainBrut = gainBrut;
            GainNet = gainNet;
            RendementGlobal = rendementGlobal;
            Cotisation = cotisation;
        }

        public double RendementGlobal { get; private set; }

        public double GainNet { get; private set; }

        public double GainBrut { get; private set; }

        public double Cotisation { get; private set; }
    }
}
