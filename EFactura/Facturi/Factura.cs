using EFactura.Cont;
using EFactura.Firme;
using EFactura.Servicii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFactura.Facturi
{
    public class Factura
    {
        public int ID {  get; set; }
        public string FirmaID { get; set; }
        public string Serie { get; set; }
        public ContBancar Cont { get; set; }
        public int Numar { get; set; }
        public List<ServiciuFactura> Servicii { get; set; }
        
        public float ValoareTotala { get; set; }
        public DateTime DataEmiterii { get; set; }
        public Client Client { get; set; }
       public string MetodaPlata { get; set; }

    }
}
