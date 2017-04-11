using System;
using System.Collections.Generic;
using ERMABusinessLibrary.NaturalGasContracts;
using ERMABusinessLibrary.Persistence;

namespace ApplicationInterface
{

    public class ContractService
    {
        public void UpdateContractComponents(int ContractComponentID, int contractItemID, DateTime BeginDate, DateTime EndDate, Double Quantity)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.UpdateContractComponents(ContractComponentID, contractItemID, BeginDate, EndDate, Quantity);
        }

        public int AddContractComponents(int ContractID, int ContractComponentTypeID, DateTime BeginDate, DateTime EndDate, Double Quantity)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.AddContractComponents(ContractID, ContractComponentTypeID, BeginDate, EndDate, Quantity);
        }

        public void RemoveContractComponent(int ContractComponentID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveContractComponent(ContractComponentID);
        }

        public void RemoveAllContractComponents(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllContractComponents(contractID);
        }

        public void RemoveAllActualLoadDropped(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllActualLoadDropped(contractID);
        }

        public void RemoveAllActualYearEndPerformance(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllActualYearEndPerformance(contractID);
        }

        public void RemoveAllPeakShaving(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllPeakShaving(contractID);
        }

        public void RemoveAllBidPackageAccountPreviousContract(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllBidPackageAccountPreviousContract(contractID);
        }

        public void RemoveAllPriceLock(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllPriceLock(contractID);
        }

        public void RemoveAllContractValidationFindings(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllContractValidationFindings(contractID);
        }

        public void RemoveAllContractAttachments(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllContractAttachments(contractID);
        }

        public void RemoveAllContractNominations(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveAllContractNominations(contractID);
        }

        public List<ContractItem> GetContractItemsList(int CommodityTypeId, int ContractPricingTypeID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetContractItemsList(CommodityTypeId, ContractPricingTypeID);
        }

        public void UpdateContractItem(int ID, string Description)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.UpdateContractItem(ID, Description);
        }

        public ContractItem GetContractItem(int ID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetContractItem(ID);
        }

        public int AddContractItem(string description, int commodityTypeId)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.AddContractItem(description, commodityTypeId);
        }

        public void RemoveContractItem(int ID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveContractItem(ID);
        }

        public List<ContractComponentDetails> GetContractComponents(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetContractComponents(contractID);
        }

        public ContractComponent GetContractComponent(int contractComponentID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetContractComponent(contractComponentID);
        }

        public List<View_Contract> GetList(int accountId, bool includeExpiredContracts)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence. GetList(accountId, includeExpiredContracts);
        }

        public List<View_Contract> GetList(bool onlyCurrentContracts, int commodityTypeId, string searchString, string sortExpression, bool includeCancelled)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetList(onlyCurrentContracts, commodityTypeId, searchString, sortExpression, includeCancelled);
        }

        public List<View_NaturalGasContract> GetNaturalGasAccountContracts(int locationID, bool includeCancelled)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetNaturalGasAccountContracts(locationID, includeCancelled);
        }

        public List<View_Contract> GetElectricityAccountContracts(int locationId, int accountId, bool includeCancelled)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetElectricityAccountContracts(locationId, accountId, includeCancelled);
        }

        public int AddContract(int LocationID, int PricingTypeID, DateTime BeginDate, DateTime EndDate, int SupplierID, int PricingPointID, int CommodityType, int? bidId, bool isCancelled, bool sendDropNotices)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.AddContract(LocationID, PricingTypeID, BeginDate, EndDate, SupplierID, PricingPointID, CommodityType, bidId, isCancelled, sendDropNotices);
        }

        public void UpdateNaturalGasContract(int ContractID, int ContractTypeID, DateTime ContractBegin, DateTime ContractEnd, int SupplierID, int PricingPointID, bool isCancelled, bool sendDropNotices)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.UpdateNaturalGasContract(ContractID, ContractTypeID, ContractBegin, ContractEnd, SupplierID, PricingPointID, isCancelled, sendDropNotices);
        }

        public View_NaturalGasContract GetNaturalGasContract(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetNaturalGasContract(contractID);
        }

        public void RemoveContract(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveContract(contractID);
        }

        public List<ContractPricingType> GetNaturalGasContractPricingTypeList()
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetNaturalGasContractPricingTypeList();
        }

        public List<ContractPricingType> GetElectricityContractPricingTypeList()
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetElectricityContractPricingTypeList();
        }

        public void UpdateElectricityContract(int SupplierID, DateTime ContractBegin, DateTime ContractEnd, int ContractTypeID, int PricingPointID, int ContractID, bool isCancelled, bool sendDropNotices)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.UpdateElectricityContract(SupplierID, ContractBegin, ContractEnd, ContractTypeID, PricingPointID, ContractID, isCancelled, sendDropNotices);
        }

        public View_Contract GetContract(int contractId)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetContract(contractId);
        }

        public List<spERMAGetExpiringContractsResult> GetExpiringContracts(int? numberDays, DateTime? startDate, DateTime? endDate, List<int> contractTypeIDs)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetExpiringContracts(numberDays, startDate, endDate, contractTypeIDs);
        }

        public List<spERMAGetFacilityContractTermsResult> GetFacilityContractTerms(bool includeElectricitySupply,
                                                                                   bool includeGasSupply,
                                                                                   bool includeElectricityDemandResponse,
                                                                                   string commaSeparatedFacCodes,
                                                                                   bool includeAccountsNotUnderContract,
                                                                                   DateTime? startDate,
                                                                                   DateTime? endDate)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetFacilityContractTerms(includeElectricitySupply,
                                                                                   includeGasSupply,
                                                                                   includeElectricityDemandResponse,
                                                                                   commaSeparatedFacCodes,
                                                                                   includeAccountsNotUnderContract,
                                                                                   startDate,
                                                                                   endDate);
        }

        public List<ActualLoadDropped> GetActualLoadDropped(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetActualLoadDropped(contractID);
        }

        public void RemoveActualLoadDropped(int ID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveActualLoadDropped(ID);
        }

        public void AddActualLoadDropped(int contractID, DateTime EffectiveDate, double Quantity)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.AddActualLoadDropped(contractID, EffectiveDate, Quantity);
        }

        public void UpdateActualLoadDropped(int ID, int contractID, DateTime EffectiveDate, double Quantity)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.UpdateActualLoadDropped(ID, contractID, EffectiveDate, Quantity);
        }

        public List<ActualYearEndPerformance> GetActualYearEndPerformance(int contractID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.GetActualYearEndPerformance(contractID);
        }

        public void RemoveActualYearEndPerformance(int ID)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.RemoveActualYearEndPerformance(ID);
        }

        public void AddActualYearEndPerformance(int contractID, DateTime EffectiveDate, double Quantity)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.AddActualYearEndPerformance(contractID, EffectiveDate, Quantity);
        }

        public void UpdateActualYearEndPerformance(int ID, int contractID, DateTime EffectiveDate, double Quantity)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            persistence.UpdateActualYearEndPerformance(ID, contractID, EffectiveDate, Quantity);
        }

        //
        // This method gets all of the electricity supply contracts for the given LocationID
        // whose contract dates overlap with the given start/end dates.
        //
        public List<View_Contract> getElectricitySupplyContracts(int locationID, DateTime startDate, DateTime endDate)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.getElectricitySupplyContracts(locationID, startDate, endDate);
        }

        public List<spGetExpiringBidPackagesResult> getExpiringBidPackages(int numberDays)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.getExpiringBidPackages(numberDays);
        }

        public List<spGetExpiringManualContractsResult> getExpiringManualContracts(int numberDays)
        {
            ERMABusinessLibrary.Persistence.ContractRepository persistence = new ERMABusinessLibrary.Persistence.ContractRepository();
            return persistence.getExpiringManualContracts(numberDays);
        }

    }
}
