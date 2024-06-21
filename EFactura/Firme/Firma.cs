using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFactura.Firme
{
        public class Firma
        {
            public string CUI { get; set; }
            public string Nume { get; set; }
            public int IDUser { get; set; }
            public string NrRegistruComert { get; set; }
            
            public string Adresa { get; set; }
            public string Tara { get; set; }
            
            public string Judet { get; set; }
            public string Localitate { get; set; }
    }
}
