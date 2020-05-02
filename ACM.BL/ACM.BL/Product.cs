using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product:EntityBase
    {
        // added overloaded constructor
        public Product()
        {
        }

        public Product(int productid)
        {
            ProductId = productid;
        }

        // this ? means it can be null
        // we take this with the validate option
        public int ProductId { get; private set; }
        public decimal? CurrentPrice { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }




        // we are going to add some of the decorator of the class
        // default properties
        // the by default tostring method will be overwrite
        // for the class
        // this is called  a decorator
        public override string ToString() => ProductName;
        // overwrite the method
        // to print the product name
        // insted of showing the class name
        // after that the class name will be called with the 
        // product name

        // you can test using debugger in the test class 
        // that its working










        // added validate method
        // validate method will take care of the 
        // empty ProductName 
        // and null price
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
            if(CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
       




    }
}
