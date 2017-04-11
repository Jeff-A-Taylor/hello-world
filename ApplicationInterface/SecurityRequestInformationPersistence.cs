//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ApplicationInterface
//{
//   public class SecurityRequestInformationPersistence
//   {
//      /// <summary>
//      /// 
//      /// </summary>
//      /// <param name="id"></param>
//      /// <param name="pricingPointId">Must be greater than 0</param>
//      /// <param name="ticker"></param>
//      /// <param name="bloombergUniqueId"></param>
//      /// <param name="contractDateTime"></param>
//      /// <param name="isActive"></param>
//      /// <param name="expirationDate"></param>
//      /// <param name="scheduleId"></param>
//      /// <returns></returns>
//      public int Add(int id, int pricingPointId, string ticker, string bloombergUniqueId, DateTime contractDateTime, bool isActive, DateTime expirationDate, int scheduleId)
//      {
//         int result = 0;

//         if (pricingPointId > 0 && string.IsNullOrEmpty(ticker) == false)
//         {
//            using (var dataContext = this.GetDataSource())
//            {
//               if (id > 0)
//               {
//                  var queryResult = from data in dataContext.SecurityRequestInformations
//                                    where data.ID == id
//                                    select data;

//                  var originalData = queryResult.FirstOrDefault();
//                  if (originalData != null)
//                  {
//                     originalData.BloombergUniqueID = bloombergUniqueId;
//                     originalData.PricingPointID = pricingPointId;
//                     originalData.Ticker = ticker;
//                     originalData.ContractDateTime = contractDateTime;

//                     originalData.IsActive = isActive;
//                     originalData.ExpirationDate = expirationDate;
//                     originalData.ScheduleId = scheduleId;

//                     result = id;
//                     dataContext.SubmitChanges();
//                  }
//                  else
//                  {
//                     //insert
//                     result = SecurityRequestInformationPersistence.InsertSecurityRequestInformation(dataContext, id, pricingPointId, ticker, bloombergUniqueId, ref contractDateTime, isActive, ref expirationDate, scheduleId);
//                  }
//               }
//               else
//               {
//                  //insert
//                  result =  SecurityRequestInformationPersistence.InsertSecurityRequestInformation(dataContext, id, pricingPointId, ticker, bloombergUniqueId, ref contractDateTime, isActive, ref expirationDate, scheduleId); 
//               }

//            }
//         }

//         return result;
//      }

//      private static int InsertSecurityRequestInformation(DataClassesNewERMADataContext datacontext, int id, int pricingPointId, string ticker, string bloombergUniqueId, ref DateTime contractDateTime, bool isActive, ref DateTime expirationDate, int scheduleId)
//      {
//         SecurityRequestInformation dataToAdd = SecurityRequestInformationPersistence.CreateSecurityRequestInformation(id, pricingPointId, ticker, bloombergUniqueId, ref contractDateTime, isActive, ref expirationDate, scheduleId);
//         datacontext.SecurityRequestInformations.InsertOnSubmit(dataToAdd);
//         datacontext.SubmitChanges();
         
//         return dataToAdd.ID;
//      }

//      private static SecurityRequestInformation CreateSecurityRequestInformation(int id, int pricingPointId, string ticker, string bloombergUniqueId, ref DateTime contractDateTime, bool isActive, ref DateTime expirationDate, int scheduleId)
//      {
//         SecurityRequestInformation result = new SecurityRequestInformation();

//         result.ID = id;
//         result.BloombergUniqueID = bloombergUniqueId;
//         result.PricingPointID = pricingPointId;
//         result.Ticker = ticker;

//         result.ContractDateTime = contractDateTime;
//         result.IsActive = isActive;
//         result.ExpirationDate = expirationDate;
//         result.ScheduleId = scheduleId;
//         result.Created = DateTime.Now;

//         return result;
//      }

//      public void SetActive(int id, bool isActive)
//      {
//         using (var dataContext = this.GetDataSource())
//         {
//            var resultQuery = from data in dataContext.SecurityRequestInformations where data.ID == id select data;
//            var dataToRemove = resultQuery.FirstOrDefault();

//            if (dataToRemove != null)
//            {
//               dataToRemove.IsActive = isActive;
//               dataContext.SubmitChanges();
//            }
//         }
//      }

//      public void Remove(int id)
//      {
//         using (var dataContext = this.GetDataSource())
//         {
//            var resultQuery = from data in dataContext.SecurityRequestInformations where data.ID == id select data;
//            var dataToRemove = resultQuery.FirstOrDefault();

//            if (dataToRemove != null)
//            {
//               dataContext.SecurityRequestInformations.DeleteOnSubmit(dataToRemove);
//               dataContext.SubmitChanges(); 
//            }
//         }
//      }

//      public SecurityRequestInformation Find(int id)
//      {
//         using (var dataContext = this.GetDataSource())
//         {
//            var resultQuery = from data in dataContext.SecurityRequestInformations where data.ID == id select data;
//            var result = resultQuery.FirstOrDefault();
            
//            return result;
//         }
//      }

//      public List<SecurityRequestInformation> GetList(bool activeOnly)
//      {
//         List<SecurityRequestInformation> result = null;

//         using (var dataContext = this.GetDataSource())
//         {
//            var resultQuery = from data in dataContext.SecurityRequestInformations select data;
//            var dataToRemove = resultQuery.FirstOrDefault();

//            if (activeOnly == true)
//            {
//               result = resultQuery.Where(d => d.IsActive == true).ToList();
//            }
//            else
//            {
//               result = resultQuery.ToList();
//            }
//         }

//         return result;
//      }

//      /// <summary>
//      /// return active items only
//      /// </summary>
//      /// <returns></returns>
//      public List<SecurityRequestInformation> GetList()
//      {
//         return this.GetList(true);
//      }

//      private DataClassesNewERMADataContext GetDataSource()
//      {
//         return DataClassesFactory.CreateNewERMADataContext();
//      }
//   }
//}
