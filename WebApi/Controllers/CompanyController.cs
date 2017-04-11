using ApplicationInterface;
using ERMABusinessLibrary.Commodities;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CompanyController : ApiController
    {
        public int Add(int CompanyId, string companyName, string address1, string address2, string city, string state, string zip, string zipExt, string url,
                       bool active, List<int> companyServiceIDs, bool calculatePriceToCompareFromRealTime, bool calculatePriceToCompareFromDayAhead)
        {
            CompanyService service = new CompanyService();
            return service.Add(CompanyId, companyName, address1, address2, city, state, zip, zipExt, url,
                       active, companyServiceIDs, calculatePriceToCompareFromRealTime, calculatePriceToCompareFromDayAhead);
        }

        // This method accepts a list of new service IDs, and a Dictionary of original service IDs (and their descriptions) and
        // determines if references to any deleted services still exist.  I.e. if a water/sewer service is to be deleted, but
        // water/sewer accounts still exist with the given companyID, a warning message will be generated.
        public string DetermineIfDeletedServicesStillHaveReferences(List<int> newServiceIDs, IDictionary<int, string> originalServices, int companyID, bool isActive)
        {
            CompanyService service = new CompanyService();
            return service.DetermineIfDeletedServicesStillHaveReferences(newServiceIDs, originalServices, companyID, isActive);
        }

        public CompanyServiceMatches getCompanyServiceMatch(int companyID, string serviceDescription, int? commodity, bool? isSupply)
        {
            CompanyService service = new CompanyService();
            return service.getCompanyServiceMatch(companyID, serviceDescription, commodity, isSupply);
        }

        public int Add(tbl_Company company)
        {
            CompanyService service = new CompanyService();
            return service.Add(company);
        }

        public IList<tbl_Company> Find(int bidPackageId, int locationId)
        {
            CompanyService service = new CompanyService();
            return service.Find(bidPackageId, locationId);
        }

        public void Remove(int id)
        {
            CompanyService service = new CompanyService();
            service.Remove(id);
        }

        public tbl_Company GetCompanyInfo(int accountId)
        {
            CompanyService service = new CompanyService();
            return service.GetCompanyInfo(accountId);
        }

        public tbl_Company Find(int id)
        {
            CompanyService service = new CompanyService();
            return service.Find(id);
        }

        public tbl_Company Find(string companyName)
        {
            CompanyService service = new CompanyService();
            return service.Find(companyName);
        }

        public IDictionary<int, string> GetDictionary(string startsWith, int serviceType)
        {
            CompanyService service = new CompanyService();
            return service.GetDictionary(startsWith, serviceType);
        }

        public List<tbl_Company> GetList(string startsWith, int serviceType, bool includeInactive)
        {
            CompanyService service = new CompanyService();
            return service.GetList(startsWith, serviceType, includeInactive);
        }

        public List<tbl_Company> GetActiveGasSuppliersWithBasisContracts()
        {
            CompanyService service = new CompanyService();
            return service.GetActiveGasSuppliersWithBasisContracts();
        }

        public List<tbl_Company> GetList(Commodity commodityType, bool isSupply)
        {
            CompanyService service = new CompanyService();
            return service.GetList(commodityType, isSupply);
        }

        public List<tbl_Company> GetList(Commodity commodityType)
        {
            CompanyService service = new CompanyService();
            return service.GetList(commodityType);
        }

        public List<DemandResponseProgramType> GetDemandResponseProgramTypes()
        {
            CompanyService service = new CompanyService();
            return service.GetDemandResponseProgramTypes();
        }
    }
}
