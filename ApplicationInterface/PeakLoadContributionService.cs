using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class PeakLoadContributionService
    {
        public int Add(int id, int locationId, double quantity, DateTime effectiveDate, bool isCapacityType, bool isTransmissionType)
        {
            ERMABusinessLibrary.Persistence.PeakLoadContributionRepository persistence = new ERMABusinessLibrary.Persistence.PeakLoadContributionRepository();
            return persistence.Add(id, locationId, quantity, effectiveDate, isCapacityType, isTransmissionType);
        }

        /// <summary>
        /// for testing
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            ERMABusinessLibrary.Persistence.PeakLoadContributionRepository persistence = new ERMABusinessLibrary.Persistence.PeakLoadContributionRepository();
            persistence.Remove(id);
        }

        public void UpdatePeakLoadContributionLocation(int newLocationId, int oldLocationId)
        {
            ERMABusinessLibrary.Persistence.PeakLoadContributionRepository persistence = new ERMABusinessLibrary.Persistence.PeakLoadContributionRepository();
            persistence.UpdatePeakLoadContributionLocation(newLocationId, oldLocationId);
        }

        public List<ElectricPeakLoadContribution> GetList(int locationId)
        {
            ERMABusinessLibrary.Persistence.PeakLoadContributionRepository persistence = new ERMABusinessLibrary.Persistence.PeakLoadContributionRepository();
            return persistence.GetList(locationId);
        }
    }
}

