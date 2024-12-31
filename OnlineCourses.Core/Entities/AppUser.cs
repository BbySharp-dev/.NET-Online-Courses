using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace OnlineCourses.Core.Entities
{
    public class AppUser : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // Navigations
        public Channel Channel { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Subscribe> Subscriptions { get; set; }
        public ICollection<LikeDislike> LikeDislikes { get; set; }
    }
}