using DotNetLab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumaKontrolna()
        {
            PESELWalidator pw = new PESELWalidator("81091003093");
            var suma = pw.SumaKontrolna();
            Assert.IsNotNull(suma);
            Assert.AreEqual(3, suma);
        }

        [TestMethod]
        public void TestSumaKontrolna_2()
        {
            PESELWalidator pw = new PESELWalidator("81091003093");
            var suma = pw.SumaKontrolna();
            Assert.AreEqual(3, suma);
        }

        [TestMethod]
        public void TestSumaKontrolna_3()
        {
            PESELWalidator pw = new PESELWalidator("81091003093");
            var suma = pw.SumaKontrolna();
            Assert.AreNotEqual(5, suma);
        }

        [TestMethod]
        public void TestPlec()
        {
            PESELWalidator pw = new PESELWalidator("81091003093");
            var plec = pw.Plec();
            Assert.AreEqual(plec, "Mezczyzna");   
        }

        [TestMethod]
        public void TestPlec_2()
        {
            PESELWalidator pw = new PESELWalidator("99051165527");
            var plec = pw.Plec();
            Assert.AreEqual(plec, "Kobieta");
        }

        [TestMethod]
        public void TestDataUrodzenia()
        {
            PESELWalidator pw = new PESELWalidator("81091003093");
            var urodziny= pw.DataUrodzenia();
            Assert.AreEqual("810910", urodziny);
            Assert.AreNotEqual("9022912", urodziny);
        }

        [TestMethod]
        public void TestDataUrodzenia_2()
        {
            PESELWalidator pw = new PESELWalidator("81091003093");
            var urodziny = pw.DataUrodzenia();
            Assert.AreNotEqual("912910", urodziny);
        }

        [TestMethod]
        public void TestSprawdzPesel()
        {
            PESELWalidator pw = new PESELWalidator("81091003093");
            var wyrazenie = pw.SprawdzPesel();
            Assert.AreEqual(true, wyrazenie);
        }

        [TestMethod]
        public void TestSprawdzPesel_2()
        {
            PESELWalidator pw = new PESELWalidator("abcdefghi11");
            var wyrazenie = pw.SprawdzPesel();
            Assert.AreNotEqual(true, wyrazenie);
        }



    }
}