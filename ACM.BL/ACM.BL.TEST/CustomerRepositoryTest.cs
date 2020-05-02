using System;
using Xunit;
using ACM.BL;


namespace ACM.BL.TEST
{
    public class CustomerRepositoryTest
    {

        [Fact]
        public void RetrieveValid()
        {
            // -- arrange

            CustomerRepository customerRepository = new CustomerRepository();
            Customer customer = new Customer(1)
            {
                // setting up the test value
            EmailAddress = "ornobtanvir.git@gmail.com",
            FirstName = "Tanvir",
            LastName = "Rahman"

        };

            // -- act
            // retreve it from the customer repository

            var actual = customerRepository.Retreve(1); // this will return the object of the same properties

            // this object is not the same
            // so you we will assert the properties

            // -- assert

            Assert.Equal(customer.EmailAddress, actual.EmailAddress);
            Assert.Equal(customer.FirstName, actual.FirstName);
            Assert.Equal(customer.LastName, actual.LastName);



        }
    }
}
