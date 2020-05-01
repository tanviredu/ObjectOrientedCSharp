using System;
using Xunit;
using ACM.BL;
namespace ACM.BL.TEST
{
    public class CustomerTest
    {
        [Fact]
        public void ValidFullNameTest()
        {

            Customer customer = new Customer
            {
                // setting the properties
                FirstName = "Tanvir",
                LastName = "Rahman"
            };
            string expectedName = "Rahman Tanvir";
            string realOutput = customer.FullName;

            //now assert
            Assert.Equal(expectedName, realOutput);
        }
        [Fact]
        public void CustomerInvalidFullNameTest()
        {
            Customer customer = new Customer
            {
                // setting the properties
                FirstName = "Tanvir",
                LastName = "Rahman"
            };
            string expectedName = "Tanvir Rahman";
            string realOutput = customer.FullName;

            //now assert
            Assert.NotEqual(expectedName, realOutput);



        }


        ///this is where we check the is empty
        /// if the string is empty how to test it
        /// // or feed thepart of the value
        
        [Fact]
        public void FullNameFirstNameEmpty()
        {

            // init with a lst name
            // it must detect the empty First name
            Customer customer = new Customer
            {
                LastName = "Hosen"
            };

            string expectedValue = "Hosen";
            string actuaValue = customer.FullName;

            Assert.Equal(expectedValue, actuaValue);


        }
        [Fact]
        public void FullNameLastNameEmpty() { 
        
        }

    }

}