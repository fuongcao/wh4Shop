using System;
using System.Collections.Generic;
using System.Text;

namespace wh4Shop.DataEntity.EntityModels
{
    public class InvOnHand
    {
        public string Itemcode { get; set; }
        public string Sku { get; set; }
        public long OrganizationId { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        public string Attribute5 { get; set; }
        public DateTime OnHandRunDate { get; set; }
        public long LastTransactionId { get; set; }
    }
}
