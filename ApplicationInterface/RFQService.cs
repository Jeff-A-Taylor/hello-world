using ERMABusinessLibrary;
using ERMABusinessLibrary.BidPackages;
using ERMABusinessLibrary.Persistence;
using ERMABusinessLibrary.RFQ;
using System;
using System.Collections.Generic;

namespace ApplicationInterface
{
    public enum RFQTypeEnum
    {
        Gas_Supply = 1,
        Electricity_Supply = 2,
        Electricity_DemandResponse = 3
    }

    public class RFQService
    {
        public List<SpendReportSummary> GetRFQsWithActiveBids(DateTime? startDate, DateTime? endDate)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetRFQsWithActiveBids(startDate, endDate);
        }

        public List<spCalendarizedAvoidedCostReportElectricityResult> GetElectricitySpendReport(int rfqid, DateTime date)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetElectricitySpendReport(rfqid, date);
        }

        public List<BidPackage> GetBidPackagesForRFQs(DateTime? StartDate,
                                                      DateTime? EndDate,
                                                      int commodityTypeId,
                                                      string deptCode,
                                                      int[] facCodes,
                                                      int[] RFQIds,
                                                      bool IncludeRFQTitle)
        {
            List<BidPackage> list = new List<BidPackage>();
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            list = persistence.GetBidPackagesForRFQs(StartDate,
                                                      EndDate,
                                                      commodityTypeId,
                                                      deptCode,
                                                      facCodes,
                                                      RFQIds,
                                                      IncludeRFQTitle);
            return list;
        }

        public List<BidPackageAccountSummary> GetRFQSummaryForLocation(int locationId)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetRFQSummaryForLocation(locationId);
        }

        public List<RFQSummary> GetElectricityRfqsForUser(string searchCriteria, string sortExpression, bool onlyCurrentRFQs, string UserId)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetElectricityRfqsForUser(searchCriteria, sortExpression, onlyCurrentRFQs, UserId);
        }

        public List<RFQSummary> GetSummaryListForDateRange(DateTime? StartDate, DateTime? EndDate, int CommodityTypeId, string agency,
                                                           string commaSeparatedfacilityCodes, int? rfqTypeID)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetSummaryListForDateRange(StartDate, EndDate, CommodityTypeId, agency,
                                                           commaSeparatedfacilityCodes, rfqTypeID);
        }
            
        public List<RFQSummary> GetSummaryList(string searchCriteria, string sortExpression, bool onlyCurrentRFQs, bool onlyActiveRFQs, string userId, int commodityTypeId)
        {
            ERMABusinessLibrary.Persistence.RfqRepository repo = new ERMABusinessLibrary.Persistence.RfqRepository();
            return repo.GetSummaryList(searchCriteria, sortExpression, onlyCurrentRFQs, onlyActiveRFQs, userId, commodityTypeId);
        }

        public List<spERMAGetNonAwardCostsResult> GetNonAwardCosts(string agency,
                                                                   string commaSeparatedBidPackageIds,
                                                                   string commaSeparatedFacCodes,
                                                                   int commodityTypeID)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetNonAwardCosts(agency, commaSeparatedBidPackageIds, commaSeparatedFacCodes, commodityTypeID);
        }

        public List<spERMAGetNonAwardCostsAFIResult> GetNonAwardCostsAFI(string agency,
                                                                         string commaSeparatedBidPackageIds,
                                                                         string commaSeparatedFacCodes,
                                                                         int commodityTypeID)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetNonAwardCostsAFI(agency, commaSeparatedBidPackageIds, commaSeparatedFacCodes, commodityTypeID);
        }

        public List<spERMAGetElectricityAvoidingCostsResult> GetElectricityAvoidingCosts(string agency,
                                                                                         string commaSeparatedBidPackageIds,
                                                                                         string commaSeparatedFacCodes)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetElectricityAvoidingCosts(agency, commaSeparatedBidPackageIds, commaSeparatedFacCodes);
        }

        // jat - ERMA-380
        public List<spERMAGetElectricityAvoidingCostsAFIResult> GetElectricityAvoidingCostsAFI(string agency,
                                                                                               string commaSeparatedBidPackageIds,
                                                                                               string commaSeparatedFacCodes)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetElectricityAvoidingCostsAFI(agency, commaSeparatedBidPackageIds, commaSeparatedFacCodes);
        }

        public List<spERMAGetNaturalGasAvoidingCostsResult> GetNaturalGasAvoidingCosts(string agency,
                                                                                       string commaSeparatedBidPackageIds,
                                                                                       string commaSeparatedFacCodes)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetNaturalGasAvoidingCosts(agency, commaSeparatedBidPackageIds, commaSeparatedFacCodes);
        }

        // jat - ERMA-380
        public List<spERMAGetNaturalGasAvoidingCostsAFIResult> GetNaturalGasAvoidingCostsAFI(string agency,
                                                                                             string commaSeparatedBidPackageIds,
                                                                                             string commaSeparatedFacCodes)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetNaturalGasAvoidingCostsAFI(agency, commaSeparatedBidPackageIds, commaSeparatedFacCodes);
        }

        //
        // This method returns all RFQs that matched the given criteria.  It check's the given user's
        // roles to return supply RFQs and/or demand response RFQs.
        // This method should be used for supplier logins only because it doesn't check the user's
        // site permissions.
        //
        public List<RFQSummary> GetSupplierSummaryList(string searchCriteria, string sortExpression, bool onlyCurrentRFQs, bool onlyActiveRFQs, int CommodityTypeId, string UserName)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetSupplierSummaryList(searchCriteria, sortExpression, onlyCurrentRFQs, onlyActiveRFQs, CommodityTypeId, UserName);
        }

        //
        // This method returns all RFQs that matched the given criteria.  It doesn't check any user permissions.
        // This method should be used for admin logins only.
        //
        public List<RFQSummary> GetAdminSummaryList(string searchCriteria, string sortExpression, bool onlyCurrentRFQs, bool onlyActiveRFQs, int CommodityTypeId)
        {
            List<RFQSummary> list = new List<RFQSummary>();
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            list = persistence.GetAdminSummaryList(searchCriteria, sortExpression, onlyCurrentRFQs, onlyActiveRFQs, CommodityTypeId);
            return list;
        }

        public View_RFQ GetRFQ(int RFQId)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetRFQ(RFQId);
        }

        public void Update(RFQ updatedRFQ)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            persistence.Update(updatedRFQ);
        }

        public int Add(RFQ newRfq)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.Add(newRfq);
        }

        public List<spGetGasAppendixAResult> GetGasAppendixA(int RFQID, string UserId, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetGasAppendixA(RFQID, UserId, sortExpression);
        }

        public List<spGetElectricAppendixBResult> GetElectricAppendixB(int RFQID, string UserId, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetElectricAppendixB(RFQID, UserId, sortExpression);
        }

        public List<spGetGasAppendixBResult> GetGasAppendixB(int RFQID,  string UserId, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetGasAppendixB(RFQID,  UserId, sortExpression);
        }

        public List<spGetElectricAppendixAResult> GetElectricAppendixA(int RFQID, string UserId, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetElectricAppendixA(RFQID, UserId, sortExpression);
        }

        //
        // This method exports the given RFQ's gas appendix A contents to a spreadsheet.
        // It returns the name of the temporary file/spreadsheet and the byte[] data of
        // the spreadsheet.  The spreadsheet contains a different tab for each bid package.
        public Tuple<string, byte[]> ExportGasAppendixASpreadsheet(int RFQID, string UserName, string rfqTitle)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.ExportGasAppendixASpreadsheet(RFQID, UserName, rfqTitle);
        }


        //
        // This method exports the given RFQ's gas appendix B contents to a spreadsheet.
        // It returns the name of the temporary file/spreadsheet and the byte[] data of
        // the spreadsheet.  The spreadsheet contains a different tab for each bid package.
        public Tuple<string, byte[]> ExportGasAppendixBSpreadsheet(int RFQID, string UserName, string rfqTitle)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.ExportGasAppendixBSpreadsheet(RFQID, UserName, rfqTitle);
        }

        //
        // This method exports the given RFQ's electric appendix A contents to a spreadsheet.
        // It returns the name of the temporary file/spreadsheet and the byte[] data of
        // the spreadsheet.  The spreadsheet contains a different tab for each bid package.
        public Tuple<string, byte[]> ExportElectricAppendixASpreadsheet(int RFQID, string UserName, string rfqTitle)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.ExportElectricAppendixASpreadsheet(RFQID, UserName, rfqTitle);
        }

        //
        // This method exports the given RFQ's electric appendix B contents to a spreadsheet.
        // It returns the name of the temporary file/spreadsheet and the byte[] data of
        // the spreadsheet.  The spreadsheet contains 1 tab for all bid packages.
        public Tuple<string, byte[]> ExportElectricAppendixBSpreadsheet(int RFQID, string UserName, string rfqTitle)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.ExportElectricAppendixBSpreadsheet(RFQID, UserName, rfqTitle);
        }

        public List<RFQDoc> GetRFQDocument(int RequestForQuoteId)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetRFQDocument(RequestForQuoteId);
        }

        public void UpdateRFQDocument(int RequestForQuoteId, string Title,
                                           string FileContent)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            persistence.UpdateRFQDocument(RequestForQuoteId, Title, FileContent);
        }

        public int InsertRFQDocument(int RequestForQuoteId, string Title, string FileContent)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.InsertRFQDocument(RequestForQuoteId, Title, FileContent);
        }

        public void DeleteRFQDocument(int ID)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            persistence.DeleteRFQDocument(ID);
        }

        public int GetRFQCommodity(int RFQId)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetRFQCommodity(RFQId);
        }

        public List<RFQSummary> GetActiveList(bool cbRFQActive, string userName)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetActiveList(cbRFQActive, userName);
        }

        public List<RFQSummary> GetActiveListByCommodity(bool cbRFQActive, int CommodityTypeId)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetActiveListByCommodity(cbRFQActive, CommodityTypeId);
        }

        public List<RFQType> GetRFQTypes(int commodityTypeID)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetRFQTypes(commodityTypeID);
        }

        public List<spERMAGetDemandResponseAvoidingCostsResult> GetDemandResponseAvoidingCosts(string agency,
                                                                                               string commaSeparatedBidPackageIds,
                                                                                               string commaSeparatedFacCodes)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetDemandResponseAvoidingCosts(agency, commaSeparatedBidPackageIds, commaSeparatedFacCodes);
        }

        // jat - ERMA-380
        public List<spERMAGetDemandResponseAvoidingCostsAFIResult> GetDemandResponseAvoidingCostsAFI(string agency,
                                                                                                     string commaSeparatedBidPackageIds,
                                                                                                     string commaSeparatedFacCodes)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetDemandResponseAvoidingCostsAFI(agency, commaSeparatedBidPackageIds, commaSeparatedFacCodes);
        }

        public List<RFQWeightedMarketData> GetWeightedMarketData(int RFQID)
        {
            ERMABusinessLibrary.Persistence.RfqRepository persistence = new ERMABusinessLibrary.Persistence.RfqRepository();
            return persistence.GetWeightedMarketData(RFQID);
        }
    }
}
