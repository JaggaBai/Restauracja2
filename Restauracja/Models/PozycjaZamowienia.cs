using Restauracja.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cena { get; set; }

        public List<Zamowienie_PozycjaZamowienia> Zamowienie_PozycjaZamowienias { get; set; }
    }
}
