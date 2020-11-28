using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Exchange_Things.Database;
using Exchange_Things.Entities;
using Exchange_Things.Models;

namespace Exchange_Things.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyAsyncController : ControllerBase
    {
        private readonly ExchangeThingsContext _context;
        public CompanyAsyncController(ExchangeThingsContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetItems")]
        public async Task<IActionResult> GetItems()
        {
            var items = _context.Items.ToList();

            if (items == null)
                return NotFound("Nope");

            return Ok(items);
        }

        [HttpPost]
        [Route("AddNewItem")]
        public async Task<IActionResult> AddNewItem(CompanyModel companyModel)
        {
            var itemEntity = new ItemEntity
            {
                Name = companyModel.Name,
                Description = companyModel.Description,
                IsVisible = companyModel.IsVisible
            };

            _context.Add(itemEntity);
            _context.SaveChanges();

            return Ok();
        }
    }
}