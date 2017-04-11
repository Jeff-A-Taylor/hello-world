using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
//using OfficeOpenXml;
using System.IO;
//using System.Web.UI.WebControls;
using ERMA.Roles;
using ERMABusinessLibrary.Persistence;

namespace ApplicationInterface
{
    public class ERMAAnnouncementsService
    {
        public List<ERMAAnnouncement> GetERMAAnnouncement(int ID)
        {
            ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository persistence = new ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository();
            return persistence.GetERMAAnnouncement(ID);
        }

        public void UpdateERMAAnnouncement(int ID, string Comment, string DisplayStartDate, string DisplayEndDate,
                                           string Message)
        {
            ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository persistence = new ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository();
            persistence.UpdateERMAAnnouncement(ID, Comment, DisplayStartDate, DisplayEndDate, Message);
        }

        public int InsertERMAAnnouncement(string Comment, string DisplayStartDate, string DisplayEndDate,
                                           string Message)
        {
            ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository persistence = new ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository();
            return persistence.InsertERMAAnnouncement(Comment, DisplayStartDate, DisplayEndDate, Message);
        }

        public void DeleteERMAAnnouncement(int ID)
        {
            ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository persistence = new ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository();
            persistence.DeleteERMAAnnouncement(ID);
        }

        public List<ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository.AllAnnouncements> GetAllAnnouncements()
        {
            ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository persistence = new ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository();
            return persistence.GetAllAnnouncements();
        }

        public List<ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository.AllAnnouncements> GetAnnouncementsOnly()
        {
            ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository persistence = new ERMABusinessLibrary.Persistence.ERMAAnnouncementsRepository();
            return persistence.GetAnnouncementsOnly();
        }

        //public partial class AllAnnouncements
        //{
        //    private int id;
        //    public int ID
        //    {
        //        get { return id; }
        //        set { id = value; }
        //    }
        //    private string message;
        //    public string Message
        //    {
        //        get { return message; }
        //        set { message = value; }
        //    }
        //    private DateTime displayStartDate;
        //    public DateTime DisplayStartDate
        //    {
        //        get { return displayStartDate; }
        //        set { displayStartDate = value; }
        //    }
        //    private DateTime displayEndDate;
        //    public DateTime DisplayEndDate
        //    {
        //        get { return displayEndDate; }
        //        set { displayEndDate = value; }
        //    }
        //    private string comment;
        //    public string Comment
        //    {
        //        get { return comment; }
        //        set { comment = value; }
        //    }
        //    private DateTime dateSaved;
        //    public DateTime DateSaved
        //    {
        //        get { return dateSaved; }
        //        set { dateSaved = value; }
        //    }
        //    private string userid;
        //    public string UserID
        //    {
        //        get { return userid; }
        //        set { userid = value; }
        //    }

        //}

    }
}
