namespace wh4Shop.DataEntity.EntityModels
{
    using System;
    using Microsoft.AspNetCore.Identity;
    public class AppRole : IdentityRole<Guid>
    {
        public long LegalEntityId { get; set; }
    }
}
