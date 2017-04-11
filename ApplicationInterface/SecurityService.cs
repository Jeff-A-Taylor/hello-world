using ERMABusinessLibrary.Persistence;
using ERMABusinessLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Web.Security;

namespace ApplicationInterface
{
    public class SecurityService
    {
        // This method returns a list of strings representing the userNames of
        // all users who have the NominationApprover role for the given
        // facility.
        public List<string> GetNominationApproverUserNames(int facCode)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            return persistence.GetNominationApproverUserNames(facCode);
        }

        public string GetPrimaryPOCForFacility(int facCode)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            return persistence.GetPrimaryPOCForFacility(facCode);
        }

        public void SavePrimaryPOC(int accountId, string userName)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            persistence.SavePrimaryPOC(accountId, userName);
        }

        public List<string> GetLocationReadOnlyUsers(int locationId)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            return persistence.GetLocationReadOnlyUsers(locationId);
        }

        public void SaveLocationReadonlyUsers(List<UserLocationPermission> readOnlyUsers, int locationId)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            persistence.SaveLocationReadonlyUsers(readOnlyUsers, locationId);
        }

        public void SaveFacilityNominationApprovers(int facCode, string[] nominationApproverUserNames, string[] sitePermissionUserNames)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            persistence.SaveFacilityNominationApprovers(facCode, nominationApproverUserNames, sitePermissionUserNames);
        }

        public void DeleteReadOnlyUsers(int locationId)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            persistence.DeleteReadOnlyUsers(locationId);
        }

        public List<UserLocationPermission> GetUserLocationPermissions(string userId)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            return persistence.GetUserLocationPermissions(userId);
        }

        public List<UserLocationPermission> GetUserLocationPermissionsById(int locationId)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            return persistence.GetUserLocationPermissionsById(locationId);
        }

        public void UpdateUserLocationPermissionLocationId(int userLocationPermissionId, int newLocationId)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            persistence.UpdateUserLocationPermissionLocationId(userLocationPermissionId, newLocationId);
        }

        public void DeleteUserLocationPermissionsByLocation(int locationId)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            persistence.DeleteUserLocationPermissionsByLocation(locationId);
        }

        public List<spGetAvailableReadOnlyUsersResult> GetAvailableReadOnlyUsers()
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            return persistence.GetAvailableReadOnlyUsers();
        }

        public List<spGetAvailableNominationApproversResult> GetAvailableNominationApprovers(int facCode, bool withSitePermissions)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            return persistence.GetAvailableNominationApprovers(facCode, withSitePermissions);
        }

        public List<spGetAvailablePrimaryPOCResult> GetAvailablePrimaryPOCs(int facCode)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            return persistence.GetAvailablePrimaryPOCs(facCode);
        }

        public static void SortList<T>(string sortExpression, string sortDirection, List<T> data)
        {
            SecurityRepository.SortList(sortExpression, sortDirection, data);
        }

        //public static void SortList<T>(string sortExpression, List<T> data)
        //{

        //    if (!String.IsNullOrEmpty(sortExpression))
        //    {
        //        ERMABusinessLibrary.Tools.CustomSort<T> customSort;
        //        string[] sort = sortExpression.Split(' ');
        //        if (sort.Count() > 1 && sort[1] == "DESC")
        //        {
        //            customSort = new ERMABusinessLibrary.Tools.CustomSort<T>(sort[0], false);
        //            data.Sort(customSort);
        //        }
        //        else if (sort.Count() <= 1 && !string.IsNullOrEmpty(sortExpression))
        //        {
        //            customSort = new ERMABusinessLibrary.Tools.CustomSort<T>(sort[0], true);
        //            data.Sort(customSort);
        //        }
        //    }
        //}

        public bool bidsExist(string userId)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            return persistence.bidsExist(userId);
        }

        // This method removes all traces of the given userid from the ERMA system.
        // This includes the user's contact info (Person table), all permissions (UserLocationPermission,
        // UserBuildingPermission, UserGroupPermission, UserSitePermission, CompanyBidder).
        // It removes the user's authentication from the ERMA_aspnetdb database.
        public void deleteUserId(string userId)
        {
            ERMABusinessLibrary.Persistence.SecurityRepository persistence = new ERMABusinessLibrary.Persistence.SecurityRepository();
            persistence.deleteUserId(userId);
        }

    }
}
