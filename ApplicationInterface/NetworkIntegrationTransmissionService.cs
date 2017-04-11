using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class NetworkIntegrationTransmissionService
    {
        public int Add(int id, int companyId, double quantity, DateTime effectiveDate)
        {
            ERMABusinessLibrary.Persistence.NetworkIntegrationTransmissionRepository persistence = new ERMABusinessLibrary.Persistence.NetworkIntegrationTransmissionRepository();
            return persistence.Add(id, companyId, quantity, effectiveDate);
        }

        /// <summary>
        /// for testing
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            ERMABusinessLibrary.Persistence.NetworkIntegrationTransmissionRepository persistence = new ERMABusinessLibrary.Persistence.NetworkIntegrationTransmissionRepository();
            persistence.Remove(id);
        }

        public List<NetworkIntegrationTransmissionCharge> GetList(int companyId, DateTime termBegin, DateTime termEnd)
        {
            ERMABusinessLibrary.Persistence.NetworkIntegrationTransmissionRepository persistence = new ERMABusinessLibrary.Persistence.NetworkIntegrationTransmissionRepository();
            return persistence.GetList(companyId, termBegin, termEnd);
        }

        public List<NetworkIntegrationTransmissionCharge> GetList(int companyId)
        {
            ERMABusinessLibrary.Persistence.NetworkIntegrationTransmissionRepository persistence = new ERMABusinessLibrary.Persistence.NetworkIntegrationTransmissionRepository();
            return persistence.GetList(companyId);
        }
    }
}
