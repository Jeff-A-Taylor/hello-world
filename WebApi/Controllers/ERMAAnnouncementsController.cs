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
    public class ERMAAnnouncementsController : ApiController
    {
        public List<ERMAAnnouncement> GetERMAAnnouncement(int ID)
        {
            ERMAAnnouncementsService service = new ERMAAnnouncementsService();
            return service.GetERMAAnnouncement(ID);
        }

        public void UpdateERMAAnnouncement(int ID, string Comment, string DisplayStartDate, string DisplayEndDate,
                                           string Message)
        {
            ERMAAnnouncementsService service = new ERMAAnnouncementsService();
            service.UpdateERMAAnnouncement(ID, Comment, DisplayStartDate, DisplayEndDate, Message);
        }

        public int InsertERMAAnnouncement(string Comment, string DisplayStartDate, string DisplayEndDate,
                                           string Message)
        {
            ERMAAnnouncementsService service = new ERMAAnnouncementsService();
            return service.InsertERMAAnnouncement(Comment, DisplayStartDate, DisplayEndDate, Message);
        }

        public void DeleteERMAAnnouncement(int ID)
        {
            ERMAAnnouncementsService service = new ERMAAnnouncementsService();
            service.DeleteERMAAnnouncement(ID);
        }

        public List<ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository.AllAnnouncements> GetAllAnnouncements()
        {
            ERMAAnnouncementsService service = new ERMAAnnouncementsService();
            return service.GetAllAnnouncements();
        }

        public List<ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository.AllAnnouncements> GetAnnouncementsOnly()
        {
            ERMAAnnouncementsService service = new ERMAAnnouncementsService();
            return service.GetAnnouncementsOnly();
        }

    }
}
