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
    public class BuildingController : ApiController
    {
        public List<tblBuildingMaster> GetList(int FacCode)
        {
            BuildingService service = new BuildingService();
            return service.GetList(FacCode);
        }

        public tblBuildingMaster Get(int BldgID)
        {
            BuildingService service = new BuildingService();
            return service.Get(BldgID);
        }
    }
}
