using EFactura.Database;
using EFactura.Facturi;
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
    public partial class AdaugareServiciu : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AdaugareFactura _adaugareFacturaForm;
        public AdaugareServiciu(IServiceProvider serviceProvider, AdaugareFactura adaugareFactura)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _adaugareFacturaForm = adaugareFactura;
        }

        private async void AddServiciu_Click(object sender, EventArgs e)
        {
            string Descriere = DescriereTextBox.Text.Trim();
            decimal pret = Convert.ToDecimal(PretTextBox.Text.Trim());
            int cantitate = Convert.ToInt32(CantitateTextBox.Text.Trim());
            float valoare = (float)pret * cantitate;
            // Get UM value from the combobox
            string umText = UMComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(umText))
            {
                MessageBox.Show("Please select a UM value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse UM enum
            if (!Enum.TryParse<Serviciu.UM>(umText, out var um))
            {
                MessageBox.Show("Invalid UM value selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get TVA value from the combobox
            string tvaText = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tvaText))
            {
                MessageBox.Show("Please select a TVA value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse TVA enum
            if (!Enum.TryParse<Serviciu.TVA>(tvaText, out var tva))
            {
                MessageBox.Show("Invalid TVA value selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Serviciu object
            var serviciu = new Serviciu
            {
                Descriere = Descriere,
                Pret = pret,
                Um = um,
                Tva = tva,
                Valoare = valoare,
                Cantitate = cantitate
            };

            // Add the new Serviciu to the database (assuming a method to add it)
            try
            {
                var _databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                _adaugareFacturaForm.ReceiveServiciuAndAddToDb(serviciu);
                MessageBox.Show("Serviciul a fost adaugat la factura!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding serviciu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
