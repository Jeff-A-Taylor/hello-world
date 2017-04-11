using System;
using System.Collections.Generic;

using ERMABusinessLibrary.Persistence;
namespace ApplicationInterface
{
    public class MeterService
    {
        public int GetMeterId(int locationID, string meterNumber)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            return persistence.GetMeterId(locationID, meterNumber);
        }

        public void UpdateMeter(int ID, int LocationID, int CommodityTypeID, int UnitID, bool IsActive, string MeterNumber,
                                string Multiplier, string Notes, string EndDate, string userName)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            persistence.UpdateMeter(ID, LocationID, CommodityTypeID, UnitID, IsActive, MeterNumber,
                                Multiplier, Notes, EndDate, userName);
        }

        public int InsertMeter(int locationID, int commodityTypeID, int unitID, bool active, string meterNumber, string multiplier,
                               string notes, string endDate, string userName)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            return persistence.InsertMeter(locationID, commodityTypeID, unitID, active, meterNumber, multiplier, notes, endDate, userName);
        }

        public void InsertMeterRead(int meterID, DateTime readDate, double quantity, bool isEstimate)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            persistence.InsertMeterRead(meterID, readDate, quantity, isEstimate);
        }

        public List<View_MeterRead> GetMeterReadList(int locationId)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            return persistence.GetMeterReadList(locationId);
        }

        public List<View_MeterRead> GetMeterReadList(int locationId, DateTime billReadDate)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            return persistence.GetMeterReadList(locationId, billReadDate);
        }

        public IDictionary<int, string> GetMeterAsDictionary(int locationId)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            return persistence.GetMeterAsDictionary(locationId);
        }

        public List<Meter> GetMetersForLocation(int locationId)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            return persistence.GetMetersForLocation(locationId);
        }

        public void RemoveMeter(int Id)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            persistence.RemoveMeter(Id);
        }


        // This method determines if the given meter has been used within
        // 2 months of the specified bill's read date.
        public bool MeterUsedRecently(int meterID, int billID)
        {
            ERMABusinessLibrary.Persistence.MeterRepository persistence = new ERMABusinessLibrary.Persistence.MeterRepository();
            return persistence.MeterUsedRecently(meterID, billID);
        }
    }
}
