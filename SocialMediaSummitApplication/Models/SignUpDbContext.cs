using System.Data.Entity;

namespace SocialMediaSummitApplication.Models
{
    public class SignUpDbContext:DbContext
    {
        public DbSet<SignUp> SignUps { get; set; }
    }
}