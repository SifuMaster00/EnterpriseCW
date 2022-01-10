using EnterpriseCW_w1739283.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseCW_w1739283.Shared;

namespace EnterpriseCW_w1739283.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        // public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<EnterpriseCW_w1739283.Shared.Todo> todo { get; set; }
        public DbSet<EnterpriseCW_w1739283.Shared.Company> Company { get; set; }
        public DbSet<EnterpriseCW_w1739283.Shared.Project> Project { get; set; }
        public DbSet<EnterpriseCW_w1739283.Shared.User> User { get; set; }

    }
}
