namespace wh4Shop.DataEntity.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using wh4Shop.DataEntity.EntityModels;

    class InvOnHandConfiguration : IEntityTypeConfiguration<InvOnHand>
    {
        public void Configure(EntityTypeBuilder<InvOnHand> builder)
        {
            builder.ToTable("InvOnHands", "wh4shop");

            builder.HasKey(c => new { c.Itemcode, c.Sku});

            builder.Property(c => c.Itemcode).HasMaxLength(40);
            builder.Property(c => c.Sku).HasMaxLength(40);

            builder.Property(c => c.Attribute1).HasMaxLength(500);
            builder.Property(c => c.Attribute2).HasMaxLength(500);
            builder.Property(c => c.Attribute3).HasMaxLength(500);
            builder.Property(c => c.Attribute4).HasMaxLength(500);
            builder.Property(c => c.Attribute5).HasMaxLength(500);

            builder.HasIndex(c => c.OnHandRunDate);
        }
    }
}
