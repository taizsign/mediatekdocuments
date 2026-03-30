using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocumentsTests
{
    [TestClass]
    public class TestUtilisateur
    {
        [TestMethod]
        public void testLoginCorrect()
        {
            Utilisateur utilisateur = new Utilisateur(1, "admin", "adminpwd", 3, "Administratif");
            Assert.AreEqual("admin", utilisateur.Login);
        }

        [TestMethod]
        public void testIdServiceCorrect()
        {
            Utilisateur utilisateur = new Utilisateur(2, "pret", "pret", 1, "Prêt");
            Assert.AreEqual(1, utilisateur.IdService);
        }

        [TestMethod]
        public void testLibelleCorrect()
        {
            Utilisateur utilisateur = new Utilisateur(1, "admin", "adminpwd", 3, "Administratif");
            Assert.AreEqual("Administratif", utilisateur.Libelle);
        }
    }
}
