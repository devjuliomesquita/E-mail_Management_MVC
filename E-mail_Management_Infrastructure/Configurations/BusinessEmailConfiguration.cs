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
    public class BusinessEmailConfiguration : IEntityTypeConfiguration<BusinessEmail>
    {
        public void Configure(EntityTypeBuilder<BusinessEmail> builder)
        {
            builder
                .HasKey(be => be.BusinessEmailId);
            builder
                .ToTable("Email");
            builder
                .Property(be => be.Email)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
