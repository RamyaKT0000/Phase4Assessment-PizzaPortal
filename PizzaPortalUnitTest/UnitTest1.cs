using NUnit.Framework;
using System.Collections.Generic;
using Phase4PizzaPortal.Models;

namespace PizzaPortalUnitTest
{
    public class Tests
    {

        private readonly PizzaBO _context = new PizzaBO();

        public PizzaModel getPizzaById(int id)
        {
            return _context.GetPizzaById(id);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //To test the count of all pizzas -- Pass
        public void Test1()
        {
            int actualCount = _context.GetAllPizzas().Count;

            int expectedCount = 8;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        //To test the count of all pizzas -- Fail
        public void Test2()
        {
            int actualCount = _context.GetAllPizzas().Count;

            int expectedCount = 4;
  
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        //To test the pizza by id -- pass
        public void Test3()
        {
            int actualId = getPizzaById(7).PId;

            int expectedId = 7;

            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
        //To test the pizza by id -- fail
        public void Test4()
        {
            int actualId = getPizzaById(1).PId;

            int expectedId = 5;

            Assert.AreEqual(expectedId, actualId);
        }

        [Test]
        //To test the pizza by name -- pass
        public void Test5()
        {
            string actualName = getPizzaById(3).PName;

            string expectedName = "Farm House";

            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        //To test the pizza by name -- fail
        public void Test6()
        {
            string actualName = getPizzaById(8).PName;

            string expectedName = "Delux Veggie";

            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        //To test the pizza by crust size -- pass
        public void Test7()
        {
            string actualCrustSize = getPizzaById(4).PCrustSize;

            string expectedCrustSize = "Extra Large";

            Assert.AreEqual(expectedCrustSize, actualCrustSize);
        }

        [Test]
        //To test the pizza by crust size -- fail
        public void Test8()
        {
            string actualCrustSize = getPizzaById(1).PCrustSize;

            string expectedCrustSize = "Medium";

            Assert.AreEqual(expectedCrustSize, actualCrustSize);
        }

        [Test]
        //To test the pizza by price -- pass
        public void Test9()
        {
            decimal actualPrice = getPizzaById(2).PPrice;

            decimal expectedPrice = 110.00M;

            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [Test]
        //To test the pizza by price -- fail
        public void Test10()
        {
            decimal actualPrice = getPizzaById(5).PPrice;

            decimal expectedPrice = 90.00M;

            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}