using Entities.Components;
using Entities.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class test_Component
    {
        /// <summary>
        /// Tests the constructor and the properties of a processor
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        [TestMethod]
        [DataRow("Intel","i9 10900")]
        public void InstancingAValidProcessor(string brand,string model)
        {
            //Arrange
            Processor p = new Processor(brand, model);

            //Act
            string actualBrand = p.Brand;
            string actualModel = p.Model;

            //Assert
            Assert.AreEqual(actualBrand, brand);
            Assert.AreEqual(actualModel, model);
        }

        [TestMethod]
        [ExpectedException(typeof(MissingComponentException))]
        [DataRow("Asus", "z490")]
        public void InstancingAnInvalidMotherboard(string brand, string model)
        {
            Motherboard mb = new Motherboard(brand, model);

            mb.Processor.ToString();
        }
    }
}
