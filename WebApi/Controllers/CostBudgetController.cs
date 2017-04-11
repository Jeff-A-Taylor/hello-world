using ApplicationInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CostBudgetController : ApiController
    {
        public void UpdateCostBudgetLocation(int newLocationId, int oldLocationId)
        {
            CostBudgetService service = new CostBudgetService();
            service.UpdateCostBudgetLocation(newLocationId, oldLocationId); ;
        }
    }
}
