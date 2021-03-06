﻿using Exchange_Things.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exchange_Things.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("IndexAsync");
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            var viewModel = new CompanyAddedViewModel
            {

                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                NumberOfCharsInOwnerName = company.OwnerName.Length,
                IsHidden = !company.IsVisible           
            };

            return View("CompanyAdded", viewModel);            

        }
    }
}
