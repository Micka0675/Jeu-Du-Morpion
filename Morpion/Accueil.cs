namespace Morpion
{
    public partial class Accueil : Form
    {
        frmPlayers unFrmPlayers;
        public Accueil()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, System.EventArgs e) 
        {
            unFrmPlayers.ShowDialog();
        }
    }
}