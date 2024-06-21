using EFactura.Cont;
using EFactura.Database;
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
    public partial class AdaugareContBancar : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly string CUIFirma;
        public AdaugareContBancar(IServiceProvider serviceProvider, string CUIFirma)
        {
            _serviceProvider = serviceProvider;
            this.CUIFirma = CUIFirma;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void AddContBtn_Click(object sender, EventArgs e)
        {
            var contBancar = new ContBancar
            {
                IBAN = IBANTextBox.Text.Trim(),
                Moneda = MonedaTextBox.Text.Trim(),
                CUIFirma = CUIFirma,
                Banca = BancaTextBox.Text.Trim()
            };

            try
            {
                var databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                await databaseManager.CreateContBancarAsync(contBancar);
                MessageBox.Show("Cont bancar added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding cont bancar: {ex.Message}");
            }
        }

        private void AdaugareContBancar_Load(object sender, EventArgs e)
        {

        }
    }
}
