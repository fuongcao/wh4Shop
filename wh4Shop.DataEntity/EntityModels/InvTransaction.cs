using System;
using System.Collections.Generic;
using System.Text;

namespace wh4Shop.DataEntity.EntityModels
{
    public class InvTransaction
    {
        public long TransactionId { get; set; }
        public long TransactionSetId { get; set; }
        public long FromOrganization { get; set; }
        public long OwnerOrganization { get; set; }
        public decimal TransactionQuantity { get; set; }
        public string TransactionStatus { get; set; }
        public string TransactionAction { get; set; }
        public string TransactionType { get; set; }
        public string Uom { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        public string Attribute5 { get; set; }
        public Guid CreationBy { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }


    }
}
