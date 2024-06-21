using EFactura.Database;
using EFactura.Firme;
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
    public partial class AdaugareClient : Form
    {
        private readonly AdaugareFactura formFirma;
        private readonly IServiceProvider _serviceProvider;
        public AdaugareClient(IServiceProvider serviceProvider, AdaugareFactura formFirma)
        {
            this._serviceProvider = serviceProvider;
            this.formFirma = formFirma;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string CUI = CUITextBox.Text.Trim();
            string Nume = NumeFirmaTextBox.Text.Trim();
            string NRC = NRRegComertTextBox.Text.Trim();
            string Adresa = AdresaTextBox.Text.Trim();
            string Tara = TaraTextBox.Text.Trim();
            string Judet = JudetTextBox.Text.Trim();
            string Localitate = LocalitateTextBox.Text.Trim();
            if (string.IsNullOrEmpty(CUI))
            {
                MessageBox.Show("CUI cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Nume))
            {
                MessageBox.Show("Nume cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(NRC))
            {
                MessageBox.Show("Nr Registru Comert cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Adresa))
            {
                MessageBox.Show("Adresa cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client client = new Client
            {
                CUI = CUI,
                Nume = Nume,
                NrRegistruComert = NRC,
                Adresa = Adresa,
                Tara = Tara,
                Judet = Judet,
                Localitate = Localitate
            };
            try
            {
                var databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                await databaseManager.CreateClientAsync(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding firma: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            formFirma.ReceiveClient(client);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
