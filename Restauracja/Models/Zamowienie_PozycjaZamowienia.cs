using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class Zamowienie_PozycjaZamowienia
    {
        public int IdZamownie { get; set; }
        public Zamownie Zamownie { get; set; } 
        public int IdPozycji { get; set; }
        public PozycjaZamowienia PozycjaZamowienia { get; set; }
    }
}
