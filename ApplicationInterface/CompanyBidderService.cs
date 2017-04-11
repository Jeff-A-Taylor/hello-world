using ERMABusinessLibrary.Persistence;
using System.Collections.Generic;

namespace ApplicationInterface
{
    public class CompanyBidderService
    {


        public List<string> GetCompanyBidderIdList(int companyId)
        {
            ERMABusinessLibrary.Persistence.CompanyBidderRepository persistence = new ERMABusinessLibrary.Persistence.CompanyBidderRepository();
            return persistence.GetCompanyBidderIdList(companyId);
        }

        public CompanyBidder FindByUser(string userId)
        {
            ERMABusinessLibrary.Persistence.CompanyBidderRepository persistence = new ERMABusinessLibrary.Persistence.CompanyBidderRepository();
            return persistence.FindByUser(userId);
        }

        public CompanyBidder FindByUserName(string userName)
        {
            ERMABusinessLibrary.Persistence.CompanyBidderRepository persistence = new ERMABusinessLibrary.Persistence.CompanyBidderRepository();
            return persistence.FindByUserName(userName);
        }

        public void RemoveUser(string userId)
        {
            ERMABusinessLibrary.Persistence.CompanyBidderRepository persistence = new ERMABusinessLibrary.Persistence.CompanyBidderRepository();
            persistence.RemoveUser(userId);
        }

        /// <summary>
        /// Only allow a user to be assigned to one company
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public int AddExclusive(string userId, int companyId)
        {
            ERMABusinessLibrary.Persistence.CompanyBidderRepository persistence = new ERMABusinessLibrary.Persistence.CompanyBidderRepository();
            return persistence.AddExclusive(userId, companyId);
        }
    }
}
