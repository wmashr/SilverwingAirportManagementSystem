using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SilverwingAirportManagementSystem_Final
{
    public partial class dashboard : Form
    {
        private string adminName;
        private string adminRole;
        private System.Windows.Forms.Timer timer;
        public dashboard(string name, string role)
        {
            InitializeComponent();
            adminName = name;
            adminRole = role;
            //Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += new EventHandler(UpdateTimeAndLocation);
            timer.Start();
            //This is the Traking Web Link Part
            label1.Cursor = Cursors.Hand;
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Name:     {adminName}\nRole:     {adminRole}");
            // Assuming you have labels on your MainForm to display the data
            lblAdminName.Text = adminName;
            lblAdminRole.Text = adminRole;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string url = "https://www.planefinder.net";

            // Open the URL in the default web browser
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the URL: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassengerManagement PassengerForm = new PassengerManagement();
            PassengerForm.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            EmergencyPopUp customMsgBox = new EmergencyPopUp();
            customMsgBox.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlightManagement FlightForm = new FlightManagement();
            FlightForm.Show();
        }

        //Timer-------------------------------------------------


        private void UpdateTimeAndLocation(object sender, EventArgs e)
        {
            // Get current time and date
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("HH:mm:ss"); // 24-hour format with seconds
            string dateString = currentTime.ToString("yyyy-MM-dd"); // Date format

            // Get the current location (timezone)
            string location = TimeZoneInfo.Local.DisplayName;

            // Set the label text with time, date, and location
            myLabel.Text = $"{dateString} {timeString} | {location}";
        }

    }
}
