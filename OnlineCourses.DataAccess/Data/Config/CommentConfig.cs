using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineCourses.Core.Entities;

namespace OnlineCourses.DataAccess.Data.Config;

public class CommentConfig : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        // defining the primary key which is a combination of both AppUserId and VideoId
        builder.HasKey(x => new { x.AppUserId, x.VideoId });
        builder.HasOne(a => a.AppUser).WithMany(c => c.Comments).HasForeignKey(c => c.AppUserId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(a => a.Video).WithMany(c => c.Comments).HasForeignKey(c => c.VideoId).OnDelete(DeleteBehavior.Restrict);
    }
}