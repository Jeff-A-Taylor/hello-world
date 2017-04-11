using ApplicationInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class FacilityLocationController : ApiController
    {
        public void Insert(int locationId, int facCode)
        {
            FacilityLocationService service = new FacilityLocationService();
            service.Insert(locationId, facCode);
        }
    }
}
