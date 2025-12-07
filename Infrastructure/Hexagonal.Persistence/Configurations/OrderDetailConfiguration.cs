using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Hexagonal.Domain.Entities;

namespace Hexagonal.Persistence.Configurations
{
    public class OrderDetailConfiguration : BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);

            //id ignore edilmeden composite index oluşturuldu
            builder.HasIndex(x => new { 
                        x.OrderId, 
                        x.ProductId 
                    })
                    .IsUnique();
        }
    }
}
