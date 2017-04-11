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
    public class LocationController : ApiController
    {
        public void Add(Location location)
        {
            LocationService service = new LocationService();
            service.Add(location);
        }

        public Location GetLocation(int locationId)
        {
            LocationService service = new LocationService();
            return service.GetLocation(locationId);
        }

        public void SaveCommonwealthLocationCode(int locationId, string commonwealthLocationCode)
        {
            LocationService service = new LocationService();
            service.SaveCommonwealthLocationCode(locationId, commonwealthLocationCode);
        }

        public string GetNotes(int locationId)
        {
            LocationService service = new LocationService();
            return service.GetNotes(locationId);
        }

        public void SaveNotes(int locationId, string notes)
        {
            LocationService service = new LocationService();
            service.SaveNotes(locationId, notes);
        }
    }
}
