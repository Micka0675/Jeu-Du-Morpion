using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    internal class MJoueur
    {
        private string nomJoueur;

        public string NomJoueur
        {
            get { return nomJoueur; }
            set { nomJoueur = value; }
        }

        private string prenomJoueur;

        public string PrenomJoueur 
        {
            get { return prenomJoueur; }
            set { nomJoueur= value; }
        }

        private string pseudoJoueur;

        public string PseudoJoueur
        { 
            get { return pseudoJoueur; }
            set { pseudoJoueur= value; }
        }

        internal MJoueur(string consNomJoueur,string consPrenomJoueur,string consPseudoJoueur) 
        { 
            NomJoueur = consNomJoueur;
            PrenomJoueur = consPrenomJoueur;
            PseudoJoueur = consPseudoJoueur;
        }
    }
}
