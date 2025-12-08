using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCUserManagementHus.Models
{
    public partial class UserDbContext : DbContext
    {
        public UserDbContext()
            : base("name=HusUserDbContext")
        {
        }

        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
