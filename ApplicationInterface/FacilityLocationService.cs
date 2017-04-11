using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class FacilityLocationService
    {
        public void Insert(int locationId, int facCode)
        {
            ERMABusinessLibrary.Persistence.FacilityLocationRepository persistence = new ERMABusinessLibrary.Persistence.FacilityLocationRepository();
            persistence.Insert(locationId, facCode);
        }
    }
}
