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
    public class PlaceSystemPermissionsController : ApiController
    {
        public void InsertBuildingLevelPermission(int buildingId, string userName)
        {
            PlaceSystemPermissionService service = new PlaceSystemPermissionService();
            service.InsertBuildingLevelPermission(buildingId, userName);
        }

        public void InsertSiteLevelPermission(int siteId, string userName)
        {
            PlaceSystemPermissionService service = new PlaceSystemPermissionService();
            service.InsertSiteLevelPermission(siteId, userName);
        }

        public void DeleteUserBuildingPermission(int PermissionId)
        {
            PlaceSystemPermissionService service = new PlaceSystemPermissionService();
            service.DeleteUserBuildingPermission(PermissionId);
        }

        public void DeleteUserSitePermission(int PermissionId)
        {
            PlaceSystemPermissionService service = new PlaceSystemPermissionService();
            service.DeleteUserSitePermission(PermissionId);
        }

        public List<PlaceSystemSummary> GetUserBuildingPermissions(string userName)
        {
            PlaceSystemPermissionService service = new PlaceSystemPermissionService();
            return service.GetUserBuildingPermissions(userName);
        }

        public List<PlaceSystemSummary> GetUserSitePermissions(string userName)
        {
            PlaceSystemPermissionService service = new PlaceSystemPermissionService();
            return service.GetUserSitePermissions(userName);
        }

        public void SetSitePermissionIsPrimaryPOC(int permissionID, bool isPrimaryPOC)
        {
            PlaceSystemPermissionService service = new PlaceSystemPermissionService();
            service.SetSitePermissionIsPrimaryPOC(permissionID, isPrimaryPOC);
        }

        // This method determines if the passed in permission's site
        // already has a UserSitePermission entry whose IsPrimaryPOC flag is set.  It returns
        // the existing primary POC's username or the empty string if no primary POC already
        // exists.
        public string SitePrimaryPOCAlreadyExists(int permissionID)
        {
            PlaceSystemPermissionService service = new PlaceSystemPermissionService();
            return service.SitePrimaryPOCAlreadyExists(permissionID);
        }
    }
}
