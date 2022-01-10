using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data.Services
{
    public interface IPozycjaZamowienia
    {
        Task<IEnumerable<PozycjaZamowienia>> PobierzWszystkie();
        void Dodaj(PozycjaZamowienia pozycjaZamowienia);

        PozycjaZamowienia Update(int id, PozycjaZamowienia nowapozycjaZamowienia);
        void Delate(int id);


    }
}
