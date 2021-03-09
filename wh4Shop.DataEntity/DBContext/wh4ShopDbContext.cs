namespace wh4Shop.DataEntity
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using wh4Shop.DataEntity.EntityModels;
    using wh4Shop.DataEntity.Configurations;
    using Microsoft.AspNetCore.Identity;

    public class wh4ShopDbContext : IdentityDbContext<AppUser,AppRole, Guid>
    {
        public wh4ShopDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin", "wh4shop").HasKey(p => p.UserId);

            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRole", "wh4shop").HasKey(p => new { p.UserId, p.RoleId });

            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserToken", "wh4shop").HasKey(p => p.UserId);

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaim", "wh4shop");

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaim", "wh4shop");

            modelBuilder.ApplyConfiguration(new MasterItemConfiguration());
            modelBuilder.ApplyConfiguration(new InvTransactionConfiguration());
            modelBuilder.ApplyConfiguration(new LegalProfileConfiguration());
            modelBuilder.ApplyConfiguration(new MasterItemConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizationConfiguration());
            modelBuilder.ApplyConfiguration(new LicenceProfileConfiguration());

            modelBuilder.ApplyConfiguration(new CcountConfiguration());
            modelBuilder.ApplyConfiguration(new CcountLineConfiguration());
            modelBuilder.ApplyConfiguration(new InvOnHandConfiguration());


        }

    }
}
