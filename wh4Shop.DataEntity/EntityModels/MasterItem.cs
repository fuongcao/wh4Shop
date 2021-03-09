using System;
using System.Collections.Generic;
using System.Text;

namespace wh4Shop.DataEntity.EntityModels
{
    public class MasterItem
    {
        public long Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemSku { get; set; }
        public decimal ItemCost { get; set; }
        public string Unit { get; set; }
        public long LegalEntityId { get; set; }
        public long OrganizationId { get; set; }
        public string Description { get; set; }
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
