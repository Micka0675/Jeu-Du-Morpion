using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Morpion
{
   
    public partial class frmPlayers : Form
    {
        private frmGame zoneJeu;
        internal MJoueur joueur1;
        internal MJoueur joueur2;
        public frmPlayers()
        {
            InitializeComponent();
        }

        private void validInfos_Click(object sender, EventArgs e)
        {
            string message;
            string typeMessage = "ERREUR";
            string messageIncomplet = "Au moins un champ n'est pas complet. Appuyez sur Ok pour recommencer.";
            string messageGen = "Au moins un champ n'est pas complet et des caractères non autorisés ont été detectés. Appuyez sur Ok pour recommencer.";
            string messageCharPbm = "Seuls les caractères alphanumériques et le symbole '_' sont autorisés. Appuyez sur Ok pour recommencer.";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            int emptyData = 0, charIntruderVerif = 0;

            //recupération des données du joueur 1 saisies
            string nomJoueur1 = nom1TextBox.Text;
            string prenomJoueur1 = prenom1TextBox.Text;
            string pseudoJoueur1 = pseudo1TextBox.Text;

            //recupération des données du joueur 2 saisies
            string nomJoueur2 = nom2TextBox.Text;
            string prenomJoueur2 = prenom2TextBox.Text;
            string pseudoJoueur2 = pseudo2TextBox.Text;

            List<string> dataPlayers = new List<string>() {nomJoueur1,prenomJoueur1,pseudoJoueur1,nomJoueur2,prenomJoueur2,pseudoJoueur2};
            
            foreach(string elem in dataPlayers)
            {
                if(elem == "" || elem == null)
                {
                    emptyData++;
                }
                if (!Regex.IsMatch(elem, @"^[a-zA-Z0-9_]+$") && elem !="")
                {
                    charIntruderVerif++;
                }
            }

            if(emptyData > 0 || charIntruderVerif > 0)
            {
                if (emptyData > 0 && charIntruderVerif > 0)
                {
                    result = MessageBox.Show(messageGen, typeMessage, buttons);
                    
                }

                if (emptyData > 0 && charIntruderVerif == 0)
                {
                    result = MessageBox.Show(messageIncomplet, typeMessage, buttons);
                   
                }

                if (emptyData == 0 && charIntruderVerif > 0)
                {
                    result = MessageBox.Show(messageCharPbm, typeMessage, buttons);
                }
            }
            else
            {
                
                


                this.Hide();
                zoneJeu = new frmGame(pseudoJoueur1, pseudoJoueur2);
               


                zoneJeu.ShowDialog();
                
            }

            joueur1 = new MJoueur(nomJoueur1, prenomJoueur1, pseudoJoueur1);
            joueur2 = new MJoueur(nomJoueur2, prenomJoueur2, pseudoJoueur2);

           
        }
    }
}
