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
    public class IntervalHistoryController : ApiController
    {
        public bool DoesIntervalDataExist(List<IntervalUsage> list)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            return service.DoesIntervalDataExist(list);
        }

        /**
         * This method returns the number of records which already existed and the number of records saved.
         */
        public Tuple<int, int> SaveIntervalData(List<IntervalUsage> list)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            return service.SaveIntervalData(list);
        }

        public IList<IIntervalUsage> GetIntervalUsage(int locationId, DateTime fromDate, DateTime toDate, bool combineMeters)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            return service.GetIntervalUsage(locationId, fromDate, toDate, combineMeters);
        }

        public List<View_IntervalUsage> GetIntervalUsage(int locationId, DateTime fromDate, DateTime toDate)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            return service.GetIntervalUsage(locationId, fromDate, toDate);
        }

        public List<View_IntervalUsageByLocation> GetIntervalUsageGroupedByLocation(int locationId, DateTime fromDate, DateTime toDate)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            return service.GetIntervalUsageGroupedByLocation(locationId, fromDate, toDate);
        }

        public void SaveInterval(IntervalUsage usage)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            service.SaveInterval(usage);
        }

        // This method subtracts one year from the "toDate" and gets last year's interval usage data for the specified of number of 
        // months before that date.  So if a bid is submitted for 7/1/2013 to 9/30/2013 (3 month bid), the "toDate" is
        // 9/30/2013.  We subtract to get 9/30/2012, then we get the 3 months of interval data available before that,
        // I.e., 7/1/2012 to 9/30/2012.
        public IList<View_IntervalUsageByLocation> GetLastYearsMonthsOfIntervalData(int locationId, int bidPackageId, DateTime dateStart, DateTime dateEnd)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            return service.GetLastYearsMonthsOfIntervalData(locationId, bidPackageId, dateStart, dateEnd);
        }


        public IList<IntervalUsageDailyCount> GetIntervalUsageDailyCount(int locationId, int meterId, DateTime fromDate, DateTime toDate,
                                                                         string SortExpression)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            return service.GetIntervalUsageDailyCount(locationId, meterId, fromDate, toDate, SortExpression);
        }

        public void RemoveIntervalUsage(int locationId, int meterId, DateTime fromDate, DateTime toDate)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            service.RemoveIntervalUsage(locationId, meterId, fromDate, toDate);
        }

        public void DeleteDuplicateIntervalUsageRecords(int locationId, int meterId, DateTime monthDate, int expectedCount)
        {
            IntervalHistoryService service = new IntervalHistoryService();
            service.DeleteDuplicateIntervalUsageRecords(locationId, meterId, monthDate, expectedCount);
        }

    }
}
