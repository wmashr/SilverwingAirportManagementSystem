using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace SilverwingAirportManagementSystem_Final
{
    public partial class PassengerManagement : Form
    {
        private string connectionString = "Server=localhost;Database=SilverwingAirportDB;Trusted_Connection=True;";
        public PassengerManagement()
        {
            InitializeComponent();
            LoadFlights();
        }

        private void LoadFlights()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT FlightID, FlightNumber FROM Flight";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                cboFlight.DataSource = dt;
                cboFlight.DisplayMember = "FlightNumber";  // What user sees
                cboFlight.ValueMember = "FlightID";        // Value stored in database

                conn.Close();
            }
        }

        private void AddPassenger()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Passenger (PassportNumber, FirstName, LastName, DateOfBirth, Gender, Email, PhoneNumber, FlightID) 
                                     VALUES (@PassportNumber, @FirstName, @LastName, @DateOfBirth, @Gender, @Email, @PhoneNumber, @FlightID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PassportNumber", txtPassportNumber.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@Gender", cboGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@FlightID", Convert.ToInt32(cboFlight.SelectedValue));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Passenger added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPassengerData();
            }
        }

        private void SearchPassenger(string searchValue)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT PassengerID, PassportNumber, FirstName, LastName, DateOfBirth, Gender, Email, PhoneNumber, FlightID 
                             FROM Passenger 
                             WHERE PassportNumber LIKE @SearchValue OR
                                   FirstName LIKE @SearchValue OR 
                                   LastName LIKE @SearchValue OR 
                                   Email LIKE @SearchValue OR 
                                   PhoneNumber LIKE @SearchValue";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPassengers.DataSource = dt;
            }
        }

        private void UpdatePassenger(int passengerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Passenger 
                             SET PassportNumber=@PassportNumber, FirstName=@FirstName, LastName=@LastName, 
                                 DateOfBirth=@DateOfBirth, Gender=@Gender, Email=@Email, PhoneNumber=@PhoneNumber 
                             WHERE PassengerID=@PassengerID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PassportNumber", txtPassportNumber.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@Gender", cboGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@PassengerID", passengerId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Passenger updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPassengerData();
            }
        }

        private void DeletePassenger(int passengerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Passenger WHERE PassengerID=@PassengerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PassengerID", passengerId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Passenger deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPassengerData();
            }
        }

        private void LoadPassengerData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Passenger";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPassengers.DataSource = dt;
            }
        }

        private void PassengerManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPassenger();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPassengers.SelectedRows.Count > 0)
            {
                int passengerId = Convert.ToInt32(dgvPassengers.SelectedRows[0].Cells[0].Value);
                UpdatePassenger(passengerId);
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (dgvPassengers.SelectedRows.Count > 0)
            {
                int passengerId = Convert.ToInt32(dgvPassengers.SelectedRows[0].Cells[0].Value);
                DeletePassenger(passengerId);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadPassengerData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPassenger(txtSearch.Text);
        }
    }
}
