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
    public partial class AdaugareFirma : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly int userID;

        public AdaugareFirma(IServiceProvider serviceProvider, int userID)
        {
            InitializeComponent();
            this.userID = userID;
            this._serviceProvider = serviceProvider;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private async void AdaugareFirmBtn_Click(object sender, EventArgs e)
        {
            string CUI = CUITextBox.Text.Trim();
            string Nume = NumeFirmaTextBox.Text.Trim();
            string NRC = NRRegComertTextBox.Text.Trim();
            string Adresa = AdresaTextBox.Text.Trim();
            string Tara = TaraTextBox.Text.Trim();
            string Judet = JudetTextBox.Text.Trim();
            string Localitate = LocalitateTextBox.Text.Trim();
            if (string.IsNullOrEmpty(CUI))

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

            // Further processing if all inputs are valid
            Firma newFirma = new Firma
            {
                CUI = CUI,
                Nume = Nume,
                NrRegistruComert = NRC,
                Adresa = Adresa,
                IDUser = userID,
                Tara = Tara,
                Judet = Judet,
                Localitate = Localitate,
                

            };

            try
            {
                var databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                if (databaseManager == null)
                {
                    MessageBox.Show("Database manager service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await databaseManager.CreateFirmaAsync(newFirma);
                MessageBox.Show("Firma added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding firma: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
