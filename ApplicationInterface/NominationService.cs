using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
namespace ApplicationInterface
{
    public class NominationService
    {

        public static int GetNominationStateID(string description)
        {
            switch (description)
            {
                case "Formed":
                    return (int)NominationStateEnum.Formed;
                case "Reviewed":
                    return (int)NominationStateEnum.Reviewed;
                case "Proposed":
                    return (int)NominationStateEnum.Proposed;
                case "Refined":
                    return (int)NominationStateEnum.Refined;
                case "Approved":
                    return (int)NominationStateEnum.Approved;
                case "Finalized":
                    return (int)NominationStateEnum.Finalized;
                default:
                    return -1;
            }
        }

        public static string GetNominationStateDescription(int nominationStateID)
        {
            switch (nominationStateID)
            {
                case (int)NominationStateEnum.Formed:
                    return "Formed";
                case (int)NominationStateEnum.Reviewed:
                    return "Reviewed";
                case (int)NominationStateEnum.Proposed:
                    return "Proposed";
                case (int)NominationStateEnum.Refined:
                    return "Refined";
                case (int)NominationStateEnum.Approved:
                    return "Approved";
                case (int)NominationStateEnum.Finalized:
                    return "Finalized";
            }

            return "";
        }

        public spGetNominationEmailContentResult GetNominationEmailContent(int snapshotID, string userId)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetNominationEmailContent(snapshotID, userId);
        }

        public void DeleteNominationSnapshot(int snapshotID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.DeleteNominationSnapshot(snapshotID);
        }

        public List<spGetNominationsResult> GetNominationsForSnapshot(int bidPackageID, int snapshotID, bool getTotalNomsOnly)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetNominationsForSnapshot(bidPackageID, snapshotID, getTotalNomsOnly);
        }

        public List<spGetNominationsForContractResult> GetNominationsForContract(int contractID, int snapshotID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetNominationsForContract(contractID, snapshotID);
        }

        public void UpdateNominationsForSnapshot(int snapshotID, string userId, string Notes, int NumberBillsToUse, int NominationStateID,
                                                 double? Month1Quantity, DateTime? Month1ReadDate, double? Month2Quantity, DateTime? Month2ReadDate, 
                                                 double? Month3Quantity, DateTime? Month3ReadDate, double? Month4Quantity, DateTime? Month4ReadDate,
                                                 double? Month5Quantity, DateTime? Month5ReadDate, double? Month6Quantity, DateTime? Month6ReadDate, 
                                                 double? Month7Quantity, DateTime? Month7ReadDate, double? Month8Quantity, DateTime? Month8ReadDate,
                                                 double? Month9Quantity, DateTime? Month9ReadDate, double? Month10Quantity, DateTime? Month10ReadDate, 
                                                 double? Month11Quantity, DateTime? Month11ReadDate, double? Month12Quantity, DateTime? Month12ReadDate,
                                                 int NominationUnitID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.UpdateNominationsForSnapshot( snapshotID,  userId,  Notes,  NumberBillsToUse,  NominationStateID,
                                                      Month1Quantity,  Month1ReadDate,  Month2Quantity,  Month2ReadDate, 
                                                      Month3Quantity,  Month3ReadDate,  Month4Quantity,  Month4ReadDate,
                                                      Month5Quantity,  Month5ReadDate,  Month6Quantity,  Month6ReadDate, 
                                                      Month7Quantity,  Month7ReadDate,  Month8Quantity,  Month8ReadDate,
                                                      Month9Quantity,  Month9ReadDate,  Month10Quantity,  Month10ReadDate, 
                                                      Month11Quantity,  Month11ReadDate, Month12Quantity,  Month12ReadDate,
                                                      NominationUnitID);
        }

        public void UpdateNominationsForContract(int snapshotID, string userId,
                                                 double? Month1Quantity, DateTime? Month1ReadDate, double? Month2Quantity, DateTime? Month2ReadDate,
                                                 double? Month3Quantity, DateTime? Month3ReadDate, double? Month4Quantity, DateTime? Month4ReadDate,
                                                 double? Month5Quantity, DateTime? Month5ReadDate, double? Month6Quantity, DateTime? Month6ReadDate,
                                                 double? Month7Quantity, DateTime? Month7ReadDate, double? Month8Quantity, DateTime? Month8ReadDate,
                                                 double? Month9Quantity, DateTime? Month9ReadDate, double? Month10Quantity, DateTime? Month10ReadDate,
                                                 double? Month11Quantity, DateTime? Month11ReadDate, double? Month12Quantity, DateTime? Month12ReadDate,
                                                 int NominationUnitID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.UpdateNominationsForContract(snapshotID, userId,
                                                             Month1Quantity, Month1ReadDate, Month2Quantity, Month2ReadDate,
                                                             Month3Quantity, Month3ReadDate, Month4Quantity, Month4ReadDate,
                                                             Month5Quantity, Month5ReadDate, Month6Quantity, Month6ReadDate,
                                                             Month7Quantity, Month7ReadDate, Month8Quantity, Month8ReadDate,
                                                             Month9Quantity, Month9ReadDate, Month10Quantity, Month10ReadDate,
                                                             Month11Quantity, Month11ReadDate, Month12Quantity, Month12ReadDate,
                                                             NominationUnitID);
        }

        public List<View_Nomination> GetAggregateBidPackageNominations(int bidPackageId)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetAggregateBidPackageNominations(bidPackageId);
        }

        //public List<View_Nomination> GetNominations(int contractID)
        //{
        //    using (var dataContext = GetDataSource())
        //    {
        //        return dataContext.spGetNominationsForContract(contractID).ToList();
        //    }
        //}

        public List<View_Nomination> GetNominations(int bidPackageId, int accountID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetNominations(bidPackageId, accountID);
        }

        public IDictionary<int, string> GetNominationSnapshots(int bidPackageId, int accountID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetNominationSnapshots(bidPackageId, accountID);
        }

        public IDictionary<int, string> GetNominationSnapshotsForContract(int contractID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetNominationSnapshotsForContract(contractID);
        }

        public spGetNominationSnapshotDetailsResult GetNominationSnapshotDetails(int snapshotID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetNominationSnapshotDetails(snapshotID);
        }

        public List<NominationState> GetNominationStates()
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetNominationStates();
        }

        /// <summary>
        /// not used. SDK
        /// </summary>
        /// <param name="nominationId"></param>
        /// <returns></returns>
        //public Nomination GetNomination(int nominationId)
        //{
        //    Nomination result = null;

        //    using (var dataContext = GetDataSource())
        //    {
        //        result = (from data in dataContext.Nominations
        //                  where data.ID == nominationId
        //                  select data).FirstOrDefault();
        //    }

        //    return result;
        //}

        public void UpdateNominations(int NominationID, DateTime NominationForDate, double Quantity, int QuantityUnitID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.UpdateNominations(NominationID, NominationForDate, Quantity, QuantityUnitID);
        }

        public int AddNomination(int BidPackageID, int NominationSnapshotID, int AccountID, DateTime NominationForDate, double Quantity, int QuantityUnitID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.AddNomination(BidPackageID, NominationSnapshotID, AccountID, NominationForDate, Quantity, QuantityUnitID);
        }

        public void AddNominations(List<NominationSerializable> nominations)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.AddNominations(nominations);
        }

        public void DeleteNomination(int NominationID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.DeleteNomination(NominationID);
        }

        public void FormNominationsForRFQ(int RFQID, string userId)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.FormNominationsForRFQ(RFQID, userId);
        }

        public void FormNominationsForBidPackage(int BidPackageID, int accountID, List<Tuple<DateTime, DateTime, double>> dateWeights, string userId)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.FormNominationsForBidPackage(BidPackageID, accountID, dateWeights, userId);
        }

        //
        // This method exports the given RFQ's electric appendix B contents to a spreadsheet.
        // It returns the name of the temporary file/spreadsheet and the byte[] data of
        // the spreadsheet.  The spreadsheet contains 1 tab for all bid packages.
        public Tuple<string, byte[]> ExportNominationsSpreadsheet(int bidPackageId, int snapshotID, bool getTotalNomsOnly, string bidPackageTitle, string accountNumber)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.ExportNominationsSpreadsheet(bidPackageId, snapshotID, getTotalNomsOnly, bidPackageTitle, accountNumber);
        }

        public spGetMostRecentNominationInDTForContractResult GetMostRecentNominationInDTForContract(int contractID, DateTime forDate)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetMostRecentNominationInDTForContract(contractID, forDate);
        }

        public void CopyMostRecentNominationsForNewContract(int contractID, int existingNominationSnapshotID, string userName)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.CopyMostRecentNominationsForNewContract(contractID, existingNominationSnapshotID, userName);
        }

        public List<spGetNominationSnapshotsForCopyingToManualContractResult> GetNominationSnapshotsForCopyingToManualContract(int contractID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            return persistence.GetNominationSnapshotsForCopyingToManualContract(contractID);
        }

        // This method is called when no nomination snapshot exists for a manually entered contract.
        // It creates a nomination snapshot and inserts up to 12 nominations with the specified values.
        public void InsertNominationsForContract(int contractID, string userId,
                                                 double? Month1Quantity, DateTime? Month1ReadDate, double? Month2Quantity, DateTime? Month2ReadDate,
                                                 double? Month3Quantity, DateTime? Month3ReadDate, double? Month4Quantity, DateTime? Month4ReadDate,
                                                 double? Month5Quantity, DateTime? Month5ReadDate, double? Month6Quantity, DateTime? Month6ReadDate,
                                                 double? Month7Quantity, DateTime? Month7ReadDate, double? Month8Quantity, DateTime? Month8ReadDate,
                                                 double? Month9Quantity, DateTime? Month9ReadDate, double? Month10Quantity, DateTime? Month10ReadDate,
                                                 double? Month11Quantity, DateTime? Month11ReadDate, double? Month12Quantity, DateTime? Month12ReadDate,
                                                 int NominationUnitID)
        {
            ERMABusinessLibrary.Persistence.NominationRepository persistence = new ERMABusinessLibrary.Persistence.NominationRepository();
            persistence.InsertNominationsForContract(contractID, userId,
                                                     Month1Quantity, Month1ReadDate, Month2Quantity, Month2ReadDate,
                                                     Month3Quantity, Month3ReadDate, Month4Quantity, Month4ReadDate,
                                                     Month5Quantity, Month5ReadDate, Month6Quantity, Month6ReadDate,
                                                     Month7Quantity, Month7ReadDate, Month8Quantity, Month8ReadDate,
                                                     Month9Quantity, Month9ReadDate, Month10Quantity, Month10ReadDate,
                                                     Month11Quantity, Month11ReadDate, Month12Quantity, Month12ReadDate,
                                                     NominationUnitID);
        }
    }
}
