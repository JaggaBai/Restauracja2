using Microsoft.AspNetCore.Mvc;
using Restauracja.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Controllers
{
    public class PozycjeZamowieniaController : Controller
    {
        private readonly RestDbContext _context;
        public PozycjeZamowieniaController(RestDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.PozycjeZamowienia.ToList();
            return View();
        }
    }
}
