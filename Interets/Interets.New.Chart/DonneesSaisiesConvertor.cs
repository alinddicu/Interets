namespace Interets.New.Chart
{
    using System;
    using Logic;

    public class DonneesSaisiesConvertor
    {
        private readonly string _taux;
        private readonly string _primeMensuelle;
        private readonly string _anneesContrat;
        private readonly string _fraisGlobaux;

        public DonneesSaisiesConvertor(string taux, string primeMensuelle, string anneesContrat, string fraisGlobaux)
        {
            _taux = taux;
            _primeMensuelle = primeMensuelle;
            _anneesContrat = anneesContrat;
            _fraisGlobaux = fraisGlobaux;
        }

        public DonneesSaisies Convert()
        {
            return new DonneesSaisies(Convert(_taux), Convert(_primeMensuelle), Convert(_anneesContrat), Convert(_fraisGlobaux));
        }

        private double Convert(string saisie)
        {
            var result = 0.0;
            if (!double.TryParse(saisie, out result))
            {
                throw new FormatException("Donnée incorecte");
            }

            return result;
        }
    }
}
