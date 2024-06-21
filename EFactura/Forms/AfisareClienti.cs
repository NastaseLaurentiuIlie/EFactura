using EFactura.Database;
using EFactura.Firme;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFactura.Forms
{
    public partial class AfisareClienti : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AdaugareFactura _facturaForm;
        public AfisareClienti(IServiceProvider serviceProvider, AdaugareFactura facturaForm)
        {
            _serviceProvider = serviceProvider;
            _facturaForm = facturaForm;
            LoadClient();
            InitializeComponent();
        }

        public async Task LoadClient()
        {
            try
            {
                var databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                if (databaseManager == null)
                {
                    MessageBox.Show("Database manager service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var clients = await databaseManager.GetAllClientsAsync();
                dataGridView1.DataSource = clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving clients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedClient = selectedRow.DataBoundItem as Client;

                if (selectedClient != null)
                {
                    _facturaForm.ReceiveClient(selectedClient);
                    MessageBox.Show($"Selected Client:\nCUI: {selectedClient.CUI}\nNume: {selectedClient.Nume}\nNr Registru Comert: {selectedClient.NrRegistruComert}\nAdresa: {selectedClient.Adresa}", "Client Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a valid client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
