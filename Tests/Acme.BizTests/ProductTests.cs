﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        // Initialization by Setting Properties is best when populating from database values or modifying properties after initialization.
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

        // Initialization by Parameterized Constructor is best when setting the basic set of properties to initialize an object to a valid state.
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

        // Initialization by Object Initializer is best when readability is important and when initializing to a subset or supersubset of properties.
        [TestMethod()]
        public void SayHelloTest_ObjectInitializer()
        {
            //Arrange
            var currentProduct = new Product
            {
                ProductId = 1,
                ProductName = "Saw",
                Description = "15-inch steel blade hand saw."
            };
            var expected = "Hello Saw (1): 15-inch steel blade hand saw.";

            //Act
            var actual = currentProduct.SayHello();

            Assert.AreEqual(expected, actual);
        }
    }
}