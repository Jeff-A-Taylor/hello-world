using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ERMABusinessLibrary.Persistence;
using ApplicationInterface;
using ERMABusinessLibrary.Commodities;

namespace WebApi.Controllers
{
    public class BidPackageController : ApiController
    {
        [HttpGet]
        public List<spBidPackageResult> GetBidPackagesForUser(Commodity commodityType, int RFQId, string searchCriteria, string sortExpression, string UserId)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPackagesForUser(commodityType, RFQId, searchCriteria, sortExpression, UserId);
        }

        public List<BidPackageBidTermLength> GetBidPackageBidTermLengths(int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPackageBidTermLengths(bidPackageId);
        }

        public List<spBidPackageResult> GetBidPackages(Commodity commodityType, int RFQId, string searchCriteria, string sortExpression, string UserId, bool IncludeInactive)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPackages(commodityType, RFQId, searchCriteria, sortExpression, UserId, IncludeInactive);
        }

        public bool IsBidPackageAwarded(int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            return service.IsBidPackageAwarded(bidPackageId);
        }

        public int? GetAwardedSupplierCompanyId(int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            return service.GetAwardedSupplierCompanyId(bidPackageId);
        }

        public void NonAward(int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            service.NonAward(bidPackageId);
        }

        public void ReverseNonAward(int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            service.ReverseNonAward(bidPackageId);
        }

        public void Update(BidPackage bidPackage)
        {
            BidPackageService service = new BidPackageService();
            service.Update(bidPackage);
        }

        public List<BidPricingType> GetBidPricingTypeList()
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPricingTypeList();
        }

        public List<BidPricingType> GetElectricBidPricingTypeList(int rfqTypeID)
        {
            BidPackageService service = new BidPackageService();
            return service.GetElectricBidPricingTypeList(rfqTypeID);
        }

        public List<BidPricingType> GetNaturalBidPricingTypeList()
        {
            BidPackageService service = new BidPackageService();
            return service.GetNaturalBidPricingTypeList();
        }

        public void AddRange(List<BidPackageAccount> newAccounts)
        {
            BidPackageService service = new BidPackageService();
            service.AddRange(newAccounts);
        }

        public int Add(BidPackage bidPackage)
        {
            BidPackageService service = new BidPackageService();
            return service.Add(bidPackage);
        }

        public int GetBidPackageIndex(int rfqId, int bidPackageId, bool includeInactiveBidPackages)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPackageIndex(rfqId, bidPackageId, includeInactiveBidPackages);
        }

        public int GetRFQBidPackageCount(int rfqId, bool includeInactiveBidPackages)
        {
            BidPackageService service = new BidPackageService();
            return service.GetRFQBidPackageCount(rfqId, includeInactiveBidPackages);
        }

        public int GetBidPackageIdAtIndex(int rfqId, int index, bool includeInactiveBidPackages)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPackageIdAtIndex(rfqId, index, includeInactiveBidPackages);
        }

        public int GetRFQId(int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            return service.GetRFQId(bidPackageId);
        }

        public string GetBidPricingType(int bidPricingTypeId)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPricingType(bidPricingTypeId);
        }

        public List<BidPackageAccount> GetBidPackageAccounts(int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPackageAccounts(bidPackageId);
        }

        public List<View_Account> GetBidPackageAccountViews(int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPackageAccountViews(bidPackageId);
        }

        public void RemoveBidPackageAccount(int bidPackageAccountId)
        {
            BidPackageService service = new BidPackageService();
            service.RemoveBidPackageAccount(bidPackageAccountId);
        }

        public spBidPackageResult GetBidPackage(int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPackage(bidPackageId);
        }

        public void RemoveBidPackage(int ID)
        {
            BidPackageService service = new BidPackageService();
            service.RemoveBidPackage(ID);
        }

        public void SetAwardNoticesSent(bool noticesSent, int bidPackageId)
        {
            BidPackageService service = new BidPackageService();
            service.SetAwardNoticesSent(noticesSent, bidPackageId);
        }

        public bool StartBidPackageValidation(int bidPackageId, bool regatherBillsIntervalData)
        {
            BidPackageService service = new BidPackageService();
            return service.StartBidPackageValidation(bidPackageId, regatherBillsIntervalData);
        }

        public bool StartBidPackageCalculation(List<int> bidPackageIds, bool regatherBillsIntervalData)
        {
            BidPackageService service = new BidPackageService();
            return service.StartBidPackageCalculation(bidPackageIds, regatherBillsIntervalData);
        }

        public List<spGetValidationFindingTypesResult> GetValidationFindingTypes(int bidPackageID)
        {
            BidPackageService service = new BidPackageService();
            return service.GetValidationFindingTypes(bidPackageID);
        }

        public void UnverifyValidationFinding(int id)
        {
            BidPackageService service = new BidPackageService();
            service.UnverifyValidationFinding(id);
        }

        public void VerifyValidationFinding(int id, string userName)
        {
            BidPackageService service = new BidPackageService();
            service.VerifyValidationFinding(id, userName);
        }

        public List<spGetValidationFindingsResult> GetValidationFindings(int bidPackageId, List<int> validationFindingTypes)
        {
            BidPackageService service = new BidPackageService();
            return service.GetValidationFindings(bidPackageId, validationFindingTypes);
        }

        public int CopyBidPackage(int existingBidPackageId, DateTime requestedDeliveryStartDate, int newRFQID)
        {
            BidPackageService service = new BidPackageService();
            return service.CopyBidPackage(existingBidPackageId, requestedDeliveryStartDate, newRFQID);
        }

        public spERMAGetAccountForBidPackageByAccountAndCustomerNumberResult GetAccountForBidPackageByAccountAndCustomerNumber(string accountNumber, string customerNumber, bool includeInactiveAccounts, bool requireExactMatch, int commodityTypeID)
        {
            BidPackageService service = new BidPackageService();
            return service.GetAccountForBidPackageByAccountAndCustomerNumber(accountNumber, customerNumber, includeInactiveAccounts, requireExactMatch, commodityTypeID);
        }

        public Tuple<int, List<string>> BulkImportAccounts(int bidPackageID, List<Tuple<string, string>> accountNumbersCustomerNumbersToInsert, bool requireExactMatch, int commodityTypeID)
        {
            BidPackageService service = new BidPackageService();
            return service.BulkImportAccounts(bidPackageID, accountNumbersCustomerNumbersToInsert, requireExactMatch, commodityTypeID);
        }

        public List<int> GetBidPackageAttachmentIDs(int bidPackageID)
        {
            BidPackageService service = new BidPackageService();
            return service.GetBidPackageAttachmentIDs(bidPackageID);
        }
    }
}
