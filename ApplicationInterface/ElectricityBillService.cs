using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERMABusinessLibrary.ElectricityBills;
using ERMABusinessLibrary.Persistence;

namespace ApplicationInterface
{
    public class ElectricityBillService
    {
        public List<View_Act129Charge> GetAct129ChargesByFacility(int facilityId)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetAct129ChargesByFacility(facilityId);
        }

        public List<AgencyBillingSummary> GetAgencyBillingSummary(string agencyCode, DateTime fromDate, DateTime toDate)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetAgencyBillingSummary(agencyCode, fromDate, toDate);
        }

        public List<View_FacilityUseAndCost> GetFacilityBillingSummary(string agencyCode, DateTime fromDate, DateTime toDate)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetFacilityBillingSummary(agencyCode, fromDate, toDate);
        }

        public List<ElectricityBill> GetBillsList(int locationId, int facilityId)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetBillsList(locationId, facilityId);
        }

        // This method gets 12 monthly bills summarizing all accounts' usage/cost for all accounts
        // in the given bid package (1 for each month)
        public List<View_BidPackageAccountBill> GetMonthlySummaryBillsByBidPackage(int bidPackageId, DateTime bidTermBegin, int numberMonths)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetMonthlySummaryBillsByBidPackage(bidPackageId, bidTermBegin, numberMonths);
        }

        public List<View_BidPackageAccountBill> GetBillsByAccount(int accountId, DateTime bidTermBegin, int numberMonths, int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetBillsByAccount(accountId, bidTermBegin, numberMonths, bidPackageId);
        }

        public List<ElectricityBill> GetBillsByAccount(int accountId, bool includeInActiveBills)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetBillsByAccount(accountId, includeInActiveBills);
        }

        public List<Bill> GetEDIBills()
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetEDIBills();
        }

        public void UpdateBillBalances(Bill b, double? previousBalance, double? balanceForward, double? totalPaid)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            persistence.UpdateBillBalances(b, previousBalance, balanceForward, totalPaid);
        }

        public List<View_ElectricityBillSummary> GetRecentBillsBeforeDate(int accountId, int numberOfMonths, DateTime evaluationDate)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetRecentBillsBeforeDate(accountId, numberOfMonths, evaluationDate);
        }

        public List<string> GetCostLineItemTypes(int locationId)
        {
            ERMABusinessLibrary.Persistence.ElectricityBillRepository persistence = new ERMABusinessLibrary.Persistence.ElectricityBillRepository();
            return persistence.GetCostLineItemTypes(locationId);
        }
    }

    //public class AgencyBillingSummary
    //{
    //    private DateTime billingPeriod;

    //    public DateTime BillingPeriod
    //    {
    //        get { return billingPeriod; }
    //        set { billingPeriod = value; }
    //    }
    //    private double? totalKwh;

    //    public double? TotalKwh
    //    {
    //        get { return totalKwh; }
    //        set { totalKwh = value; }
    //    }
    //    private double? totalCost;

    //    public double? TotalCost
    //    {
    //        get { return totalCost; }
    //        set { totalCost = value; }
    //    }
    //}

    //public class FacilityBillingSummary
    //{
    //    private string facilityName;
    //    private string accountNumber;
    //    private double? kwh;
    //    private double? totalCosts;
    //    private int billCount;

    //    public string AccountNumber
    //    {
    //        get { return accountNumber; }
    //        set { accountNumber = value; }
    //    }

    //    public string FacilityName
    //    {
    //        get { return facilityName; }
    //        set { facilityName = value; }
    //    }

    //    public double? Kwh
    //    {
    //        get { return kwh; }
    //        set { kwh = value; }
    //    }

    //    public double? TotalCosts
    //    {
    //        get { return totalCosts; }
    //        set { totalCosts = value; }
    //    }

    //    public int BillCount
    //    {
    //        get { return billCount; }
    //        set { billCount = value; }
    //    }

    //    public FacilityBillingSummary()
    //    { }

    //    public FacilityBillingSummary(string facilityName, string accountNumber, double kwh, double kwDemand, double totalCosts, int billCount)
    //    {
    //        this.facilityName = facilityName;
    //        this.accountNumber = accountNumber;
    //        this.kwh = kwh;
    //        this.totalCosts = totalCosts;
    //        this.billCount = billCount;
    //    }
    }
