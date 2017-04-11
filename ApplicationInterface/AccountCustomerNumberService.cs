using ERMABusinessLibrary.Persistence;
using System.Collections.Generic;

namespace ApplicationInterface
{
    public class AccountCustomerNumberService
    {
        public List<AccountCustomerNumberSerializable> GetAllAccountCustomerNumbers(int accountId)
        {
            List<AccountCustomerNumberSerializable> list = new List<AccountCustomerNumberSerializable>();
            ERMABusinessLibrary.Persistence.AccountCustomerNumberRepository persistence = new ERMABusinessLibrary.Persistence.AccountCustomerNumberRepository();
            list = persistence.GetAllAccountCustomerNumbers(accountId);
            return list;
        }

        public void UpdateCustomerNumbers(List<AccountCustomerNumberSerializable> accountCustomerNumbers, int accountId)
        {
            ERMABusinessLibrary.Persistence.AccountCustomerNumberRepository persistence = new ERMABusinessLibrary.Persistence.AccountCustomerNumberRepository();
            persistence.UpdateCustomerNumbers(accountCustomerNumbers, accountId);
        }

//        //public void AddCustomerNumber(int accountId, string customerNumber, bool isActive, DateTime? expirationDate)
//        //{
//        //    using (var dataContext = this.GetDataSource())
//        //    {
//        //        AccountCustomerNumber newNumber = new AccountCustomerNumber();
//        //        newNumber.AccountId = accountId;
//        //        newNumber.CustomerNumber = customerNumber;
//        //        newNumber.IsActive = isActive;
//        //        newNumber.ExpirationDate = expirationDate;
//        //        newNumber.Created = DateTime.Now;
//        //        newNumber.Updated = DateTime.Now;

//        //        dataContext.AccountCustomerNumbers.InsertOnSubmit(newNumber);
//        //        dataContext.SubmitChanges();
//        //    }
//        //}

//        //public void UpdateCustomerNumber(int accountCustomerNumberId, string customerNumber, bool isActive,
//        //    DateTime? expirationDate)
//        //{
//        //    using (var dataContext = this.GetDataSource())
//        //    {
//        //        var query = from data in dataContext.AccountCustomerNumbers
//        //                    where data.Id == accountCustomerNumberId
//        //                    select data;

//        //        if (query.Count() > 0)
//        //        {
//        //            AccountCustomerNumber existingNumber = query.First();
//        //            existingNumber.CustomerNumber = customerNumber;
//        //            existingNumber.IsActive = isActive;
//        //            existingNumber.ExpirationDate = expirationDate;
//        //            existingNumber.Updated = DateTime.Now;

//        //            dataContext.SubmitChanges();
//        //        }
//        //    }
//        //}

//        //public void DeleteCustomerNumber(int accountCustomerNumberId)
//        //{
//        //    using (var dataContext = this.GetDataSource())
//        //    {
//        //        var query = from data in dataContext.AccountCustomerNumbers
//        //                    where data.Id == accountCustomerNumberId
//        //                    select data;

//        //        if (query.Count() > 0)
//        //        {
//        //            AccountCustomerNumber existingNumber = query.First();
//        //            dataContext.AccountCustomerNumbers.DeleteOnSubmit(existingNumber);
//        //            dataContext.SubmitChanges();
//        //        }
//        //    }
//        //}
    }
}
