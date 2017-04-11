using ERMABusinessLibrary.Persistence;
using ERMABusinessLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    //public class PlaceSystemSummary
    //{
    //    int permissionId;
    //    int facCode;
    //    bool isPrimaryPOC;

    //    public int PermissionId
    //    {
    //        get { return permissionId; }
    //        set { permissionId = value; }
    //    }
    //    string agency;

    //    public string Agency
    //    {
    //        get { return agency; }
    //        set { agency = value; }
    //    }
    //    string facility;

    //    public string Facility
    //    {
    //        get { return facility; }
    //        set { facility = value; }
    //    }
    //    string building;

    //    public string Building
    //    {
    //        get { return building; }
    //        set { building = value; }
    //    }

    //    public int FacCode
    //    {
    //        get { return facCode; }
    //        set { facCode = value; }
    //    }

    //    public bool IsPrimaryPOC
    //    {
    //        get { return isPrimaryPOC; }
    //        set { isPrimaryPOC = value; }
    //    }

    //    public PlaceSystemSummary(int permissionId, string agency, string facility, string building, int facCode, bool isPrimaryPOC)
    //    {
    //        this.permissionId = permissionId;
    //        this.agency = agency;
    //        this.facility = facility;
    //        this.building = building;
    //        this.facCode = facCode;
    //        this.isPrimaryPOC = isPrimaryPOC;
    //    }
    //}

    public class PlaceSystemPermissionService
    {
        public void InsertBuildingLevelPermission(int buildingId, string userName)
        {
            ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository persistence = new ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository();
            persistence.InsertBuildingLevelPermission(buildingId, userName);
        }

        public void InsertSiteLevelPermission(int siteId, string userName)
        {
            ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository persistence = new ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository();
            persistence.InsertSiteLevelPermission(siteId, userName);
        }

        public void DeleteUserBuildingPermission(int PermissionId)
        {
            ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository persistence = new ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository();
            persistence.DeleteUserBuildingPermission(PermissionId);
        }

        public void DeleteUserSitePermission(int PermissionId)
        {
            ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository persistence = new ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository();
            persistence.DeleteUserSitePermission(PermissionId);
        }

        public List<PlaceSystemSummary> GetUserBuildingPermissions(string userName)
        {
            ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository persistence = new ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository();
            return persistence.GetUserBuildingPermissions(userName);
        }

        public List<PlaceSystemSummary> GetUserSitePermissions(string userName)
        {
            ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository persistence = new ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository();
            return persistence.GetUserSitePermissions(userName);
        }

        public void SetSitePermissionIsPrimaryPOC(int permissionID, bool isPrimaryPOC)
        {
            ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository persistence = new ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository();
            persistence.SetSitePermissionIsPrimaryPOC(permissionID, isPrimaryPOC);
        }

        // This method determines if the passed in permission's site
        // already has a UserSitePermission entry whose IsPrimaryPOC flag is set.  It returns
        // the existing primary POC's username or the empty string if no primary POC already
        // exists.
        public string SitePrimaryPOCAlreadyExists(int permissionID)
        {
            ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository persistence = new ERMABusinessLibrary.Persistence.PlaceSystemPermissionRepository();
            return persistence.SitePrimaryPOCAlreadyExists(permissionID);
        }
    }
}
