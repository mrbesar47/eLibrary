using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLibrary.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eLibrary.Controllers
{
    public class SearchController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public async Task<IActionResult> Index(string Request)
        {
            var Search = from m in _context.Book select m;
            var count = 0;

            if (!String.IsNullOrEmpty(Request))
            {
                Search = Search.Where(s => s.Name.ToLower().Contains(Request.ToLower()) || s.Description.ToLower().Contains(Request.ToLower()) || s.Author.ToLower().Contains(Request.ToLower()));
                count++;
            }

            return View(await Search.ToListAsync());
        }

    }
}