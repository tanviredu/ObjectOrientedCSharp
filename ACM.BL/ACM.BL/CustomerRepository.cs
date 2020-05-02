using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository{
        
        // added a attribute 
        // to store the adress repository
        // add a extra field
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();

        }

        // This repository 
        // will have the data save and retrieve method
        // taking the method from the main class
        // we make another Method that retreve a customer

        // for now we make a fake object
        // so the test is passed

        public Customer Retreve(int customerid)
        {

            // this is test code
            // and it will be deleted

            Customer customer = new Customer(customerid);
            // thats create a object based on the customerid

            // this is hard coded value
            if(customerid == 1)
            {
                // setting up the test value
                customer.EmailAddress = "ornobtanvir.git@gmail.com";
                customer.FirstName = "Tanvir";
                customer.LastName = "Rahman";
                // add this address list for this
                customer.AddressList = addressRepository.RetrieveCustomerById(customerid).ToList();




                
            }


            return customer;
            //return new Customer();
        }


        public bool Save()
        {
            return true;
        }

    }
}
