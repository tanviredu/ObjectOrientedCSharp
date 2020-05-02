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
        
        public void StaticTest()
        {
            //we devide the codein three A

            // Arrange
            // make three ovjects
            var c1 = new Customer();
            var c2 = new Customer();
            var c3 = new Customer();
            // Act
            // for three iinstalce we will increase this three time
            Customer.InstanceCount += 1;
            Customer.InstanceCount += 1;
            Customer.InstanceCount += 1;

            // Assert
            Assert.Equal(3, Customer.InstanceCount);
        }


        // test for Customer Valid method
        public void ValidateValid()
        {

            /// arrange

            var customer = new Customer
            {
                LastName = "Rahman",
                EmailAddress = "ornobtanvir.git@gmail.com"
            };

            /// act
            bool expected = true;
            bool actual = customer.Validate();

            ///Assert

            Assert.Equal(expected, actual);



        }

        // so if the lastName is missing 
        // then we must validate
        // and test it with unit test


        [Fact]
        public void ValidateMissingLastName()
        {

            //arrange

            Customer customer = new Customer
            {
                // add with just the Email address
                EmailAddress = "ornobtanvir.git@gmail.com"

            };
            //act

            var expected = false;
            var actual = customer.Validate();
            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ValidateMissingEmailAddress()
        {
            // create a customer without EmailAddress
            // arrange
            Customer customer = new Customer
            {
                LastName = "Rahman"
            };

            // act
            var expected = false;
            var actual = customer.Validate();

            Assert.Equal(expected, actual);
            


        }


    }

}