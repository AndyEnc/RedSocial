using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using TwitterChine.Core.Domain.Entities;

namespace TwitterChine.Infrastructure.Persistence.EntityConfigurations
{
    public class PostsConfiguration : IEntityTypeConfiguration<Posts>
    {
        public void Configure(EntityTypeBuilder<Posts> builder)
        {
            builder.ToTable("Posts");

            //Keys and Restrictions
            builder.HasKey(x => x.Id);
            //Properties
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Image).IsRequired();
        }
    }
}
