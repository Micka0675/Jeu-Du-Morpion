namespace Morpion
{
    public partial class Accueil : Form
    {
        frmPlayers unFrmPlayers;
        public Accueil()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            unFrmPlayers = new frmPlayers();
            unFrmPlayers.ShowDialog();
        }
    }
}