using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1BeerClass;

namespace BeerTest
{
    [TestClass]
    public class TestBeer
    {
        Beer testingBeer = new Beer(0, "Alkoholfrei Bavaria", 10,0);

        [TestMethod] 
        public void TestId()
        {
            Assert.AreEqual(0, testingBeer.Id);
            testingBeer.Id = 1;
            Assert.AreEqual(1,testingBeer.Id);
        }
        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Alkoholfrei Bavaria",testingBeer.Name);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testingBeer.Name = "Top");
            Assert.ThrowsException<ArgumentNullException>(() => testingBeer.Name = null);
        }

        [TestMethod]
        public void TestPrice()
        {
            Assert.AreEqual(10, testingBeer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testingBeer.Price = 0);
        }
        [TestMethod]
        public void TestAbv()
        {
            Assert.AreEqual(0, testingBeer.Abv);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testingBeer.Abv = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testingBeer.Abv = 120);
        }
    }
}
