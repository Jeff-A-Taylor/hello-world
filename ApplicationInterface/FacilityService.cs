using ERMABusinessLibrary.Persistence;
using ERMABusinessLibrary.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class FacilityService
    {
        public int AddFacility(string agency, string facility)
        {
            ERMABusinessLibrary.Persistence.FacilityRepository persistence = new ERMABusinessLibrary.Persistence.FacilityRepository();
            return persistence.AddFacility(agency, facility);
        }

        public List<tblFacilityMaster> GetFacilities(string agency)
        {
            ERMABusinessLibrary.Persistence.FacilityRepository persistence = new ERMABusinessLibrary.Persistence.FacilityRepository();
            return persistence.GetFacilities(agency);
        }

        public List<tblFacilityMaster> GetFacilitiesWithActiveBasisContracts(List<int> companyIDs, string[] agencies)
        {
            ERMABusinessLibrary.Persistence.FacilityRepository persistence = new ERMABusinessLibrary.Persistence.FacilityRepository();
            return persistence.GetFacilitiesWithActiveBasisContracts(companyIDs, agencies);
        }

        public List<tblFacilityMaster> GetFacilities(string agency, string userId)
        {
            ERMABusinessLibrary.Persistence.FacilityRepository persistence = new ERMABusinessLibrary.Persistence.FacilityRepository();
            return persistence.GetFacilities(agency, userId);
        }

        public tblFacilityMaster Get(int facCode)
        {
            ERMABusinessLibrary.Persistence.FacilityRepository persistence = new ERMABusinessLibrary.Persistence.FacilityRepository();
            return persistence.Get(facCode);
        }

        public List<spCheckForExistingFacilityResult> CheckForExistingFacility(string newFacility)
        {
            ERMABusinessLibrary.Persistence.FacilityRepository persistence = new ERMABusinessLibrary.Persistence.FacilityRepository();
            return persistence.CheckForExistingFacility(newFacility);
        }
    }
}
