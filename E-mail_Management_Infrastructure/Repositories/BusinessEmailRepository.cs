using E_mail_Management_Domain.Entities;
using E_mail_Management_Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_Management_Infrastructure.Repositories
{
    public class BusinessEmailRepository : RepositoryBase<BusinessEmail>, IBusinessEmailRepository
    {
        public BusinessEmailRepository(bool SaveChangues = true) : base(SaveChangues)
        {
            
        }
    }
}
