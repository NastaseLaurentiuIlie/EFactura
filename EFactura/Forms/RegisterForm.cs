using EFactura.Database;
using EFactura.Users;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EFactura.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public RegisterForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private async void ButtonInreg_Click(object sender, EventArgs e)
        {
            string username = InregistrareNume.Text.Trim();
            string password = InregistrareParola.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {

                Username = username,
                Password = password
            };
            try
            {
                IDatabaseManager _databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                await _databaseManager.CreateUserAsync(newUser);
                MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
