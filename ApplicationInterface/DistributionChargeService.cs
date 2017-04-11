using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class DistributionChargeService
    {
        public DistributionCharge Get(int locationId, int? bidPackageId)
        {
            ERMABusinessLibrary.Persistence.DistributionChargeRepository persistence = new ERMABusinessLibrary.Persistence.DistributionChargeRepository();
            return persistence.Get(locationId, bidPackageId);
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
            ERMABusinessLibrary.Persistence.DistributionChargeRepository persistence = new ERMABusinessLibrary.Persistence.DistributionChargeRepository();
            return persistence.Save(locationId, bidPackageId, price, description, effectiveDate);
        }

        /// <summary>
        /// For testing
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            ERMABusinessLibrary.Persistence.DistributionChargeRepository persistence = new ERMABusinessLibrary.Persistence.DistributionChargeRepository();
            persistence.Remove(id);
        }

        public void RemoveDistributionCharge(int Id, int LocationId)
        {
            ERMABusinessLibrary.Persistence.DistributionChargeRepository persistence = new ERMABusinessLibrary.Persistence.DistributionChargeRepository();
            persistence.RemoveDistributionCharge(Id, LocationId);
        }

        public void UpdateDistributionCharge(int Id, int LocationId, string Quantity, string Description, string Effective, int? BidPackageID,
                                         string AccountNumber, string CustomerNumber, string Tariff, string Rate)
        {
            ERMABusinessLibrary.Persistence.DistributionChargeRepository persistence = new ERMABusinessLibrary.Persistence.DistributionChargeRepository();
            persistence.UpdateDistributionCharge(Id, LocationId, Quantity, Description, Effective, BidPackageID,
                                         AccountNumber, CustomerNumber, Tariff, Rate);
        }

        public List<DistributionChargeExpanded> GetDistributionChargesForBidPackage(int bidPackageId, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.DistributionChargeRepository persistence = new ERMABusinessLibrary.Persistence.DistributionChargeRepository();
            return persistence.GetDistributionChargesForBidPackage(bidPackageId, sortExpression);
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
            ERMABusinessLibrary.Persistence.DistributionChargeRepository persistence = new ERMABusinessLibrary.Persistence.DistributionChargeRepository();
            return persistence.BulkImport(rfqID, distChargeValues);
        }
    }
}
