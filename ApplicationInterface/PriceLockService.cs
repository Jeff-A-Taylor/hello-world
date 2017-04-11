//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Common;
//using System.Data.SqlClient;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using OfficeOpenXml;

using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Data;

namespace ApplicationInterface
{

    public class PriceLockService
    {
        public List<spGetPriceLocksForContractResult> GetList(int contractID, string SortExpression)
        {
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            return persistence.GetList(contractID, SortExpression);
        }

        public List<PriceLockType> GetPriceLockTypeList()
        {
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            return persistence.GetPriceLockTypeList();
        }

        public string Update(int PriceLockTypeID, double PercentLocked, DateTime PriceLockForDate, 
            double LockPrice, double Quantity, DateTime DateTimeLocked, int PriceLockID, int QuantityUnitID )
        {
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            return persistence.Update(PriceLockTypeID, PercentLocked, PriceLockForDate, 
            LockPrice, Quantity, DateTimeLocked, PriceLockID, QuantityUnitID );
        }

        public string Insert(int ContractID, int PriceLockTypeID, double PercentLocked, DateTime PriceLockForDate,
            double LockPrice, double Quantity, DateTime DateTimeLocked, int QuantityUnitID)
        {
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            return persistence.Insert(ContractID, PriceLockTypeID, PercentLocked, PriceLockForDate,
            LockPrice, Quantity, DateTimeLocked, QuantityUnitID);
        }

        public void Delete(int PriceLockID, double Nomination)
        {
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            persistence.Delete(PriceLockID, Nomination);
        }

        public void Delete(List<int> PriceLockIDs)
        {
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            persistence.Delete(PriceLockIDs);
        }

        public List<spCreatePriceLocksForBulkAddResult> CreatePriceLocksForBulkAdd(int contractID, DateTime beginDate, DateTime endDate, double percent, double quantity)
        {
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            return persistence.CreatePriceLocksForBulkAdd(contractID, beginDate, endDate, percent, quantity);
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
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            return persistence.GetPriceLocks(commaSeparatedFacCodes,
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
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            return persistence.GeneratePriceLockRequestEmailAttachment(companyID, accountIDs, dataTable);
        }

        public DataTable GetInitialPriceLockTiers()
        {
            ERMABusinessLibrary.Persistence.PriceLockRepository persistence = new ERMABusinessLibrary.Persistence.PriceLockRepository();
            return persistence.GetInitialPriceLockTiers();
        }
    }
}
