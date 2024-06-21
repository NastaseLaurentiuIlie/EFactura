using EFactura.Cont;
using EFactura.Facturi;
using EFactura.Firme;
using EFactura.Servicii;
using EFactura.Users;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EFactura.Database
{
    public interface IDatabaseManager
    {
        Task<List<Serviciu>> GeterviciiAsync();
        Task<int> AddServiciuAsync(Serviciu serviciu);
        Task<List<ContBancar>> GetConturiByFirmaCUIAsync(string cuiFirma);
        Task CreateContBancarAsync(ContBancar contBancar);
        Task<Firma> GetFirmaByCuiAsync(string cui);
        Task<List<Factura>> GetFacturiByFirmaAsync(string cui);
        Task<List<Client>> GetAllClientsAsync();        
        Task CreateClientAsync(Client client);
        Task CreateFacturaAsync(Factura factura);
        Task DeleteFirmaAsync(string cui);
        Task UpdateFirmaAsync(Firma firma);
        Task<List<Firma>> GetFirmeByUserAsync(int userId);
        Task<bool> FirmaExistsAsync(string cui, string nrRegistruComert, string nume);
        Task<int> GetUserIDAsync(string username);
        Task<bool> LoginUserAsync(User user);

        Task<bool> UserExistsAsync(string username);
        Task CreateUserAsync(User user);
        Task CreateFirmaAsync(Firma firma);
    }

    public class DatabaseManager : IDatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<List<Serviciu>> GeterviciiAsync()
        {
            var servicii = new List<Serviciu>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM servicii";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var serviciu = new Serviciu
                            {
                                Id = reader.GetInt32("Id"),
                                Descriere = reader.GetString("Descriere"),
                                Pret = reader.GetDecimal("Pret"),
                                Um = (Serviciu.UM)reader.GetInt32("UM"),
                                Tva = (Serviciu.TVA)reader.GetInt32("TVA"),
                                Cantitate = reader.GetInt32("Cantitate"),
                                Valoare = reader.GetFloat("Valoare")
                            };
                            servicii.Add(serviciu);
                        }
                    }
                }
            }

            return servicii;
        }

        public async Task<int> AddServiciuAsync(Serviciu serviciu)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = @"
            INSERT INTO servicii (Descriere, Pret, Um, Tva, Cantitate, Valoare)
            VALUES (@Descriere, @Pret, @Um, @Tva, @Cantitate, @Valoare);
            SELECT LAST_INSERT_ID();";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Descriere", serviciu.Descriere);
                    command.Parameters.AddWithValue("@Pret", serviciu.Pret);
                    command.Parameters.AddWithValue("@Um", (int)serviciu.Um);
                    command.Parameters.AddWithValue("@Tva", (int)serviciu.Tva);
                    command.Parameters.AddWithValue("@Cantitate", serviciu.Cantitate);
                    command.Parameters.AddWithValue("@Valoare", serviciu.Valoare);

                    // Execute the query and get the last inserted ID
                    serviciu.Id = Convert.ToInt32(await command.ExecuteScalarAsync());
                    return serviciu.Id;
                }
            }
        }
        public async Task<List<ContBancar>> GetConturiByFirmaCUIAsync(string cuiFirma)
        {
            var conturi = new List<ContBancar>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT IBAN, Moneda, CUIFirma, Banca FROM ContBancar WHERE CUIFirma = @CUIFirma";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CUIFirma", cuiFirma);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var cont = new ContBancar
                            {
                                IBAN = reader.GetString("IBAN"),
                                Moneda = reader.GetString("Moneda"),
                                CUIFirma = reader.GetString("CUIFirma"),
                                Banca = reader.GetString("Banca")
                            };
                            conturi.Add(cont);
                        }
                    }
                }
            }

            return conturi;
        }
        public async Task CreateContBancarAsync(ContBancar cont)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "INSERT INTO ContBancar (IBAN, Moneda, CUIFirma, Banca) VALUES (@IBAN, @Moneda, @CUIFirma, @Banca)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IBAN", cont.IBAN);
                    command.Parameters.AddWithValue("@Moneda", cont.Moneda);
                    command.Parameters.AddWithValue("@CUIFirma", cont.CUIFirma);
                    command.Parameters.AddWithValue("@Banca", cont.Banca);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task<Firma> GetFirmaByCuiAsync(string cui)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM Firma WHERE CUI = @CUI";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CUI", cui);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new Firma
                            {
                                CUI = reader.GetString("CUI"),
                                Nume = reader.GetString("Nume"),
                                IDUser = reader.GetInt32("IDUser"),
                                NrRegistruComert = reader.GetString("NrRegistruComert"),
                                Adresa = reader.GetString("Adresa"),
                                Tara=reader.GetString("Tara"),
                                Judet=reader.GetString("Judet"),
                                Localitate=reader.GetString("Localitate")
                            };
                        }
                    }
                }
            }
            return null;
        }
        public async Task<List<Factura>> GetFacturiByFirmaAsync(string cui)
        {
            var facturi = new List<Factura>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = @"
        SELECT 
            f.ID,
            f.FirmaID,
            f.Serie,
            f.Numar,
            f.DataEmiterii,
            f.ClientID,
            f.MetodaPlata,
            c.CUI,
            c.Nume,
            c.NrRegistruComert,
            c.Adresa,
            cb.IBAN,
            cb.Moneda,
            cb.CUIFirma,
            cb.Banca,
            s.Id AS ServiciuID,
            s.Descriere,
            s.Pret,
            s.Um,
            s.Tva AS ServiciuTva,
            s.Cantitate,
            s.Valoare
        FROM 
            Factura f
        INNER JOIN 
            Client c ON f.ClientID = c.CUI
        LEFT JOIN 
            FacturaServiciu fs ON f.ID = fs.FacturaID
        LEFT JOIN 
            Servicii s ON fs.ServiciuID = s.Id
        LEFT JOIN 
            contbancar cb ON f.FirmaID = cb.CUIFirma
        WHERE 
            f.FirmaID = @CUI";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CUI", cui);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var factura = facturi.FirstOrDefault(f => f.ID == reader.GetInt32("ID"));
                            if (factura == null)
                            {
                                factura = new Factura
                                {
                                    ID = reader.GetInt32("ID"),
                                    FirmaID = reader.GetString("FirmaID"),
                                    Serie = reader.GetString("Serie"),
                                    Numar = reader.GetInt32("Numar"),
                                    DataEmiterii = reader.GetDateTime("DataEmiterii"),
                                    Client = new Client
                                    {
                                        CUI = reader.GetString("CUI"),
                                        Nume = reader.GetString("Nume"),
                                        NrRegistruComert = reader.GetString("NrRegistruComert"),
                                        Adresa = reader.GetString("Adresa")
                                    },
                                    MetodaPlata = reader.GetString("MetodaPlata"),
                                    Servicii = new List<ServiciuFactura>(),
                                    Cont = new ContBancar
                                    {
                                        IBAN = reader.GetString("IBAN"),
                                        Moneda = reader.GetString("Moneda"),
                                        CUIFirma = reader.GetString("CUIFirma"),
                                        Banca = reader.GetString("Banca")
                                    }
                                };
                                facturi.Add(factura);
                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("ServiciuID")))
                            {
                                var serviciu = new Serviciu
                                {
                                    Id = reader.GetInt32("ServiciuID"),
                                    Descriere = reader.GetString("Descriere"),
                                    Pret = reader.GetDecimal("Pret"),
                                    Um = (Serviciu.UM)reader.GetInt32("Um"),
                                    Tva = (Serviciu.TVA)reader.GetInt32("ServiciuTva"),
                                    Cantitate = reader.GetInt32("Cantitate"),
                                    Valoare = reader.GetFloat("Valoare")
                                };
                                factura.ValoareTotala += serviciu.Valoare + Convert.ToSingle(serviciu.Tva)/100;
                                var serviciuFactura = new ServiciuFactura
                                {
                                    ServiciuID = serviciu.Id,
                                    Serviciu = serviciu,
                                };

                                factura.Servicii.Add(serviciuFactura);
                            }
                        }
                    }
                }
            }

            return facturi;
        }




        public async Task<List<Client>> GetAllClientsAsync()
        {
            var clients = new List<Client>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM Client";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var client = new Client
                            {
                                CUI = reader.GetString("CUI"),
                                Nume = reader.GetString("Nume"),
                                NrRegistruComert = reader.GetString("NrRegistruComert"),
                                Adresa = reader.GetString("Adresa")
                            };
                            clients.Add(client);
                        }
                    }
                }
            }

            return clients;
        }
        public async Task CreateClientAsync(Client client)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = @"INSERT INTO Client (CUI, Nume, NrRegistruComert, Adresa, Tara, Judet, Localitate) 
                                 VALUES (@CUI, @Nume, @NrRegistruComert, @Adresa, @Tara, @Judet, @Localitate)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CUI", client.CUI);
                    command.Parameters.AddWithValue("@Nume", client.Nume);
                    command.Parameters.AddWithValue("@NrRegistruComert", client.NrRegistruComert);
                    command.Parameters.AddWithValue("@Adresa", client.Adresa);
                    command.Parameters.AddWithValue("@Tara", client.Tara);
                    command.Parameters.AddWithValue("@Judet", client.Judet);
                    command.Parameters.AddWithValue("@Localitate", client.Localitate);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task CreateUserAsync(User user)
        {
            Console.WriteLine("intra");
            if (await UserExistsAsync(user.Username))
                throw new Exception("Numele de utilizator este deja folosit!");
            Console.WriteLine("trece");
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "INSERT INTO User (Username, Password) VALUES (@Username, @Password)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task CreateFacturaAsync(Factura factura)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        // Insert Factura
                        string facturaQuery = "INSERT INTO Factura (FirmaID, Serie, Numar, DataEmiterii, MetodaPlata, ClientID, ContBancarIBAN) VALUES (@FirmaID, @Serie, @Numar, @DataEmiterii, @MetodaPlata, @ClientID, @ContBancarIBAN)";
                        using (MySqlCommand command = new MySqlCommand(facturaQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@FirmaID", factura.FirmaID);
                            command.Parameters.AddWithValue("@Serie", factura.Serie);
                            command.Parameters.AddWithValue("@Numar", factura.Numar);
                            command.Parameters.AddWithValue("@DataEmiterii", factura.DataEmiterii);
                            command.Parameters.AddWithValue("@MetodaPlata", factura.MetodaPlata);
                            command.Parameters.AddWithValue("@ClientID", factura.Client.CUI);
                            command.Parameters.AddWithValue("@ContBancarIban", factura.Cont.IBAN);
                            await command.ExecuteNonQueryAsync();
                            factura.ID = (int)command.LastInsertedId;
                        }

                        // Insert FacturaServiciu entries
                        string facturaServiciuQuery = "INSERT INTO FacturaServiciu (FacturaID, ServiciuID) VALUES (@FacturaID, @ServiciuID)";
                        foreach (var serviciuFactura in factura.Servicii)
                        {
                            using (MySqlCommand command = new MySqlCommand(facturaServiciuQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@FacturaID", factura.ID);
                                command.Parameters.AddWithValue("@ServiciuID", serviciuFactura.ServiciuID);
                              
                                await command.ExecuteNonQueryAsync();
                            }
                        }

                        await transaction.CommitAsync();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        Console.WriteLine($"Error creating factura: {ex.Message}");  // Log the exception message
                        Console.WriteLine($"Stack Trace: {ex.StackTrace}");  // Log the stack trace
                        throw;
                    }
                }
            }
        }

        public async Task UpdateFirmaAsync(Firma firma)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = @"UPDATE Firma 
                             SET Nume = @Nume, 
                                 IDUser = @IDUser, 
                                 NrRegistruComert = @NrRegistruComert, 
                                 Adresa = @Adresa 
                             WHERE CUI = @CUI";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CUI", firma.CUI);
                    command.Parameters.AddWithValue("@Nume", firma.Nume);
                    command.Parameters.AddWithValue("@IDUser", firma.IDUser);
                    command.Parameters.AddWithValue("@NrRegistruComert", firma.NrRegistruComert);
                    command.Parameters.AddWithValue("@Adresa", firma.Adresa);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task DeleteFirmaAsync(string cui)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "DELETE FROM Firma WHERE CUI = @CUI";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CUI", cui);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task<List<Firma>> GetFirmeByUserAsync(int userId)
        {
            await Console.Out.WriteLineAsync(userId.ToString());
            var firme = new List<Firma>();

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT CUI, Nume, IDUser, NrRegistruComert, Adresa, Tara, Judet, Localitate FROM Firma WHERE IDUser = @IDUser";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDUser", userId);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var firma = new Firma
                            {
                                CUI = reader.GetString("CUI"),
                                Nume = reader.GetString("Nume"),
                                IDUser = reader.GetInt32("IDUser"),
                                NrRegistruComert = reader.GetString("NrRegistruComert"),
                                Adresa = reader.GetString("Adresa"),
                                Tara = reader.GetString("Tara"),
                                Judet = reader.GetString("Judet"),
                                Localitate = reader.GetString("Localitate")
                            };
                            firme.Add(firma);
                        }
                    }
                }
            }

            return firme;
        }
        public async Task<bool> UserExistsAsync(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT COUNT(*) FROM user WHERE Username = @Username";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    return count > 0;
                }
            }
        }


        public async Task CreateFirmaAsync(Firma firma)
        {
            if (await FirmaExistsAsync(firma.CUI, firma.NrRegistruComert, firma.Nume))
                throw new Exception("Aceasta firma exista deja in baza de date!");

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "INSERT INTO Firma (CUI, Nume, IDUser, NrRegistruComert, Adresa, Tara, Judet , Localitate) VALUES (@CUI, @Nume, @IDUser, @NrRegistruComert, @Adresa, @Tara, @Judet , @Localitate)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CUI", firma.CUI);
                    command.Parameters.AddWithValue("@Nume", firma.Nume);
                    command.Parameters.AddWithValue("@IDUser", firma.IDUser);
                    command.Parameters.AddWithValue("@NrRegistruComert", firma.NrRegistruComert);
                    command.Parameters.AddWithValue("@Adresa", firma.Adresa);
                    command.Parameters.AddWithValue("@Tara", firma.Tara);
                    command.Parameters.AddWithValue("@Judet", firma.Judet);
                    command.Parameters.AddWithValue("@Localitate", firma.Localitate);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<bool> LoginUserAsync(User user)
        {
           
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                
                if (!await UserExistsAsync(user.Username))
                    throw new Exception("Numele de utilizator sau parola sunt gresite!");
                await connection.OpenAsync();
                string query = "SELECT * FROM USER where Username = @Username AND Password = @Password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    
                    int count = Convert.ToInt32(await command.ExecuteScalarAsync());

                    if(count <= 0)
                        throw new Exception("Numele de utilizator sau parola sunt gresite!");

                    return true;

                }
            }
        }
        public async Task<bool> FirmaExistsAsync(string cui, string nrRegistruComert, string nume)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT COUNT(*) FROM Firma WHERE CUI = @CUI";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CUI", cui);
                    command.Parameters.AddWithValue("@NrRegistruComert", nrRegistruComert);
                    command.Parameters.AddWithValue("@Nume", nume);
                    int count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    return count > 0;
                }
            }
        }

        public async Task<int> GetUserIDAsync(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT Id FROM user WHERE Username = @Username";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    
                    return Convert.ToInt32(await command.ExecuteScalarAsync()); 
                }
            }
        }
    }
}
