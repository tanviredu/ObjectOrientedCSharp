using System;
using Xunit;
using ACM.BL;

namespace ACM.BL.TEST
{
   public  class ProductTest
    {
        [Fact]
        public void ProductValidTest()
        {
            // init a product without a name

            Product product = new Product
            {
              ProductName = "Rice",
              CurrentPrice = (decimal) 60.0

            };

            bool expected = true;
            bool actual = product.Validate();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ProductNameInValidTest()
        {
            // init a product without a name

            Product product = new Product
            {
                CurrentPrice = (decimal)60.0

            };

            bool expected = false;
            bool actual = product.Validate();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ProductPriceInValidTest()
        {
            // init a product without a name

            Product product = new Product
            {

                ProductName = "Rice",
            };

            bool expected = false;
            bool actual = product.Validate();

            Assert.Equal(expected, actual);
        }

        
    }
}
