using CoursTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTest
{
    [TestClass]
    public class ShopTest
    {
        private Shop shop = new Shop();

        [TestMethod]
        public void UpdateTest_DESC_SellIn_Simple()
        {
            Product product = new Product()
            {
                Type = "s",
                SellIn = 10,
                Quality = 10,
                Name = "name",
            };

            shop.Update(product);

            Assert.AreEqual(9, product.SellIn);
        }

        [TestMethod]
        public void UpdateTest_DESC_SellIn_0()
        {
            Product product = new Product()
            {
                Type = "s",
                SellIn = 0,
                Quality = 10,
                Name = "name",
            };

            shop.Update(product);

            Assert.AreEqual(0, product.SellIn);
        }

        [TestMethod]
        public void UpdateTest_DESC_Quality_Simple_Product()
        {
            Product product = new Product()
            {
                Type = "s",
                SellIn = 10,
                Quality = 10,
                Name = "name",
            };

            shop.Update(product);

            Assert.AreEqual(9, product.Quality);
        }

        [TestMethod]
        public void UpdateTest_DESC_Quality_Simple_Product_SellIn_0()
        {
            Product product = new Product()
            {
                Type = "s",
                SellIn = 0,
                Quality = 10,
                Name = "name",
            };

            shop.Update(product);

            Assert.AreEqual(8, product.Quality);
        }

        [TestMethod]
        public void UpdateTest_DESC_Quality_La_Product_Not_Brie()
        {
            Product product = new Product()
            {
                Type = "l",
                SellIn = 10,
                Quality = 10,
                Name = "name",
            };

            shop.Update(product);

            Assert.AreEqual(8, product.Quality);
        }

        [TestMethod]
        public void UpdateTest_DESC_Quality_La_Product_Not_Brie_SellIn_0()
        {
            Product product = new Product()
            {
                Type = "l",
                SellIn = 0,
                Quality = 10,
                Name = "name",
            };

            shop.Update(product);

            Assert.AreEqual(6, product.Quality);
        }
        [TestMethod]
        public void UpdateTest_DESC_Quality_0_Not_Brie()
        {
            Product product = new Product()
            {
                Type = "s",
                SellIn = 10,
                Quality = -1,
                Name = "name",
            };

            shop.Update(product);

            Assert.AreEqual(0, product.Quality);
        }

        [TestMethod]
        public void UpdateTest_ASC_Quality_50()
        {
            Product product = new Product()
            {
                Type = "s",
                SellIn = 10,
                Quality = 51,
                Name = "name",
            };

            shop.Update(product);

            Assert.AreEqual(50, product.Quality);
        }

        [TestMethod]
        public void UpdateTest_Quality_Brie()
        {
            Product product = new Product()
            {
                Type = "l",
                SellIn = 10,
                Quality = 10,
                Name = "Brie",
            };

            shop.Update(product);

            Assert.AreEqual(11, product.Quality);
        }
    }
}
