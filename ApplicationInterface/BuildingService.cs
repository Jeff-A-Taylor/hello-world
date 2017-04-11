//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

using ERMABusinessLibrary.Persistence;
using System.Collections.Generic;

namespace ApplicationInterface
{
    public class BuildingService
    {
        public List<tblBuildingMaster> GetList(int FacCode)
        {
            ERMABusinessLibrary.Persistence.BuildingRepository persistence = new ERMABusinessLibrary.Persistence.BuildingRepository();
            return persistence.GetList(FacCode);
        }

        public tblBuildingMaster Get(int BldgID)
        {
            ERMABusinessLibrary.Persistence.BuildingRepository persistence = new ERMABusinessLibrary.Persistence.BuildingRepository();
            return persistence.Get(BldgID);
        }
    }
}
