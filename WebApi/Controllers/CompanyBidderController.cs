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
    public class CompanyBidderController : ApiController
    {
        public List<string> GetCompanyBidderIdList(int companyId)
        {
            CompanyBidderService service = new CompanyBidderService();
            return service.GetCompanyBidderIdList(companyId);
        }

        public CompanyBidder FindByUser(string userId)
        {
            CompanyBidderService service = new CompanyBidderService();
            return service.FindByUser(userId);
        }

        public CompanyBidder FindByUserName(string userName)
        {
            CompanyBidderService service = new CompanyBidderService();
            return service.FindByUserName(userName);
        }

        public void RemoveUser(string userId)
        {
            CompanyBidderService service = new CompanyBidderService();
            service.RemoveUser(userId);
        }

        /// <summary>
        /// Only allow a user to be assigned to one company
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public int AddExclusive(string userId, int companyId)
        {
            CompanyBidderService service = new CompanyBidderService();
            return service.AddExclusive(userId, companyId);
        }
    }
}
