using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApps.Models;

namespace WebApps.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //App 03
        public DbSet<Student> Students { get; set; }

        // App 04
        public DbSet<Post> Posts { get; set; }
        public DbSet<MessagePost> Messages { get; set; }
        public DbSet<PhotoPost> Photos { get; set; }
    }
}
