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
    public class EstimatedLoadToDropService
    {

        public List<spGetEstimatedLoadToDropsForBidPackageResult> GetEstimatedLoadToDropsForBidPackage(int bidPackageId, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.EstimatedLoadToDropRepository persistence = new ERMABusinessLibrary.Persistence.EstimatedLoadToDropRepository();
            return persistence.GetEstimatedLoadToDropsForBidPackage(bidPackageId, sortExpression);
        }

        public void RemoveEstimatedLoadToDrop(int ID)
        {
            ERMABusinessLibrary.Persistence.EstimatedLoadToDropRepository persistence = new ERMABusinessLibrary.Persistence.EstimatedLoadToDropRepository();
            persistence.RemoveEstimatedLoadToDrop(ID);
        }

        public void RemoveEstimatedLoadsToDrop(List<int> IDsToDrop)
        {
            ERMABusinessLibrary.Persistence.EstimatedLoadToDropRepository persistence = new ERMABusinessLibrary.Persistence.EstimatedLoadToDropRepository();
            persistence.RemoveEstimatedLoadsToDrop(IDsToDrop);
        }

        public void UpdateEstimatedLoadToDrop(int ID, string Quantity, string EffectiveYear, string AccountNumber, string Tariff, string Rate)
        {
            ERMABusinessLibrary.Persistence.EstimatedLoadToDropRepository persistence = new ERMABusinessLibrary.Persistence.EstimatedLoadToDropRepository();
            persistence.UpdateEstimatedLoadToDrop(ID, Quantity, EffectiveYear, AccountNumber, Tariff, Rate);
        }

        //public static void SortList<T>(string sortExpression, List<T> data)
        //{
        //    ERMABusinessLibrary.Persistence.EstimatedLoadToDropPersistence persistence = new ERMABusinessLibrary.Persistence.EstimatedLoadToDropPersistence();
        //    return persistence.GetEstimatedLoadToDropsForBidPackage(bidPackageId, sortExpression);
        //}

        // returns the newly inserted ID (or 0 if nothing inserted)
        //internal int Save(int bidPackageAccountID, double quantity, int effectiveYear)
        //{
        //    int result = 0;
        //    using (var dataContext = this.GetDataSource())
        //    {
        //        var queryResult = dataContext.EstimatedLoadToDrops.Where(p => p.BidPackageAccountID == bidPackageAccountID && p.EffectiveYear == effectiveYear);

        //        if (queryResult.Count() > 0)
        //        {
        //            dataContext.EstimatedLoadToDrops.DeleteAllOnSubmit(queryResult);
        //            dataContext.SubmitChanges();
        //        }

        //        EstimatedLoadToDrop newItem = new EstimatedLoadToDrop();
        //        newItem.BidPackageAccountID = bidPackageAccountID;
        //        newItem.EffectiveYear = effectiveYear;
        //        newItem.Quantity = quantity;
        //        newItem.Updated = DateTime.Now;
        //        newItem.Created = DateTime.Now;

        //        dataContext.EstimatedLoadToDrops.InsertOnSubmit(newItem);
        //        dataContext.SubmitChanges();

        //        result = newItem.ID;
        //    }

        //    return result;
        //}



    }
}
