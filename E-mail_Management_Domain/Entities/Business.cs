using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_Management_Domain.Entities
{
    public class Business
    {
        public Business(string? businessName)
        {
            BusinessName = businessName;

            BusinessNNI = false;
            Active = true;
            CreatedAt = DateTime.Now;
            Emails = new List<BusinessEmail>();
        }

        public int BusinessId { get; private set; }
        public string? BusinessName { get; private set; }
        public bool BusinessNNI { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime CanceledAt { get; private set; }
        public List<BusinessEmail>? Emails { get; private set; }
    }
}
