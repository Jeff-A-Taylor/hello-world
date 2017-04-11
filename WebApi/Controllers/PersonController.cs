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
    public class PersonController : ApiController
    {
        public int Insert(string providerUserKey, int addressId, string firstName, string middleName, string lastName,
            string suffix, string officePhone, string mobilePhone, string fax, string email, string companyName, string facility)
        {
            PersonService service = new PersonService();
            return service.Insert(providerUserKey, addressId, firstName, middleName, lastName,
            suffix, officePhone, mobilePhone, fax, email, companyName, facility);
        }

        public Person GetPerson(string webSiteUserId)
        {
            PersonService service = new PersonService();
            return service.GetPerson(webSiteUserId);
        }

        public void Delete(int personId)
        {
            PersonService service = new PersonService();
            service.Delete(personId);
        }

        public int? GetFailedPasswordAttemptCount(string userName)
        {
            PersonService service = new PersonService();
            return service.GetFailedPasswordAttemptCount(userName);
        }

        public bool UpdatePerson(string userName, string email, string firstName, string middleName, string lastName,
            string suffix, string address1, string address2, string address3, string city, string state, string zip, string phone,
            string mobilePhone, string fax)
        {
            PersonService service = new PersonService();
            return service.UpdatePerson(userName, email, firstName, middleName, lastName,
            suffix, address1, address2, address3, city, state, zip, phone,
            mobilePhone, fax);
        }
    }
}
