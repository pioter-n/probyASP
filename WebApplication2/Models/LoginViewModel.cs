using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Podaj nazwe użytkownika")]
        public string UserName { get; set; }
        [Required(ErrorMessage =  "Podaj hasło")]
        public string Password { get; set; }
    }
}