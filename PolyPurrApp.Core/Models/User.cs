using Microsoft.AspNetCore.Identity;

namespace PolyPurrApp.Core.Models;

public class User : IdentityUser
{
    public string? ProfilImageUrl { get; set; }
}
