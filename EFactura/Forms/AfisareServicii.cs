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
    public partial class AfisareServicii : Form
    {
        private readonly IServiceProvider serviceProvider;
        private readonly AdaugareFactura facturaForm;
        public AfisareServicii(IServiceProvider serviceProvider, AdaugareFactura facturaForm)
        {
            this.facturaForm = facturaForm;
            this.serviceProvider = serviceProvider;
            LoadServicii();
            InitializeComponent();
        }
        private async void LoadServicii()
        {
            var databaseManager = serviceProvider.GetService<IDatabaseManager>();
            if (databaseManager != null)
            {
                var servicii = await databaseManager.GeterviciiAsync();
                dataGridView1.DataSource = servicii;
            }
            else
            {
                MessageBox.Show("Database manager service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddServiciuBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRowIndex = dataGridView1.SelectedRows[0];
                var selectedServiciu = selectedRowIndex.DataBoundItem as Serviciu;
                facturaForm.ReceiveServiciu(selectedServiciu);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a serviciu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
