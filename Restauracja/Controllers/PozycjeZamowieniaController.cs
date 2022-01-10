using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restauracja.Data;
using Restauracja.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Controllers
{
    public class PozycjeZamowieniaController : Controller
    {
        private readonly IPozycjaZamowienia _service;
        public PozycjeZamowieniaController(IPozycjaZamowienia service)
        {
            _service= service;
        }
        public async Task<IActionResult> Index()
        {
            var pz = await _service.PobierzWszystkie();
            return View(pz);
        }
    }
}
