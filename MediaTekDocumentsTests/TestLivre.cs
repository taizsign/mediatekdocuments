using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocumentsTests
{
    [TestClass]
    public class TestLivre
    {
        [TestMethod]
        public void testAuteurCorrect()
        {
            Livre livre = new Livre("00001", "Titre test", "", "123", "Philippe Masson", "",
                "g1", "Policier", "p1", "Adultes", "r1", "Romans");
            Assert.AreEqual("Philippe Masson", livre.Auteur);
        }

        [TestMethod]
        public void testIsbnCorrect()
        {
            Livre livre = new Livre("00001", "Titre test", "", "978-3-16-148410-0", "Auteur test", "",
                "g1", "Policier", "p1", "Adultes", "r1", "Romans");
            Assert.AreEqual("978-3-16-148410-0", livre.Isbn);
        }

        [TestMethod]
        public void testTitreCorrect()
        {
            Livre livre = new Livre("00001", "Catastrophes au Brésil", "", "123", "Auteur test", "",
                "g1", "Policier", "p1", "Adultes", "r1", "Romans");
            Assert.AreEqual("Catastrophes au Brésil", livre.Titre);
        }

        [TestMethod]
        public void testIdCorrect()
        {
            Livre livre = new Livre("00017", "Titre test", "", "123", "Auteur test", "",
                "g1", "Policier", "p1", "Adultes", "r1", "Romans");
            Assert.AreEqual("00017", livre.Id);
        }
    }
}
