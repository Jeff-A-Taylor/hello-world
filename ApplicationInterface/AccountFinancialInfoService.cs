using ERMABusinessLibrary.Persistence;
using System.Collections.Generic;

namespace ApplicationInterface
{
    public class AccountFinancialInfoService
    {
        public List<spGetAccountFinancialInfoResult> getAccountFinancialInfoByAcctId(int acctId)
        {
            List<spGetAccountFinancialInfoResult> list = new List<spGetAccountFinancialInfoResult>();
            ERMABusinessLibrary.Persistence.AccountFinancialInfoRepository persistence = new ERMABusinessLibrary.Persistence.AccountFinancialInfoRepository();
            list = persistence.getAccountFinancialInfoByAcctId(acctId);
            return list;
        }

        public List<AccountFinancialInfo> getAllAccountFinancialInfo()
        {
            List<AccountFinancialInfo> list = new List<AccountFinancialInfo>();
            ERMABusinessLibrary.Persistence.AccountFinancialInfoRepository persistence = new ERMABusinessLibrary.Persistence.AccountFinancialInfoRepository();
            list = persistence.getAllAccountFinancialInfo();
            return list;
        }


        /*
         * jat - ERMA-380 - This method deletes account financial information from the database
         */
        public void DeleteAccountFinancialInformation(int accountId)
        {
            ERMABusinessLibrary.Persistence.AccountFinancialInfoRepository persistence = new ERMABusinessLibrary.Persistence.AccountFinancialInfoRepository();
            persistence.DeleteAccountFinancialInformation(accountId);
        }

        /*
         * jat - ERMA-380 - This method saves account financial information to the database
         */
        public void UpdateAccountFinancialInformation(string lineItemNumber, string lineItemPercentage, string saveBy, int accountId, string glAccount, string fund, string costCenter, string order, string wbsElement)
        {
            ERMABusinessLibrary.Persistence.AccountFinancialInfoRepository persistence = new ERMABusinessLibrary.Persistence.AccountFinancialInfoRepository();
            persistence.UpdateAccountFinancialInformation(lineItemNumber, lineItemPercentage, saveBy, accountId, glAccount, fund, costCenter, order, wbsElement);
        }
    }
}
