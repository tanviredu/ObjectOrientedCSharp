using System;
using Xunit;
using ACM.BL;
using System.Threading;

namespace ACM.BL.TEST
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void ValidOrderDisplay()
        {
            OrderRepository orderrepository = new OrderRepository();
            Order order = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };


            var actual = orderrepository.Retrieve(10);

            // assert

            Assert.Equal(order.OrderDate, actual.OrderDate);

        }

    }
}
