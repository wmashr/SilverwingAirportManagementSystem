using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SilverwingAirportManagementSystem_Final
{
    public partial class EmergencyPopUp : Form
    {
        private SoundPlayer player;
        public EmergencyPopUp()
        {
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 100;
            progressBar1.ForeColor = System.Drawing.Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyPopUp_Load(object sender, EventArgs e)
        {
            try
            {
                player = new SoundPlayer(@"C:\Users\malee\Downloads\hello.wav");
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player?.Stop();
            this.Close();
        }
    }
}
