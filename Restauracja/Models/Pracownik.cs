using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class Pracownik
    {
        [Key]
        public int IdPracownika { get; set; }
        public string ImiePracownika { get; set; }

        public string NazwiskoPracownika { get; set; }

        public List<Zamownie> Zamowienia { get; set; }
    }
}
