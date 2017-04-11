using ApplicationInterface;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class PriceLockController : ApiController
    {
        public List<spGetPriceLocksForContractResult> GetList(int contractID, string SortExpression)
        {
            PriceLockService service = new PriceLockService();
            return service.GetList(contractID, SortExpression);
        }

        public List<PriceLockType> GetPriceLockTypeList()
        {
            PriceLockService service = new PriceLockService();
            return service.GetPriceLockTypeList();
        }

        public string Update(int PriceLockTypeID, double PercentLocked, DateTime PriceLockForDate,
            double LockPrice, double Quantity, DateTime DateTimeLocked, int PriceLockID, int QuantityUnitID)
        {
            PriceLockService service = new PriceLockService();
            return service.Update(PriceLockTypeID, PercentLocked, PriceLockForDate,
            LockPrice, Quantity, DateTimeLocked, PriceLockID, QuantityUnitID);
        }

        public string Insert(int ContractID, int PriceLockTypeID, double PercentLocked, DateTime PriceLockForDate,
            double LockPrice, double Quantity, DateTime DateTimeLocked, int QuantityUnitID)
        {
            PriceLockService service = new PriceLockService();
            return service.Insert(ContractID, PriceLockTypeID, PercentLocked, PriceLockForDate,
            LockPrice, Quantity, DateTimeLocked, QuantityUnitID);
        }

        public void Delete(int PriceLockID, double Nomination)
        {
            PriceLockService service = new PriceLockService();
            service.Delete(PriceLockID, Nomination);
        }

        public void Delete(List<int> PriceLockIDs)
        {
            PriceLockService service = new PriceLockService();
            service.Delete(PriceLockIDs);
        }

        public List<spCreatePriceLocksForBulkAddResult> CreatePriceLocksForBulkAdd(int contractID, DateTime beginDate, DateTime endDate, double percent, double quantity)
        {
            PriceLockService service = new PriceLockService();
            return service.CreatePriceLocksForBulkAdd(contractID, beginDate, endDate, percent, quantity);
        }

        //public static void SortList<T>(string sortExpression, List<T> data)
        //{
        //    ERMABusinessLibrary.Persistence.PriceLockPersistence persistence = new ERMABusinessLibrary.Persistence.PriceLockPersistence();
        //    persistence.SortList<T>(sortExpression, data);
        //}

        public List<spGetPriceLocksResult> GetPriceLocks(string commaSeparatedFacCodes,
                                                         string commaSeparatedAccountIDs,
                                                         bool includeMonthsWithNoPriceLocks,
                                                         DateTime? startDate,
                                                         DateTime? endDate)
        {
            PriceLockService service = new PriceLockService();
            return service.GetPriceLocks(commaSeparatedFacCodes,
                                                         commaSeparatedAccountIDs,
                                                         includeMonthsWithNoPriceLocks,
                                                         startDate,
                                                         endDate);
        }

        //
        // This method creates an Excel spreadsheet which contains a row for every account that should have price locks requested
        // for the given supplier companyID, accountIDs and percent to lock/month to lock dataTable.
        // It returns a Tuple<string,string,byte[]> where Item1 = the generated filename (without the path), Item2 = generated file's content,
        // Item3 = fully qualified generated filename (including the path), Item4 = list of Contract.ID values
        public Tuple<string, byte[], string, List<int>> GeneratePriceLockRequestEmailAttachment(int companyID, List<int> accountIDs,
            DataTable dataTable)
        {
            PriceLockService service = new PriceLockService();
            return service.GeneratePriceLockRequestEmailAttachment(companyID, accountIDs, dataTable);
        }

        public DataTable GetInitialPriceLockTiers()
        {
            PriceLockService service = new PriceLockService();
            return service.GetInitialPriceLockTiers();
        }
    }
}
