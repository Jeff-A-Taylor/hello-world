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
    public class PriceToCompareController : ApiController
    {
        public List<PriceToCompareExpanded> GetPriceToComparesForBidPackage(int bidPackageId, string sortExpression)
        {
            PriceToCompareService service = new PriceToCompareService();
            return service.GetPriceToComparesForBidPackage(bidPackageId, sortExpression);
        }

        //public static void SortList<T>(string sortExpression, List<T> data)
        //{
        //    ERMABusinessLibrary.Persistence.PriceToComparePersistence persistence = new ERMABusinessLibrary.Persistence.PriceToComparePersistence();
        //    return persistence.SortList<T>(sortExpression, data);
        //}

        public void RemovePriceToCompare(int Id, int LocationId)
        {
            PriceToCompareService service = new PriceToCompareService();
            service.RemovePriceToCompare(Id, LocationId);
        }

        public void RemovePriceToCompares(int bidPackageId, List<int> IdList)
        {
            PriceToCompareService service = new PriceToCompareService();
            service.RemovePriceToCompares(bidPackageId, IdList);
        }

        public void UpdatePriceToCompare(int Id, int LocationId, string Quantity, string Description, string Effective, int? BidPackageID,
                                         string AccountNumber, string Tariff, string Rate)
        {
            PriceToCompareService service = new PriceToCompareService();
            service.UpdatePriceToCompare(Id, LocationId, Quantity, Description, Effective, BidPackageID, AccountNumber, Tariff, Rate);
        }

        public void UpdatePriceToCompare(int Id, int LocationId, string Quantity, string Description, string Effective, int? BidPackageID,
                                         string AccountNumber, string CustomerNumber, string Tariff, string Rate)
        {
            PriceToCompareService service = new PriceToCompareService();
            service.UpdatePriceToCompare(Id, LocationId, Quantity, Description, Effective, BidPackageID, AccountNumber, CustomerNumber, Tariff, Rate);
        }

        /**
         * This method accepts an RFQID, and a list of <Account Number, Quantity, Effective Date> strings
         * and calls a stored procedure that tries to find the corresponding account with the given
         * account number in the RFQ's bid packages and inserts the price to compare values (with effective dates).
         * 
         * It returns a Tuple of <int,List<string>> where the int contains the number of successfully inserted rows and
         * the List<string> contains all of the accountnumbers whose pricetocompares failed to insert
         */
        public Tuple<int, List<string>> BulkImport(int rfqID, List<Tuple<string, string, string>> priceToCompareValues)
        {
            PriceToCompareService service = new PriceToCompareService();
            return service.BulkImport(rfqID, priceToCompareValues);
        }

        public List<spGetPriceToComparesPerTariffForBidPackageResult> GetPriceToComparesPerTariffForBidPackage(int bidPackageId, string sortExpression)
        {
            PriceToCompareService service = new PriceToCompareService();
            return service.GetPriceToComparesPerTariffForBidPackage(bidPackageId, sortExpression);
        }

        // This method removes all price to compares whose tariff ids are in the given list.
        public void RemovePriceToComparesByTariffID(int bidPackageId, List<int> tariffIDsToDelete)
        {
            PriceToCompareService service = new PriceToCompareService();
            service.RemovePriceToComparesByTariffID(bidPackageId, tariffIDsToDelete);
        }

        // This method removes all price to compares whose tariff id = the given TariffId
        public void DeletePriceToComparesPerTariffForBidPackage(int bidPackageId, int TariffId)
        {
            PriceToCompareService service = new PriceToCompareService();
            service.DeletePriceToComparesPerTariffForBidPackage(bidPackageId, TariffId);
        }

        public void UpdatePriceToComparesPerTariffForBidPackage(int BidPackageID, double Quantity, string Description, DateTime Effective, int TariffId, bool insertMissingP2CsToo)
        {
            PriceToCompareService service = new PriceToCompareService();
            service.UpdatePriceToComparesPerTariffForBidPackage(BidPackageID, Quantity, Description, Effective, TariffId, insertMissingP2CsToo);
        }
    }
}
