using AutoMapper;
using E_mail_Management_Domain.Entities;
using E_mail_Management_Domain.Interfaces;
using E_mail_Management_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_mail_Management_MVC.Controllers
{
    public class BusinessController : Controller
    {
        private readonly IBusinessRepository _Businessrepository;
        private readonly IMapper _mapper;
        public BusinessController(IBusinessRepository repository, IMapper mapper)
        {
            _Businessrepository = repository;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BusinessInputModel businessModel)
        {
            //VERIFICAR SE O MÓDEL ESTÁ VÁLIDO
            if (!ModelState.IsValid) { return View(businessModel); }
            var model = _mapper.Map<BusinessInputModel, Business>(businessModel);
            _Businessrepository.Add(model);
            return RedirectToAction("Index");
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
