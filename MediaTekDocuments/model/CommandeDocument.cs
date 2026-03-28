using System;

namespace MediaTekDocuments.model
{
    public class CommandeDocument
    {
        public string Id { get; }
        public DateTime DateCommande { get; }
        public double Montant { get; }
        public int NbExemplaire { get; }
        public string IdLivreDvd { get; }
        public int IdSuivi { get; set; }
        public string LibelleSuivi { get; set; }

        public CommandeDocument(string id, DateTime dateCommande, double montant,
            int nbExemplaire, string idLivreDvd, int idSuivi, string libelleSuivi)
        {
            this.Id = id;
            this.DateCommande = dateCommande;
            this.Montant = montant;
            this.NbExemplaire = nbExemplaire;
            this.IdLivreDvd = idLivreDvd;
            this.IdSuivi = idSuivi;
            this.LibelleSuivi = libelleSuivi;
        }
    }
}
