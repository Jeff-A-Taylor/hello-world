using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERMABusinessLibrary.Scheduling;
using ERMABusinessLibrary.Persistence;

namespace ApplicationInterface
{
    public class SchedulingService
    {

        public DateTime IncrementNextScheduledTime(int id)
        {
            ERMABusinessLibrary.Persistence.SchedulingRepository persistence = new ERMABusinessLibrary.Persistence.SchedulingRepository();
            return persistence.IncrementNextScheduledTime(id);
        }

        /// <summary>
        /// Does not change any underlying values -  returns the next calculated value based on the stored datetime. 
        /// If NextScheduledTime is less than DateTime.Now it will recalculate the value using DateTime.Now
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DateTime CalculateNextScheduledTime(int id)
        {
            ERMABusinessLibrary.Persistence.SchedulingRepository persistence = new ERMABusinessLibrary.Persistence.SchedulingRepository();
            return persistence.CalculateNextScheduledTime(id);
        }

        public void ChangeNextScheduledTime(int id, DateTime? nextScheduledTime)
        {
            ERMABusinessLibrary.Persistence.SchedulingRepository persistence = new ERMABusinessLibrary.Persistence.SchedulingRepository();
            persistence.ChangeNextScheduledTime(id, nextScheduledTime);
        }

        public IDictionary<int, DateTime> GetNextScheduledTimeList()
        {
            ERMABusinessLibrary.Persistence.SchedulingRepository persistence = new ERMABusinessLibrary.Persistence.SchedulingRepository();
            return persistence.GetNextScheduledTimeList();
        }

        public int Add(int id, string description, int interval, SchedulingType schedulingType, bool isActive, DateTime? nextScheduledTime,
           DateTime? dailyStartTime, DateTime? dailyEndTime, bool monday, bool tuesday, bool wednesday, bool thursday,
           bool friday, bool saturday, bool sunday)
        {
            ERMABusinessLibrary.Persistence.SchedulingRepository persistence = new ERMABusinessLibrary.Persistence.SchedulingRepository();
            return persistence.Add(id, description, interval, schedulingType, isActive, nextScheduledTime,
           dailyStartTime, dailyEndTime, monday, tuesday, wednesday, thursday,
           friday, saturday, sunday);
        }

        public void Remove(int id)
        {
            ERMABusinessLibrary.Persistence.SchedulingRepository persistence = new ERMABusinessLibrary.Persistence.SchedulingRepository();
            persistence.Remove(id);
        }

        public Schedule Find(int id)
        {
            ERMABusinessLibrary.Persistence.SchedulingRepository persistence = new ERMABusinessLibrary.Persistence.SchedulingRepository();
            return persistence.Find(id);
        }

        public List<Schedule> GetList(bool activeOnly)
        {
            ERMABusinessLibrary.Persistence.SchedulingRepository persistence = new ERMABusinessLibrary.Persistence.SchedulingRepository();
            return persistence.GetList(activeOnly);
        }

        /// <summary>
        /// return active items only
        /// </summary>
        /// <returns></returns>
        public List<Schedule> GetList()
        {
            ERMABusinessLibrary.Persistence.SchedulingRepository persistence = new ERMABusinessLibrary.Persistence.SchedulingRepository();
            return persistence.GetList();
        }
    }
}
