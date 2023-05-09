using System.ComponentModel.DataAnnotations;

namespace E_mail_Management_MVC.Models.Business
{
    public class BusinessViewModel
    {
        
        public int BusinessId { get; set; }
        public string? BusinessName { get; set; }
        public bool BusinessNNI { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CanceledAt { get; set; }
    }
}
