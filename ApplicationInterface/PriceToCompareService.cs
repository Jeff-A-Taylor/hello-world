using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace ApplicationInterface
{
    public class PriceToCompareService
    {
        public List<PriceToCompareExpanded> GetPriceToComparesForBidPackage(int bidPackageId, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            return persistence.GetPriceToComparesForBidPackage(bidPackageId, sortExpression);
        }

        //public static void SortList<T>(string sortExpression, List<T> data)
        //{
        //    ERMABusinessLibrary.Persistence.PriceToComparePersistence persistence = new ERMABusinessLibrary.Persistence.PriceToComparePersistence();
        //    return persistence.SortList<T>(sortExpression, data);
        //}

        public void RemovePriceToCompare(int Id, int LocationId)
        {
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            persistence.RemovePriceToCompare(Id, LocationId);
        }

        public void RemovePriceToCompares(int bidPackageId, List<int> IdList)
        {
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            persistence.RemovePriceToCompares(bidPackageId, IdList);
        }

        public void UpdatePriceToCompare(int Id, int LocationId, string Quantity, string Description, string Effective, int? BidPackageID,
                                         string AccountNumber, string Tariff, string Rate)
        {
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            persistence.UpdatePriceToCompare(Id, LocationId, Quantity, Description, Effective, BidPackageID, AccountNumber, Tariff, Rate);
        }

        public void UpdatePriceToCompare(int Id, int LocationId, string Quantity, string Description, string Effective, int? BidPackageID,
                                         string AccountNumber, string CustomerNumber, string Tariff, string Rate)
        {
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            persistence.UpdatePriceToCompare(Id, LocationId, Quantity, Description, Effective, BidPackageID, AccountNumber, CustomerNumber, Tariff, Rate);
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
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            return persistence.BulkImport(rfqID, priceToCompareValues);
        }

        public List<spGetPriceToComparesPerTariffForBidPackageResult> GetPriceToComparesPerTariffForBidPackage(int bidPackageId, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            return persistence.GetPriceToComparesPerTariffForBidPackage(bidPackageId, sortExpression);
        }

        // This method removes all price to compares whose tariff ids are in the given list.
        public void RemovePriceToComparesByTariffID(int bidPackageId, List<int> tariffIDsToDelete)
        {
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            persistence.RemovePriceToComparesByTariffID(bidPackageId, tariffIDsToDelete);
        }

        // This method removes all price to compares whose tariff id = the given TariffId
        public void DeletePriceToComparesPerTariffForBidPackage(int bidPackageId, int TariffId)
        {
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            persistence.DeletePriceToComparesPerTariffForBidPackage(bidPackageId, TariffId);
        }

        public void UpdatePriceToComparesPerTariffForBidPackage(int BidPackageID, double Quantity, string Description, DateTime Effective, int TariffId, bool insertMissingP2CsToo)
        {
            ERMABusinessLibrary.Persistence.PriceToCompareRepository persistence = new ERMABusinessLibrary.Persistence.PriceToCompareRepository();
            persistence.UpdatePriceToComparesPerTariffForBidPackage(BidPackageID, Quantity, Description, Effective, TariffId, insertMissingP2CsToo);
        }
    }
}
