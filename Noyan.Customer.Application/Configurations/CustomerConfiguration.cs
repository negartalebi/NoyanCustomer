
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Noyan.Customers.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noyan.Customers.Application.Configurations
{

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder
               .Property(b => b.Family)
               .IsRequired()
               .HasMaxLength(100);

            builder
               .Property(b => b.Code)
               .IsRequired()
               .HasMaxLength(10);

            builder
               .Property(b => b.NationalCode)
               .IsRequired()
               .HasMaxLength(10);

            builder
               .Property(b => b.FatherName)
               .IsRequired()
               .HasMaxLength(100);

            builder
             .Property(b => b.BirthCertificate)
             .IsRequired()
             .HasMaxLength(10); 
        }
    }
}
