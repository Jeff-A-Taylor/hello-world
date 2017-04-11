using ERMABusinessLibrary.Commodities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
   public class CommodityTypeService
   {
      /// <summary>
      /// A dropdown can use an IDictionary as Key-Value.
      /// </summary>
      /// <returns></returns>
      public IDictionary<int, string> GetList()
      {
            IDictionary<int, string> dictionary = new Dictionary<int, string>();
            ERMABusinessLibrary.Persistence.CommodityTypeRepository persistence = new ERMABusinessLibrary.Persistence.CommodityTypeRepository();
            dictionary = persistence.GetList();
            return dictionary;
      }

      public IDictionary<int, string> GetElectricityGasList()
      {
          ERMABusinessLibrary.Persistence.CommodityTypeRepository persistence = new ERMABusinessLibrary.Persistence.CommodityTypeRepository();
          return persistence.GetElectricityGasList();
      }

      public string GetCommodityDescription(int CommodityTypeId)
      {
          ERMABusinessLibrary.Persistence.CommodityTypeRepository persistence = new ERMABusinessLibrary.Persistence.CommodityTypeRepository();
          return GetCommodityDescription(CommodityTypeId);
      }

      public int GetCommodityTypeID(string description)
      {
          ERMABusinessLibrary.Persistence.CommodityTypeRepository persistence = new ERMABusinessLibrary.Persistence.CommodityTypeRepository();
          return GetCommodityTypeID(description);
      }

      // get a list of all commodity types except coal/oil
      public IDictionary<int, string> GetListWithoutCoalOil()
      {
          ERMABusinessLibrary.Persistence.CommodityTypeRepository persistence = new ERMABusinessLibrary.Persistence.CommodityTypeRepository();
          return persistence.GetListWithoutCoalOil();
      }

      public int GetDefaultUnitId(int CommodityTypeId, bool isSupply)
      {
          ERMABusinessLibrary.Persistence.CommodityTypeRepository persistence = new ERMABusinessLibrary.Persistence.CommodityTypeRepository();
          return persistence.GetDefaultUnitId(CommodityTypeId, isSupply);
      }
   }
}
