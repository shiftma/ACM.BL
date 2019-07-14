using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrive(int Id)
        {
            Address address = new Address();

            if(Id == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bagaboo";
                address.StreetLine2 = "Nemogu";
                address.City = "Kansas";
                address.Country = "US";
                address.PostalCode = "12345";
            };

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId (int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bagaboo",
                StreetLine2 = "Nemogu",
                City = "Kansas",
                Country = "US",
                PostalCode = "12345"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Pickapoo",
                StreetLine2 = "Lyamur",
                City = "Kansas",
                Country = "US",
                PostalCode = "12345"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
