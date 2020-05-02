using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
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

        
        // added validate method
        // validate method will take care of the 
        // empty ProductName 
        // and null price
        public bool Validate()
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
