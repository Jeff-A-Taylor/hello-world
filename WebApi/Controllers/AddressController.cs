using ApplicationInterface;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class AddressController : ApiController
    {
        public int InsertAddress(int addressId, string address1, string address2, string address3, string city, string state, string zip)
        {
            AddressService service = new AddressService();
            return service.InsertAddress(addressId, address1, address2, address3, city, state, zip);

        }

        public int InsertAddress(string address1, string address2, string address3, string city, string state, string zip)
        {
            AddressService service = new AddressService();
            return service.InsertAddress(address1, address2, address3, city, state, zip);
        }

        public int InsertAddress(Address address)
        {
            AddressService service = new AddressService();
            return service.InsertAddress(address);
        }

        public void UpdateServiceAddress(int locationId, Address newServiceAddress)
        {
            AddressService service = new AddressService();
            service.UpdateServiceAddress(locationId, newServiceAddress);
        }

        public void UpdateBillingAddress(int locationId, Address newBillingAddress)
        {
            AddressService service = new AddressService();
            service.UpdateBillingAddress(locationId, newBillingAddress);
        }
    }
}
