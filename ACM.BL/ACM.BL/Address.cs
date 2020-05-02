using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public  class Address
    {
        public Address()
        {

        }
        public Address(int addressid){
            AddressId = addressid;
        }

        // setting all the attribute for the 
        // address class
        
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }


        public bool Validate(){

            var isValid = true;
            if (PostalCode == null) isValid = false;
            if (AddressId <= 0) isValid = false;
            return isValid;
        }

    }
}
