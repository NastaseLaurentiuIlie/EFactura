using EFactura.AWS;
using EFactura.ConfigSettings;
using EFactura.Database;
using EFactura.Forms;
using EFactura.Json;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;

namespace EFactura
{
    public partial class Form1 : Form
    {
        private IServiceProvider _serviceProvider;
        private Config? _config;
        private SecretsManager _secretsManager;
        public void LoadConfig()
        {
           

        }
        public Form1()
        {

            ServiceManager serviceManager = new ServiceManager();
            _serviceProvider = serviceManager.ConfigureServices();
            LoadConfig();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            RegisterForm formInregistrare = new RegisterForm(_serviceProvider);
            formInregistrare.Show();
            formInregistrare.Focus();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            LoginForm formLogare = new LoginForm(_serviceProvider);
            formLogare.Show();
            formLogare.Focus();
            this.Hide();
        }
    }
}
