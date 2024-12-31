using System.ComponentModel.DataAnnotations;

namespace OnlineCourses.Core.Entities;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}