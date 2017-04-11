using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class PricingPointService
    {
        public int Add(int id, int commodityTypeId, string description, string tickerAbbreviation)
        {
            ERMABusinessLibrary.Persistence.PricingPointRepository persistence = new ERMABusinessLibrary.Persistence.PricingPointRepository();
            return persistence.Add(id, commodityTypeId, description, tickerAbbreviation);
        }

        public int Add(PricingPoint pricingPoint)
        {
            ERMABusinessLibrary.Persistence.PricingPointRepository persistence = new ERMABusinessLibrary.Persistence.PricingPointRepository();
            return persistence.Add(pricingPoint);
        }

        public void Remove(int id)
        {
            ERMABusinessLibrary.Persistence.PricingPointRepository persistence = new ERMABusinessLibrary.Persistence.PricingPointRepository();
            persistence.Remove(id);
        }

        public PricingPoint Find(int id)
        {
            ERMABusinessLibrary.Persistence.PricingPointRepository persistence = new ERMABusinessLibrary.Persistence.PricingPointRepository();
            return persistence.Find(id);
        }

        public List<PricingPoint> GetActiveList(bool doSpecificCommodityType, int commodityTypeId)
        {
            ERMABusinessLibrary.Persistence.PricingPointRepository persistence = new ERMABusinessLibrary.Persistence.PricingPointRepository();
            return persistence.GetActiveList(doSpecificCommodityType, commodityTypeId);
        }

        public List<PricingPoint> GetList(bool doSpecificCommodityType, int commodityTypeId)
        {
            ERMABusinessLibrary.Persistence.PricingPointRepository persistence = new ERMABusinessLibrary.Persistence.PricingPointRepository();
            return persistence.GetList(doSpecificCommodityType, commodityTypeId);
        }

        public List<PricingPoint> GetList()
        {
            ERMABusinessLibrary.Persistence.PricingPointRepository persistence = new ERMABusinessLibrary.Persistence.PricingPointRepository();
            return persistence.GetList();
        }

        public int GetPricingPointId(int companyId, bool dayAhead, int CommodityTypeId)
        {
            ERMABusinessLibrary.Persistence.PricingPointRepository persistence = new ERMABusinessLibrary.Persistence.PricingPointRepository();
            return persistence.GetPricingPointId(companyId, dayAhead, CommodityTypeId);
        }
    }
}
