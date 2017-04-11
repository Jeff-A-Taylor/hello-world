using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class CostItemToMeteredItemService
    {
        public List<CostItemToMeteredItem> GetCostItemToMeteredItemList()
        {
            ERMABusinessLibrary.Persistence.CostItemToMeteredItemRepository persistence = new ERMABusinessLibrary.Persistence.CostItemToMeteredItemRepository();
            return persistence.GetCostItemToMeteredItemList();
        }
    }
}
