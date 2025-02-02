﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwitterChine.Core.Domain.Entities;

namespace TwitterChine.Infrastructure.Persistence.EntityConfigurations
{
    public class CommentsConfiguration : IEntityTypeConfiguration<Comments>
    {
        public void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.ToTable("Comments");
            //Keys and Restrictions
            builder.HasKey(x => x.Id);
            //Properties
            builder.Property(x => x.Content).IsRequired();

            builder.HasOne(x => x.Post)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.IdPost)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
