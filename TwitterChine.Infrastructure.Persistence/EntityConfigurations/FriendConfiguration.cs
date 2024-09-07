
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwitterChine.Core.Domain.Entities;

namespace TwitterChine.Infrastructure.Persistence.EntityConfigurations
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friends>
    {
        public void Configure(EntityTypeBuilder<Friends> builder)
        {
            builder.ToTable("Friends");
            //Keys and Restriction
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName).IsRequired();

           
        }
    }
}
