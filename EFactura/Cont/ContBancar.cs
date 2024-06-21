using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFactura.Cont
{
    public class ContBancar
    {
        public string IBAN { get; set; }
        public string Moneda { get; set; }
        public string CUIFirma { get; set; }
        public string Banca { get; set; }
    }
}
