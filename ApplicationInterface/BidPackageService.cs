using ERMABusinessLibrary.Commodities;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;

namespace ApplicationInterface
{
    public class BidPackageService
    {
        public List<spBidPackageResult> GetBidPackagesForUser(Commodity commodityType, int RFQId, string searchCriteria, string sortExpression, string UserId)
        {
            List<spBidPackageResult> list = new List<spBidPackageResult>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetBidPackagesForUser(commodityType, RFQId, searchCriteria, sortExpression, UserId);
            return list;
        }

        public List<BidPackageBidTermLength> GetBidPackageBidTermLengths(int bidPackageId)
        {
            List<BidPackageBidTermLength> list = new List<BidPackageBidTermLength>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetBidPackageBidTermLengths(bidPackageId);
            return list;
        }

        public List<spBidPackageResult> GetBidPackages(Commodity commodityType, int RFQId, string searchCriteria, string sortExpression, string UserId, bool IncludeInactive)
        {
            List<spBidPackageResult> list = new List<spBidPackageResult>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetBidPackages(commodityType, RFQId, searchCriteria, sortExpression, UserId, IncludeInactive);
            return list;
        }

        public bool IsBidPackageAwarded(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.IsBidPackageAwarded(bidPackageId);
        }

        public int? GetAwardedSupplierCompanyId(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.GetAwardedSupplierCompanyId(bidPackageId);
        }

        public void NonAward(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            persistence.NonAward(bidPackageId);
        }

        public void ReverseNonAward(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            persistence.ReverseNonAward(bidPackageId);
        }

        public void Update(BidPackage bidPackage)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            persistence.Update(bidPackage);
        }

        public List<BidPricingType> GetBidPricingTypeList()
        {
            List<BidPricingType> list = new List<BidPricingType>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetBidPricingTypeList();
            return list;
        }

        public List<BidPricingType> GetElectricBidPricingTypeList(int rfqTypeID)
        {
            List<BidPricingType> list = new List<BidPricingType>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetElectricBidPricingTypeList(rfqTypeID);
            return list;
        }

        public List<BidPricingType> GetNaturalBidPricingTypeList()
        {
            List<BidPricingType> list = new List<BidPricingType>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetNaturalBidPricingTypeList();
            return list;
        }

        public void AddRange(List<BidPackageAccount> newAccounts)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            persistence.AddRange(newAccounts);
        }

        public int Add(BidPackage bidPackage)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.Add(bidPackage);
        }

        public int GetBidPackageIndex(int rfqId, int bidPackageId, bool includeInactiveBidPackages)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.GetBidPackageIndex(rfqId, bidPackageId, includeInactiveBidPackages);
        }

        public int GetRFQBidPackageCount(int rfqId, bool includeInactiveBidPackages)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.GetRFQBidPackageCount(rfqId, includeInactiveBidPackages);
        }

        public int GetBidPackageIdAtIndex(int rfqId, int index, bool includeInactiveBidPackages)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.GetBidPackageIdAtIndex(rfqId, index, includeInactiveBidPackages);
        }

        public int GetRFQId(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.GetRFQId(bidPackageId);
        }

        public string GetBidPricingType(int bidPricingTypeId)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.GetBidPricingType(bidPricingTypeId);
        }

        public List<BidPackageAccount> GetBidPackageAccounts(int bidPackageId)
        {
            List<BidPackageAccount> list = new List<BidPackageAccount>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetBidPackageAccounts(bidPackageId);
            return list;
        }

        public List<View_Account> GetBidPackageAccountViews(int bidPackageId)
        {
            List<View_Account> list = new List<View_Account>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetBidPackageAccountViews(bidPackageId);
            return list;
        }

        public void RemoveBidPackageAccount(int bidPackageAccountId)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            persistence.RemoveBidPackageAccount(bidPackageAccountId);
        }

        public spBidPackageResult GetBidPackage(int bidPackageId)
        {
            spBidPackageResult result = new spBidPackageResult();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            result = persistence.GetBidPackage(bidPackageId);
            return result;
        }

        public void RemoveBidPackage(int ID)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            persistence.RemoveBidPackage(ID);
        }

        public void SetAwardNoticesSent(bool noticesSent, int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            persistence.SetAwardNoticesSent(noticesSent, bidPackageId);
        }

        // This method starts an asynchronous stored procedure to
        // validate the specified bid package.  It returns false
        // if unable to start the process.
        public bool StartBidPackageValidation(int bidPackageId, bool regatherBillsIntervalData)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return StartBidPackageValidation(bidPackageId, regatherBillsIntervalData);
        }

        // This method starts an asynchronous stored procedure to
        // validate the specified bid package.  It returns false
        // if unable to start the process.
        public bool StartBidPackageCalculation(List<int> bidPackageIds, bool regatherBillsIntervalData)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return StartBidPackageCalculation(bidPackageIds, regatherBillsIntervalData);
        }

        public List<spGetValidationFindingTypesResult> GetValidationFindingTypes(int bidPackageID)
        {
            List<spGetValidationFindingTypesResult> list = new List<spGetValidationFindingTypesResult>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetValidationFindingTypes(bidPackageID);
            return list;
        }

        // this method unsets the verified flag for the given validation finding
        public void UnverifyValidationFinding(int id)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            persistence.UnverifyValidationFinding(id);
        }

        // this method flags the given validation finding as verified
        public void VerifyValidationFinding(int id, string userName)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            persistence.VerifyValidationFinding(id, userName);
        }

        public List<spGetValidationFindingsResult> GetValidationFindings(int bidPackageId, List<int> validationFindingTypes)
        {
            List<spGetValidationFindingsResult> list = new List<spGetValidationFindingsResult>();
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            list = persistence.GetValidationFindings(bidPackageId, validationFindingTypes);
            return list;
        }

        // This method creates a new bid package by copying the existing bid package.
        // It returns the new bid package's ID.  It does a "deep" copy in that all 
        // included accounts, price to compares, etc are also copied.
        public int CopyBidPackage(int existingBidPackageId, DateTime requestedDeliveryStartDate, int newRFQID)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.CopyBidPackage(existingBidPackageId, requestedDeliveryStartDate, newRFQID);
        }

        public spERMAGetAccountForBidPackageByAccountAndCustomerNumberResult GetAccountForBidPackageByAccountAndCustomerNumber(string accountNumber, string customerNumber, bool includeInactiveAccounts, bool requireExactMatch, int commodityTypeID)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.GetAccountForBidPackageByAccountAndCustomerNumber(accountNumber, customerNumber, includeInactiveAccounts, requireExactMatch, commodityTypeID);
        }

        // This method accepts a list of <AccountNumber,CustomerNumber> tuples to add to the 
        // corresponding bid package.  If AccountNumber and CustomerNumber are specified it tries to find
        // an account with both values.  If just 1 value is specified, it tries to find an account with 
        // that 1 value.
        // It returns the number of accounts added, and a list of account numbers (or customer numbers if the
        // account number wasn't specified) that were unable to be added.
        public Tuple<int, List<string>> BulkImportAccounts(int bidPackageID, List<Tuple<string, string>> accountNumbersCustomerNumbersToInsert, bool requireExactMatch, int commodityTypeID)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.BulkImportAccounts(bidPackageID, accountNumbersCustomerNumbersToInsert, requireExactMatch, commodityTypeID);
        }

        public List<int> GetBidPackageAttachmentIDs(int bidPackageID)
        {
            ERMABusinessLibrary.Persistence.BidPackageRepository persistence = new ERMABusinessLibrary.Persistence.BidPackageRepository();
            return persistence.GetBidPackageAttachmentIDs(bidPackageID);
        }
    }
}
