using E_mail_Management_Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace E_mail_Management_MVC.Models
{
    public class BusinessInputModel
    {
        [Required(ErrorMessage = "O Nome do Parceiro é Obrigatório.")]
        public string? BusinessName { get; set; }
        public bool BusinessNNI { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime CanceledAt { get; set; }
        public List<BusinessEmailViewModel>? Emails { get; set; } = new List<BusinessEmailViewModel>();
    }
}
