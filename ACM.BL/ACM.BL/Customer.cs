using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {


        // if we use empty constructor
        // calling it without parameter will return a list
        // with a customer id parameter will return a single customer
        // overloaded customer

        public Customer()
        {

        }

        public Customer(int customerid) {
            CustomerId = customerid;
        }












        // this is Customer type

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        // make a static attribute to store the number of instance 
        // to find the number of customer that is created
        // this will be a static not no instance in necessary
        public static int InstanceCount { get; set; } // added test


        public string FullName {

            get
            {
                //return FirstName + " " + LastName;
                // changing the full name property
                string fullname = LastName;
                if (!string.IsNullOrEmpty(FirstName)) {
                        // if the first name is filled
                    if (!string.IsNullOrEmpty(fullname)) {
                        // and the second name is filled
                        // for now full name is the lastname
                        // added a space with the full name
                        // then add the First name
                        fullname += " ";
                    }
                    // then add it with the lastname which is full name
                    fullname += FirstName;
                }

                return fullname;
            }


        }

        /// added the summery
        /// validate option for name (if lastname is empty thn validation error
        /// add a unit test for the Validate
        public bool Validate()
        {

            var isValid = true;
            if (!string.IsNullOrWhiteSpace(LastName)) {
                isValid = false;
            }
            if (!string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;


        }

        public bool Save()
        {
            return true;
        }

        // we make another Method that retreve a customer

        public Customer Retreve(int customerid) {

            return new Customer();
        }


        // we make another method to retreve a list 
        // of the customers and we use list type
        // and we return a  list
        // list of which type ?? Customer type

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }



    }
}
