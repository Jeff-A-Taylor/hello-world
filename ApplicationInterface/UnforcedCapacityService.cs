using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class UnforcedCapacityService
    {
        public int Add(int id, int companyId, double quantity, DateTime effectiveDate)
        {
            ERMABusinessLibrary.Persistence.UnforcedCapacityRepository persistence = new ERMABusinessLibrary.Persistence.UnforcedCapacityRepository();
            return persistence.Add(id, companyId, quantity, effectiveDate);
        }

        /// <summary>
        /// for testing
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            ERMABusinessLibrary.Persistence.UnforcedCapacityRepository persistence = new ERMABusinessLibrary.Persistence.UnforcedCapacityRepository();
            persistence.Remove(id);
        }

        public List<UnforcedCapacityCharge> GetList(int companyId, DateTime termEnd)
        {
            ERMABusinessLibrary.Persistence.UnforcedCapacityRepository persistence = new ERMABusinessLibrary.Persistence.UnforcedCapacityRepository();
            return persistence.GetList(companyId, termEnd);
        }

        public List<UnforcedCapacityCharge> GetList(int companyId, DateTime termBegin, DateTime termEnd)
        {
            ERMABusinessLibrary.Persistence.UnforcedCapacityRepository persistence = new ERMABusinessLibrary.Persistence.UnforcedCapacityRepository();
            return persistence.GetList(companyId, termBegin, termEnd);
        }

        public List<UnforcedCapacityCharge> GetList(int companyId)
        {
            ERMABusinessLibrary.Persistence.UnforcedCapacityRepository persistence = new ERMABusinessLibrary.Persistence.UnforcedCapacityRepository();
            return persistence.GetList(companyId);
        }
    }
}
