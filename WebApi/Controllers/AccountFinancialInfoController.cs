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
    public class AccountFinancialInfoController : ApiController
    {
        public List<spGetAccountFinancialInfoResult> getAccountFinancialInfoByAcctId(int acctId)
        {
            AccountFinancialInfoService service = new AccountFinancialInfoService();
            return service.getAccountFinancialInfoByAcctId(acctId);

        }

        public List<AccountFinancialInfo> getAllAccountFinancialInfo()
        {
            AccountFinancialInfoService service = new AccountFinancialInfoService();
            return service.getAllAccountFinancialInfo();
        }


        /*
         * jat - ERMA-380 - This method deletes account financial information from the database
         */
        public void DeleteAccountFinancialInformation(int accountId)
        {
            AccountFinancialInfoService service = new AccountFinancialInfoService();
            service.DeleteAccountFinancialInformation(accountId);
        }

        /*
         * jat - ERMA-380 - This method saves account financial information to the database
         */
        public void UpdateAccountFinancialInformation(string lineItemNumber, string lineItemPercentage, string saveBy, int accountId, string glAccount, string fund, string costCenter, string order, string wbsElement)
        {
            AccountFinancialInfoService service = new AccountFinancialInfoService();
            service.UpdateAccountFinancialInformation(lineItemNumber, lineItemPercentage, saveBy, accountId, glAccount, fund, costCenter, order, wbsElement);
        }
    }
}
