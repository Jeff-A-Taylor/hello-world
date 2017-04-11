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
    public class MeterController : ApiController
    {
        public int GetMeterId(int locationID, string meterNumber)
        {
            MeterService service = new MeterService();
            return service.GetMeterId(locationID, meterNumber);
        }

        public void UpdateMeter(int ID, int LocationID, int CommodityTypeID, int UnitID, bool IsActive, string MeterNumber,
                                string Multiplier, string Notes, string EndDate, string userName)
        {
            MeterService service = new MeterService();
            service.UpdateMeter(ID, LocationID, CommodityTypeID, UnitID, IsActive, MeterNumber,
                                Multiplier, Notes, EndDate, userName);
        }

        public int InsertMeter(int locationID, int commodityTypeID, int unitID, bool active, string meterNumber, string multiplier,
                               string notes, string endDate, string userName)
        {
            MeterService service = new MeterService();
            return service.InsertMeter(locationID, commodityTypeID, unitID, active, meterNumber, multiplier, notes, endDate, userName);
        }

        public void InsertMeterRead(int meterID, DateTime readDate, double quantity, bool isEstimate)
        {
            MeterService service = new MeterService();
            service.InsertMeterRead(meterID, readDate, quantity, isEstimate);
        }

        public List<View_MeterRead> GetMeterReadList(int locationId)
        {
            MeterService service = new MeterService();
            return service.GetMeterReadList(locationId);
        }

        public List<View_MeterRead> GetMeterReadList(int locationId, DateTime billReadDate)
        {
            MeterService service = new MeterService();
            return service.GetMeterReadList(locationId, billReadDate);
        }

        public IDictionary<int, string> GetMeterAsDictionary(int locationId)
        {
            MeterService service = new MeterService();
            return service.GetMeterAsDictionary(locationId);
        }

        public List<Meter> GetMetersForLocation(int locationId)
        {
            MeterService service = new MeterService();
            return service.GetMetersForLocation(locationId);
        }

        public void RemoveMeter(int Id)
        {
            MeterService service = new MeterService();
            service.RemoveMeter(Id);
        }


        // This method determines if the given meter has been used within
        // 2 months of the specified bill's read date.
        public bool MeterUsedRecently(int meterID, int billID)
        {
            MeterService service = new MeterService();
            return service.MeterUsedRecently(meterID, billID);
        }
    }
}
