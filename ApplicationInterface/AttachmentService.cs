//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

using ERMABusinessLibrary.Persistence;
using System.Collections.Generic;
namespace ApplicationInterface
{

public enum AttachmentLinkType
{
    NONE = 0,
    BILL = 1,
    ACCOUNT = 2,
    BID = 3,
    CONTRACT = 4,
    ERMA = 5,
    BIDPACKAGE = 6,
    RFQ = 7
};

    public class AttachmentService
    {
        //public static string GetLinkTypeDescription(AttachmentLinkType linkType)
        //{
        //    ERMABusinessLibrary.Persistence.AttachmentPersistence persistence = new ERMABusinessLibrary.Persistence.AttachmentPersistence();
        //    return persistence.GetLinkTypeDescription(linkType);
        //}

        public Attachment GetAttachment(int ID)
        {
            ERMABusinessLibrary.Persistence.AttachmentRepository persistence = new ERMABusinessLibrary.Persistence.AttachmentRepository();
            return persistence.GetAttachment(ID);
        }

        public void AddAttachment(int linkId, string fileSourceLocation, string fileDestinationLocation, string userId, byte[] fileData, int linkType)
        {
            ERMABusinessLibrary.Persistence.AttachmentRepository persistence = new ERMABusinessLibrary.Persistence.AttachmentRepository();
            persistence.AddAttachment(linkId, fileSourceLocation, fileDestinationLocation, userId, fileData, linkType);
        }

        public void RemoveAttachment(int ID)
        {
            ERMABusinessLibrary.Persistence.AttachmentRepository persistence = new ERMABusinessLibrary.Persistence.AttachmentRepository();
            persistence.RemoveAttachment(ID);
        }

        public List<Attachment> GetAttachments(int linkID, int linkType)
        {
            ERMABusinessLibrary.Persistence.AttachmentRepository persistence = new ERMABusinessLibrary.Persistence.AttachmentRepository();
            return persistence.GetAttachments(linkID, linkType);
        }

        public bool hasAttachments(int linkID, int linkType)
        {
            ERMABusinessLibrary.Persistence.AttachmentRepository persistence = new ERMABusinessLibrary.Persistence.AttachmentRepository();
            return persistence.hasAttachments(linkID, linkType);
        }
    }
}
