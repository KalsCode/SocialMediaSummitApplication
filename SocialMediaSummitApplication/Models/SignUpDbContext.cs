using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SocialMediaSummitApplication.Models
{
    public class SignUpDbContext:DbContext
    {
        public DbSet<SignUp> SignUps { get; set; }
    }
}