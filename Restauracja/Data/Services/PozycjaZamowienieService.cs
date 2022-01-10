using Microsoft.EntityFrameworkCore;
using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data.Services
{
    public class PozycjaZamowienieService : IPozycjaZamowienia
    {     
        private readonly RestDbContext _context;
        public PozycjaZamowienieService(RestDbContext context)
        {
            _context = context;
        }
        public void Delate(int id)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(PozycjaZamowienia pozycjaZamowienia)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PozycjaZamowienia>> PobierzWszystkie()
        {
            var res = await _context.PozycjeZamowienia.ToListAsync();
            return res;
        }

        public PozycjaZamowienia Update(int id, PozycjaZamowienia nowapozycjaZamowienia)
        {
            throw new NotImplementedException();
        }
    }
}

