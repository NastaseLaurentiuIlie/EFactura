using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFactura.Firme
{
    public class Client
    {
        public string CUI { get; set; }
        public string Nume { get; set; }
        public string NrRegistruComert { get; set; }
        public string Adresa { get; set; }
        public string Tara { get; set; }

        public string Judet { get; set; }
        public string Localitate { get; set; }
        public override string ToString()
        {
            return $"CUI: {CUI}, Nume: {Nume}, NrRegistruComert: {NrRegistruComert}, Adresa: {Adresa}";
        }
    }
}
