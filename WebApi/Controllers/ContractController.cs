using ApplicationInterface;
using ERMABusinessLibrary.NaturalGasContracts;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ContractController : ApiController
    {
        public void UpdateContractComponents(int ContractComponentID, int contractItemID, DateTime BeginDate, DateTime EndDate, Double Quantity)
        {
            ContractService service = new ContractService();
            service.UpdateContractComponents(ContractComponentID, contractItemID, BeginDate, EndDate, Quantity);
        }

        public int AddContractComponents(int ContractID, int ContractComponentTypeID, DateTime BeginDate, DateTime EndDate, Double Quantity)
        {
            ContractService service = new ContractService();
            return service.AddContractComponents(ContractID, ContractComponentTypeID, BeginDate, EndDate, Quantity);
        }

        public void RemoveContractComponent(int ContractComponentID)
        {
            ContractService service = new ContractService();
            service.RemoveContractComponent(ContractComponentID);
        }

        public void RemoveAllContractComponents(int contractID)
        {
            ContractService service = new ContractService();
            service.RemoveAllContractComponents(contractID);
        }

        public void RemoveAllActualLoadDropped(int contractID)
        {
            ContractService service = new ContractService();
            service.RemoveAllActualLoadDropped(contractID);
        }

        public void RemoveAllActualYearEndPerformance(int contractID)
        {
            ContractService service = new ContractService();
            service.RemoveAllActualYearEndPerformance(contractID);
        }

        public void RemoveAllPeakShaving(int contractID)
        {
            ContractService service = new ContractService();
            service.RemoveAllPeakShaving(contractID);
        }

        public void RemoveAllBidPackageAccountPreviousContract(int contractID)
        {
            ContractService service = new ContractService();
            service.RemoveAllBidPackageAccountPreviousContract(contractID);
        }

        public void RemoveAllPriceLock(int contractID)
        {
            ContractService service = new ContractService();



            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllPriceLock(contractID);
        }

        public void RemoveAllContractValidationFindings(int contractID)
        {
            ContractService service = new ContractService();
            service.RemoveAllContractValidationFindings(contractID);
        }

        public void RemoveAllContractAttachments(int contractID)
        {
            ContractService service = new ContractService();
            service.RemoveAllContractAttachments(contractID);
        }

        public void RemoveAllContractNominations(int contractID)
        {
            ContractService service = new ContractService();
            service.RemoveAllContractNominations(contractID);
        }

        public List<ContractItem> GetContractItemsList(int CommodityTypeId, int ContractPricingTypeID)
        {
            ContractService service = new ContractService();
            return service.GetContractItemsList(CommodityTypeId, ContractPricingTypeID);
        }

        public void UpdateContractItem(int ID, string Description)
        {
            ContractService service = new ContractService();
            service.UpdateContractItem(ID, Description);
        }

        public ContractItem GetContractItem(int ID)
        {
            ContractService service = new ContractService();
            return service.GetContractItem(ID);
        }

        public int AddContractItem(string description, int commodityTypeId)
        {
            ContractService service = new ContractService();
            return service.AddContractItem(description, commodityTypeId);
        }

        public void RemoveContractItem(int ID)
        {
            ContractService service = new ContractService();
            service.RemoveContractItem(ID);
        }

        public List<ContractComponentDetails> GetContractComponents(int contractID)
        {
            ContractService service = new ContractService();
            return service.GetContractComponents(contractID);
        }

        public ContractComponent GetContractComponent(int contractComponentID)
        {
            ContractService service = new ContractService();
            return service.GetContractComponent(contractComponentID);
        }

        public List<View_Contract> GetList(int accountId, bool includeExpiredContracts)
        {
            ContractService service = new ContractService();
            return service.GetList(accountId, includeExpiredContracts);
        }

        public List<View_Contract> GetList(bool onlyCurrentContracts, int commodityTypeId, string searchString, string sortExpression, bool includeCancelled)
        {
            ContractService service = new ContractService();
            return service.GetList(onlyCurrentContracts, commodityTypeId, searchString, sortExpression, includeCancelled);
        }

        public List<View_NaturalGasContract> GetNaturalGasAccountContracts(int locationID, bool includeCancelled)
        {
            ContractService service = new ContractService();
            return service.GetNaturalGasAccountContracts(locationID, includeCancelled);
        }

        public List<View_Contract> GetElectricityAccountContracts(int locationId, int accountId, bool includeCancelled)
        {
            ContractService service = new ContractService();
            return service.GetElectricityAccountContracts(locationId, accountId, includeCancelled);
        }

        public int AddContract(int LocationID, int PricingTypeID, DateTime BeginDate, DateTime EndDate, int SupplierID, int PricingPointID, int CommodityType, int? bidId, bool isCancelled, bool sendDropNotices)
        {
            ContractService service = new ContractService();
            return service.AddContract(LocationID, PricingTypeID, BeginDate, EndDate, SupplierID, PricingPointID, CommodityType, bidId, isCancelled, sendDropNotices);
        }

        public void UpdateNaturalGasContract(int ContractID, int ContractTypeID, DateTime ContractBegin, DateTime ContractEnd, int SupplierID, int PricingPointID, bool isCancelled, bool sendDropNotices)
        {
            ContractService service = new ContractService();
            service.UpdateNaturalGasContract(ContractID, ContractTypeID, ContractBegin, ContractEnd, SupplierID, PricingPointID, isCancelled, sendDropNotices);
        }

        public View_NaturalGasContract GetNaturalGasContract(int contractID)
        {
            ContractService service = new ContractService();
            return service.GetNaturalGasContract(contractID);
        }

        public void RemoveContract(int contractID)
        {
            ContractService service = new ContractService();
            service.RemoveContract(contractID);
        }

        public List<ContractPricingType> GetNaturalGasContractPricingTypeList()
        {
            ContractService service = new ContractService();
            return service.GetNaturalGasContractPricingTypeList();
        }

        public List<ContractPricingType> GetElectricityContractPricingTypeList()
        {
            ContractService service = new ContractService();
            return service.GetElectricityContractPricingTypeList();
        }

        public void UpdateElectricityContract(int SupplierID, DateTime ContractBegin, DateTime ContractEnd, int ContractTypeID, int PricingPointID, int ContractID, bool isCancelled, bool sendDropNotices)
        {
            ContractService service = new ContractService();
            service.UpdateElectricityContract(SupplierID, ContractBegin, ContractEnd, ContractTypeID, PricingPointID, ContractID, isCancelled, sendDropNotices);
        }

        public View_Contract GetContract(int contractId)
        {
            ContractService service = new ContractService();
            return service.GetContract(contractId);
        }

        public List<spERMAGetExpiringContractsResult> GetExpiringContracts(int? numberDays, DateTime? startDate, DateTime? endDate, List<int> contractTypeIDs)
        {
            ContractService service = new ContractService();
            return service.GetExpiringContracts(numberDays, startDate, endDate, contractTypeIDs);
        }

        public List<spERMAGetFacilityContractTermsResult> GetFacilityContractTerms(bool includeElectricitySupply,
                                                                                   bool includeGasSupply,
                                                                                   bool includeElectricityDemandResponse,
                                                                                   string commaSeparatedFacCodes,
                                                                                   bool includeAccountsNotUnderContract,
                                                                                   DateTime? startDate,
                                                                                   DateTime? endDate)
        {
            ContractService service = new ContractService();
            return service.GetFacilityContractTerms(includeElectricitySupply,
                                                                                   includeGasSupply,
                                                                                   includeElectricityDemandResponse,
                                                                                   commaSeparatedFacCodes,
                                                                                   includeAccountsNotUnderContract,
                                                                                   startDate,
                                                                                   endDate);
        }

        public List<ActualLoadDropped> GetActualLoadDropped(int contractID)
        {
            ContractService service = new ContractService();
            return service.GetActualLoadDropped(contractID);
        }

        public void RemoveActualLoadDropped(int ID)
        {
            ContractService service = new ContractService();
            service.RemoveActualLoadDropped(ID);
        }

        public void AddActualLoadDropped(int contractID, DateTime EffectiveDate, double Quantity)
        {
            ContractService service = new ContractService();
            service.AddActualLoadDropped(contractID, EffectiveDate, Quantity);
        }

        public void UpdateActualLoadDropped(int ID, int contractID, DateTime EffectiveDate, double Quantity)
        {
            ContractService service = new ContractService();
            service.UpdateActualLoadDropped(ID, contractID, EffectiveDate, Quantity);
        }

        public List<ActualYearEndPerformance> GetActualYearEndPerformance(int contractID)
        {
            ContractService service = new ContractService();
            return service.GetActualYearEndPerformance(contractID);
        }

        public void RemoveActualYearEndPerformance(int ID)
        {
            ContractService service = new ContractService();
            service.RemoveActualYearEndPerformance(ID);
        }

        public void AddActualYearEndPerformance(int contractID, DateTime EffectiveDate, double Quantity)
        {
            ContractService service = new ContractService();
            service.AddActualYearEndPerformance(contractID, EffectiveDate, Quantity);
        }

        public void UpdateActualYearEndPerformance(int ID, int contractID, DateTime EffectiveDate, double Quantity)
        {
            ContractService service = new ContractService();
            service.UpdateActualYearEndPerformance(ID, contractID, EffectiveDate, Quantity);
        }

        //
        // This method gets all of the electricity supply contracts for the given LocationID
        // whose contract dates overlap with the given start/end dates.
        //
        public List<View_Contract> getElectricitySupplyContracts(int locationID, DateTime startDate, DateTime endDate)
        {
            ContractService service = new ContractService();
            return service.getElectricitySupplyContracts(locationID, startDate, endDate);
        }

        public List<spGetExpiringBidPackagesResult> getExpiringBidPackages(int numberDays)
        {
            ContractService service = new ContractService();
            return service.getExpiringBidPackages(numberDays);
        }

        public List<spGetExpiringManualContractsResult> getExpiringManualContracts(int numberDays)
        {
            ContractService service = new ContractService();
            return service.getExpiringManualContracts(numberDays);
        }
    }
}
