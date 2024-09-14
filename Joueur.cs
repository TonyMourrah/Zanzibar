using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3TonyMourrah
{
    internal class Joueur
    {
        private int _total;
        public int total
        {
            get { return _total; }
            set { _total = value; }
        }
        private string _nom ; 
        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private string _couleur;
        public string couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        private int _pointage; 
        public int pointage { 
            get { return _pointage; }
            set { _pointage = value; } 
        }

        public Joueur(string pNom, string pCouleur, int pPointage)
        {
            _nom = pNom;
            _couleur = pCouleur;
            _pointage = pPointage;
        }
        public override string ToString()
        {
            return pointage.ToString();
        }
    }  
    
}
