using ApplicationInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CommodityTypeController : ApiController
    {
        public IDictionary<int, string> GetList()
        {
            CommodityTypeService service = new CommodityTypeService();
            return service.GetList();
        }

        public IDictionary<int, string> GetElectricityGasList()
        {
            CommodityTypeService service = new CommodityTypeService();
            return service.GetElectricityGasList();
        }

        public string GetCommodityDescription(int CommodityTypeId)
        {
            CommodityTypeService service = new CommodityTypeService();
            return service.GetCommodityDescription(CommodityTypeId);
        }

        public int GetCommodityTypeID(string description)
        {
            CommodityTypeService service = new CommodityTypeService();
            return service.GetCommodityTypeID(description);
        }

        // get a list of all commodity types except coal/oil
        public IDictionary<int, string> GetListWithoutCoalOil()
        {
            CommodityTypeService service = new CommodityTypeService();
            return service.GetListWithoutCoalOil();
        }

        public int GetDefaultUnitId(int CommodityTypeId, bool isSupply)
        {
            CommodityTypeService service = new CommodityTypeService();
            return service.GetDefaultUnitId(CommodityTypeId, isSupply);
        }
    }
}
