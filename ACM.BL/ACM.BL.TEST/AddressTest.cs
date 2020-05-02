using System;
using Xunit;
using ACM.BL;

namespace ACM.BL.TEST
{
    public class AddressTest
    {
        [Fact]
        public void PostalCodeValid()
        {
            Address address = new Address(1)
            {
                PostalCode = "1234"
            };

            Assert.True(address.Validate());

        }

        [Fact]
        public void PostalCodeInvalid()
        {
            Address address = new Address(1)
            {
                PostalCode = null
            };

            Assert.False(address.Validate());
        }

    }
}
