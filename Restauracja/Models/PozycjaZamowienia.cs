using Restauracja.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class PozycjaZamowienia
    {
        public int Id { get; set; }
        public string Zdjecie { get; set; }
        public string Nazwa { get; set; }
        public KategoriaPozycji KategoriaPozycji { get; set; }
        public decimal Cena { get; set; }
    }
}
