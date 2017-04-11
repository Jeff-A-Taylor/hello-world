using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ApplicationInterface;
using ERMABusinessLibrary.Persistence;

namespace WebApi.Controllers
{
    public class AccountController : ApiController
    {
        public string GetString()
        {
            return "it works";
        }
        public List<spAccountResult> GetList(bool onlyActiveAccounts, string searchCriteria, bool includeSupplyAccount,
            string sortExpression, int commodityTypeID, string userId, bool includeDemand, bool searchComments)
        {
            AccountService service = new AccountService();
            return service.GetList(onlyActiveAccounts, searchCriteria, includeSupplyAccount, sortExpression, commodityTypeID, userId, includeDemand, searchComments);
        }

        public spAccountResult GetAccountSummary(string accountNumber, string UserId, bool requireExactMatch,
            int commodityTypeID) //ERMA ticket JIRA-192
        {
            AccountService service = new AccountService();
            return service.GetAccountSummary(accountNumber, UserId, requireExactMatch, commodityTypeID);
        }

        public List<View_Account> GetAccountSummaries(string accountNumber, string UserId, bool? includeInactiveAccounts,
            int commodityTypeID)
        {
            AccountService service = new AccountService();
            return service.GetAccountSummaries(accountNumber, UserId, includeInactiveAccounts, commodityTypeID);
        }

        public spAccountResult GetAccountSummaryByCustomerNumberForBidPackage(string customerNumber,
            bool? includeInactiveAccounts, bool requireExactMatch, int commodityTypeID)
        {
            AccountService service = new AccountService();
            return service.GetAccountSummaryByCustomerNumberForBidPackage(customerNumber, includeInactiveAccounts, requireExactMatch, commodityTypeID);
        }

        public spAccountResult GetAccountSummaryByCustomerNumberForBidPackage(string customerNumber,
            bool? includeInactiveAccounts, bool requireExactMatch, int commodityTypeID, int bidPackageId)
        {
            AccountService service = new AccountService();
            return service.GetAccountSummaryByCustomerNumberForBidPackage(customerNumber, includeInactiveAccounts, requireExactMatch, commodityTypeID, bidPackageId);
        }

        public View_Account GetAccountSummaryByCustomerNumber(string customerNumber, string UserId,
            bool? includeInactiveAccounts, bool requireExactMatch)
        {
            AccountService service = new AccountService();
            return service.GetAccountSummaryByCustomerNumber(customerNumber, UserId, includeInactiveAccounts, requireExactMatch);
        }

        public View_Account GetViewAccount(int accountID)
        {
            AccountService service = new AccountService();
            return service.GetViewAccount(accountID);
        }

        // This method returns the corresponding supply or utility account with the
        // same LocationID as the given AccountID.
        public View_Account GetCorrespondingViewAccount(int locationId, int accountId)
        {
            AccountService service = new AccountService();
            return service.GetCorrespondingViewAccount(locationId, accountId);
        }

        public IEnumerable<spAccountResult> GetAccounts(string UserId)
        {
            AccountService service = new AccountService();
            return service.GetAccounts(UserId);
        }

        public IEnumerable<Account> GetAccountsByAccountNumber(string accountNumber)
        {
            AccountService service = new AccountService();
            return service.GetAccountsByAccountNumber(accountNumber);
        }

        public IEnumerable<Account> GetAccountsByCustomerNumber(string customerNumber, int ignoreAccountID, int commodityTypeID)
        {
            AccountService service = new AccountService();
            return service.GetAccountsByCustomerNumber(customerNumber, ignoreAccountID, commodityTypeID);
        }

        public Account GetAccount(string accountNumber, int commodityTypeID)
        {
            AccountService service = new AccountService();
            return service.GetAccount(accountNumber, commodityTypeID);
        }

        // the customerNumber parameter is a comma-separated string of multiple customer numbers
        public Account GetAccount(string accountNumber, string customerNumber, int commodityTypeID)
        {
            AccountService service = new AccountService();
            return service.GetAccount(accountNumber, customerNumber, commodityTypeID);
        }
    }
}
