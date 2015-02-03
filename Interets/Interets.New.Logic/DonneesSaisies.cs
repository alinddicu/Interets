namespace Interets.New.Logic
{
    public class DonneesSaisies
    {
        public DonneesSaisies(double interetsMoyensNetsAnnuels, double primeMensuelle, int anneesContrat, double fraisGlobaux)
        {
            InteretsMoyensNetsAnnuels = interetsMoyensNetsAnnuels;
            PrimeMensuelle = primeMensuelle;
            AnneesContrat = anneesContrat;
            FraisGlobaux = fraisGlobaux;
        }

        public double InteretsMoyensNetsAnnuels { get; private set; }

        public double PrimeMensuelle { get; private set; }

        public double FraisGlobaux { get; private set; }

        public double AnneesContrat { get; private set; }
    }
}
