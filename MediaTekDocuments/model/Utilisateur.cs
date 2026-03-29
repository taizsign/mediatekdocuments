namespace MediaTekDocuments.model
{
    public class Utilisateur
    {
        public int Id { get; }
        public string Login { get; }
        public string Mdp { get; }
        public int IdService { get; }
        public string Libelle { get; }

        public Utilisateur(int id, string login, string mdp, int idService, string libelle)
        {
            this.Id = id;
            this.Login = login;
            this.Mdp = mdp;
            this.IdService = idService;
            this.Libelle = libelle;
        }
    }
}
