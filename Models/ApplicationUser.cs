using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace TranGiaBao_0230_lab02.Models;

public class ApplicationUser: IdentityUser {
    [Required]
    public string FullName { get; set; }
    public string? Address { get; set; }
    public string? Age { get; set; }
}