namespace wh4Shop.DataEntity.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using wh4Shop.DataEntity.EntityModels;

    class InvTransactionConfiguration : IEntityTypeConfiguration<InvTransaction>
    {
        public void Configure(EntityTypeBuilder<InvTransaction> builder)
        {
            builder.ToTable("InvTransactions", "wh4shop");

            builder.HasKey(c => c.TransactionId);

            builder.Property(c => c.TransactionId).ValueGeneratedOnAdd();

            builder.HasIndex(c => new { c.TransactionId, c.TransactionSetId }).IsUnique(true);

            builder.Property(c => c.TransactionAction).HasMaxLength(15);
            builder.Property(c => c.TransactionStatus).HasMaxLength(15);
            builder.Property(c => c.TransactionType).HasMaxLength(15);
            builder.Property(c => c.Uom).HasMaxLength(20);

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
