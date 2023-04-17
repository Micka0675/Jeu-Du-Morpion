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
            string typeMessage = "ERREUR";
            string message = "Veuillez compléter tous les champs pour jouer";$
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            int emptyData = 0;
            //recupération des données du joueur 1 saisies
            string nomJoueur1 = nom1TextBox.Text;
            string prenomJoueur1 = prenom1TextBox.Text;
            string pseudoJoueur1 = pseudo1TextBox.Text;

            //recupération des données du joueur 2 saisies
            string nomJoueur2 = nom2TextBox.Text;
            string prenomJoueur2 = prenom2TextBox.Text;
            string pseudoJoueur2 = pseudo2TextBox.Text;

            List<string> dataPlayers = new List<string>() { nomJoueur1,prenomJoueur1,pseudoJoueur1,nomJoueur2,prenomJoueur2,pseudoJoueur2};

            foreach(string elem in dataPlayers)
            {
                if(elem == "")
                {
                    emptyData++;
                    
                }
            }

            if(emptyData > 0) 
            {
                result = MessageBox.Show(typeMessage, message, buttons);
                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            joueur1 = new MJoueur(nomJoueur1, prenomJoueur1, pseudoJoueur1);
            joueur2 = new MJoueur(nomJoueur2, prenomJoueur2, pseudoJoueur2);

        }
    }
}
