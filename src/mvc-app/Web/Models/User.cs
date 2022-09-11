using Microsoft.AspNetCore.Identity;

namespace Web.Models
{
    public class User : IdentityUser
    {
        public bool? IsActive { get; set; }
        public int NumTimesForgotPass { get; set; }
        public ICollection<Cart>? Carts { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}

