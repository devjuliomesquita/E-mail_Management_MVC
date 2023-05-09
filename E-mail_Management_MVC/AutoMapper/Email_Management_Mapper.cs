using AutoMapper;
using E_mail_Management_Domain.Entities;
using E_mail_Management_MVC.Models;

namespace E_mail_Management_MVC.AutoMapper
{
    public class Email_Management_Mapper : Profile
    {
        public Email_Management_Mapper() 
        {
            //Modelos de Criação
            CreateMap<BusinessInputModel, Business>();
        }

    }
}
