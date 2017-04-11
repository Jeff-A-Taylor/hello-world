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
    public class BidController : ApiController
    {
        public List<View_NaturalGasBid> GetNaturalGasBids(int bidPackageId, int bidItemTypeId)
        {
            BidService service = new BidService();
            return service.GetNaturalGasBids(bidPackageId, bidItemTypeId);
        }

        public View_NaturalGasBid GetNaturalGasBid(int bidId)
        {
            BidService service = new BidService();
            return service.GetNaturalGasBid(bidId);
        }

        //public void AwardSupplyAccounts(int bidPackageId, int bidId)
        //{
        //    BidService service = new BidService();
        //    return service.GetNaturalGasBids(bidPackageId, bidItemTypeId);
        //}

        //public void ReverseAwardSupplyAccounts(int bidPackageId, int bidId)
        //{
        //    BidService service = new BidService();
        //    return service.GetNaturalGasBids(bidPackageId, bidItemTypeId);
        //}

        public List<View_ElectricityFixedBid> GetFixedBids(int bidPackageId, string sortExpression)
        {
            BidService service = new BidService();
            return service.GetFixedBids(bidPackageId, sortExpression);
        }

        public List<View_DemandResponseBid> GetDemandResponseBids(int bidPackageId, string sortExpression)
        {
            BidService service = new BidService();
            return service.GetDemandResponseBids(bidPackageId, sortExpression);
        }

        public List<View_NaturalGasBid> GetNaturalGasBids(int bidPackageId, int bidItemTypeId, string UserId)
        {
            BidService service = new BidService();
            return service.GetNaturalGasBids(bidPackageId, bidItemTypeId, UserId);
        }

        public double? getBidPackagePreviousContractPerUnitCost(int bidPackageId)
        {
            BidService service = new BidService();
            return service.getBidPackagePreviousContractPerUnitCost(bidPackageId);
        }

        public double? getBidPackageAnnualSavingsVsCurrentContract(int bidId)
        {
            BidService service = new BidService();
            return service.getBidPackageAnnualSavingsVsCurrentContract(bidId);
        }

        public double? getBidPackagePreviousContractPerUnitCost(int bidPackageId, int accountId)
        {
            BidService service = new BidService();
            return service.getBidPackagePreviousContractPerUnitCost(bidPackageId, accountId);
        }

        public View_ElectricityFixedBid GetFixedBid(int bidId)
        {
            BidService service = new BidService();
            return service.GetFixedBid(bidId);
        }

        public View_ElectricityBlockAndIndexBid GetBlockAndIndexBid(int bidId)
        {
            BidService service = new BidService();
            return service.GetBlockAndIndexBid(bidId);
        }

        public View_ElectricityBlockAndIndexBid GetFirstBlockAndIndexBid(int bidPackageId)
        {
            BidService service = new BidService();
            return service.GetFirstBlockAndIndexBid(bidPackageId);
        }

        public List<View_ElectricityBlockAndIndexBid> GetBlockAndIndexBids(int bidPackageId, string sortExpression)
        {
            BidService service = new BidService();
            return service.GetBlockAndIndexBids(bidPackageId, sortExpression);
        }

        public FunctionGetElectricBidDetailsResult GetElectricBidDetails(int accountId, int locationId, int bidId,
                                                                         DateTime? startDate, DateTime? endDate,
                                                                         bool useLastYearsData)
        {
            BidService service = new BidService();
            return service.GetElectricBidDetails(accountId, locationId, bidId, startDate, endDate, useLastYearsData);
        }

        public void SaveBidCosts(int bidId, double? calculatedPerUnitCost, double? totalCost, double? CostComparedToCurrentContract)
        {
            BidService service = new BidService();
            service.SaveBidCosts(bidId, calculatedPerUnitCost, totalCost, CostComparedToCurrentContract);
        }

        public List<View_ElectricityFixedBid> GetFixedBids(int bidPackageId, string UserId, string SortExpression)
        {
            BidService service = new BidService();
            return service.GetFixedBids(bidPackageId, UserId, SortExpression);
        }

        public List<View_ElectricityBlockAndIndexBid> GetBlockAndIndexBids(int bidPackageId, string UserId, string SortExpression)
        {
            BidService service = new BidService();
            return service.GetBlockAndIndexBids(bidPackageId, UserId, SortExpression);
        }

        // jat - remove this for now because another method has the same signature
        //public IDictionary<int, string> GetBidPackageAccounts(int bidPackageId)
        //{
        //    BidService service = new BidService();
        //    return service.GetBidPackageAccounts(bidPackageId);
        //}

        public IDictionary<int, string> GetBidPackageAccountsWithAccountIDs(int bidPackageId)
        {
            BidService service = new BidService();
            return service.GetBidPackageAccountsWithAccountIDs(bidPackageId);
        }

        public View_BidPackageAccount GetBidPackageAccount(int bidPackageId, int locationId)
        {
            BidService service = new BidService();
            return service.GetBidPackageAccount(bidPackageId, locationId);
        }

        public List<View_BidPackageAccount> GetBidPackageAccounts(int bidPackageId, string searchCriteria, string sortExpression)
        {
            BidService service = new BidService();
            return service.GetBidPackageAccounts(bidPackageId, searchCriteria, sortExpression);
        }

        public void CascadeDeleteContract(int bidId)
        {
            BidService service = new BidService();
            service.CascadeDeleteContract(bidId);
        }

        public void RemoveBidPackageAccount(int locationId, int AccountID, int bidPackageAccountId)
        {
            BidService service = new BidService();
            service.RemoveBidPackageAccount(locationId, AccountID, bidPackageAccountId);
        }

        public int InsertBid(int BidPackageId, string UserId, double BidPrice, DateTime TermBegin, DateTime TermEnd, int BidItemTypeId, int ContractPricingTypeId, int PricingPointID)
        {
            BidService service = new BidService();
            return service.InsertBid(BidPackageId, UserId, BidPrice, TermBegin, TermEnd, BidItemTypeId, ContractPricingTypeId, PricingPointID);
        }

        public void InsertBidItem(int bidId, int bidItemTypeId, double price, DateTime effectiveDate)
        {
            BidService service = new BidService();
            service.InsertBidItem(bidId, bidItemTypeId, price, effectiveDate);
        }

        public int InsertBlockAndIndexBid(int BidPackageId, string UserId, double OnPeakPrice, double OffPeakPrice,
            double ManagementCharge, DateTime TermBegin, DateTime TermEnd)
        {
            BidService service = new BidService();
            return service.InsertBlockAndIndexBid(BidPackageId, UserId, OnPeakPrice, OffPeakPrice, ManagementCharge, TermBegin, TermEnd);
        }

        public void UpdateAllBlockAndIndexBids(int BidPackageId)
        {
            BidService service = new BidService();
            service.UpdateAllBlockAndIndexBids(BidPackageId);
        }

        //public int GetBidPackageId(int BidId)
        //{
        //    BidService service = new BidService();
        //    return service.GetNaturalGasBids(bidPackageId, bidItemTypeId);
        //}

        public int UpdateBid(int bidId, int BidItemTypeId, string userId, double bidPrice, DateTime termBegin, DateTime termEnd, int numberOfMonths, int PricingPointID)
        {
            BidService service = new BidService();
            return service.UpdateBid(bidId, BidItemTypeId, userId, bidPrice, termBegin, termEnd, numberOfMonths, PricingPointID);
        }


        public int UpdateBlockAndIndexBid(int bidId, string userId, double onPeakPrice, double offPeakPrice,
            double managementCharge, DateTime termBegin, DateTime termEnd, string bidder /* not used*/, int numberOfMonths /* not used*/)
        {
            BidService service = new BidService();
            return service.UpdateBlockAndIndexBid(bidId, userId, onPeakPrice, offPeakPrice, managementCharge, termBegin, termEnd, bidder /* not used*/, numberOfMonths /* not used*/);
        }

        public void DeleteBid(int bidId)
        {
            BidService service = new BidService();
            service.DeleteBid(bidId);
        }

        public double GetBidAmount(int bidId, ERMABusinessLibrary.Bids.BidItemTypeEnum bidType)
        {
            BidService service = new BidService();
            return service.GetBidAmount(bidId, bidType);
        }

        public void InsertTotalCost(int bidId, double? totalCost)
        {
            BidService service = new BidService();
            service.InsertTotalCost(bidId, totalCost);
        }

        public void InsertCalculatedPerUnitCost(int bidId, double? perUnitCost)
        {
            BidService service = new BidService();
            service.InsertCalculatedPerUnitCost(bidId, perUnitCost);
        }

        public void InsertSavingsOverHighBid(int bidId, double? savings)
        {
            BidService service = new BidService();
            service.InsertSavingsOverHighBid(bidId, savings);
        }

        public void InsertCostComparedToCurrent(int bidId, double? costDifference)
        {
            BidService service = new BidService();
            service.InsertCostComparedToCurrent(bidId, costDifference);
        }

        public void InsertTotalSavingsOverPriceToCompare(int bidId, double? savings)
        {
            BidService service = new BidService();
            service.InsertTotalSavingsOverPriceToCompare(bidId, savings);
        }

        public void InsertSavingsOverPriceToCompare(int bidId, double? savings)
        {
            BidService service = new BidService();
            service.InsertSavingsOverPriceToCompare(bidId, savings);
        }

        public Bid GetAwardedBid(int bidPackageId)
        {
            BidService service = new BidService();
            return service.GetAwardedBid(bidPackageId);
        }

        public List<View_NaturalGasBid> GetList(int bidPackageId, int bidItemTypeId)
        {
            BidService service = new BidService();
            return service.GetList(bidPackageId, bidItemTypeId);
        }

        public List<double> GetDemandResponseCSPCommmissionValues(int bidId)
        {
            BidService service = new BidService();
            return service.GetDemandResponseCSPCommmissionValues(bidId);
        }

        public int GetNumberYearsMarketData(int bidId)
        {
            BidService service = new BidService();
            return service.GetNumberYearsMarketData(bidId);
        }
    }
}
