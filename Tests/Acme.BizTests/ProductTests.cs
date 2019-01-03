using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Hammer";
            currentProduct.ProductId = 1;
            currentProduct.Description = "Smash with this!";
            var expected = "Hello Hammer (1): Smash with this!";

            //Act
            var actual = currentProduct.SayHello();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHelloTest_ParameterizedContructor()
        {
            //Arrange
            var currentProduct = new Product("Hammer", "Smash with this!", 1);
            var expected = "Hello Hammer (1): Smash with this!";

            //Act
            var actual = currentProduct.SayHello();

            Assert.AreEqual(expected, actual);
        }
    }
}