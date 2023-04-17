using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morpion
{
   
    public partial class frmPlayers : Form
    {
        internal MJoueur joueur1;
        internal MJoueur joueur2;
        public frmPlayers()
        {
            InitializeComponent();
        }

        private void validInfos_Click(object sender, EventArgs e)
        {
            //recupération des données du joueur 1 saisies
            string nomJoueur1 = nom1TextBox.Text;
            string prenomJoueur1 = prenom1TextBox.Text;
            string pseudoJoueur1 = pseudo1TextBox.Text;

            //recupération des données du joueur 2 saisies
            string nomJoueur2 = nom2TextBox.Text;
            string prenomJoueur2 = prenom2TextBox.Text;
            string pseudoJoueur2 = pseudo2TextBox.Text;

            joueur1 = new MJoueur(nomJoueur1, prenomJoueur1, pseudoJoueur1);
            joueur2 = new MJoueur(nomJoueur2, prenomJoueur2, pseudoJoueur2);

        }
    }
}
