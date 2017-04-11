using ERMABusinessLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ERMABusinessLibrary;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;

namespace ApplicationInterface
{
    public class UtilityBillService
    {
        public List<CostItem> GetAllCostItems()
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetAllCostItems();
        }

        public List<MeteredItem> GetAllMeteredItems()
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetAllMeteredItems();
        }

        public void InsertBill(Bill newBill)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            persistence.InsertBill(newBill);
        }

        public void InsertMeteredLineItems(List<MeteredLineItem> meteredLineItemList)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            persistence.InsertMeteredLineItems(meteredLineItemList);
        }

        // This method removes all MeteredLineItem rows for the given BillID
        // and MeteredItemId
        public void DeleteMeteredLineItems(int billID, int meteredItemID)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            persistence.DeleteMeteredLineItems(billID, meteredItemID);
        }

        // This method removes all MeteredLineItem rows for the given BillID
        // It returns true if the MeteredLineItems were deleted, it returns false
        // if the bill was an EDI bill with MeteredLineItems whose description == Meter #
        // (delete not executed).
        public bool DeleteMeteredLineItems(int billID)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.DeleteMeteredLineItems(billID);
        }

        public void InsertCostLineItems(List<CostLineItem> costLineitemList)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            persistence.InsertCostLineItems(costLineitemList);
        }

        public int GetBillId(string accountNumber, DateTime readDate)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetBillId(accountNumber, readDate);
        }

        public List<Bill> GetBills(int billId)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetBills(billId);
        }

        public IList<Bill> GetBillsByAccount(int accountId, bool includeInActiveBills)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetBillsByAccount(accountId, includeInActiveBills);
        }

        public IList<Bill> GetBillsByAccount(int accountId, bool includeInActiveBills, DateTime? beginDate, DateTime? endDate, double? minTotalBill)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetBillsByAccount(accountId, includeInActiveBills, beginDate, endDate, minTotalBill);
        }

        public DateTime? GetReadDate(int billId)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetReadDate(billId);
        }

        public Account GetCorrespondingAccount(int billId)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetCorrespondingAccount(billId);
        }

        public List<CostLineItem> GetAllCostLineItems()
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetAllCostLineItems();
        }

        public List<View_CostLineItem> GetCostLineItems(int billId)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetCostLineItems(billId);
        }

        public List<View_MeteredLineItem> GetMeteredLineItems(int billId)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            return persistence.GetMeteredLineItems(billId);
        }

        public void SaveCostItemIds(List<CostLineItem> costLineItems)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            persistence.SaveCostItemIds(costLineItems);
        }

        public void SetNonCorrectedBillsInactive(int accountId, Bill correctedBill)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            persistence.SetNonCorrectedBillsInactive(accountId, correctedBill);
        }

        public void SetPreviousBillsInactive(int accountId, Bill correctedBill)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            persistence.SetPreviousBillsInactive(accountId, correctedBill);
        }

        //
        // This method updates the Bill.InvoiceTotal value based on the
        // sum of the CostLineItem.Cost values
        //
        public void updateInvoiceTotal(int billID)
        {
            ERMABusinessLibrary.Persistence.UtilityBillRepository persistence = new ERMABusinessLibrary.Persistence.UtilityBillRepository();
            persistence.updateInvoiceTotal(billID);
        }
    }
}
