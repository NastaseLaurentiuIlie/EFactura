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
    public partial class AfisareConturi : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly string CUIFirma;
        private readonly AdaugareFactura factoraForm;
        public AfisareConturi(IServiceProvider serviceProvider, string CUIFirma, AdaugareFactura factoraForm)
        {
            _serviceProvider = serviceProvider;
            this.CUIFirma = CUIFirma;

            this.factoraForm = factoraForm;
            LoadConturi();
            InitializeComponent();
        }
        public async Task LoadConturi()
        {
            try
            {
                var _databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                var conturi = await _databaseManager.GetConturiByFirmaCUIAsync(CUIFirma);
                dataGridView1.DataSource = conturi;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading conturi: {ex.Message}");
            }
        }

        private void AddCont_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedClient = selectedRow.DataBoundItem as ContBancar;
                factoraForm.ReceiveCont(selectedClient);
                this.Close();
            }
        }
    }
}
