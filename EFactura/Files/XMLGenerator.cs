using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using EFactura.Database;
using EFactura.Facturi;

namespace EFactura.Files
{
    public class XmlGenerator : IFileGenerator
    {
        private readonly IDatabaseManager _databaseManager;

        public XmlGenerator(IDatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public async Task GenerateFile(Factura factura, string filePath)
        {
            var firma = await _databaseManager.GetFirmaByCuiAsync(factura.FirmaID);

            XNamespace ns = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
            XNamespace cac = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
            XNamespace cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
            XNamespace cec = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";

            var invoice = new XElement(ns + "Invoice",
                new XAttribute(XNamespace.Xmlns + "cac", cac),
                new XAttribute(XNamespace.Xmlns + "cbc", cbc),
                new XAttribute(XNamespace.Xmlns + "cec", cec),
                new XElement(cbc + "CustomizationID", "urn:cen.eu:en16931:2017#compliant#urn:efactura.mfinante.ro:CIUS-RO:1.0.1"),
                new XElement(cbc + "ID", factura.Numar),
                new XElement(cbc + "IssueDate", factura.DataEmiterii.ToString("yyyy-MM-dd")),
                new XElement(cbc + "DueDate", factura.DataEmiterii.AddDays(60).ToString("yyyy-MM-dd")),
                new XElement(cbc + "InvoiceTypeCode", "380"),
                new XElement(cbc + "DocumentCurrencyCode", "RON"),
                new XElement(cbc + "TaxCurrencyCode", "RON"),
                new XElement(cac + "OrderReference",
                    new XElement(cbc + "ID", factura.Serie)
                ),
                new XElement(cac + "AccountingSupplierParty",
                    new XElement(cac + "Party",
                        new XElement(cac + "PartyName",
                            new XElement(cbc + "Name", firma.Nume)
                        ),
                        new XElement(cac + "PostalAddress",
                            new XElement(cbc + "StreetName", firma.Adresa),
                            new XElement(cbc + "CityName", firma.Localitate),
                            new XElement(cbc + "PostalZone", "300129"),
                            new XElement(cbc + "CountrySubentity", firma.Judet),
                            new XElement(cac + "Country",
                                new XElement(cbc + "IdentificationCode", firma.Tara)
                            )
                        ),
                        new XElement(cac + "PartyTaxScheme",
                            new XElement(cbc + "CompanyID", firma.CUI),
                            new XElement(cac + "TaxScheme",
                                new XElement(cbc + "ID", "VAT")
                            )
                        ),
                        new XElement(cac + "PartyLegalEntity",
                            new XElement(cbc + "RegistrationName", firma.Nume)
                        ),
                        new XElement(cac + "PartyContact",
                            new XElement(cbc + "ID", factura.Cont.IBAN),
                            new XElement(cbc + "Name", factura.Cont.Banca),
                            new XElement(cbc + "Note", $"Moneda: {factura.Cont.Moneda}")
                        )
                    )
                ),
                new XElement(cac + "AccountingCustomerParty",
                    new XElement(cac + "Party",
                        new XElement(cac + "PostalAddress",
                            new XElement(cbc + "StreetName", factura.Client.Adresa),
                            new XElement(cbc + "CityName", "City"),
                            new XElement(cbc + "PostalZone", "077190"),
                            new XElement(cbc + "CountrySubentity", "RO-IF"),
                            new XElement(cac + "Country",
                                new XElement(cbc + "IdentificationCode", "RO")
                            )
                        ),
                        new XElement(cac + "PartyTaxScheme",
                            new XElement(cbc + "CompanyID", factura.Client.CUI),
                            new XElement(cac + "TaxScheme",
                                new XElement(cbc + "ID", "VAT")
                            )
                        ),
                        new XElement(cac + "PartyLegalEntity",
                            new XElement(cbc + "RegistrationName", factura.Client.Nume)
                        )
                    )
                ),
                new XElement(cac + "Delivery",
                    new XElement(cbc + "ActualDeliveryDate", factura.DataEmiterii.ToString("yyyy-MM-dd"))
                ),
                new XElement(cac + "PaymentMeans",
                    new XElement(cbc + "PaymentMeansCode", "42"),
                    new XElement(cbc + "PaymentID", factura.Numar)
                ),
                new XElement(cac + "TaxTotal",
                    new XElement(cbc + "TaxAmount", new XAttribute("currencyID", "RON"), (factura.Servicii.Sum(s => s.Serviciu.Pret * s.Serviciu.Cantitate * ((decimal)s.Serviciu.Tva / 100.0m))).ToString("F2")),
                    new XElement(cac + "TaxSubtotal",
                        new XElement(cbc + "TaxableAmount", new XAttribute("currencyID", "RON"), factura.Servicii.Sum(s => s.Serviciu.Pret * s.Serviciu.Cantitate).ToString("F2")),
                        new XElement(cbc + "TaxAmount", new XAttribute("currencyID", "RON"), (factura.Servicii.Sum(s => s.Serviciu.Pret * s.Serviciu.Cantitate * ((decimal)s.Serviciu.Tva / 100.0m))).ToString("F2")),
                        new XElement(cac + "TaxCategory",
                            new XElement(cbc + "ID", "S"),
                            new XElement(cbc + "Percent", "19"),
                            new XElement(cac + "TaxScheme",
                                new XElement(cbc + "ID", "VAT")
                            )
                        )
                    )
                ),
                new XElement(cac + "LegalMonetaryTotal",
                    new XElement(cbc + "LineExtensionAmount", new XAttribute("currencyID", "RON"), factura.Servicii.Sum(s => s.Serviciu.Pret * s.Serviciu.Cantitate).ToString("F2")),
                    new XElement(cbc + "TaxExclusiveAmount", new XAttribute("currencyID", "RON"), factura.Servicii.Sum(s => s.Serviciu.Pret * s.Serviciu.Cantitate).ToString("F2")),
                    new XElement(cbc + "TaxInclusiveAmount", new XAttribute("currencyID", "RON"), (factura.Servicii.Sum(s => s.Serviciu.Pret * s.Serviciu.Cantitate) + factura.Servicii.Sum(s => s.Serviciu.Pret * s.Serviciu.Cantitate * ((decimal)s.Serviciu.Tva / 100.0m))).ToString("F2")),
                    new XElement(cbc + "PayableAmount", new XAttribute("currencyID", "RON"), (factura.Servicii.Sum(s => s.Serviciu.Pret * s.Serviciu.Cantitate) + factura.Servicii.Sum(s => s.Serviciu.Pret * s.Serviciu.Cantitate * ((decimal)s.Serviciu.Tva / 100.0m))).ToString("F2"))
                )
            );

            int lineIndex = 1;
            foreach (var serviciuFactura in factura.Servicii)
            {
                var serviciu = serviciuFactura.Serviciu;
                invoice.Add(
                    new XElement(cac + "InvoiceLine",
                        new XElement(cbc + "ID", lineIndex.ToString()),
                        new XElement(cbc + "InvoicedQuantity", new XAttribute("unitCode", serviciu.Um.ToString()), serviciu.Cantitate.ToString("F2")),
                        new XElement(cbc + "LineExtensionAmount", new XAttribute("currencyID", "RON"), (serviciu.Pret * serviciu.Cantitate).ToString("F2")),
                        new XElement(cac + "Item",
                            new XElement(cbc + "Description", serviciu.Descriere)
                        ),
                        new XElement(cac + "Price",
                            new XElement(cbc + "PriceAmount", new XAttribute("currencyID", "RON"), serviciu.Pret.ToString("F2")),
                            new XElement(cbc + "BaseQuantity", serviciu.Cantitate.ToString("F2"))
                        )
                    )
                );
                lineIndex++;
            }

            using (var writer = new XmlTextWriter(filePath, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                invoice.WriteTo(writer);
            }
        }
    }
}
