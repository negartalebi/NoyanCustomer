

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Noyan.Customers.Core.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Noyan.Customers.Application
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerDbContext).Assembly);
        }

        public DbSet<Customer> Customers { get; set; }
    }


    public class CustomerDbContextFactory : IDesignTimeDbContextFactory<CustomerDbContext>
    {
        public CustomerDbContext CreateDbContext(string[] args)
        {
            

            var builder = new DbContextOptionsBuilder<CustomerDbContext>();
            var connectionString = "Server=.;Database=noyan_cusotmer_db;user Id=sa;password=QazWsx12!@;Trusted_Connection=True;MultipleActiveResultSets=true";

            builder.UseSqlServer(connectionString);

            return new CustomerDbContext(builder.Options);
        }
    }
}
