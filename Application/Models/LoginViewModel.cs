using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class LoginViewModel
    {
        [DataType(DataType.Password)] 
        public string Password { get; set; }
    }
}