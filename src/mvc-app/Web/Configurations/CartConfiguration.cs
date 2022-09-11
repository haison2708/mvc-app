using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Models;

namespace Web.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Cart");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsOrder).HasColumnType("bit").HasDefaultValue(false);
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValue(DateTime.Now);

        }
    }
}
