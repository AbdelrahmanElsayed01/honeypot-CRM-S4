
using HoneypotCRMS4.Models;
using MySql.Data.MySqlClient;

namespace HoneypotCRMS4.Data
{
    public class DataHelper
    {
        private string conn;
        MySqlConnection con;

        public DataHelper()
        {
            conn = "Server=mysql;Uid=root;Database=honeypot;Pwd=; SSL Mode=None;";
            con = new MySqlConnection(conn);
        }

        public string CheckConnection()
        {
            try
            {
                con.Open();
                return "Connection successful";
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        public List<UserModel> GetUsers()
        {
            List<UserModel> users = new List<UserModel>();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserModel user = new UserModel();
                user.Id = Convert.ToInt32(reader["id"]);
                user.Name = reader["name"].ToString();
                user.Email = reader["email"].ToString();
                user.Role = reader["role"].ToString();
                users.Add(user);
            }
            con.Close();
            return users;
        }

        public void AddUser(UserModel user)
        {
            con.Open();
            string query = "INSERT INTO user (name, email, role) VALUES (@Name, @Email, @Role)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Role", user.Role);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public void DeleteUser(int id)
        {
            con.Open();
        string query = "DELETE FROM user WHERE id = @Id";
    MySqlCommand cmd = new MySqlCommand(query, con);
    cmd.Parameters.AddWithValue("@Id", id);
    cmd.ExecuteNonQuery();
    con.Close();
        }

        public List<ClientModel> GetClients()
        {
            List<ClientModel> users = new List<ClientModel>();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM client", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ClientModel user = new ClientModel();
                user.Id = Convert.ToInt32(reader["id"]);
                user.Name = reader["name"].ToString();
                user.Email = reader["email"].ToString();
                user.CompanyName = reader["company_name"].ToString();
                users.Add(user);
            }
            con.Close();
            return users;
        }
        
        public void AddClient(ClientModel user)
        {
            con.Open();
            string query = "INSERT INTO client (name, email, company_name) VALUES (@Name, @Email, @Company_name)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Company_name", user.CompanyName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

                public void DeleteClient(int id)
        {
            con.Open();
        string query = "DELETE FROM client WHERE id = @Id";
    MySqlCommand cmd = new MySqlCommand(query, con);
    cmd.Parameters.AddWithValue("@Id", id);
    cmd.ExecuteNonQuery();
    con.Close();
        }



         public List<QuoteModel> GetQuotes()
        {
            List<QuoteModel> quotes = new List<QuoteModel>();

            
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM quotes", con);
            
            MySqlDataReader reader = cmd.ExecuteReader();
            
                        while (reader.Read())
                        {
                            QuoteModel quote = new QuoteModel()
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                CustomerName = reader["CustomerName"].ToString(),
                                QuoteSum = Convert.ToDecimal(reader["QuoteSum"]),
                                PaymentStatus = reader["PaymentStatus"].ToString()
                            };
                            quotes.Add(quote);
                        }
                    
                
            

            return quotes;
        }


         public List<InvoiceModel> GetInvoices()
        {
            List<InvoiceModel> invoices = new List<InvoiceModel>();

            
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM invoices", con);
            
            MySqlDataReader reader = cmd.ExecuteReader();
            
                        while (reader.Read())
                        {
                            InvoiceModel invoice = new InvoiceModel()
                            {
                                Id = Convert.ToInt32(reader["JobID"]),
                                CustomerName = reader["CustomerName"].ToString(),
                                Amount = Convert.ToDecimal(reader["AmountDue"]),
                                Status = reader["PaymentStatus"].ToString()
                            };
                            invoices.Add(invoice);
                        }
                    
                
            

            return invoices;
        }

         public List<OrderModel> GetOrders()
        {
            List<OrderModel> orders = new List<OrderModel>();

            
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM orders", con);
            
            MySqlDataReader reader = cmd.ExecuteReader();
            
                        while (reader.Read())
                        {
                            OrderModel order = new OrderModel()
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                OrderNumber = reader["OrderReference"].ToString(),
                                CompanyName = Convert.ToString(reader["CompanyName"]),
                                Status = reader["Status"].ToString(),
                                Total = Convert.ToDecimal(reader["Total"]),
                                Created = Convert.ToDateTime(reader["Created"])
                            };
                            orders.Add(order);
                        }
                    
                
            

            return orders;
        }
    }
}