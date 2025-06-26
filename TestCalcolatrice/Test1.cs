using LibCalcolatrice;

namespace TestCalcolatrice
{
    [TestClass]
    //decoratori per consentire a visual studio chhe e un test
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {

            var calc = new Calcolatrice();
            var risultato = calc.Somma(3, 5);
            Assert.AreEqual(8,risultato);
        }

        [TestMethod]
        public void TestDivisione()
        {

            var calc = new Calcolatrice();
            var risultato = calc.Divisione(5, 2);
            Assert.AreEqual(4, risultato);
        }
    }
}
