using ApplicationInterface;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CostItemToMeteredItemController : ApiController
    {
        public List<CostItemToMeteredItem> GetCostItemToMeteredItemList()
        {
            CostItemToMeteredItemService service = new CostItemToMeteredItemService();
            return service.GetCostItemToMeteredItemList();
        }
    }
}
