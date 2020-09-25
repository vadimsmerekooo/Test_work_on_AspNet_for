using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test_from_CBT_AspNet.Areas.Identity.Data;

namespace Test_from_CBT_AspNet.Data
{
    public class Test_from_CBT_AspNetContext : IdentityDbContext<IdentityUser>
    {
        public Test_from_CBT_AspNetContext(DbContextOptions<Test_from_CBT_AspNetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetEvents> AspNetEvents { get; set; }
        public virtual DbSet<AspNetEventsImages> AspNetEventsImages { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
