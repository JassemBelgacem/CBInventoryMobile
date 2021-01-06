using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventoryCB.Business.Service.Abstract;
using InventoryCB.Business.Service.Concret;

namespace InventoryTestProject
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ProductServiceUnitTest
    {
        IProductService _prodService = new ProductService();
        public ProductServiceUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

       
       

        [TestMethod]
        public void TestMethod1()
        {
            string prodref = "737628064502";
            DateTime expiryDate = DateTime.Now;
            var result =_prodService.GetProductInfo(prodref, expiryDate);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.name, "Rice Noodles");
            Assert.AreEqual(result.picture, "https://static.openfoodfacts.org/images/products/073/762/806/4502/front_en.6.200.jpg");

        }
    }
}
