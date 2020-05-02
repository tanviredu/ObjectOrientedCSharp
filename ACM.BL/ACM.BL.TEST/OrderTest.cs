using System;
using Xunit;
using ACM.BL;

namespace ACM.BL.TEST
{
    public class OrderTest
    {
        [Fact]

        public void OrderDateValidateInValid()
        {
            Order order = new Order();
            order.OrderDate = null;
            var expected = false;
            var actual = order.Validate();
            Assert.Equal(expected, actual);
        }

    }
}
