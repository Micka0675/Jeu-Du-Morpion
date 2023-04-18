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
        Button buttonTarget;
        public frmGame(string joueur1,string joueur2)
        {
            InitializeComponent();
            victoryJ1 = 0;
            victoryJ2 = 0;
            countGame = 1;
            pseudJ1 = joueur1;
            pseudJ2 = joueur2;
            curentGame = countGame.ToString();
                nbreClick = 0;
                //dataTable pour afficher les infos de parties dans le dgv prevu
                DataTable dtGame = new DataTable();
                dtGame.Columns.Add("Joueur1");
                dtGame.Columns.Add("Joueur2");
                dtGame.Columns.Add("Partie (Sur 6)");

                DataRow row = dtGame.NewRow();
                row[0] = joueur1;
                row[1] = joueur2;
                row[2] = curentGame;
                dtGame.Rows.Add(row);

                InProgressDataGridView.DataSource = dtGame;

            textBox1.Text = pseudJ1 + " , Choisissez une case";

            //boucle d'ajout d'event sur les boutons ormis le quit button
            foreach (Button buttonInform in this.Controls.OfType<Button>())
                {
                    if (buttonInform != quitButton)
                    {
                        buttonInform.Click += new EventHandler(AddEvent_Click);
                    }
                }
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {

            nbreClick++;

            buttonTarget = (Button)sender;
            if (clickCase == true)
            {
                buttonTarget.Text = "O"; 
                buttonTarget.Enabled = false;
                this.clickCase = false;
                textBox1.Text = pseudJ2 +" , Choisissez une case";
            }
            else
            {
                buttonTarget.Text = "X";
                buttonTarget.Enabled = false;
                this.clickCase = true;
                textBox1.Text = pseudJ1 + " , Choisissez une case";
            }

            checkIfWin();
            
            if(nbreClick == 9)
            {
                countGame++;
                nbreClick = 0;
                reinitialize(pseudJ1,pseudJ2);

            }
        }

        private void reinitialize(string j1,string j2)
        {
     
            foreach (Button buttonInform in this.Controls.OfType<Button>())
            {
                
                buttonInform.Enabled = true;
                buttonInform.BackColor = Color.FromArgb(255,173,0);
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
                }
                else 
                {
                    victoryJ2++;
                }

                
                countGame++;
                nbreClick = 0;
                reinitialize(pseudJ1, pseudJ2);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
