namespace MediaTekDocuments.model
{
    public class Service
    {
        public int Id { get; }
        public string Libelle { get; }

        public Service(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }
    }
}
