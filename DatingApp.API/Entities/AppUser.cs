using System.ComponentModel.DataAnnotations;

namespace DatingApp.API;

public class AppUser
{
    public int Id { get; set; }

    [Required]
    public string UserName { get; set; }
    
}