namespace wh4Shop.DataEntity.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using wh4Shop.DataEntity.EntityModels;
    class LegalProfileConfiguration : IEntityTypeConfiguration<LegalProfile>
    {
        public void Configure(EntityTypeBuilder<LegalProfile> builder)
        {
            builder.ToTable("LegalProfiles", "wh4shop");

            builder.HasKey(c => c.LegalEntityId);

            builder.Property(c => c.LegalEntityId).ValueGeneratedOnAdd();

            builder.Property(c => c.LegalType).HasMaxLength(15);
            builder.Property(c => c.LegalName).HasMaxLength(125);
            builder.Property(c => c.LegalAddress).HasMaxLength(250);
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
