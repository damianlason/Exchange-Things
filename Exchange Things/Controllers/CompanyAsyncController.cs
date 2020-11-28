﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Exchange_Things.Models;

namespace NewBrandingStyle.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyAsyncController : ControllerBase
    {
        [HttpPost]
        [Route("AddNewItem")]
        public async Task<IActionResult> AddNewItem(CompanyModel companyModel)
        {
            var companyAddedModel = new CompanyAddedViewModel
            {
                NumberOfCharsInName = companyModel.Name.Length,
                NumberOfCharsInDescription = companyModel.Description.Length,
                IsHidden = !companyModel.IsVisible
            };

            return Ok(companyAddedModel);
        }
    }
}