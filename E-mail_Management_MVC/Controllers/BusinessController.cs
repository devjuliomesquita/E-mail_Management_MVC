using AutoMapper;
using E_mail_Management_Domain.Entities;
using E_mail_Management_Domain.Interfaces;
using E_mail_Management_MVC.Models.Business;
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
            var business = _Businessrepository.GetAll();
            var businessVM = business.Select(b => new BusinessViewModel
            {
                BusinessId = b.BusinessId,
                BusinessName = b.BusinessName,
                BusinessNNI = b.BusinessNNI,
                Active = b.Active,
                CreatedAt = b.CreatedAt,
                CanceledAt  = b.CanceledAt
            }).ToList();
            return View(businessVM);
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
