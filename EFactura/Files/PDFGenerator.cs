using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Borders;
using System.Threading.Tasks;
using EFactura.Database;
using EFactura.Facturi;

namespace EFactura.Files
{
    public class PDFGenerator : IFileGenerator
    {
        private readonly IDatabaseManager _databaseManager;
        public PDFGenerator(IDatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public async Task GenerateFile(Factura factura, string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    var firma = await _databaseManager.GetFirmaByCuiAsync(factura.FirmaID);
                    Document document = new Document(pdf);
                    document.SetMargins(20, 20, 20, 20);

                    // Add title
                    document.Add(new Paragraph("FACTURA").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20).SetBold());

                    // Add invoice details directly under the title
                    Table detailsTable = new Table(new float[] { 1, 1, 1 });
                    detailsTable.SetWidth(UnitValue.CreatePercentValue(100));
                    detailsTable.AddCell(CreateCell($"Serie: {factura.Serie}", TextAlignment.LEFT, 10));
                    detailsTable.AddCell(CreateCell($"Nr. facturii: {factura.Numar}", TextAlignment.CENTER, 10));
                    detailsTable.AddCell(CreateCell($"Data (ziua, luna, anul): {factura.DataEmiterii:dd/MM/yyyy}", TextAlignment.RIGHT, 10));
                    document.Add(detailsTable);

                    // Add header information
                    Table headerTable = new Table(new float[] { 1, 1 });
                    headerTable.SetWidth(UnitValue.CreatePercentValue(100));

                    // Left column (Furnizor)
                    headerTable.AddCell(CreateCell("Furnizor:", TextAlignment.LEFT, 10, true));
                    headerTable.AddCell(CreateCell("Cumparator:", TextAlignment.LEFT, 10, true));

                    headerTable.AddCell(CreateCell($"Nume: {firma.Nume}", TextAlignment.LEFT, 10));
                    headerTable.AddCell(CreateCell($"Nume: {factura.Client.Nume}", TextAlignment.LEFT, 10));

                    headerTable.AddCell(CreateCell($"C.I.F.: {firma.CUI}", TextAlignment.LEFT, 10));
                    headerTable.AddCell(CreateCell($"C.I.F.: {factura.Client.CUI}", TextAlignment.LEFT, 10));

                    headerTable.AddCell(CreateCell($"Nr. Ord. reg. com./an: {firma.NrRegistruComert}", TextAlignment.LEFT, 10));
                    headerTable.AddCell(CreateCell($"Nr. Ord. reg. com./an: {factura.Client.NrRegistruComert}", TextAlignment.LEFT, 10));

                    headerTable.AddCell(CreateCell($"Sediul: {firma.Adresa}", TextAlignment.LEFT, 10));
                    headerTable.AddCell(CreateCell($"Sediul: {factura.Client.Adresa}", TextAlignment.LEFT, 10));

                    
                    if (factura.Cont != null)
                    {
                        headerTable.AddCell(CreateCell($"IBAN: {factura.Cont.IBAN}", TextAlignment.LEFT, 10));
                        headerTable.AddCell(CreateCell("", TextAlignment.LEFT, 10)); // Empty cell for Cumparator side
                        headerTable.AddCell(CreateCell($"Moneda: {factura.Cont.Moneda}", TextAlignment.LEFT, 10));
                        headerTable.AddCell(CreateCell("", TextAlignment.LEFT, 10)); // Empty cell for Cumparator side
                        headerTable.AddCell(CreateCell($"Banca: {factura.Cont.Banca}", TextAlignment.LEFT, 10));
                        headerTable.AddCell(CreateCell("", TextAlignment.LEFT, 10)); // Empty cell for Cumparator side
                    }

                    document.Add(headerTable);

                    // Add items table
                    Table itemsTable = new Table(new float[] { 1, 3, 1, 1, 1, 1, 1 });
                    itemsTable.SetWidth(UnitValue.CreatePercentValue(100));
                    itemsTable.AddHeaderCell(CreateCell("Nr. crt", TextAlignment.CENTER, 10, true));
                    itemsTable.AddHeaderCell(CreateCell("Denumirea produselor sau a serviciilor", TextAlignment.CENTER, 10, true));
                    itemsTable.AddHeaderCell(CreateCell("U.M.", TextAlignment.CENTER, 10, true));
                    itemsTable.AddHeaderCell(CreateCell("Cantitatea", TextAlignment.CENTER, 10, true));
                    itemsTable.AddHeaderCell(CreateCell("Pretul unitar (fara T.V.A.)", TextAlignment.CENTER, 10, true));
                    itemsTable.AddHeaderCell(CreateCell("Valoarea (fara T.V.A.)", TextAlignment.CENTER, 10, true));
                    itemsTable.AddHeaderCell(CreateCell("Valoarea T.V.A.", TextAlignment.CENTER, 10, true));

                    // Add item rows
                    int index = 1;
                    decimal totalValoare = 0;
                    decimal totalValoareFaraTva = 0;
                    foreach (var serviciuFactura in factura.Servicii)
                    {
                        var serviciu = serviciuFactura.Serviciu;
                        decimal valoareServiciu = serviciu.Pret * serviciu.Cantitate;
                        decimal valoareTVA = valoareServiciu * ((decimal)serviciu.Tva / 100.0m);
                        totalValoare += valoareServiciu + valoareTVA;
                        totalValoareFaraTva += valoareServiciu;
                        itemsTable.AddCell(CreateCell(index.ToString(), TextAlignment.CENTER, 10));
                        itemsTable.AddCell(CreateCell(serviciu.Descriere, TextAlignment.LEFT, 10));
                        itemsTable.AddCell(CreateCell(serviciu.Um.ToString(), TextAlignment.CENTER, 10));
                        itemsTable.AddCell(CreateCell(serviciu.Cantitate.ToString(), TextAlignment.CENTER, 10));
                        itemsTable.AddCell(CreateCell(serviciu.Pret.ToString(), TextAlignment.CENTER, 10));
                        itemsTable.AddCell(CreateCell(valoareServiciu.ToString(), TextAlignment.CENTER, 10));
                        itemsTable.AddCell(CreateCell(valoareTVA.ToString(), TextAlignment.CENTER, 10));
                        index++;
                    }

                    document.Add(itemsTable);

                    // Add footer
                    document.Add(new Paragraph("Semnatura si stampila furnizorului").SetTextAlignment(TextAlignment.LEFT).SetFontSize(10).SetBold());
                    document.Add(new Paragraph("Date privind expeditia:").SetTextAlignment(TextAlignment.LEFT).SetFontSize(10).SetBold());
                    document.Add(new Paragraph("Semnatura de primire").SetTextAlignment(TextAlignment.LEFT).SetFontSize(10).SetBold());
                    document.Add(new Paragraph($"Total de plata: {totalValoare:F2}").SetTextAlignment(TextAlignment.LEFT).SetFontSize(10).SetBold());
                    document.Add(new Paragraph($"Total de plata fara TVA: {totalValoareFaraTva:F2}").SetTextAlignment(TextAlignment.LEFT).SetFontSize(10).SetBold());
                }
            }
        }

        private Cell CreateCell(string content, TextAlignment alignment, float fontSize, bool bold = false, int rowspan = 1)
        {
            var cell = new Cell(1, rowspan).Add(new Paragraph(content).SetTextAlignment(alignment).SetFontSize(fontSize));
            if (bold)
            {
                cell.SetBold();
            }
            return cell.SetBorder(Border.NO_BORDER);
        }
    }
}
