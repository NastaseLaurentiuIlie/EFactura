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

namespace EFactura.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public LoginForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        public async void LoginButt_Click(object sender, EventArgs e)
        {

        }

        private async void LoginButt_Click_1(object sender, EventArgs e)
        {
            string username = LoginNume.Text.Trim();
            string password = LoginParola.Text.Trim();
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
            User user = new User
            {
                Username = username,
                Password = password
            };
            try
            {
                IDatabaseManager _databaseManager = _serviceProvider.GetService<IDatabaseManager>();
                if (await _databaseManager.LoginUserAsync(user))
                {
                    MessageBox.Show("Login Succesfull");
                    int userID = await _databaseManager.GetUserIDAsync(username);
                    Dashboard dashboard = new Dashboard(_serviceProvider, userID);
                    dashboard.Show();
                    dashboard.Focus();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loging user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
