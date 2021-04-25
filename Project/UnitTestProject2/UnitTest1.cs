﻿using CoffeMakerDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    public class UnitTest2
    {
        [TestMethod]
        public void OrderACoffee_Should_return_Received_Message()
        {
            //Arrange
            StarbuckStore store = new StarbuckStore(new FakeStarbucksStore());
            //Act
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received.", result);
        }

        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingStub()
        {
            StarbuckStore store = new StarbuckStore(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your order is received.", result);
        }

        //Moq MOCK

        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingMock()
        {
            var service = new Mock<IMakeACoffee>();
            service.Setup(x => x.CheckIngredientAvailability()).Returns(true);
            service.Setup(x => x.CheckIngredientAvailability()).Returns(true);
            //var result = store.OrderCoffee(2, 4);
            //Assert.AreEqual("Your Order is received", result);

        }



    }

    internal class Mock<T>
    {
        public Mock()
        {
        }

        internal object Setup(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
