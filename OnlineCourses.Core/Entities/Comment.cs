using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineCourses.Core.Entities
{
    public class Comment
    {
        // PK (AppUserId, VideoId)
        // FK = AppUserId and FK = VideoId
        public int AppUserId { get; set; }
        public int VideoId { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime PostedAt { get; set; } = DateTime.UtcNow;
        // Navigations
        public AppUser AppUser { get; set; }
        public Video Video { get; set; }
    }
}