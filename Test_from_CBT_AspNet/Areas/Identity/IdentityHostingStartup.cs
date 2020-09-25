using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Test_from_CBT_AspNet.Data;

[assembly: HostingStartup(typeof(Test_from_CBT_AspNet.Areas.Identity.IdentityHostingStartup))]
namespace Test_from_CBT_AspNet.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Test_from_CBT_AspNetContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Test_from_CBT_AspNetContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Test_from_CBT_AspNetContext>();
            });
        }
    }
}