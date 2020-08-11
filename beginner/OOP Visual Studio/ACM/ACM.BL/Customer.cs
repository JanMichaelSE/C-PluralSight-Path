using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {

        public int CustomerId { get; private set; }
        public List<Address> AddressList { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public int CustomerType { get; set; }

        // We do not use backing field  because it doesnt hold any additional data
        public string FullName { 
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            } 
        }

        public static int InstanceCount { get; set; }

        // Backing field
        private string _lastName;

        // Property field
        public string LastName { get => _lastName; set => _lastName = value; }


        public Customer() : this(0) // This is constructor chaining
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public string Log()
        {
            return $"{CustomerId}: {FullName}, Email: {EmailAddress}, Status: {EntityState.ToString()}";
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            
            return isValid;
            
        }

        
    }
}
