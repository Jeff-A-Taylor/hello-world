using System.Collections.Generic;
using ERMABusinessLibrary.NaturalGasBills;
using ERMABusinessLibrary.Persistence;

namespace ApplicationInterface
{
    public class NaturalGasBillService
    {
        public List<View_NaturalGasBill> GetList(int locationID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBillRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBillRepository();
            return persistence.GetList(locationID);
        }

        public List<View_NaturalGasBillSummary> GetBillSummaryList(int locationID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBillRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBillRepository();
            return persistence.GetBillSummaryList(locationID);
        }

        //public NaturalGasBill GetRecentBillsForMonthYear(int month, int year, int locationID, bool isSupplyAccount)
        //{
        //    //A bill is counted as being in the month given if it has more days in that month then any other bill
        //    //So a bill with a read date of the 14th of June is counted as a bill for May
        //    //A bill with read date June 15th is counted for June
        //    //The cut off is the 15th
        //    DateTime queryDate = new DateTime(year, month, 1);
        //    using (var dataContext = this.GetDataSource())
        //    {
        //        Bill queriedBill = (from location in dataContext.Locations
        //                            join account in dataContext.Accounts on location.ID equals account.LocationID
        //                            join bill in dataContext.Bills on account.ID equals bill.AccountID
        //                            where location.ID == locationID
        //                            && account.IsSupplyAccount == isSupplyAccount
        //                            && (bill.ReadDate.Date >= queryDate.AddDays(15)
        //                            && bill.ReadDate < queryDate.AddMonths(1).AddDays(15))
        //                            orderby bill.ReadDate descending
        //                            select bill).FirstOrDefault();
        //        if (queriedBill != null)
        //        {
        //            List<CostLineItem> costLineItems = GetCostLineItems(queriedBill.ID);
        //            List<MeteredLineItem> meteredLineItems = GetMeteredLineItems(queriedBill.ID);
        //            return new NaturalGasBill(queriedBill, costLineItems, meteredLineItems);
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //}

        /// <summary>
        /// Used in NaturalGasBudgetHelper need:  BillDate, TotalBillCost, Usage
        /// </summary>
        /// <param name="month"></param>
        /// <param name="locationID"></param>
        /// <param name="isSupplyAccount"></param>
        /// <returns></returns>
        public NaturalGasBill GetRecentBillForMonth(int month, int locationID, bool isSupplyAccount)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBillRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBillRepository();
            return persistence.GetRecentBillForMonth(month, locationID, isSupplyAccount);
        }

        public List<Bill> GetBillList(int accountID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBillRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBillRepository();
            return persistence.GetBillList(accountID);
        }

        public List<MeteredLineItem> GetMeteredLineItems(int billID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBillRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBillRepository();
            return persistence.GetMeteredLineItems(billID);
        }

        public List<CostLineItem> GetCostLineItems(int billID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBillRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBillRepository();
            return persistence.GetCostLineItems(billID);
        }
    }
}
