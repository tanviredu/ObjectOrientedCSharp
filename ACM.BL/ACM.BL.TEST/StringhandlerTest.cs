using System;
using Xunit;
using ACME.Common;
using System.Reflection.Metadata;

namespace ACM.BL.TEST
{
    public class StringhandlerTest
    {
        // checking the string handler
        // class
        [Fact]
        public void InsertSpaceTestValid()
        {

            // Arrange
            var source = "TanvirRahman";
            var expected = "Tanvir Rahman";

            // act
            var actual = Stringhandler.InsetSpaces(source);

            Assert.Equal(expected, actual);



        }
        

        // insert spaces 
        // if theew is already spaec in there
        [Fact]
        public void InsertSpacesTestwithExistingSpace()
        {
            // arrange
            var source = "Tanvir Rahman";
            var expected = "Tanvir Rahman";
            //var handler = new Stringhandler();

            // act
            var actual = Stringhandler.InsetSpaces(source);

            Assert.Equal(expected, actual);
        }

    }
}
