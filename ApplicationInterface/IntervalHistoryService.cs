using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class IntervalHistoryService
    {
        public bool DoesIntervalDataExist(List<IntervalUsage> list)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            return persistence.DoesIntervalDataExist(list);
        }

        /**
         * This method returns the number of records which already existed and the number of records saved.
         */
        public Tuple<int, int> SaveIntervalData(List<IntervalUsage> list)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            return persistence.SaveIntervalData(list);
        }

        public IList<IIntervalUsage> GetIntervalUsage(int locationId, DateTime fromDate, DateTime toDate, bool combineMeters)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            return persistence.GetIntervalUsage(locationId, fromDate, toDate, combineMeters);
        }

        public List<View_IntervalUsage> GetIntervalUsage(int locationId, DateTime fromDate, DateTime toDate)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            return persistence.GetIntervalUsage(locationId, fromDate, toDate);
        }

        public List<View_IntervalUsageByLocation> GetIntervalUsageGroupedByLocation(int locationId, DateTime fromDate, DateTime toDate)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            return persistence.GetIntervalUsageGroupedByLocation(locationId, fromDate, toDate);
        }

        public void SaveInterval(IntervalUsage usage)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            persistence.SaveInterval(usage);
        }

        // This method subtracts one year from the "toDate" and gets last year's interval usage data for the specified of number of 
        // months before that date.  So if a bid is submitted for 7/1/2013 to 9/30/2013 (3 month bid), the "toDate" is
        // 9/30/2013.  We subtract to get 9/30/2012, then we get the 3 months of interval data available before that,
        // I.e., 7/1/2012 to 9/30/2012.
        public IList<View_IntervalUsageByLocation> GetLastYearsMonthsOfIntervalData(int locationId, int bidPackageId, DateTime dateStart, DateTime dateEnd)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            return persistence.GetLastYearsMonthsOfIntervalData(locationId, bidPackageId, dateStart, dateEnd);
        }


        public IList<IntervalUsageDailyCount> GetIntervalUsageDailyCount(int locationId, int meterId, DateTime fromDate, DateTime toDate,
                                                                         string SortExpression)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            return persistence.GetIntervalUsageDailyCount(locationId, meterId, fromDate, toDate, SortExpression);
        }

        public void RemoveIntervalUsage(int locationId, int meterId, DateTime fromDate, DateTime toDate)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            persistence.RemoveIntervalUsage(locationId, meterId, fromDate, toDate);
        }

        public void DeleteDuplicateIntervalUsageRecords(int locationId, int meterId, DateTime monthDate, int expectedCount)
        {
            ERMABusinessLibrary.Persistence.IntervalHistoryRepository persistence = new ERMABusinessLibrary.Persistence.IntervalHistoryRepository();
            persistence.DeleteDuplicateIntervalUsageRecords(locationId, meterId, monthDate, expectedCount);
        }
    }
}
