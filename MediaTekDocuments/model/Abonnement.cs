using System;

namespace MediaTekDocuments.model
{
    public class Abonnement
    {
        public string Id { get; }
        public DateTime DateCommande { get; }
        public double Montant { get; }
        public DateTime DateFinAbonnement { get; }
        public string IdRevue { get; }
        public string Titre { get; set; }

        public Abonnement(string id, DateTime dateCommande, double montant, DateTime dateFinAbonnement, string idRevue)
        {
            this.Id = id;
            this.DateCommande = dateCommande;
            this.Montant = montant;
            this.DateFinAbonnement = dateFinAbonnement;
            this.IdRevue = idRevue;
            this.Titre = "";
        }

        public static bool ParutionDansAbonnement(DateTime dateCommande, DateTime dateFinAbonnement, DateTime dateParution)
        {
            return dateParution >= dateCommande && dateParution <= dateFinAbonnement;
        }
    }
}
