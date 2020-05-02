using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ACM.BL
{
    public class Order
    {
        // making overloaded constructor

        // make the constructor chaining
        // for the id the oreder is init without the 
        // orderid then we still init the list 
        // but with a zero value
        public Order():this(0)
        {
        }
        public Order(int orderid)
        {
            OrderID  = orderid;

            // everytime the order is init it will init theordr List too
            OrderItems = new List<OrderItem>(); 
        }

        // from the schema picture 
        // the order has relation with the Customer class
        // and the Address class
        // make the two attribute to hold this value






        // so we take the CustomerId and 
        // the AddressId as a shipping Id
        // this comes fromt he customer class
        public int CustomerId { get; set; }

        // this contains shipping address
        public int ShippingAddressId { get; set; }

        // every order habe multiple order item
        // so we add a List to store them
        public List<OrderItem> OrderItems { get; set; }

        // it can be null we will take care of it in 
        // validate method
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }
        // this order id id tie to the orderitem id
        // in the Orderitem class
    
        
        // retrieve the order 

        
        /// validate method
        public bool Validate()
        {
            var isValid = true;

            // validate the order date
            if(OrderDate == null)
            {
                isValid = false;
            }
            return isValid;
        }


    }
}
