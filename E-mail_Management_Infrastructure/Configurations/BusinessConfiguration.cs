using E_mail_Management_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_Management_Infrastructure.Configurations
{
    public class BusinessConfiguration : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder
                .HasKey(b => b.BusinessId);
            builder
                .ToTable("Business");
            builder
                .Property(b => b.BusinessName)
                .IsRequired()
                .HasMaxLength(50);
            //Definindo os relacionamentos
            builder
                .HasMany(b => b.Emails)
                .WithOne()
                .HasForeignKey(b => b.BusinessId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
