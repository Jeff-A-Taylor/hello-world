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
    public class NetworkIntegrationTransmissionController : ApiController
    {
        public int Add(int id, int companyId, double quantity, DateTime effectiveDate)
        {
            NetworkIntegrationTransmissionService service = new NetworkIntegrationTransmissionService();
            return service.Add(id, companyId, quantity, effectiveDate);
        }

        /// <summary>
        /// for testing
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            NetworkIntegrationTransmissionService service = new NetworkIntegrationTransmissionService();
            service.Remove(id);
        }

        public List<NetworkIntegrationTransmissionCharge> GetList(int companyId, DateTime termBegin, DateTime termEnd)
        {
            NetworkIntegrationTransmissionService service = new NetworkIntegrationTransmissionService();
            return service.GetList(companyId, termBegin, termEnd);
        }

        public List<NetworkIntegrationTransmissionCharge> GetList(int companyId)
        {
            NetworkIntegrationTransmissionService service = new NetworkIntegrationTransmissionService();
            return service.GetList(companyId);
        }
    }
}
