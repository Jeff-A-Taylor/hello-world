using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;

namespace ApplicationInterface
{
    public class BidService
    {
        public List<View_NaturalGasBid> GetNaturalGasBids(int bidPackageId, int bidItemTypeId)
        {
            List<View_NaturalGasBid> list = new List<View_NaturalGasBid>();
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetNaturalGasBids(bidPackageId, bidItemTypeId);
        }

        public View_NaturalGasBid GetNaturalGasBid(int bidId)
        {
            List<View_NaturalGasBid> list = new List<View_NaturalGasBid>();
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetNaturalGasBid(bidId);
        }

        public void AwardSupplyAccounts(int bidPackageId, int bidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.AwardSupplyAccounts(bidPackageId, bidId);
        }

        public void ReverseAwardSupplyAccounts(int bidPackageId, int bidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.ReverseAwardSupplyAccounts(bidPackageId, bidId);
        }

        public List<View_ElectricityFixedBid> GetFixedBids(int bidPackageId, string sortExpression)
        {
            List<View_ElectricityFixedBid> list = new List<View_ElectricityFixedBid>();
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetFixedBids(bidPackageId, sortExpression);
        }

        public List<View_DemandResponseBid> GetDemandResponseBids(int bidPackageId, string sortExpression)
        {
            List<View_DemandResponseBid> list = new List<View_DemandResponseBid>();
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetDemandResponseBids(bidPackageId, sortExpression);
        }

        public List<View_NaturalGasBid> GetNaturalGasBids(int bidPackageId, int bidItemTypeId, string UserId)
        {
            List<View_NaturalGasBid> list = new List<View_NaturalGasBid>();
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetNaturalGasBids(bidPackageId, bidItemTypeId, UserId);
        }

        // this method returns the summary previous contract per unit cost for all accounts in the bid package
        public double? getBidPackagePreviousContractPerUnitCost(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.getBidPackagePreviousContractPerUnitCost(bidPackageId);
        }

        public double? getBidPackageAnnualSavingsVsCurrentContract(int bidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.getBidPackageAnnualSavingsVsCurrentContract(bidId);
        }

        public double? getBidPackagePreviousContractPerUnitCost(int bidPackageId, int accountId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.getBidPackagePreviousContractPerUnitCost(bidPackageId, accountId);
        }

        public View_ElectricityFixedBid GetFixedBid(int bidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetFixedBid(bidId);
        }

        public View_ElectricityBlockAndIndexBid GetBlockAndIndexBid(int bidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetBlockAndIndexBid(bidId);
        }

        // This method gets the first block & index bid that's in the specified
        // bid package.  It doesn't matter which bid is returned; it's just used to
        // calculate the projected energy only $/kwh for fixed bids.
        public View_ElectricityBlockAndIndexBid GetFirstBlockAndIndexBid(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetFirstBlockAndIndexBid(bidPackageId);
        }

        public List<View_ElectricityBlockAndIndexBid> GetBlockAndIndexBids(int bidPackageId, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetBlockAndIndexBids(bidPackageId, sortExpression);
        }

        public FunctionGetElectricBidDetailsResult GetElectricBidDetails(int accountId, int locationId, int bidId,
                                                                         DateTime? startDate, DateTime? endDate,
                                                                         bool useLastYearsData)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetElectricBidDetails(accountId, locationId, bidId, startDate, endDate, useLastYearsData);
        }

        public void SaveBidCosts(int bidId, double? calculatedPerUnitCost, double? totalCost, double? CostComparedToCurrentContract)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.SaveBidCosts(bidId, calculatedPerUnitCost, totalCost, CostComparedToCurrentContract);
        }

        public List<View_ElectricityFixedBid> GetFixedBids(int bidPackageId, string UserId, string SortExpression)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetFixedBids(bidPackageId, UserId, SortExpression);
        }

        public List<View_ElectricityBlockAndIndexBid> GetBlockAndIndexBids(int bidPackageId, string UserId, string SortExpression)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetBlockAndIndexBids(bidPackageId, UserId, SortExpression);
        }

        public IDictionary<int, string> GetBidPackageAccounts(int bidPackageId)
        {
            IDictionary<int, string> list = new Dictionary<int, string>();
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            list = persistence.GetBidPackageAccounts(bidPackageId);
            return list;
        }

        //
        // This method is just like GetBidPackageAccounts(bidPackageId) except that the
        // accounts' AccountID is returned as the key (not LocationID).
        //
        public IDictionary<int, string> GetBidPackageAccountsWithAccountIDs(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetBidPackageAccountsWithAccountIDs(bidPackageId);
        }

        public View_BidPackageAccount GetBidPackageAccount(int bidPackageId, int locationId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetBidPackageAccount(bidPackageId, locationId);
        }

        public List<View_BidPackageAccount> GetBidPackageAccounts(int bidPackageId, string searchCriteria, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetBidPackageAccounts(bidPackageId, searchCriteria, sortExpression);
        }

        // this method removes the Contract, ContractComponent, PriceLock, PeakShavingInformation
        // and PeakShavingContact rows associated to the given BidId
        public void CascadeDeleteContract(int bidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.CascadeDeleteContract(bidId);
        }

        public void RemoveBidPackageAccount(int locationId, int AccountID, int bidPackageAccountId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.RemoveBidPackageAccount(locationId, AccountID, bidPackageAccountId);
        }


        //
        // This method inserts a Bid row and a BidItem row and returns the new Bid.ID value
        //
        public int InsertBid(int BidPackageId, string UserId, double BidPrice, DateTime TermBegin, DateTime TermEnd, int BidItemTypeId, int ContractPricingTypeId, int PricingPointID)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.InsertBid(BidPackageId, UserId, BidPrice, TermBegin, TermEnd, BidItemTypeId, ContractPricingTypeId,PricingPointID);
        }

        public void InsertBidItem(int bidId, int bidItemTypeId, double price, DateTime effectiveDate)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.InsertBidItem(bidId, bidItemTypeId, price, effectiveDate);
        }

        public int InsertBlockAndIndexBid(int BidPackageId, string UserId, double OnPeakPrice, double OffPeakPrice,
            double ManagementCharge, DateTime TermBegin, DateTime TermEnd)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.InsertBlockAndIndexBid(BidPackageId, UserId, OnPeakPrice, OffPeakPrice,
            ManagementCharge, TermBegin, TermEnd);
        }

        // This method is called when the bid package's block & index price escalation rate is changed.
        // It loops through all block & index bids, recalculating their costs and re-inserting their
        // ElectricBidDetail and ElectricBidDetailsPerAccount rows.
        public void UpdateAllBlockAndIndexBids(int BidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.UpdateAllBlockAndIndexBids(BidPackageId);
        }

        public int GetBidPackageId(int BidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetBidPackageId(BidId);
        }

        public int UpdateBid(int bidId, int BidItemTypeId, string userId, double bidPrice, DateTime termBegin, DateTime termEnd, int numberOfMonths, int PricingPointID)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.UpdateBid(bidId, BidItemTypeId, userId, bidPrice, termBegin, termEnd, numberOfMonths, PricingPointID);
        }


        public int UpdateBlockAndIndexBid(int bidId, string userId, double onPeakPrice, double offPeakPrice,
            double managementCharge, DateTime termBegin, DateTime termEnd, string bidder /* not used*/, int numberOfMonths /* not used*/)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.UpdateBlockAndIndexBid(bidId, userId, onPeakPrice, offPeakPrice, managementCharge, termBegin, termEnd, bidder /* not used*/, numberOfMonths /* not used*/);
        }

        public void DeleteBid(int bidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.DeleteBid(bidId);
        }

        public double GetBidAmount(int bidId, ERMABusinessLibrary.Bids.BidItemTypeEnum bidType)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetBidAmount(bidId, bidType);
        }

        public void InsertTotalCost(int bidId, double? totalCost)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.InsertTotalCost(bidId, totalCost);
        }

        public void InsertCalculatedPerUnitCost(int bidId, double? perUnitCost)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.InsertCalculatedPerUnitCost(bidId, perUnitCost);
        }

        public void InsertSavingsOverHighBid(int bidId, double? savings)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.InsertSavingsOverHighBid(bidId, savings);
        }

        public void InsertCostComparedToCurrent(int bidId, double? costDifference)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.InsertCostComparedToCurrent(bidId, costDifference);
        }

        public void InsertTotalSavingsOverPriceToCompare(int bidId, double? savings)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.InsertTotalSavingsOverPriceToCompare(bidId, savings);
        }

        public void InsertSavingsOverPriceToCompare(int bidId, double? savings)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            persistence.InsertSavingsOverPriceToCompare(bidId, savings);
        }

        public Bid GetAwardedBid(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetAwardedBid(bidPackageId);
        }

        public List<View_NaturalGasBid> GetList(int bidPackageId, int bidItemTypeId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetList(bidPackageId, bidItemTypeId);
        }

        public List<double> GetDemandResponseCSPCommmissionValues(int bidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetDemandResponseCSPCommmissionValues(bidId);
        }

        public int GetNumberYearsMarketData(int bidId)
        {
            ERMABusinessLibrary.Persistence.BidRepository persistence = new ERMABusinessLibrary.Persistence.BidRepository();
            return persistence.GetNumberYearsMarketData(bidId);
        }
    }
}
