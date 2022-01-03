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
        public int IdZamowienia { get; set; }
        public DateTime DataZamowienia { get; set; }
        public decimal CenaZamowniena { get; set; }

    }
}
