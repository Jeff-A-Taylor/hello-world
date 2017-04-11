using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class PersonService
    {
        public int Insert(string providerUserKey, int addressId, string firstName, string middleName, string lastName,
            string suffix, string officePhone, string mobilePhone, string fax, string email, string companyName, string facility)
        {
            ERMABusinessLibrary.Persistence.PersonRepository persistence = new ERMABusinessLibrary.Persistence.PersonRepository();
            return persistence.Insert(providerUserKey, addressId, firstName, middleName, lastName,
            suffix, officePhone, mobilePhone, fax, email, companyName, facility);
        }

        public Person GetPerson(string webSiteUserId)
        {
            ERMABusinessLibrary.Persistence.PersonRepository persistence = new ERMABusinessLibrary.Persistence.PersonRepository();
            return persistence.GetPerson(webSiteUserId);
        }

        public void Delete(int personId)
        {
            ERMABusinessLibrary.Persistence.PersonRepository persistence = new ERMABusinessLibrary.Persistence.PersonRepository();
            persistence.Delete(personId);
        }

        public int? GetFailedPasswordAttemptCount(string userName)
        {
            ERMABusinessLibrary.Persistence.PersonRepository persistence = new ERMABusinessLibrary.Persistence.PersonRepository();
            return persistence.GetFailedPasswordAttemptCount(userName);
        }

        public bool UpdatePerson(string userName, string email, string firstName, string middleName, string lastName,
            string suffix, string address1, string address2, string address3, string city, string state, string zip, string phone,
            string mobilePhone, string fax)
        {
            ERMABusinessLibrary.Persistence.PersonRepository persistence = new ERMABusinessLibrary.Persistence.PersonRepository();
            return persistence.UpdatePerson(userName, email, firstName, middleName, lastName,
            suffix, address1, address2, address3, city, state, zip, phone,
            mobilePhone, fax);
        }
    }
}
