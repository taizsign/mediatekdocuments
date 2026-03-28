using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocumentsTests
{
    [TestClass]
    public class TestAbonnement
    {
        [TestMethod]
        public void testDateDansIntervalle()
        {
            DateTime dateCommande = new DateTime(2024, 1, 1);
            DateTime dateFinAbonnement = new DateTime(2024, 12, 31);
            DateTime dateParution = new DateTime(2024, 6, 15);
            bool resultat = Abonnement.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParution);
            Assert.IsTrue(resultat);
        }

        [TestMethod]
        public void testDateAvantCommande()
        {
            DateTime dateCommande = new DateTime(2024, 1, 1);
            DateTime dateFinAbonnement = new DateTime(2024, 12, 31);
            DateTime dateParution = new DateTime(2023, 11, 10);
            bool resultat = Abonnement.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParution);
            Assert.IsFalse(resultat);
        }

        [TestMethod]
        public void testDateApresFinAbonnement()
        {
            DateTime dateCommande = new DateTime(2024, 1, 1);
            DateTime dateFinAbonnement = new DateTime(2024, 12, 31);
            DateTime dateParution = new DateTime(2025, 3, 5);
            bool resultat = Abonnement.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParution);
            Assert.IsFalse(resultat);
        }

        [TestMethod]
        public void testDateEgaleDebutAbonnement()
        {
            DateTime dateCommande = new DateTime(2024, 1, 1);
            DateTime dateFinAbonnement = new DateTime(2024, 12, 31);
            bool resultat = Abonnement.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateCommande);
            Assert.IsTrue(resultat);
        }
    }
}
