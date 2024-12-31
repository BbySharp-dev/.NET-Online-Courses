using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineCourses.Core.Entities;
using OnlineCourses.DataAccess.Data.Config;

namespace OnlineCourses.DataAccess.Data
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Channel> Channel { get; set; }
        public DbSet<Video> Video { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // shorter way of applying the manual configuration
            //$ builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // longer way of applying the manual configuration
            builder.ApplyConfiguration(new CommentConfig());
            builder.ApplyConfiguration(new SubscribeConfig());
            builder.ApplyConfiguration(new LikeDislikeConfig());
        }
    }
}