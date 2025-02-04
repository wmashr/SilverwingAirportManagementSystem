using System;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace SilverwingAirportManagementSystem_Final
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
           InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=SilverwingAirportDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection status with the Airport: Successful!",
                        "Connection Status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk); // Correct icon for success
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection status with the Airport: Failed! {ex.Message}",
                        "Connection Status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Error icon for failure
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost;Database=SilverwingAirportDB;Integrated Security=True";
            string query = "SELECT AdminID, Name, Role FROM Admin WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text); // Get username from the text box
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text); // Get password from the text box (no hashing)

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Fetch the Name, Role, and Admin ID from the database
                        string adminName = reader["Name"].ToString();
                        string adminRole = reader["Role"].ToString();

                        // Pass the data to the main form (dashboard)
                        dashboard dashboardform = new dashboard(adminName, adminRole);
                        this.Hide(); // Hide the login form
                        dashboardform.Show(); // Show the main form (dashboard)
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
