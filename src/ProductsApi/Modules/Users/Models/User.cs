using ProductsApi.Global.Models;
using System.ComponentModel.DataAnnotations;

namespace ProductsApi.Modules.Users.Models
{
    public class User : Model
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
