using Microsoft.AspNetCore.Identity;

namespace PH.Models
{
    public class User: IdentityUser
    {
         public bool IsBlock{ get; set; }
    }
}