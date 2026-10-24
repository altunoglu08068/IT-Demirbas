using Microsoft.AspNetCore.Identity;

namespace DemirbasApp.Models
{
    public class Kullanici : IdentityUser
    {
        public string AdSoyad { get; set; } = string.Empty;
        public string Departman { get; set; } = string.Empty;
    }
}