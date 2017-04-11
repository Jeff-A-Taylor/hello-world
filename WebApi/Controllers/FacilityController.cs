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
    public class FacilityController : ApiController
    {
        public int AddFacility(string agency, string facility)
        {
            FacilityService service = new FacilityService();
            return service.AddFacility(agency, facility);
        }

        public List<tblFacilityMaster> GetFacilities(string agency)
        {
            FacilityService service = new FacilityService();
            return service.GetFacilities(agency);
        }

        public List<tblFacilityMaster> GetFacilitiesWithActiveBasisContracts(List<int> companyIDs, string[] agencies)
        {
            FacilityService service = new FacilityService();
            return service.GetFacilitiesWithActiveBasisContracts(companyIDs, agencies);
        }

        public List<tblFacilityMaster> GetFacilities(string agency, string userId)
        {
            FacilityService service = new FacilityService();
            return service.GetFacilities(agency, userId);
        }

        public tblFacilityMaster Get(int facCode)
        {
            FacilityService service = new FacilityService();
            return service.Get(facCode);
        }

        public List<spCheckForExistingFacilityResult> CheckForExistingFacility(string newFacility)
        {
            FacilityService service = new FacilityService();
            return service.CheckForExistingFacility(newFacility);
        }
    }
}
