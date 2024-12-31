namespace OnlineCourses.Core.Entities
{
    public class LikeDislike
    {
        // PK (AppUserId, VideoId)
        // FK = AppUserId and FK = VideoId
        public int AppUserId { get; set; }
        public int VideoId { get; set; }
        public bool Liked { get; set; } = true;
        // Navigations
        public AppUser AppUser { get; set; }
        public Video Video { get; set; }
    }
}