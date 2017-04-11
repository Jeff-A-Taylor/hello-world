using ERMABusinessLibrary;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;

namespace ApplicationInterface
{
    public class AccountService
    {
        public List<HistoricalAccountNumber> GetHistoricalAccountNumbersByAccount(int accountID)
        {
            List<HistoricalAccountNumber> list = new List<HistoricalAccountNumber>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetHistoricalAccountNumbersByAccount(accountID);
            return list;
        }

        public List<EmailNotification> GetEmailNotifications(int accountID)
        {
            List<EmailNotification> list = new List<EmailNotification>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetEmailNotifications(accountID);
            return list;
        }

        public void UpdateEmailNotification(int Id, DateTime DateToSend, string FromEmailAddress, bool Sent,
            string ToEmailAddresses, string EmailSubject, string EmailBody, int AccountID)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.UpdateEmailNotification(Id, DateToSend, FromEmailAddress, Sent, ToEmailAddresses, EmailSubject, EmailBody, AccountID);
        }

        public int InsertEmailNotification(DateTime DateToSend, string FromEmailAddress, string ToEmailAddresses, string EmailSubject, string EmailBody, int AccountID)
        {
            int result = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.InsertEmailNotification(DateToSend, FromEmailAddress, ToEmailAddresses, EmailSubject, EmailBody, AccountID);
            return result;
        }

        public void DeleteEmailNotification(int Id)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.DeleteEmailNotification(Id);
        }

        public void DeleteHistoricalAccountNumber(int accountID, int ID)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.DeleteHistoricalAccountNumber(accountID, ID);
        }

        public void UpdateHistoricalAccountNumber(int accountID, int ID, DateTime expired, string accountNumber)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.UpdateHistoricalAccountNumber(accountID, ID, expired, accountNumber);
        }

        public List<spAccountResult> GetList(bool onlyActiveAccounts, string searchCriteria, bool includeSupplyAccount,
            string sortExpression, int commodityTypeID, string userId, bool includeDemand, bool searchComments)
        {
            List<spAccountResult> list = new List<spAccountResult>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetList(onlyActiveAccounts, searchCriteria, includeSupplyAccount,
            sortExpression, commodityTypeID, userId, includeDemand, searchComments);
            return list;
        }

        public spAccountResult GetAccountSummary(string accountNumber, string UserId, bool requireExactMatch,
            int commodityTypeID) //ERMA ticket JIRA-192
        {
            spAccountResult result = new spAccountResult();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.GetAccountSummary(accountNumber, UserId, requireExactMatch, commodityTypeID);
            return result;
        }

        public List<View_Account> GetAccountSummaries(string accountNumber, string UserId, bool? includeInactiveAccounts,
            int commodityTypeID)
        {
            List<View_Account> list = new List<View_Account>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetAccountSummaries(accountNumber, UserId, includeInactiveAccounts, commodityTypeID);
            return list;
        }

        public spAccountResult GetAccountSummaryByCustomerNumberForBidPackage(string customerNumber,
            bool? includeInactiveAccounts, bool requireExactMatch, int commodityTypeID)
        {
            spAccountResult result = new spAccountResult();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.GetAccountSummaryByCustomerNumberForBidPackage(customerNumber, includeInactiveAccounts, requireExactMatch, commodityTypeID);
            return result;
        }

        public spAccountResult GetAccountSummaryByCustomerNumberForBidPackage(string customerNumber,
            bool? includeInactiveAccounts, bool requireExactMatch, int commodityTypeID, int bidPackageId)
        {
            spAccountResult result = new spAccountResult();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.GetAccountSummaryByCustomerNumberForBidPackage(customerNumber, includeInactiveAccounts, requireExactMatch, commodityTypeID, bidPackageId);
            return result;
        }

        public View_Account GetAccountSummaryByCustomerNumber(string customerNumber, string UserId,
            bool? includeInactiveAccounts, bool requireExactMatch)
        {
            View_Account result = new View_Account();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.GetAccountSummaryByCustomerNumber(customerNumber, UserId, includeInactiveAccounts, requireExactMatch);
            return result;
        }

        public View_Account GetViewAccount(int accountID)
        {
            View_Account result = new View_Account();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.GetViewAccount(accountID);
            return result;
        }

        // This method returns the corresponding supply or utility account with the
        // same LocationID as the given AccountID.
        public View_Account GetCorrespondingViewAccount(int locationId, int accountId)
        {
            View_Account result = new View_Account();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.GetCorrespondingViewAccount(locationId, accountId);
            return result;
        }

        public IEnumerable<spAccountResult> GetAccounts(string UserId)
        {
            List<spAccountResult> list = new List<spAccountResult>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetAccounts(UserId);
            return list;
        }

        public IEnumerable<Account> GetAccountsByAccountNumber(string accountNumber)
        {
            List<Account> list = new List<Account>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetAccountsByAccountNumber(accountNumber);
            return list;
        }

        public IEnumerable<Account> GetAccountsByCustomerNumber(string customerNumber, int ignoreAccountID, int commodityTypeID)
        {
            List<Account> list = new List<Account>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetAccountsByCustomerNumber(customerNumber, ignoreAccountID, commodityTypeID);
            return list;
        }

        public Account GetAccount(string accountNumber, int commodityTypeID)
        {
            Account account = new Account();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            account = persistence.GetAccount(accountNumber, commodityTypeID);
            return account;
        }

        // the customerNumber parameter is a comma-separated string of multiple customer numbers
        public Account GetAccount(string accountNumber, string customerNumber, int commodityTypeID)
        {
            Account account = new Account();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            account = persistence.GetAccount(accountNumber, customerNumber, commodityTypeID);
            return account;
        }

        public int GetLocationID(int accountID)
        {
            int locationID = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            locationID = persistence.GetLocationID(accountID);
            return locationID;
        }

        public int GetAccountID(int locationId)
        {
            int accountID = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            accountID = persistence.GetAccountID(locationId);
            return accountID;
        }

        public int GetLocationID(string accountNumber, bool? activeAccountsOnly)
        {
            int locationID = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            locationID = persistence.GetLocationID(accountNumber, activeAccountsOnly);
            return locationID;
        }

        public int GetLocationID(string accountNumber, int bidPackageId, bool? activeAccountsOnly)
        {
            int locationID = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            locationID = persistence.GetLocationID(accountNumber, bidPackageId, activeAccountsOnly);
            return locationID;
        }

        public int GetBidPackageAccountID(string accountNumber, int bidPackageId, bool? activeAccountsOnly)
        {
            int bidPackageAccountID = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            bidPackageAccountID = persistence.GetBidPackageAccountID(accountNumber, bidPackageId, activeAccountsOnly);
            return bidPackageAccountID;
        }

        public int GetTariffID(int companyID, string rate)
        {
            int tariffID = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            tariffID = persistence.GetTariffID(companyID, rate);
            return tariffID;
        }

        public int GetExistingTariffID(int accountID)
        {
            int tariffID = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            tariffID = persistence.GetExistingTariffID(accountID);
            return tariffID;
        }

        public List<string> GetAgencies()
        {
            List<string> list = new List<string>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetAgencies();
            return list;
        }

        public List<string> GetAgenciesWithBasisContracts(List<int> companyIDs)
        {
            List<string> list = new List<string>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetAgenciesWithBasisContracts(companyIDs);
            return list;
        }

        public IDictionary<int, string> GetAgenciesDictionary(string userName)
        {
            IDictionary<int, string> dictionary = new Dictionary<int, string>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            dictionary = persistence.GetAgenciesDictionary(userName);
            return dictionary;
        }

        public IList<FacilityFromAccount> GetFacilityInformation(int accountId, string userId)
        {
            IList<FacilityFromAccount> list = new List<FacilityFromAccount>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetFacilityInformation(accountId, userId);
            return list;
        }

        public IList<FacilityFromAccount> GetFacilityInformation(string accountNumberOrCustomerNumber, string userId)
        {
            IList<FacilityFromAccount> list = new List<FacilityFromAccount>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetFacilityInformation(accountNumberOrCustomerNumber, userId);
            return list;
        }

        public List<tblFacilityMaster> GetFacilities(string departmentCode)
        {
            List<tblFacilityMaster> list = new List<tblFacilityMaster>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetFacilities(departmentCode);
            return list;
        }

        public int InsertLocation(int serviceAddressID, int billingAddressID, string commonwealthLocationCode,
            bool isActive)
        {
            int result = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.InsertLocation(serviceAddressID, billingAddressID, commonwealthLocationCode, isActive);
            return result;
        }

        public Account InsertAccount(Account account)
        {
            Account acct = new Account();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            acct = persistence.InsertAccount(account);
            return acct;
        }

        public void InsertAccountTariff(AccountTariff accountRateClass)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.InsertAccountTariff(accountRateClass);
        }

        public void UpdateAccountActiveness(int accountID, bool isActive)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.UpdateAccountActiveness(accountID, isActive);
        }

        public Account GetAccount(int accountId)
        {
            Account acct = new Account();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            acct = persistence.GetAccount(accountId);
            return acct;
        }

        public int GetCurrentAccountId(int locationId, bool isSupplyAccount)
        {
            int result = 0;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.GetCurrentAccountId(locationId, isSupplyAccount);
            return result;
        }

        public void UpdateAccountNumber(int accountId, string newAccountNumber)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.UpdateAccountNumber(accountId, newAccountNumber);
        }

        public void SetAccountInactive(int accountId, bool isActive)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.SetAccountInactive(accountId, isActive);
        }

        //
        // This method accepts an array of active customerNumber strings.  It flags any
        // AccountCustomerNumber rows as inactive whose AccountCustomerNumber.CustomerNumber
        // aren't in the customerNumbers array.
        //
        public void FlagUnusedCustomerNumbersAsInactive(string[] customerNumbers, int accountId)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.FlagUnusedCustomerNumbersAsInactive(customerNumbers, accountId);
        }

        public void SaveCustomerNumbers(string[] customerNumbers, int accountId, bool isActive)
        {
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            persistence.SaveCustomerNumbers(customerNumbers, accountId, isActive);
        }

        // This method accepts the specified parameters, converts them to Table Value Parameters (TVP),
        // invokes the stored procedure and translates the results back in a list of FacilityCostAndUse.
        public IEnumerable<FacilityCostAndUse> GetFacilityCostAndUse(List<int> selectedCommodities,
                                                                     string deptCode,
                                                                     DateTime? startDate,
                                                                     DateTime? endDate,
                                                                     string commaSepFacCodes, // comma separated list of FacCode values
                                                                     string userId
                                                                    )
        {
            IEnumerable<FacilityCostAndUse> list = new List<FacilityCostAndUse>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetFacilityCostAndUse(selectedCommodities, deptCode, startDate, endDate, commaSepFacCodes, userId);
            return list;
        }

        // This method accepts the specified parameters, converts them to Table Value Parameters (TVP),
        // invokes the stored procedure and translates the results back in a list of AccountMonthlyCostAndUse.
        public IEnumerable<AccountMonthlyCostAndUse> GetAccountMonthlyCostAndUse(List<int> selectedCommodities,
                                                                     string deptCode,
                                                                     DateTime? startDate,
                                                                     DateTime? endDate,
                                                                     string commaSepFacCodes, // comma separated list of FacCode values
                                                                     string userId
                                                                    )
        {
            IEnumerable<AccountMonthlyCostAndUse> list = new List<AccountMonthlyCostAndUse>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetAccountMonthlyCostAndUse(selectedCommodities, deptCode, startDate, endDate, commaSepFacCodes, userId);
            return list;
        }

        // This method accepts the specified parameters, converts them to Table Value Parameters (TVP),
        // invokes the stored procedure and translates the results back in a list of AccountCostAndUse.
        public IEnumerable<AccountCostAndUse> GetAccountCostAndUse(List<int> selectedCommodities,
                                                                     string deptCode,
                                                                     DateTime? startDate,
                                                                     DateTime? endDate,
                                                                     string commaSepFacCodes, // comma separated list of FacCode values
                                                                     string userId
                                                                    )
        {
            IEnumerable<AccountCostAndUse> list = new List<AccountCostAndUse>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetAccountCostAndUse(selectedCommodities, deptCode, startDate, endDate, commaSepFacCodes, userId);
            return list;
        }

        public List<Account> GetGasAccountsWithContracts(DateTime? startDate, DateTime? endDate, string commaSeparatedFacilityCodes)
        {
            List<Account> list = new List<Account>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetGasAccountsWithContracts(startDate, endDate, commaSeparatedFacilityCodes);
            return list;
        }

        public List<spGetMergeAccountsResult> GetMergeAccounts(bool onlyActiveAccounts, string searchCriteria, bool includeSupplyAccount, List<int> commodityTypeIDs)
        {
            List<spGetMergeAccountsResult> list = new List<spGetMergeAccountsResult>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetMergeAccounts(onlyActiveAccounts, searchCriteria, includeSupplyAccount, commodityTypeIDs);
            return list;
        }

        public bool MergeAccounts(int keepAccountID, int removeAccountID)
        {
            bool result = false;
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            result = persistence.MergeAccounts(keepAccountID, removeAccountID);
            return result;
        }

        public List<spGetGasAccountNumberAndIDsFromFacilitiesResult> GetAccountNumbersAndIdsFromFacilities(List<int> companyIds, List<int> facCodes)
        {
            List<spGetGasAccountNumberAndIDsFromFacilitiesResult> list = new List<spGetGasAccountNumberAndIDsFromFacilitiesResult>();
            ERMABusinessLibrary.Persistence.AccountRepository persistence = new ERMABusinessLibrary.Persistence.AccountRepository();
            list = persistence.GetAccountNumbersAndIdsFromFacilities(companyIds, facCodes);
            return list;
        }
    }
}
