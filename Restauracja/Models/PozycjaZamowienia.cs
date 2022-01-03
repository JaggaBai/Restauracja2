using Restauracja.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class PozycjaZamowienia
    {
        [Key]
        public int IdPozycji { get; set; }
        public string Zdjecie { get; set; }
        public string Nazwa { get; set; }
        public KategoriaPozycji KategoriaPozycji { get; set; }
        public decimal Cena { get; set; }

        public List<Zamowienie_PozycjaZamowienia> Zamowienie_PozycjaZamowienias { get; set; }
    }
}
