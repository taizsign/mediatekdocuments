using MediaTekDocuments.dal;
using MediaTekDocuments.model;

namespace MediaTekDocuments.controller
{
    class FrmLoginController
    {
        private readonly Access access;

        public FrmLoginController()
        {
            access = Access.GetInstance();
        }

        public Utilisateur GetUtilisateur(string login, string mdp)
        {
            return access.GetUtilisateur(login, mdp);
        }
    }
}
