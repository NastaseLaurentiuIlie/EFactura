using static EFactura.Facturi.Factura;

namespace EFactura.Firme
{
    public class Serviciu
    {
        public int Id { get; set; }
        public string Descriere { get; set; }
        public decimal Pret { get; set; }
        public UM Um { get; set; }
        public TVA Tva { get; set; }
        public int Cantitate { get; set; }
        public float Valoare { get; set; }
        public enum UM
        {
            
        KG =0,   // Kilogram
            buc =1,  // Pieces
            L =2 // Liters
        }
        public enum TVA
        {
            Zero = 0,
            Unu = 5,
            Noua = 9,
            Nouapsrezece = 19
        }
    }
}
