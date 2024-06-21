using EFactura.Cont;
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
    public partial class Dashboard : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly int userID;
        public Dashboard(IServiceProvider serviceProvider, int userID)
        {
            _serviceProvider = serviceProvider;
            this.userID = userID;
            InitializeComponent();
            LoadFirmeDataAsync();
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }
        private async void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Fetch the updated row data
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var updatedFirma = new Firma
                {
                    CUI = row.Cells["CUI"].Value.ToString(),
                    Nume = row.Cells["Nume"].Value.ToString(),
                    IDUser = Convert.ToInt32(row.Cells["IDUser"].Value),
                    NrRegistruComert = row.Cells["NrRegistruComert"].Value.ToString(),
                    Adresa = row.Cells["Adresa"].Value.ToString()
                };

                try
                {
                    var databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                    if (databaseManager == null)
                    {
                        MessageBox.Show("Database manager service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    await databaseManager.UpdateFirmaAsync(updatedFirma);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating firma: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void LoadFirmeDataAsync()
        {
            try
            {
                var databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                if (databaseManager == null)
                {
                    MessageBox.Show("Database manager service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var firme = await databaseManager.GetFirmeByUserAsync(userID);
                dataGridView1.DataSource = firme;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving firme: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADDFirmaBtn_Click(object sender, EventArgs e)
        {
            AdaugareFirma adaugareFirmaForm = new AdaugareFirma(_serviceProvider, userID);
            adaugareFirmaForm.Show();
            adaugareFirmaForm.Focus();
        }

        private async void DeleteFirmaButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var cui = selectedRow.Cells["CUI"].Value.ToString();

                try
                {
                    var databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                    if (databaseManager == null)
                    {
                        MessageBox.Show("Database manager service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    await databaseManager.DeleteFirmaAsync(cui);
                    MessageBox.Show("Firma deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the data grid view
                    LoadFirmeDataAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting firma: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddFacturaButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedFirma = selectedRow.DataBoundItem as Firma;

                if (selectedFirma != null)
                {
                    var adaugareFacturaForm = new AdaugareFactura(_serviceProvider, selectedFirma.CUI);
                    adaugareFacturaForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a valid Firma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a Firma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowFacBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedFirma = selectedRow.DataBoundItem as Firma;

                if (selectedFirma != null)
                {
                    var afisaeFacturiFirmaForm = new AfisaeFacturiFirma(_serviceProvider, selectedFirma.CUI);
                    afisaeFacturiFirmaForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a valid firma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a firma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddContBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedFirma = selectedRow.DataBoundItem as Firma;

            
                AdaugareContBancar form = new AdaugareContBancar(_serviceProvider, selectedFirma.CUI);
                form.Show();
                form.Focus();
               

            }
            
        }
    }
}
