using E_mail_Management_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_Management_Infrastructure.Context
{
    public class Email_Management_Context : DbContext
    {
        public Email_Management_Context(DbContextOptions<Email_Management_Context> options) : base(options)
        {
        }
        public DbSet<Business> Business { get; set; }
        public DbSet<BusinessEmail> Emails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
