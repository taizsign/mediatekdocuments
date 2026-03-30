using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocumentsTests
{
    [TestClass]
    public class TestRevue
    {
        [TestMethod]
        public void testPeriodiciteCorrecte()
        {
            Revue revue = new Revue("10001", "Le Monde", "", "g1", "Actualités",
                "p1", "Adultes", "r1", "Presse quotidienne", "QT", 5);
            Assert.AreEqual("QT", revue.Periodicite);
        }

        [TestMethod]
        public void testDelaiMiseADispoCorrect()
        {
            Revue revue = new Revue("10001", "Le Monde", "", "g1", "Actualités",
                "p1", "Adultes", "r1", "Presse quotidienne", "QT", 5);
            Assert.AreEqual(5, revue.DelaiMiseADispo);
        }

        [TestMethod]
        public void testTitreCorrect()
        {
            Revue revue = new Revue("10001", "Le Monde", "", "g1", "Actualités",
                "p1", "Adultes", "r1", "Presse quotidienne", "QT", 5);
            Assert.AreEqual("Le Monde", revue.Titre);
        }
    }
}
