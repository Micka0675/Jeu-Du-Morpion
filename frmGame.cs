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
            string pseudJ1 = joueur1;
            string pseudJ2 = joueur2;  
        }

        


    }
}
