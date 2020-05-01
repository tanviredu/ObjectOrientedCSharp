﻿using System;

namespace ACM.BL
{
    public class Customer
    {
        
        // this is Customer type
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerId { get; private set; }
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
    }
}
