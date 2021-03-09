using System;
using System.Collections.Generic;
using System.Text;

namespace wh4Shop.DataEntity.EntityModels
{
    public class LicenceProfile
    {
        public long LicenceId { get; set; }
        public string LicenceKey { get; set; }
        public string LicenceType { get; set; }
        public int MaxUser { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string Description { get; set; }
    }
}
