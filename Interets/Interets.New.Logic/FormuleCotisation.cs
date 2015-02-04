namespace Interets.New.Logic
{
    public class FormuleCotisation
    {
        private readonly DonneesSaisies _donneesSaisies;

        public FormuleCotisation(DonneesSaisies donneesSaisies)
        {
            _donneesSaisies = donneesSaisies;
        }

        public double Calculer(double moisCotisation)
        {
            return moisCotisation * _donneesSaisies.PrimeMensuelle;
        }
    }
}
