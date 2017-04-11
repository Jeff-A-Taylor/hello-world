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
    public class PriceEscalationController : ApiController
    {
        public BidPackagePriceEscalationRate GetPriceEscalation(int bidPackageId)
        {
            PriceEscalationService service = new PriceEscalationService();
            return service.GetPriceEscalation(bidPackageId);
        }

        public bool RemovePriceEscalation(int bidPackageId)
        {
            PriceEscalationService service = new PriceEscalationService();
            return service.RemovePriceEscalation(bidPackageId);
        }

        public bool SavePriceEscalation(int bidPackageId, double percentIncrease)
        {
            PriceEscalationService service = new PriceEscalationService();
            return service.SavePriceEscalation(bidPackageId, percentIncrease);
        }
    }
}
