namespace wh4Shop.DataEntity.EntityModels
{
    using System;
    using Microsoft.AspNetCore.Identity;
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClientType { get; set; }
    }
}
