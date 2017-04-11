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
    public class DistributionChargeController : ApiController
    {
        public DistributionCharge Get(int locationId, int? bidPackageId)
        {
            DistributionChargeService service = new DistributionChargeService();
            return service.Get(locationId, bidPackageId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="bidPackageId"></param>
        /// <param name="price"></param>
        /// <param name="description"></param>
        /// <param name="effectiveDate"></param>
        /// <returns>return new index</returns>
        public int Save(int locationId, int? bidPackageId, double price, string description, DateTime effectiveDate)
        {
            DistributionChargeService service = new DistributionChargeService();
            return service.Save(locationId, bidPackageId, price, description, effectiveDate);
        }

        /// <summary>
        /// For testing
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            DistributionChargeService service = new DistributionChargeService();
            service.Remove(id);
        }

        public void RemoveDistributionCharge(int Id, int LocationId)
        {
            DistributionChargeService service = new DistributionChargeService();
            service.RemoveDistributionCharge(Id, LocationId);
        }

        public void UpdateDistributionCharge(int Id, int LocationId, string Quantity, string Description, string Effective, int? BidPackageID,
                                         string AccountNumber, string CustomerNumber, string Tariff, string Rate)
        {
            DistributionChargeService service = new DistributionChargeService();
            service.UpdateDistributionCharge(Id, LocationId, Quantity, Description, Effective, BidPackageID,
                                         AccountNumber, CustomerNumber, Tariff, Rate);
        }

        public List<DistributionChargeExpanded> GetDistributionChargesForBidPackage(int bidPackageId, string sortExpression)
        {
            DistributionChargeService service = new DistributionChargeService();
            return service.GetDistributionChargesForBidPackage(bidPackageId, sortExpression);
        }

        /**
         * This method accepts an RFQID, and a list of <Account Number, Quantity, Effective Date> strings
         * and calls a stored procedure that tries to find the corresponding account with the given
         * account number in the RFQ's bid packages and inserts the distribution charge values (with effective dates).
         * 
         * It returns a Tuple of <int,List<string>> where the int contains the number of successfully inserted rows and
         * the List<string> contains all of the accountnumbers whose distributioncharges failed to insert
         */
        public Tuple<int, List<string>> BulkImport(int rfqID, List<Tuple<string, string, string>> distChargeValues)
        {
            DistributionChargeService service = new DistributionChargeService();
            return service.BulkImport(rfqID, distChargeValues);
        }
    }
}
