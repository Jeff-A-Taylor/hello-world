using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class PeakShavingNotificationsService
    {
        public int AddPeakShavingInformation(int contractId, double OnPeakStrikePrice, double offPeakStrikePrice, bool sendNotifications)
        {
            ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository persistence = new ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository();
            return persistence.AddPeakShavingInformation(contractId, OnPeakStrikePrice, offPeakStrikePrice, sendNotifications);
        }

        public void UpdatePeakShavingInformation(int peakShavingInformationId, double OnPeakStrikePrice, double offPeakStrikePrice, bool sendNotifications)
        {
            ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository persistence = new ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository();
            persistence.UpdatePeakShavingInformation(peakShavingInformationId, OnPeakStrikePrice, offPeakStrikePrice, sendNotifications);
        }

        public PeakShavingInformation GetPeakShavingInformation(int contractId)
        {
            ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository persistence = new ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository();
            return persistence.GetPeakShavingInformation(contractId);
        }

        public void AddContact(int peakShavingId, string firstName, string lastName, string emailAddress)
        {
            ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository persistence = new ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository();
            persistence.AddContact(peakShavingId, firstName, lastName, emailAddress);
        }

        public void RemoveAllEmailContacts(int peakShavingId)
        {
            ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository persistence = new ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository();
            persistence.RemoveAllEmailContacts(peakShavingId);
        }

        public List<string> GetPeakShavingContactAddresses(int peakShavingInformationId)
        {
            ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository persistence = new ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository();
            return persistence.GetPeakShavingContactAddresses(peakShavingInformationId);
        }

        public List<PeakShavingInformation> GetPeakShavingInformation(bool sendNotifications)
        {
            ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository persistence = new ERMABusinessLibrary.Persistence.PeakShavingNotificationsRepository();
            return persistence.GetPeakShavingInformation(sendNotifications);
        }
    }
}
