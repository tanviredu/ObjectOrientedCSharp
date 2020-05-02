using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        // this class will  be used
        // to retreve and save the address class/type
        // so that other class can actually 
        // retreve and save address
        // we are hardcore this stuff
        
        // making the retreve Method
        public Address Retrieve(int addressid)
        {
            // create a address object
            Address address = new Address(addressid);

            // hardcore this stuff normally should come from database
            // this will return a single address od a specif person

            if(addressid == 1)
            {
                // set the address
                address.AddressType = 1;
                address.StreetLine1 = "testblock1";
                address.StreetLine2 = "testblock2";
                address.City = "Chittagong";
                address.State = "Patenga";
                address.Country = "Bangladesh";
                address.PostalCode = "104";
            }
            return address;
            
        }


        // define method for reteiving all the address of a specfic customer 
        //it will retun a the address list
        // all the address that is given
        // this method will return Ienumrable of the address type for this purpose

            public IEnumerable<Address> RetrieveCustomerById (int customerid)
        {
            // create a list
            // to store multiple address of a person
            // we can return a list of course but iEnumrable has 
            // bettrt helper method to work with
            List<Address> addresslist = new List<Address>();

            // create two different address if the same customer
            // with two different address id
            // address also have and id but multiple
            // address id can be belogs to a same customerid

            // create two different address
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "test1",
                StreetLine2 = "test2",
                City = "test3",
                State = "test4",
                Country = "test5",
                PostalCode = "144'"
            };

            // added to the list
            addresslist.Add(address);

            var address2 = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "test11",
                StreetLine2 = "test12",
                City = "test13",
                State = "test14",
                Country = "test15",
                PostalCode = "144'"
            };
            addresslist.Add(address2);

            return addresslist;



            // added to the list
            addresslist.Add(address);


            // now init this object in the constructor 
            // of the customer Repository
            // so when we fetch the customer
            // the address list object will also be 
            // avilable of the customer
            // then in other method
            // we can worj with the specfic customer address list

        }



        // define the save method

        public bool Save(Address address)
        {
            // this will save the info in the database
            return true;
        }
       

    }
}
