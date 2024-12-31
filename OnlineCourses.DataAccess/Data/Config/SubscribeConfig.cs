using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineCourses.Core.Entities;

namespace OnlineCourses.DataAccess.Data.Config
{
    public class SubscribeConfig : IEntityTypeConfiguration<Subscribe>
    {
        public void Configure(EntityTypeBuilder<Subscribe> builder)
        {
            // defining the primary key which is a combination of both AppUserId and ChannelId
            builder.HasKey(x => new { x.AppUserId, x.ChannelId });
            builder.HasOne(a => a.AppUser).WithMany(c => c.Subscriptions).HasForeignKey(c => c.AppUserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(a => a.Channel).WithMany(c => c.Subscribers).HasForeignKey(c => c.ChannelId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}