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
    public class AttachmentController : ApiController
    {
        //public static string GetLinkTypeDescription(AttachmentLinkType linkType)
        //{
        //    ERMABusinessLibrary.Persistence.AttachmentPersistence persistence = new ERMABusinessLibrary.Persistence.AttachmentPersistence();
        //    return persistence.GetLinkTypeDescription(linkType);
        //}

        public Attachment GetAttachment(int ID)
        {
            AttachmentService service = new AttachmentService();
            return service.GetAttachment(ID);
        }

        public void AddAttachment(int linkId, string fileSourceLocation, string fileDestinationLocation, string userId, byte[] fileData, int linkType)
        {
            AttachmentService service = new AttachmentService();
            service.AddAttachment(linkId, fileSourceLocation, fileDestinationLocation, userId, fileData, linkType);
        }

        public void RemoveAttachment(int ID)
        {
            AttachmentService service = new AttachmentService();
            service.RemoveAttachment(ID);
        }

        public List<Attachment> GetAttachments(int linkID, int linkType)
        {
            AttachmentService service = new AttachmentService();
            return service.GetAttachments(linkID, linkType);
        }

        public bool hasAttachments(int linkID, int linkType)
        {
            AttachmentService service = new AttachmentService();
            return service.hasAttachments(linkID, linkType);
        }
    }
}
