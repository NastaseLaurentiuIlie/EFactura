using EFactura.Cont;
using EFactura.Database;
using EFactura.Facturi;
using EFactura.Firme;
using EFactura.Servicii;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFactura.Forms
{
    public partial class AdaugareFactura : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly string CUIFirma;
        private Client client;
        private ContBancar cont;
        private List<ServiciuFactura> Servicii { get; set; } = new List<ServiciuFactura>();
        public AdaugareFactura(IServiceProvider serviceProvider, string CUIFirma)
        {
            this._serviceProvider = serviceProvider;
            this.CUIFirma = CUIFirma;
            InitializeComponent();
        }
        public void ReceiveClient(Client client)
        {
            this.client = client;
            Console.WriteLine(client);
        }
        private void AdaugareFactura_Load(object sender, EventArgs e)
        {

        }
        public async void ReceiveServiciu(Serviciu serviciu)
        {
            


            var serviciuFactura = new ServiciuFactura
            {
                ServiciuID = serviciu.Id,
                Serviciu = serviciu
            };

            Servicii.Add(serviciuFactura);
        }
        public async void ReceiveServiciuAndAddToDb(Serviciu serviciu)
        {
            var databaseManager = _serviceProvider.GetService<IDatabaseManager>();
            if (databaseManager == null)
            {
                MessageBox.Show("Database manager service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            serviciu.Id = await databaseManager.AddServiciuAsync(serviciu);

            var serviciuFactura = new ServiciuFactura
            {
                ServiciuID = serviciu.Id,
                Serviciu = serviciu
            };

            Servicii.Add(serviciuFactura);
        }
        private void ADDClientBtn_Click(object sender, EventArgs e)
        {
            AdaugareClient addClientForm = new AdaugareClient(_serviceProvider, this);
            addClientForm.ShowDialog();
            addClientForm.Focus();
            addClientForm.Close();
        }

        private async void ADDFacturaBtn_Click(object sender, EventArgs e)
        {
            if (client is null)
            {
                MessageBox.Show($"Adaugati mai intai un client!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Retrieve values from the textboxes and other controls
            string serie = SerieTextBox.Text.Trim();
            string numarText = NrTextBox.Text.Trim();
            DateTime dataEmiterii = dateTimePicker1.Value;
            string metodaPlata = MetodaPlataTextBox.Text.Trim();

            // Validate the numerical inputs
            if (!int.TryParse(numarText, out int numar))

            {
                MessageBox.Show("Va rugam introduceti un numar de factura valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Factura object
            var newFactura = new Factura
            {
                FirmaID = this.CUIFirma,
                Serie = serie,
                Numar = numar,
                Servicii = Servicii,
                Client = client,
                DataEmiterii = dataEmiterii,
                MetodaPlata = metodaPlata,
                Cont = cont
            };

            // Save the new Factura to the database
            try
            {
                var databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                if (databaseManager == null)
                {
                    MessageBox.Show("Database manager service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await databaseManager.CreateFacturaAsync(newFactura);
                MessageBox.Show("Factura created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, close the form or reset the inputs
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReceiveCont(ContBancar cont)
        {
            this.cont = cont;
        }
        private void UMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectClientBTN_Click(object sender, EventArgs e)
        {
            AfisareClienti afisareClienti = new AfisareClienti(_serviceProvider, this);
            afisareClienti.Show();
            afisareClienti.Focus();

        }

        private void AddContBtn_Click(object sender, EventArgs e)
        {

        }

        private void SelectCont_Click(object sender, EventArgs e)
        {
            AfisareConturi afisareConturi = new AfisareConturi(_serviceProvider, CUIFirma, this);
            afisareConturi.Show();
            afisareConturi.Focus();
        }

        private void AddServiciu_Click(object sender, EventArgs e)
        {
            AdaugareServiciu adaugareServiciuForm = new AdaugareServiciu(_serviceProvider, this);
            adaugareServiciuForm.Show();
            adaugareServiciuForm.Focus();
        }

        private void AfisServiciiBtn_Click(object sender, EventArgs e)
        {
            AfisareServicii afisareServicii = new AfisareServicii(_serviceProvider, this);
            afisareServicii.Show();
            afisareServicii.Focus();
        }
    }
}
