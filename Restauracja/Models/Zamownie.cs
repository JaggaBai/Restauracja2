using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class Zamownie
    {
        [Key]
        public int IdZamownie { get; set; }
        public DateTime DataZamowienia { get; set; }
        public decimal CenaZamowniena { get; set; }

        public List<Zamowienie_PozycjaZamowienia> Zamowienie_PozycjaZamowienias { get; set; }

        public int IdPracownika { get; set; }

        public Pracownik Pracownik { get; set; }

        public int KlientId { get; set; }

        public Klient Klient {get; set;}

    }
}
