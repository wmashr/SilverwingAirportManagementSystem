namespace SilverwingAirportManagementSystem_Final
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            lblAdminName = new Label();
            lblAdminRole = new Label();
            lblGlobalTracking = new Label();
            btnPassengerManagement = new Button();
            button2 = new Button();
            label1 = new Label();
            myLabel = new Label();
            SuspendLayout();
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.BackColor = Color.Transparent;
            lblAdminName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminName.ForeColor = Color.Yellow;
            lblAdminName.Location = new Point(91, 109);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(0, 21);
            lblAdminName.TabIndex = 0;
            // 
            // lblAdminRole
            // 
            lblAdminRole.AutoSize = true;
            lblAdminRole.BackColor = Color.Transparent;
            lblAdminRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminRole.ForeColor = Color.Yellow;
            lblAdminRole.Location = new Point(91, 147);
            lblAdminRole.Name = "lblAdminRole";
            lblAdminRole.Size = new Size(0, 21);
            lblAdminRole.TabIndex = 1;
            // 
            // lblGlobalTracking
            // 
            lblGlobalTracking.AutoSize = true;
            lblGlobalTracking.BackColor = Color.Transparent;
            lblGlobalTracking.Cursor = Cursors.Hand;
            lblGlobalTracking.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            lblGlobalTracking.ForeColor = SystemColors.ButtonHighlight;
            lblGlobalTracking.Location = new Point(706, 35);
            lblGlobalTracking.Name = "lblGlobalTracking";
            lblGlobalTracking.Size = new Size(208, 21);
            lblGlobalTracking.TabIndex = 2;
            lblGlobalTracking.Text = "GLOBAL FLIGHT TRACKING";
            lblGlobalTracking.Click += label1_Click;
            // 
            // btnPassengerManagement
            // 
            btnPassengerManagement.Font = new Font("Ethnocentric", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPassengerManagement.Location = new Point(272, 441);
            btnPassengerManagement.Name = "btnPassengerManagement";
            btnPassengerManagement.Size = new Size(187, 46);
            btnPassengerManagement.TabIndex = 3;
            btnPassengerManagement.Text = "GET ACESS";
            btnPassengerManagement.UseVisualStyleBackColor = true;
            btnPassengerManagement.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Ethnocentric", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(625, 441);
            button2.Name = "button2";
            button2.Size = new Size(187, 46);
            button2.TabIndex = 4;
            button2.Text = "GET ACESS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 232);
            label1.Name = "label1";
            label1.Size = new Size(123, 29);
            label1.TabIndex = 5;
            label1.Text = "EMERGENCY";
            label1.Click += label1_Click_1;
            // 
            // myLabel
            // 
            myLabel.AutoSize = true;
            myLabel.BackColor = Color.Transparent;
            myLabel.Font = new Font("Yu Gothic", 14F, FontStyle.Bold);
            myLabel.ForeColor = Color.DarkGreen;
            myLabel.Location = new Point(272, 128);
            myLabel.Name = "myLabel";
            myLabel.Size = new Size(67, 25);
            myLabel.TabIndex = 6;
            myLabel.Text = "label2";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DASHBOARD_ALLADMINPIC2;
            ClientSize = new Size(954, 564);
            Controls.Add(myLabel);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnPassengerManagement);
            Controls.Add(lblGlobalTracking);
            Controls.Add(lblAdminRole);
            Controls.Add(lblAdminName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dashboard";
            RightToLeft = RightToLeft.No;
            Text = "dashboard";
            Load += dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminName;
        private Label lblAdminRole;
        private Label lblGlobalTracking;
        private Button btnPassengerManagement;
        private Button button2;
        private Label label1;
        private Label myLabel;
    }
}