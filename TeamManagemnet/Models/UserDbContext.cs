using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TeamManagemnet.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext()
        {
            Database.SetInitializer<UserDbContext>
                (new CreateDatabaseIfNotExists<UserDbContext>());
        }
        public DbSet<User> Users{ get; set;}

        public System.Data.Entity.DbSet<TeamManagemnet.Models.Role> Roles { get; set; }
    }
}