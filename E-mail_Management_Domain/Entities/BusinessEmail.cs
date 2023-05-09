using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_Management_Domain.Entities
{
    public class BusinessEmail
    {
        //public BusinessEmail(string? email, int businessId)
        //{
        //    Email = email;
        //    BusinessId = businessId;
        //}

        public int BusinessEmailId { get; private set; }
        public string? Email { get; private set; }
        public int BusinessId { get; private set; }
    }
}
