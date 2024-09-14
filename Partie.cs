using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3TonyMourrah
{
    internal class Partie
    {
        private const string EGALITE = "Vous avez tout les deux le même score ";
        private string _nom1;
        public string nom1
        {
            get { return _nom1; }
            set { _nom1 = value; }
        }
        private string _nom2;
        public string nom2
        {
            get { return _nom2; }
            set { _nom2 = value; }
        }

        private int _nombreJoueur;

        public int nombreJoueur
        {
            get { return _nombreJoueur; }
            set { _nombreJoueur = value; }
        }

        private List<Joueur> _joueurs;
        public List<Joueur> joueurs
        {
            get { return _joueurs; }
            set { _joueurs = value; }
        }
        private int _tourEnCours;
        public int tourEnCours
        {
            get { return _tourEnCours; }
            set { _tourEnCours = value; }
        }
        private List<int> _resultats;
        public List<int> resultats
        {
            get { return _resultats; }
            set { _resultats = value; }

        }


        public Partie()
        {
            _nombreJoueur = 0;
            _joueurs = null;
            _tourEnCours = 0;
            _resultats = null;
        }

        public Partie(string premierNom, string deuxiemeNom,
            int pNombreJoueurs, List<int> pResultats, int pTourEnCours)
        {
            _nom1 = premierNom;
            _nom2 = deuxiemeNom;
            _nombreJoueur = pNombreJoueurs;
            _resultats = pResultats;
            _joueurs = new List<Joueur>
    {
        new Joueur("C'est à ton tour " + premierNom + " ! ", "Bleu", 0),
        new Joueur("C'est à ton tour " + deuxiemeNom + " ! ", "Jaune", 0)
    };
            _tourEnCours = pTourEnCours;

        }
        public Joueur DeterminerGagnant()
        {
            if (joueurs[0].pointage > joueurs[1].pointage)
            {
                return joueurs[1];
            }
            else if (joueurs[1].pointage > joueurs[0].pointage)
            {
                return joueurs[0];
            }
            else
            {
                return null ;
                MessageBox.Show(EGALITE);
            }
        }
    }
}
