using System;
using System.Collections.Generic;
using System.Text;

namespace wh4Shop.DataEntity.EntityModels
{
    public class Ccount
    {
        public long CntId { get; set; }
        public string CcountCode { get; set; }
        public string CcountType { get; set; }
        public string CcountStatus { get; set; }
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

        public ICollection<CcountLine> CcountLines { get; set; }
    }
}
