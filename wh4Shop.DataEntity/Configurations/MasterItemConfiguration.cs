namespace wh4Shop.DataEntity.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using wh4Shop.DataEntity.EntityModels;

    public class MasterItemConfiguration : IEntityTypeConfiguration<MasterItem>
    {
        public void Configure(EntityTypeBuilder<MasterItem> builder)
        {
            builder.ToTable("MasterItems", "wh4shop");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.HasIndex(c => new { c.ItemCode, c.ItemSku }).IsUnique(true);

            builder.HasIndex(c => new { c.ItemCode, c.OrganizationId }).IsUnique(true);

            builder.HasIndex(c => new { c.LegalEntityId, c.OrganizationId }).IsUnique(true);


            builder.Property(c => c.ItemCode).HasMaxLength(60);
            builder.Property(c => c.ItemSku).HasMaxLength(100);

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
