using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERMABusinessLibrary.Commodities;
using ERMABusinessLibrary.Company;
using ERMABusinessLibrary.Persistence;

namespace ApplicationInterface
{

    public enum CompanyServiceTypesEnum
    {
        ElectricDistributionCompany = 1,
        NaturalGasUtility = 2,
        ESCO = 3,
        ElectricGenerationSupplyCompany = 4,
        NaturalGasSupply = 5,
        Steam = 6,
        WaterSewer = 7,
        CurtailmentServiceProvider = 8
    }


    public class CompanyService
    {
        public int Add(int CompanyId, string companyName, string address1, string address2, string city, string state, string zip, string zipExt, string url,
                       bool active, List<int> companyServiceIDs, bool calculatePriceToCompareFromRealTime, bool calculatePriceToCompareFromDayAhead)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.Add(CompanyId, companyName, address1, address2, city, state, zip, zipExt, url,
                       active, companyServiceIDs, calculatePriceToCompareFromRealTime, calculatePriceToCompareFromDayAhead);
        }

        // This method accepts a list of new service IDs, and a Dictionary of original service IDs (and their descriptions) and
        // determines if references to any deleted services still exist.  I.e. if a water/sewer service is to be deleted, but
        // water/sewer accounts still exist with the given companyID, a warning message will be generated.
        public string DetermineIfDeletedServicesStillHaveReferences(List<int> newServiceIDs, IDictionary<int, string> originalServices, int companyID, bool isActive)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.DetermineIfDeletedServicesStillHaveReferences(newServiceIDs, originalServices, companyID, isActive);
        }

        public CompanyServiceMatches getCompanyServiceMatch(int companyID, string serviceDescription, int? commodity, bool? isSupply)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.getCompanyServiceMatch(companyID, serviceDescription, commodity, isSupply);
        }

        public int Add(tbl_Company company)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.Add(company);
        }

        public IList<tbl_Company> Find(int bidPackageId, int locationId)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.Find(bidPackageId, locationId);
        }

        public void Remove(int id)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            persistence.Remove(id);
        }

        public tbl_Company GetCompanyInfo(int accountId)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.GetCompanyInfo(accountId);
        }

        public tbl_Company Find(int id)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.Find(id);
        }

        public tbl_Company Find(string companyName)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.Find(companyName);
        }

        public IDictionary<int, string> GetDictionary(string startsWith, int serviceType)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.GetDictionary(startsWith, serviceType);
        }

        public List<tbl_Company> GetList(string startsWith, int serviceType, bool includeInactive)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.GetList(startsWith, serviceType, includeInactive);
        }

        public List<tbl_Company> GetActiveGasSuppliersWithBasisContracts()
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.GetActiveGasSuppliersWithBasisContracts();
        }

        public List<tbl_Company> GetList(Commodity commodityType, bool isSupply)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.GetList(commodityType, isSupply);
        }

        public List<tbl_Company> GetList(Commodity commodityType)
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.GetList(commodityType);
        }

        public List<DemandResponseProgramType> GetDemandResponseProgramTypes()
        {
            ERMABusinessLibrary.Persistence.CompanyRepository persistence = new ERMABusinessLibrary.Persistence.CompanyRepository();
            return persistence.GetDemandResponseProgramTypes();
        }
    }
}
