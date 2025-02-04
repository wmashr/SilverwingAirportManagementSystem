namespace SilverwingAirportManagementSystem_Final
{
    partial class PassengerManagement
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
            dgvPassengers = new DataGridView();
            txtPassportNumber = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            bntDelete = new Button();
            btnViewAll = new Button();
            cboGender = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            cboFlight = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).BeginInit();
            SuspendLayout();
            // 
            // dgvPassengers
            // 
            dgvPassengers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPassengers.Location = new Point(564, 21);
            dgvPassengers.Name = "dgvPassengers";
            dgvPassengers.Size = new Size(475, 546);
            dgvPassengers.TabIndex = 0;
            // 
            // txtPassportNumber
            // 
            txtPassportNumber.BorderStyle = BorderStyle.None;
            txtPassportNumber.Location = new Point(200, 199);
            txtPassportNumber.Name = "txtPassportNumber";
            txtPassportNumber.Size = new Size(145, 16);
            txtPassportNumber.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Location = new Point(201, 258);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(285, 16);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Location = new Point(201, 314);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(285, 16);
            txtLastName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(201, 488);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 16);
            txtEmail.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Location = new Point(201, 545);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(285, 16);
            txtPhoneNumber.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(577, 592);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(696, 592);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 34);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // bntDelete
            // 
            bntDelete.Location = new Point(812, 592);
            bntDelete.Name = "bntDelete";
            bntDelete.Size = new Size(99, 34);
            bntDelete.TabIndex = 10;
            bntDelete.Text = "Delete";
            bntDelete.UseVisualStyleBackColor = true;
            bntDelete.Click += bntDelete_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new Point(928, 592);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(99, 34);
            btnViewAll.TabIndex = 11;
            btnViewAll.Text = "View All";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // cboGender
            // 
            cboGender.FlatStyle = FlatStyle.Flat;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(201, 365);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(172, 23);
            cboGender.TabIndex = 13;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarMonthBackground = Color.Transparent;
            dtpDateOfBirth.CalendarTitleBackColor = Color.Transparent;
            dtpDateOfBirth.CalendarTrailingForeColor = Color.Transparent;
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(200, 424);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(172, 23);
            dtpDateOfBirth.TabIndex = 14;
            // 
            // cboFlight
            // 
            cboFlight.FlatStyle = FlatStyle.Flat;
            cboFlight.FormattingEnabled = true;
            cboFlight.Location = new Point(200, 144);
            cboFlight.Name = "cboFlight";
            cboFlight.Size = new Size(122, 23);
            cboFlight.TabIndex = 15;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(45, 92);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 23);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(459, 89);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // PassengerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PASSENGER_MANAGEMENT2;
            ClientSize = new Size(1050, 659);
            Controls.Add(txtSearch);
            Controls.Add(cboFlight);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cboGender);
            Controls.Add(btnSearch);
            Controls.Add(btnViewAll);
            Controls.Add(bntDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtPassportNumber);
            Controls.Add(dgvPassengers);
            Name = "PassengerManagement";
            Text = "PassengerManagement";
            Load += PassengerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPassengers;
        private TextBox txtPassportNumber;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Button btnAdd;
        private Button btnUpdate;
        private Button bntDelete;
        private Button btnViewAll;
        private ComboBox cboGender;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cboFlight;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}