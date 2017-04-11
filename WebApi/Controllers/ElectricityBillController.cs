using ApplicationInterface;
using ERMABusinessLibrary.ElectricityBills;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ElectricityBillController : ApiController
    {
        public List<View_Act129Charge> GetAct129ChargesByFacility(int facilityId)
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetAct129ChargesByFacility(facilityId);
        }

        public List<AgencyBillingSummary> GetAgencyBillingSummary(string agencyCode, DateTime fromDate, DateTime toDate)
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetAgencyBillingSummary(agencyCode, fromDate, toDate);
        }

        public List<View_FacilityUseAndCost> GetFacilityBillingSummary(string agencyCode, DateTime fromDate, DateTime toDate)
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetFacilityBillingSummary(agencyCode, fromDate, toDate);
        }

        public List<ElectricityBill> GetBillsList(int locationId, int facilityId)
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetBillsList(locationId, facilityId);
        }

        // This method gets 12 monthly bills summarizing all accounts' usage/cost for all accounts
        // in the given bid package (1 for each month)
        public List<View_BidPackageAccountBill> GetMonthlySummaryBillsByBidPackage(int bidPackageId, DateTime bidTermBegin, int numberMonths)
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetMonthlySummaryBillsByBidPackage(bidPackageId, bidTermBegin, numberMonths);
        }

        public List<View_BidPackageAccountBill> GetBillsByAccount(int accountId, DateTime bidTermBegin, int numberMonths, int bidPackageId)
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetBillsByAccount(accountId, bidTermBegin, numberMonths, bidPackageId);
        }

        public List<ElectricityBill> GetBillsByAccount(int accountId, bool includeInActiveBills)
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetBillsByAccount(accountId, includeInActiveBills);
        }

        public List<Bill> GetEDIBills()
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetEDIBills();
        }

        public void UpdateBillBalances(Bill b, double? previousBalance, double? balanceForward, double? totalPaid)
        {
            ElectricityBillService service = new ElectricityBillService();
            service.UpdateBillBalances(b, previousBalance, balanceForward, totalPaid);
        }

        public List<View_ElectricityBillSummary> GetRecentBillsBeforeDate(int accountId, int numberOfMonths, DateTime evaluationDate)
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetRecentBillsBeforeDate(accountId, numberOfMonths, evaluationDate);
        }

        public List<string> GetCostLineItemTypes(int locationId)
        {
            ElectricityBillService service = new ElectricityBillService();
            return service.GetCostLineItemTypes(locationId);
        }
    }
}
