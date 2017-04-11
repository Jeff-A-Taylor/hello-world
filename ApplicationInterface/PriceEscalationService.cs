using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class PriceEscalationService
    {
        public BidPackagePriceEscalationRate GetPriceEscalation(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.PriceEscalationRepository persistence = new ERMABusinessLibrary.Persistence.PriceEscalationRepository();
            return persistence.GetPriceEscalation(bidPackageId);
        }

        public bool RemovePriceEscalation(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.PriceEscalationRepository persistence = new ERMABusinessLibrary.Persistence.PriceEscalationRepository();
            return persistence.RemovePriceEscalation(bidPackageId);
        }

        public bool SavePriceEscalation(int bidPackageId, double percentIncrease)
        {
            ERMABusinessLibrary.Persistence.PriceEscalationRepository persistence = new ERMABusinessLibrary.Persistence.PriceEscalationRepository();
            return persistence.SavePriceEscalation(bidPackageId, percentIncrease);
        }
    }
}
