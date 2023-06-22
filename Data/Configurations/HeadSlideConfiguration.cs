using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class HeadSlideConfiguration:IEntityTypeConfiguration<HeadSlide>
    {
        public void Configure(EntityTypeBuilder<HeadSlide> builder)
        {

            builder.Property(p => p.Image).IsRequired().HasMaxLength(255);
            builder.Property(p => p.CreatedAt).IsRequired().HasDefaultValueSql("GETUTCDATE()");

        }
    }
}
