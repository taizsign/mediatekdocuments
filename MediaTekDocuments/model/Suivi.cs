namespace MediaTekDocuments.model
{
    public class Suivi
    {
        public int Id { get; }
        public string Libelle { get; }

        public Suivi(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
