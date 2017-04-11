using ERMABusinessLibrary.Persistence;

namespace ApplicationInterface
{
    public class AddressService
    {
        public int InsertAddress(int addressId, string address1, string address2, string address3, string city, string state, string zip)
        {
            ERMABusinessLibrary.Persistence.AddressRepository persistence = new ERMABusinessLibrary.Persistence.AddressRepository();
            return persistence.InsertAddress(addressId, address1, address2, address3, city, state, zip);
        }

        public int InsertAddress(string address1, string address2, string address3, string city, string state, string zip)
        {
            ERMABusinessLibrary.Persistence.AddressRepository persistence = new ERMABusinessLibrary.Persistence.AddressRepository();
            return persistence.InsertAddress(address1, address2, address3, city, state, zip);
        }

        public int InsertAddress(Address address)
        {
            ERMABusinessLibrary.Persistence.AddressRepository persistence = new ERMABusinessLibrary.Persistence.AddressRepository();
            return persistence.InsertAddress(address);
        }

        public void UpdateServiceAddress(int locationId, Address newServiceAddress)
        {
            ERMABusinessLibrary.Persistence.AddressRepository persistence = new ERMABusinessLibrary.Persistence.AddressRepository();
            persistence.UpdateServiceAddress(locationId, newServiceAddress);
        }

        public void UpdateBillingAddress(int locationId, Address newBillingAddress)
        {
            ERMABusinessLibrary.Persistence.AddressRepository persistence = new ERMABusinessLibrary.Persistence.AddressRepository();
            persistence.UpdateBillingAddress(locationId, newBillingAddress);
        }
    }
}
