using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            // Pass in the requested id
            Address address = new Address(addressId);

            // Code that retrieves the defined address

            // Temporary hard-coded values to return
            // a population address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag end";
                address.StreetLine2 = "Bagshort row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = " 00987";


            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses for customer


            // Temporary hard coded values
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag end",
                StreetLine2 = "Bagshort row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = " 00987"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Frodo end",
                StreetLine2 = "Frodo row",
                City = "Hobbi",
                State = "Shining",
                Country = "First Earth",
                PostalCode = " 03100"
            };

            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            // Code that saves the defined address here

            return true;
        }
    }
}
