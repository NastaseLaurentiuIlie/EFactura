using EFactura.Database;
using EFactura.Facturi;
using EFactura.Files;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFactura.Forms
{
    public partial class AfisaeFacturiFirma : Form
    {
        private readonly IServiceProvider serviceProvider;
        private readonly string CUIFirma;
        private List<Factura> facturi;
        public AfisaeFacturiFirma(IServiceProvider serviceProvider, string CUIFirma)
        {
            this.serviceProvider = serviceProvider;
            this.CUIFirma = CUIFirma;

            LoadFacturiFirma();
            InitializeComponent();
        }
        public async Task LoadFacturiFirma()
        {
            try
            {
                var databaseManager = serviceProvider.GetService<IDatabaseManager>();
                if (databaseManager == null)
                {
                    MessageBox.Show("Database manager service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                facturi = await databaseManager.GetFacturiByFirmaAsync(CUIFirma);

                var dataSource = facturi.Select(f => new
                {
                    f.ID,
                    f.FirmaID,
                    f.Serie,
                    f.Numar,
                    f.ValoareTotala,
                    f.DataEmiterii,
                    Client = $"{f.Client.CUI}, Nume: {f.Client.Nume}, NrRegistruComert: {f.Client.NrRegistruComert}, Adresa: {f.Client.Adresa}",
                    f.MetodaPlata,
                    Cont = $"{f.Cont.IBAN}, {f.Cont.Moneda}, {f.Cont.Banca}",
                    Servicii = string.Join(", ", f.Servicii.Select(s => $"{s.Serviciu.Descriere} (Cant: {s.Serviciu.Cantitate}, Pret: {s.Serviciu.Pret}, TVA: {s.Serviciu.Tva})"))
                }).ToList();

                dataGridView1.DataSource = dataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving facturi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void PDFBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedFacturaId = (int)selectedRow.Cells["ID"].Value;
                var selectedFactura = facturi.FirstOrDefault(f => f.ID == selectedFacturaId);

                if (selectedFactura != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Factura as PDF";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var factory = serviceProvider.GetService<FileGeneratorFactory>();
                        var fileGenerator = factory.GetFileGenerator(FileGeneratorFactory.GeneratorType.PDFGenerator);
                        fileGenerator.GenerateFile(selectedFactura, saveFileDialog.FileName);
                        MessageBox.Show("PDF generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenXMLBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedFacturaId = (int)selectedRow.Cells["ID"].Value;
                var selectedFactura = facturi.FirstOrDefault(f => f.ID == selectedFacturaId);

                if (selectedFactura != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML file (*.xml)|*.xml";
                    saveFileDialog.Title = "Save Factura as XML";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileGenerator = serviceProvider.GetService<IFileGenerator>();
                        fileGenerator.GenerateFile(selectedFactura, saveFileDialog.FileName);
                        MessageBox.Show("Fisierul XML a fost creat!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Va rugam selectati o factura valida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Va rugam selectati o factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AfisaeFacturiFirma_Load(object sender, EventArgs e)
        {

        }
    }
}
