using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using workshop2.Data.Seeders;
using workshop2.Models;

namespace workshop2.Data {
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser> {
        public ApplicationDbContext (
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base (options, operationalStoreOptions) { }
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentFile> DocumentFile { get; set; }
        public DbSet<DocumentFileStatus> DocumentFileStatus { get; set; }
        public DbSet<Secret> Secret { get; set; }
        public DbSet<Board> Board { get; set; }
        public DbSet<DocumentStatus> DocumentStatus { get; set; }
        public DbSet<DocumentFilePositionSignature> DocumentFilePositionSignature { get; set; }
        public DbSet<Employee> Employee { get; set; }
        protected override void OnModelCreating (ModelBuilder builder) {

            base.OnModelCreating (builder);
            builder.ApplyConfiguration (new DocumentFileStatusSeeder ());
            builder.ApplyConfiguration (new DocumentStatusSeeder ());
            builder.ApplyConfiguration (new SecretSeeder ());
            builder.ApplyConfiguration (new BoardSeeder ());
            builder.ApplyConfiguration (new EmployeeSeeder ());

        }
    }
}