using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class LocationService
    {
        public void Add(Location location)
        {
            ERMABusinessLibrary.Persistence.LocationRepository persistence = new ERMABusinessLibrary.Persistence.LocationRepository();
            persistence.Add(location);
        }

        public Location GetLocation(int locationId)
        {
            ERMABusinessLibrary.Persistence.LocationRepository persistence = new ERMABusinessLibrary.Persistence.LocationRepository();
            return persistence.GetLocation(locationId);
        }

        public void SaveCommonwealthLocationCode(int locationId, string commonwealthLocationCode)
        {
            ERMABusinessLibrary.Persistence.LocationRepository persistence = new ERMABusinessLibrary.Persistence.LocationRepository();
            persistence.SaveCommonwealthLocationCode(locationId, commonwealthLocationCode);
        }

        public string GetNotes(int locationId)
        {
            ERMABusinessLibrary.Persistence.LocationRepository persistence = new ERMABusinessLibrary.Persistence.LocationRepository();
            return persistence.GetNotes(locationId);
        }

        public void SaveNotes(int locationId, string notes)
        {
            ERMABusinessLibrary.Persistence.LocationRepository persistence = new ERMABusinessLibrary.Persistence.LocationRepository();
            persistence.SaveNotes(locationId, notes);
        }
    }
}
