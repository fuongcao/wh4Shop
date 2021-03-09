namespace wh4Shop.DataEntity.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using wh4Shop.DataEntity.EntityModels;

    class CcountLineConfiguration : IEntityTypeConfiguration<CcountLine>
    {
        public void Configure(EntityTypeBuilder<CcountLine> builder)
        {
            builder.ToTable("CcountLines", "wh4shop");

            builder.HasKey(c => c.CntLineId);

            builder.Property(c => c.CntLineId).ValueGeneratedOnAdd();

            builder.Property(c => c.ItemCode).HasMaxLength(40);

            builder.Property(c => c.Sku).HasMaxLength(40);

            builder.Property(c => c.Attribute1).HasMaxLength(500);
            builder.Property(c => c.Attribute2).HasMaxLength(500);
            builder.Property(c => c.Attribute3).HasMaxLength(500);
            builder.Property(c => c.Attribute4).HasMaxLength(500);
            builder.Property(c => c.Attribute5).HasMaxLength(500);

            builder.Property(c => c.CreationBy).HasMaxLength(60);
            builder.Property(c => c.LastUpdateBy).HasMaxLength(60);

            builder.HasIndex(c => c.CreationDate);
            builder.HasIndex(c => c.LastUpdateDate);

            builder.HasOne(o => o.Ccount)
                    .WithMany(m => m.CcountLines)
                    .HasForeignKey(fk => fk.CntId);
        }
    }
}
