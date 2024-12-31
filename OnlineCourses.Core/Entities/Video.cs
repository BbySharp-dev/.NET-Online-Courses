using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCourses.Core.Entities;

public class Video : BaseEntity
{
    [Required] public string ThumbnailUrl { get; set; }
    [Required] public string Title { get; set; }
    [Required] public string Description { get; set; }
    [Required] public string ContentType { get; set; }
    [Required] public byte[] Contents { get; set; }
    public int CategoryId { get; set; }
    public int ChannelId { get; set; }

    //Navigations
    [ForeignKey("CategoryId")] public Category Category { get; set; }
    [ForeignKey("ChannelId")] public Channel Channel { get; set; }
}