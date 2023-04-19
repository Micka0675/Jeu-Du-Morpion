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
    public partial class frmGame : Form
    {
        private frmGame formulR;
        private MJoueur joueur1;
        private MJoueur joueur2;
        bool clickCase = true;
        int nbreClick;
        int countGame;
        string pseudJ1; 
        string pseudJ2;
        string curentGame;
        int victoryJ1;
        int victoryJ2;
        string message;
        string typeMessage;
        bool mortSubite;
        Button buttonTarget;
        List<string> histoList;
        string lastWin;
        DataTable dtHisto;
        string show1;
        string show2;

        public frmGame(string joueur1,string joueur2)
        {
            InitializeComponent();
                //initialisation
                victoryJ1 = 0;
                victoryJ2 = 0;
                countGame = 1;
                pseudJ1 = joueur1;
                pseudJ2 = joueur2;
                curentGame = countGame.ToString();
                nbreClick = 0;
                
                score1.Text = "0";
                score2.Text = "0"; 
                
                
                //dataTable pour afficher les infos de parties dans le dgv prevu
                DataTable dtGame = new DataTable();
                dtGame.Columns.Add("Joueur1");
                dtGame.Columns.Add("Joueur2");
                dtGame.Columns.Add("Partie (Sur 6)");

                dtHisto = new DataTable();
                dtHisto.Columns.Add("Manche");
                dtHisto.Columns.Add("Gagnant");

            DataRow row = dtGame.NewRow();
                row[0] = joueur1;
                row[1] = joueur2;
                row[2] = curentGame;
                dtGame.Rows.Add(row);

                InProgressDataGridView.DataSource = dtGame;

                textBox1.Text = pseudJ1 + " , c'est à vous!";

                //boucle d'ajout d'event sur les boutons ormis le quit button
                foreach (Button buttonInform in this.Controls.OfType<Button>())
                {
                    if (buttonInform != quitButton)
                    {
                        buttonInform.Click += new EventHandler(AddEvent_Click);
                    }
                }
            
        }

        //methode qui traite le click sur button
        private void AddEvent_Click(object sender, EventArgs e)
        {

            nbreClick++;

            buttonTarget = (Button)sender;
            if (clickCase == true)
            {
                buttonTarget.Text = "O"; 
                buttonTarget.Enabled = false;
                this.clickCase = false;
                textBox1.Text = pseudJ2 + " , c'est à vous!";
                
            }
            else
            {
                buttonTarget.Text = "X";
                buttonTarget.Enabled = false;
                this.clickCase = true;
                textBox1.Text = pseudJ1 + " , c'est à vous!";
            }

            checkIfWin();
            
            if(nbreClick == 9)
            {
                countGame++;
                nbreClick = 0;
                reinitialize(pseudJ1,pseudJ2);

            }
        } 

        //methode de reinitialization de la grille
        private void reinitialize(string j1,string j2)
        {
            DataTable dtGame = new DataTable();
            dtGame.Columns.Add("Joueur1");
            dtGame.Columns.Add("Joueur2");
            dtGame.Columns.Add("Partie (Sur 6)");

            string curentGame = countGame.ToString();
            DataRow row = dtGame.NewRow();
            row[0] = pseudJ1;
            row[1] = pseudJ2;
            row[2] = curentGame;
            dtGame.Rows.Add(row);

            InProgressDataGridView.DataSource = dtGame;
            

            

            DataRow row2 = dtHisto.NewRow();
            row2[0] = countGame-1;
            row2[1] = lastWin;
            dtHisto.Rows.Add(row2);

            histoDataGridView.DataSource = dtHisto;


            foreach (Button buttonInform in this.Controls.OfType<Button>())
            {
                    buttonInform.Enabled = true;
                    buttonInform.BackColor = Color.FromArgb(255, 173, 0);
                    


                    if (buttonInform != quitButton)
                    {
                        buttonInform.Text = "";
                    }
                
            }

            Thread.Sleep(2000);
        }

        private void checkIfWin() 
        {
            bool winTest = true;
            string symbol = "";
            foreach (Button buttonInform in this.Controls.OfType<Button>())
            {
                if(button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    symbol = button1.Text;
                }
                else if(button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
                    {
                        button4.BackColor = Color.Red;
                        button5.BackColor = Color.Red;
                        button6.BackColor = Color.Red;
                        symbol = button4.Text;
                    }
                    else if(button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
                        {
                            button7.BackColor = Color.Red;
                            button8.BackColor = Color.Red;
                            button9.BackColor = Color.Red;
                            symbol = button7.Text;
                        }
                        else if(button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
                            {
                                button1.BackColor = Color.Red;
                                button4.BackColor = Color.Red;
                                button7.BackColor = Color.Red;
                                symbol = button1.Text;
                            }
                            else if(button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
                                {
                                    button2.BackColor = Color.Red;
                                    button5.BackColor = Color.Red;
                                    button8.BackColor = Color.Red;
                                    symbol = button2.Text;  
                                 }
                                 else if(button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
                                    {
                                        button3.BackColor = Color.Red;
                                        button6.BackColor = Color.Red;
                                        button9.BackColor = Color.Red;
                                        symbol = button3.Text;
                                    }
                                    else if(button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") 
                                        {
                                            button1.BackColor = Color.Red;
                                            button5.BackColor = Color.Red;
                                            button9.BackColor = Color.Red;
                                            symbol = button1.Text;
                                        }
                                        else if(button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
                                            {
                                            button3.BackColor = Color.Red;
                                            button5.BackColor = Color.Red;
                                            button7.BackColor = Color.Red;
                                            symbol = button3.Text;      
                                            }
                                            else 
                                            {
                                                winTest = false;
                                            }
                                    
            }
            if(winTest == true)
            {
                if(symbol == "O")
                {
                    victoryJ1++;
                    lastWin = pseudJ1;
                    score1.Text = victoryJ1.ToString();
                }
                else 
                {
                    victoryJ2++;
                    lastWin = pseudJ2;
                    score2.Text = victoryJ2.ToString();
                }

                
                countGame++;
                nbreClick = 0;
                if(countGame <= 6)
                {
                    reinitialize(pseudJ1, pseudJ2);
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    typeMessage = "FIN DE PARTIE";

                    if (victoryJ1 > victoryJ2 && countGame <= 6 && mortSubite == false)
                    {
                        message = $"{pseudJ1} a gagné ! Felicitations";
                        result = MessageBox.Show(message, typeMessage, buttons);
                        if (result == DialogResult.OK)
                        {
                            Application.Restart();
                        }
                    }
                    else
                    {
                        if (victoryJ1 < victoryJ2 && countGame <= 6 && mortSubite == false)
                        {
                            message = pseudJ2 + "a gagné ! Felicitations";
                            result = MessageBox.Show(message, typeMessage, buttons);
                            if (result == DialogResult.OK)
                            {
                                Application.Restart();
                            }
                        }
                        if(mortSubite == false)
                        {
                            message = "Match nul! Bravo à tous les deux! Voulez tenter la mort subite? (Y) Oui (N) Quitter";
                            buttons = MessageBoxButtons.YesNo;
                            result = MessageBox.Show(message, typeMessage, buttons);
                            if (result == DialogResult.Yes)
                            {
                                mortSubite = true;
                                reinitialize(pseudJ1, pseudJ2);

                            }
                            else
                            {
                                Application.Restart();
                            }
                        }
                    }
                    
                    if (mortSubite == true)
                    {
                        if (victoryJ1 > victoryJ2 )
                        {
                            message = $"{pseudJ1} a gagné ! Felicitations";
                            result = MessageBox.Show(message, typeMessage, buttons);
                            if (result == DialogResult.OK)
                            {
                                Application.Restart();
                            }
                            else
                            {
                                if (victoryJ1 < victoryJ2)
                                {
                                    message = pseudJ2 + "a gagné ! Felicitations";
                                    result = MessageBox.Show(message, typeMessage, buttons);
                                    if (result == DialogResult.OK)
                                    {
                                        Application.Restart();
                                    }
                                }
                                else
                                {  
                                    reinitialize(pseudJ1, pseudJ2);
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                lastWin = "Match nul"; 
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
