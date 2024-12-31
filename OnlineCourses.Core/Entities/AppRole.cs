using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace OnlineCourses.Core.Entities;

public class AppRole : IdentityRole<int>
{
    [Required]
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}