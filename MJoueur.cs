using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    internal class MJoueur
    {
        private frmGame formulR;
        /// <summary>
        /// attribut nom du joueur
        /// </summary>
        private string nomJoueur;

        /// <summary>
        /// Accesseur nom du joueur 
        /// </summary>
        public string NomJoueur
        {
            get { return nomJoueur; }
            set { nomJoueur = value; }
        }
        /// <summary>
        /// attribut prenom du joueur
        /// </summary>
        private string prenomJoueur;
        /// <summary>
        /// accesseur prenom du joueur
        /// </summary>
        public string PrenomJoueur 
        {
            get { return prenomJoueur; }
            set { nomJoueur= value; }
        }
        /// <summary>
        /// attribut pseudo du joueur
        /// </summary>
        private string pseudoJoueur;
        /// <summary>
        /// accesseur pseudo du joueur
        /// </summary>
        public string PseudoJoueur
        { 
            get { return pseudoJoueur; }
            set { pseudoJoueur= value; }
        }

        /// <summary>
        /// Constructeur de MJoueur incluant tous les attributs en parametres
        /// </summary>
        /// <param name="consNomJoueur"></param>
        /// <param name="consPrenomJoueur"></param>
        /// <param name="consPseudoJoueur"></param>
        internal MJoueur(string consNomJoueur,string consPrenomJoueur,string consPseudoJoueur) 
        { 
            NomJoueur = consNomJoueur;
            PrenomJoueur = consPrenomJoueur;
            PseudoJoueur = consPseudoJoueur;
        }
    }
}
