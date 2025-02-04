namespace SilverwingAirportManagementSystem_Final
{
    partial class FlightManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewFlights = new DataGridView();
            txtFlightNo = new TextBox();
            txtAirline = new TextBox();
            txtDeparture = new TextBox();
            txtArrival = new TextBox();
            dtpDepature = new DateTimePicker();
            dtpArrival = new DateTimePicker();
            btnAddFlight = new Button();
            btnUpdateFlight = new Button();
            btnDeleteFlight = new Button();
            btnViewAllFlights = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            cboStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFlights).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFlights
            // 
            dataGridViewFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFlights.Location = new Point(564, 21);
            dataGridViewFlights.Name = "dataGridViewFlights";
            dataGridViewFlights.Size = new Size(475, 536);
            dataGridViewFlights.TabIndex = 0;
            dataGridViewFlights.CellContentClick += dataGridViewFlights_CellContentClick;
            // 
            // txtFlightNo
            // 
            txtFlightNo.BorderStyle = BorderStyle.None;
            txtFlightNo.Location = new Point(223, 195);
            txtFlightNo.Name = "txtFlightNo";
            txtFlightNo.Size = new Size(108, 16);
            txtFlightNo.TabIndex = 2;
            // 
            // txtAirline
            // 
            txtAirline.BorderStyle = BorderStyle.None;
            txtAirline.Location = new Point(223, 255);
            txtAirline.Name = "txtAirline";
            txtAirline.Size = new Size(264, 16);
            txtAirline.TabIndex = 3;
            // 
            // txtDeparture
            // 
            txtDeparture.BorderStyle = BorderStyle.None;
            txtDeparture.Location = new Point(223, 310);
            txtDeparture.Name = "txtDeparture";
            txtDeparture.Size = new Size(264, 16);
            txtDeparture.TabIndex = 4;
            // 
            // txtArrival
            // 
            txtArrival.BorderStyle = BorderStyle.None;
            txtArrival.Location = new Point(223, 368);
            txtArrival.Name = "txtArrival";
            txtArrival.Size = new Size(264, 16);
            txtArrival.TabIndex = 5;
            // 
            // dtpDepature
            // 
            dtpDepature.Location = new Point(223, 422);
            dtpDepature.Name = "dtpDepature";
            dtpDepature.Size = new Size(164, 23);
            dtpDepature.TabIndex = 6;
            // 
            // dtpArrival
            // 
            dtpArrival.Location = new Point(223, 482);
            dtpArrival.Name = "dtpArrival";
            dtpArrival.Size = new Size(164, 23);
            dtpArrival.TabIndex = 7;
            // 
            // btnAddFlight
            // 
            btnAddFlight.Location = new Point(584, 579);
            btnAddFlight.Name = "btnAddFlight";
            btnAddFlight.Size = new Size(97, 42);
            btnAddFlight.TabIndex = 9;
            btnAddFlight.Text = "Add";
            btnAddFlight.UseVisualStyleBackColor = true;
            btnAddFlight.Click += btnAddFlight_Click;
            // 
            // btnUpdateFlight
            // 
            btnUpdateFlight.Location = new Point(697, 579);
            btnUpdateFlight.Name = "btnUpdateFlight";
            btnUpdateFlight.Size = new Size(97, 42);
            btnUpdateFlight.TabIndex = 10;
            btnUpdateFlight.Text = "Update";
            btnUpdateFlight.UseVisualStyleBackColor = true;
            btnUpdateFlight.Click += btnUpdateFlight_Click;
            // 
            // btnDeleteFlight
            // 
            btnDeleteFlight.Location = new Point(809, 579);
            btnDeleteFlight.Name = "btnDeleteFlight";
            btnDeleteFlight.Size = new Size(97, 42);
            btnDeleteFlight.TabIndex = 11;
            btnDeleteFlight.Text = "Delete";
            btnDeleteFlight.UseVisualStyleBackColor = true;
            btnDeleteFlight.Click += btnDeleteFlight_Click;
            // 
            // btnViewAllFlights
            // 
            btnViewAllFlights.Location = new Point(922, 579);
            btnViewAllFlights.Name = "btnViewAllFlights";
            btnViewAllFlights.Size = new Size(97, 42);
            btnViewAllFlights.TabIndex = 12;
            btnViewAllFlights.Text = "View All";
            btnViewAllFlights.UseVisualStyleBackColor = true;
            btnViewAllFlights.Click += btnViewAllFlights_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(51, 88);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(376, 23);
            txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(433, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(44, 23);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboStatus
            // 
            cboStatus.FlatStyle = FlatStyle.Flat;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Delayed", "OnTime" });
            cboStatus.Location = new Point(222, 540);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(165, 23);
            cboStatus.TabIndex = 15;
            // 
            // FlightManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FLIGHT_MANAGEMENT1;
            ClientSize = new Size(1050, 655);
            Controls.Add(cboStatus);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnViewAllFlights);
            Controls.Add(btnDeleteFlight);
            Controls.Add(btnUpdateFlight);
            Controls.Add(btnAddFlight);
            Controls.Add(dtpArrival);
            Controls.Add(dtpDepature);
            Controls.Add(txtArrival);
            Controls.Add(txtDeparture);
            Controls.Add(txtAirline);
            Controls.Add(txtFlightNo);
            Controls.Add(dataGridViewFlights);
            Name = "FlightManagement";
            Text = "FlightManagement";
            Load += FlightManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFlights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFlights;
        private TextBox txtFlightNo;
        private TextBox txtAirline;
        private TextBox txtDeparture;
        private TextBox txtArrival;
        private DateTimePicker dtpDepature;
        private DateTimePicker dtpArrival;
        private Button btnAddFlight;
        private Button btnUpdateFlight;
        private Button btnDeleteFlight;
        private Button btnViewAllFlights;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cboStatus;
    }
}