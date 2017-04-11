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
    public class PricingPointController : ApiController
    {
        public int Add(int id, int commodityTypeId, string description, string tickerAbbreviation)
        {
            PricingPointService service = new PricingPointService();
            return service.Add(id, commodityTypeId, description, tickerAbbreviation);
        }

        public int Add(PricingPoint pricingPoint)
        {
            PricingPointService service = new PricingPointService();
            return service.Add(pricingPoint);
        }

        public void Remove(int id)
        {
            PricingPointService service = new PricingPointService();
            service.Remove(id);
        }

        public PricingPoint Find(int id)
        {
            PricingPointService service = new PricingPointService();
            return service.Find(id);
        }

        public List<PricingPoint> GetActiveList(bool doSpecificCommodityType, int commodityTypeId)
        {
            PricingPointService service = new PricingPointService();
            return service.GetActiveList(doSpecificCommodityType, commodityTypeId);
        }

        public List<PricingPoint> GetList(bool doSpecificCommodityType, int commodityTypeId)
        {
            PricingPointService service = new PricingPointService();
            return service.GetList(doSpecificCommodityType, commodityTypeId);
        }

        public List<PricingPoint> GetList()
        {
            PricingPointService service = new PricingPointService();
            return service.GetList();
        }

        public int GetPricingPointId(int companyId, bool dayAhead, int CommodityTypeId)
        {
            PricingPointService service = new PricingPointService();
            return service.GetPricingPointId(companyId, dayAhead, CommodityTypeId);
        }
    }
}
