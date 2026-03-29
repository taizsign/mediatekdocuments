using System.Windows.Forms;
using MediaTekDocuments.controller;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
    public partial class FrmLogin : Form
    {
        private readonly FrmLoginController controller;
        public Utilisateur UtilisateurConnecte { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
            controller = new FrmLoginController();
        }

        private void btnConnexion_Click(object sender, System.EventArgs e)
        {
            if (txbLogin.Text.Equals("") || txbMdp.Text.Equals(""))
            {
                MessageBox.Show("Veuillez renseigner tous les champs.");
                return;
            }
            Utilisateur utilisateur = controller.GetUtilisateur(txbLogin.Text, txbMdp.Text);
            if (utilisateur == null)
            {
                MessageBox.Show("Identifiants incorrects.");
                return;
            }
            if (utilisateur.IdService == 2)
            {
                MessageBox.Show("Les droits ne sont pas suffisants pour accéder à cette application.");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            UtilisateurConnecte = utilisateur;
            this.DialogResult = DialogResult.OK;
        }
    }
}
