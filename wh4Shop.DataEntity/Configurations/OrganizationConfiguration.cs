namespace wh4Shop.DataEntity.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using wh4Shop.DataEntity.EntityModels;
    class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable("Organizations", "wh4shop");

            builder.HasKey(c => c.OrganizationId);

            builder.Property(c => c.OrganizationId).ValueGeneratedOnAdd();

            builder.Property(c => c.OrganizationCode).HasMaxLength(35);
            builder.Property(c => c.OrganizationName).HasMaxLength(125);
            builder.Property(c => c.OrganizationType).HasMaxLength(15);

            builder.Property(c => c.OrganizationAddress).HasMaxLength(250);

            builder.Property(c => c.Description).HasMaxLength(250);

            builder.Property(c => c.Attribute1).HasMaxLength(500);
            builder.Property(c => c.Attribute2).HasMaxLength(500);
            builder.Property(c => c.Attribute3).HasMaxLength(500);
            builder.Property(c => c.Attribute4).HasMaxLength(500);
            builder.Property(c => c.Attribute5).HasMaxLength(500);

            builder.Property(c => c.CreationBy).HasMaxLength(60);
            builder.Property(c => c.LastUpdateBy).HasMaxLength(60);

            builder.HasIndex(c => c.CreationDate);
            builder.HasIndex(c => c.LastUpdateDate);

        }
    }
}
