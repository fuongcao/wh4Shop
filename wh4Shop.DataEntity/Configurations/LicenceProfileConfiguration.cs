namespace wh4Shop.DataEntity.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using wh4Shop.DataEntity.EntityModels;
    public class LicenceProfileConfiguration : IEntityTypeConfiguration<LicenceProfile>
    {
        public void Configure(EntityTypeBuilder<LicenceProfile> builder)
        {
            builder.ToTable("LicenceProfiles", "wh4shop");

            builder.HasKey(c => c.LicenceId);

            builder.Property(c => c.LicenceId).ValueGeneratedOnAdd();

            builder.Property(c => c.LicenceKey).HasMaxLength(50);

            builder.HasIndex(c => c.LicenceKey).IsUnique(true);

            builder.HasIndex(c => c.IssueDate);

            builder.HasIndex(c => c.ExpiredDate);
        }
    }
}
