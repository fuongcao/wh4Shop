namespace wh4Shop.DataEntity.Configurations
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using wh4Shop.DataEntity.EntityModels;

    class CcountConfiguration : IEntityTypeConfiguration<Ccount>
    {
        public void Configure(EntityTypeBuilder<Ccount> builder)
        {
            builder.ToTable("Ccounts", "wh4shop");

            builder.HasKey(c => c.CntId);

            builder.Property(c => c.CntId).ValueGeneratedOnAdd();

            builder.Property(c => c.CcountCode).HasMaxLength(30);

            builder.Property(c => c.CcountType).HasMaxLength(15);

            builder.Property(c => c.CcountStatus).HasMaxLength(15);

            builder.Property(c => c.Description).HasMaxLength(100);

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
