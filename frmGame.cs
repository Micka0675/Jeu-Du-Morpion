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

        public frmGame(string joueur1,string joueur2)
        {
            InitializeComponent();
            int countGame = 0;
            string pseudJ1 = joueur1;
            string pseudJ2 = joueur2;
            string curentGame = countGame.ToString();

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
        }

        


    }
}
