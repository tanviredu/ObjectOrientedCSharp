using System;
using Xunit;
using ACM.BL;


namespace ACM.BL.TEST
{
    public class ProductRepositoryTest
    {

        [Fact]
        public void RetrieveValid()
        {
            // -- arrange

            ProductRepository ProductRepository = new ProductRepository();
            Product product = new Product(2)
            {
                ProductName = "Tst1",
                ProductDescription = "test2",
                CurrentPrice = 12.8M
            };



            // -- act
            // retreve it from the customer repository

            var actual = ProductRepository.Retreve(2); // this will return the object of the same properties

            // this object is not the same
            // so you we will assert the properties

            // -- assert

            Assert.Equal(product.ProductName, actual.ProductName);
            Assert.Equal(product.ProductDescription, actual.ProductDescription);
            Assert.Equal(product.CurrentPrice, actual.CurrentPrice);



        }
    }
}
