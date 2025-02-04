using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverwingAirportManagementSystem_Final
{
    public partial class FlightManagement : Form
    {
        private SqlConnection connection;
        string connectionString = @"Server=localhost;Database=SilverwingAirportDB;Integrated Security=True";
        public FlightManagement()
        {
            InitializeComponent();
        }

        private void dataGridViewFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FlightManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFlightNo.Text))
            {
                MessageBox.Show("Please enter a Flight Number to update.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Flight SET AirlineName = @AirlineName, DepartureAirport = @DepartureAirport, ArrivalAirport = @ArrivalAirport, DepartureTime = @DepartureTime, ArrivalTime = @ArrivalTime, Status = @Status WHERE FlightNumber = @FlightNumber";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@AirlineName", txtAirline.Text);
                    cmd.Parameters.AddWithValue("@DepartureAirport", txtDeparture.Text);
                    cmd.Parameters.AddWithValue("@ArrivalAirport", txtArrival.Text);
                    cmd.Parameters.AddWithValue("@DepartureTime", dtpDepature.Value);
                    cmd.Parameters.AddWithValue("@ArrivalTime", dtpArrival.Value);
                    cmd.Parameters.AddWithValue("@Status", cboStatus.Text);
                    cmd.Parameters.AddWithValue("@FlightNumber", txtFlightNo.Text);  // Use the Flight Number from TextBox

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();  // Execute the update command

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Flight updated successfully!");
                        btnViewAllFlights_Click(sender, e);  // Refresh the data grid to reflect changes
                    }
                    else
                    {
                        MessageBox.Show("No flight found with the provided Flight Number.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnViewAllFlights_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Server=localhost;Database=SilverwingAirportDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Flight";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridViewFlights.DataSource = dt;  // Bind the data to DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFlightNo.Text))
            {
                MessageBox.Show("Please enter a Flight Number to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this flight?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Flight WHERE FlightNumber = @FlightNumber";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@FlightNumber", txtFlightNo.Text);  // Use the Flight Number from TextBox

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();  // Execute the delete command

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Flight deleted successfully!");
                            btnViewAllFlights_Click(sender, e);  // Refresh the data grid to reflect changes
                        }
                        else
                        {
                            MessageBox.Show("No flight found with the provided Flight Number.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFlightNo.Text))
            {
                MessageBox.Show("Please enter a Flight Number to search.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Flight WHERE FlightNumber = @FlightNumber";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@FlightNumber", txtFlightNo.Text);  // Search by Flight Number
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewFlights.DataSource = dt;  // Bind search results to DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No flight found with the provided Flight Number.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFlightNo.Text) || string.IsNullOrEmpty(txtAirline.Text) ||
            string.IsNullOrEmpty(txtDeparture.Text) || string.IsNullOrEmpty(txtArrival.Text) ||
            string.IsNullOrEmpty(dtpDepature.Text) || string.IsNullOrEmpty(dtpArrival.Text) ||
            string.IsNullOrEmpty(cboStatus.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Flight (FlightNumber, AirlineName, DepartureAirport, ArrivalAirport, DepartureTime, ArrivalTime, Status) " +
                                   "VALUES (@FlightNumber, @AirlineName, @DepartureAirport, @ArrivalAirport, @DepartureTime, @ArrivalTime, @Status)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FlightNumber", txtFlightNo.Text);
                    cmd.Parameters.AddWithValue("@AirlineName", txtAirline.Text);
                    cmd.Parameters.AddWithValue("@DepartureAirport", txtDeparture.Text);
                    cmd.Parameters.AddWithValue("@ArrivalAirport", txtArrival.Text);
                    cmd.Parameters.AddWithValue("@DepartureTime", dtpDepature.Value);
                    cmd.Parameters.AddWithValue("@ArrivalTime", dtpArrival.Value);
                    cmd.Parameters.AddWithValue("@Status", cboStatus.Text);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();  // Execute the insert command

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Flight added successfully!");
                        btnViewAllFlights_Click(sender, e);  // Refresh the data grid to reflect new flight
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the flight.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
