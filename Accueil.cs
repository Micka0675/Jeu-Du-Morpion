namespace Morpion
{
    public partial class Accueil : Form
    {
        private frmPlayers unFrmPlayers;
        public Accueil()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //changement de form
            this.Hide();
            unFrmPlayers = new frmPlayers();
            unFrmPlayers.ShowDialog();
            this.Close();
            //form2.Closed += (s, args) => form1.Show();
            //form2.ShowDialog();
        }
    }
}