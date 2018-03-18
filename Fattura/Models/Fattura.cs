using System;

namespace FatturaMucca.Models
{
    public class Fattura
    {
        public String Professionista { get; set; }

        public String Committente { get; set; }

        public decimal Importo { get; set; }
    }
}
