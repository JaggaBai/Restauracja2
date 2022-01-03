using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class Klient
    {
        [Key]
        public int KlientId { get; set; }
        public int NumerStolika { get; set; }

        public List<Zamownie> Zamownies { get; set; }
    }
}
