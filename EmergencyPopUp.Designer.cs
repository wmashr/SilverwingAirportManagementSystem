namespace SilverwingAirportManagementSystem_Final
{
    partial class EmergencyPopUp
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(32, 77);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(382, 31);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 28F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(122, 18);
            label1.Name = "label1";
            label1.Size = new Size(196, 46);
            label1.TabIndex = 1;
            label1.Text = "EMERGENCY";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(277, 130);
            button1.Name = "button1";
            button1.Size = new Size(137, 78);
            button1.TabIndex = 2;
            button1.Text = "STOP \U0001f91a";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmergencyPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 220);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EmergencyPopUp";
            Text = "EmergencyPopUp";
            Load += EmergencyPopUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Button button1;
    }
}