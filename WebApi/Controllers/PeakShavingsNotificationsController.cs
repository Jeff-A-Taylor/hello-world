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
    public class PeakShavingsNotificationsController : ApiController
    {
        public int AddPeakShavingInformation(int contractId, double OnPeakStrikePrice, double offPeakStrikePrice, bool sendNotifications)
        {
            PeakShavingNotificationsService service = new PeakShavingNotificationsService();
            return service.AddPeakShavingInformation(contractId, OnPeakStrikePrice, offPeakStrikePrice, sendNotifications);
        }

        public void UpdatePeakShavingInformation(int peakShavingInformationId, double OnPeakStrikePrice, double offPeakStrikePrice, bool sendNotifications)
        {
            PeakShavingNotificationsService service = new PeakShavingNotificationsService();
            service.UpdatePeakShavingInformation(peakShavingInformationId, OnPeakStrikePrice, offPeakStrikePrice, sendNotifications);
        }

        public PeakShavingInformation GetPeakShavingInformation(int contractId)
        {
            PeakShavingNotificationsService service = new PeakShavingNotificationsService();
            return service.GetPeakShavingInformation(contractId);
        }

        public void AddContact(int peakShavingId, string firstName, string lastName, string emailAddress)
        {
            PeakShavingNotificationsService service = new PeakShavingNotificationsService();
            service.AddContact(peakShavingId, firstName, lastName, emailAddress);
        }

        public void RemoveAllEmailContacts(int peakShavingId)
        {
            PeakShavingNotificationsService service = new PeakShavingNotificationsService();
            service.RemoveAllEmailContacts(peakShavingId);
        }

        public List<string> GetPeakShavingContactAddresses(int peakShavingInformationId)
        {
            PeakShavingNotificationsService service = new PeakShavingNotificationsService();
            return service.GetPeakShavingContactAddresses(peakShavingInformationId);
        }

        public List<PeakShavingInformation> GetPeakShavingInformation(bool sendNotifications)
        {
            PeakShavingNotificationsService service = new PeakShavingNotificationsService();
            return service.GetPeakShavingInformation(sendNotifications);
        }

    }
}
