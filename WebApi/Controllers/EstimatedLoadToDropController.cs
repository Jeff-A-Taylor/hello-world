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
    public class EstimatedLoadToDropController : ApiController
    {
        public List<spGetEstimatedLoadToDropsForBidPackageResult> GetEstimatedLoadToDropsForBidPackage(int bidPackageId, string sortExpression)
        {
            EstimatedLoadToDropService service = new EstimatedLoadToDropService();
            return service.GetEstimatedLoadToDropsForBidPackage(bidPackageId, sortExpression);
        }

        public void RemoveEstimatedLoadToDrop(int ID)
        {
            EstimatedLoadToDropService service = new EstimatedLoadToDropService();
            service.RemoveEstimatedLoadToDrop(ID);
        }

        public void RemoveEstimatedLoadsToDrop(List<int> IDsToDrop)
        {
            EstimatedLoadToDropService service = new EstimatedLoadToDropService();
            service.RemoveEstimatedLoadsToDrop(IDsToDrop);
        }

        public void UpdateEstimatedLoadToDrop(int ID, string Quantity, string EffectiveYear, string AccountNumber, string Tariff, string Rate)
        {
            EstimatedLoadToDropService service = new EstimatedLoadToDropService();
            service.UpdateEstimatedLoadToDrop(ID, Quantity, EffectiveYear, AccountNumber, Tariff, Rate); ;
        }
    }
}
