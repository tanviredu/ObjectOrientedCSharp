using System;
using Xunit;
using ACM.BL;

namespace ACM.BL.TEST
{
    public class OrderItemTest
    {

        [Fact]
        public void ValidTest()
        {
            OrderItem order = new OrderItem(2)
            {
                ProductId = 2,
                PurchasePrice = (decimal)100,
                Quantity = 100
            };
            Assert.True(order.Validate());
        }

        [Fact]
        public void InvalidTestProductId(){
            OrderItem order = new OrderItem(2)
            {
                ProductId = -2,
                PurchasePrice = (decimal)100,
                Quantity = 100
            };
            Assert.False(order.Validate());


        }

        [Fact]
        public void InvalidTestPurchagePrice()
        {

            OrderItem order = new OrderItem(2)
            {
                ProductId = 2,
                PurchasePrice = null,
                Quantity = 100
            };
            Assert.False(order.Validate());

        }

        [Fact]
        public void InvalidTestQuantity()
        {
            OrderItem order = new OrderItem(2)
            {
                ProductId = 2,
                PurchasePrice = (decimal)100,
                Quantity = -100
            };
            Assert.False(order.Validate());
        }






    }
}
