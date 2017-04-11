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
    public class PeakLoadContributionController : ApiController
    {
        public int Add(int id, int locationId, double quantity, DateTime effectiveDate, bool isCapacityType, bool isTransmissionType)
        {
            PeakLoadContributionService service = new PeakLoadContributionService();
            return service.Add(id, locationId, quantity, effectiveDate, isCapacityType, isTransmissionType);
        }

        /// <summary>
        /// for testing
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            PeakLoadContributionService service = new PeakLoadContributionService();
            service.Remove(id);
        }

        public void UpdatePeakLoadContributionLocation(int newLocationId, int oldLocationId)
        {
            PeakLoadContributionService service = new PeakLoadContributionService();
            service.UpdatePeakLoadContributionLocation(newLocationId, oldLocationId);
        }

        public List<ElectricPeakLoadContribution> GetList(int locationId)
        {
            PeakLoadContributionService service = new PeakLoadContributionService();
            return service.GetList(locationId);
        }
    }
}
