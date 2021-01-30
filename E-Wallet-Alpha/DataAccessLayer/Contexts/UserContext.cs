using E_Wallet_Alpha.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Wallet_Alpha.DataAccessLayer.Contexts
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions options) : base(options) { }

        public DbSet<User> UserTable { get; set; } 
        public DbSet<Transiction> TransictionTable { get; set; }
    }
}
