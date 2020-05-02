using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {

        public Product Retreve(int productid)
        {

            // create the object
            Product product = new Product(productid);
            
            if(productid == 2)
            {
                product.ProductName = "Tst1";
                product.ProductDescription = "test2";
                product.CurrentPrice = 12.8M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }



    }
}
