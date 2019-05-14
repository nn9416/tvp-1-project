namespace tvp_1_project.View.UserControls
{
    partial class UCSideMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.adminFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.carsButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.offersButton = new System.Windows.Forms.Button();
            this.bookingsButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.customerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.currentBookingsButton = new System.Windows.Forms.Button();
            this.bookNewButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainFlowLayoutPanel.SuspendLayout();
            this.adminFlowLayoutPanel.SuspendLayout();
            this.customerFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.mainFlowLayoutPanel.Controls.Add(this.adminFlowLayoutPanel);
            this.mainFlowLayoutPanel.Controls.Add(this.customerFlowLayoutPanel);
            this.mainFlowLayoutPanel.Controls.Add(this.logoutButton);
            this.mainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(210, 556);
            this.mainFlowLayoutPanel.TabIndex = 0;
            // 
            // adminFlowLayoutPanel
            // 
            this.adminFlowLayoutPanel.Controls.Add(this.carsButton);
            this.adminFlowLayoutPanel.Controls.Add(this.customersButton);
            this.adminFlowLayoutPanel.Controls.Add(this.offersButton);
            this.adminFlowLayoutPanel.Controls.Add(this.bookingsButton);
            this.adminFlowLayoutPanel.Controls.Add(this.statisticsButton);
            this.adminFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.adminFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.adminFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.adminFlowLayoutPanel.Name = "adminFlowLayoutPanel";
            this.adminFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.adminFlowLayoutPanel.Size = new System.Drawing.Size(210, 240);
            this.adminFlowLayoutPanel.TabIndex = 0;
            // 
            // carsButton
            // 
            this.carsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.carsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.carsButton.Location = new System.Drawing.Point(8, 13);
            this.carsButton.Name = "carsButton";
            this.carsButton.Size = new System.Drawing.Size(194, 40);
            this.carsButton.TabIndex = 0;
            this.carsButton.Tag = "cars";
            this.carsButton.Text = "Automobili";
            this.carsButton.UseVisualStyleBackColor = false;
            this.carsButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // customersButton
            // 
            this.customersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.customersButton.Location = new System.Drawing.Point(8, 59);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(194, 40);
            this.customersButton.TabIndex = 1;
            this.customersButton.Tag = "customers";
            this.customersButton.Text = "Kupci";
            this.customersButton.UseVisualStyleBackColor = false;
            this.customersButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // offersButton
            // 
            this.offersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.offersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offersButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.offersButton.Location = new System.Drawing.Point(8, 105);
            this.offersButton.Name = "offersButton";
            this.offersButton.Size = new System.Drawing.Size(194, 40);
            this.offersButton.TabIndex = 2;
            this.offersButton.Tag = "offers";
            this.offersButton.Text = "Ponude";
            this.offersButton.UseVisualStyleBackColor = false;
            this.offersButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // bookingsButton
            // 
            this.bookingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.bookingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.bookingsButton.Location = new System.Drawing.Point(8, 151);
            this.bookingsButton.Name = "bookingsButton";
            this.bookingsButton.Size = new System.Drawing.Size(194, 40);
            this.bookingsButton.TabIndex = 3;
            this.bookingsButton.Tag = "bookings";
            this.bookingsButton.Text = "Rezervacije";
            this.bookingsButton.UseVisualStyleBackColor = false;
            this.bookingsButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.statisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.statisticsButton.Location = new System.Drawing.Point(8, 197);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(194, 40);
            this.statisticsButton.TabIndex = 4;
            this.statisticsButton.Tag = "statistics";
            this.statisticsButton.Text = "Statistika";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // customerFlowLayoutPanel
            // 
            this.customerFlowLayoutPanel.Controls.Add(this.currentBookingsButton);
            this.customerFlowLayoutPanel.Controls.Add(this.bookNewButton);
            this.customerFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.customerFlowLayoutPanel.Location = new System.Drawing.Point(0, 240);
            this.customerFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.customerFlowLayoutPanel.Name = "customerFlowLayoutPanel";
            this.customerFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.customerFlowLayoutPanel.Size = new System.Drawing.Size(210, 102);
            this.customerFlowLayoutPanel.TabIndex = 1;
            // 
            // currentBookingsButton
            // 
            this.currentBookingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.currentBookingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentBookingsButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.currentBookingsButton.Location = new System.Drawing.Point(8, 13);
            this.currentBookingsButton.Name = "currentBookingsButton";
            this.currentBookingsButton.Size = new System.Drawing.Size(194, 40);
            this.currentBookingsButton.TabIndex = 0;
            this.currentBookingsButton.Tag = "currentBookings";
            this.currentBookingsButton.Text = "Trenutne rezervacije";
            this.currentBookingsButton.UseVisualStyleBackColor = false;
            this.currentBookingsButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // bookNewButton
            // 
            this.bookNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.bookNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookNewButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.bookNewButton.Location = new System.Drawing.Point(8, 59);
            this.bookNewButton.Name = "bookNewButton";
            this.bookNewButton.Size = new System.Drawing.Size(194, 40);
            this.bookNewButton.TabIndex = 1;
            this.bookNewButton.Tag = "bookNew";
            this.bookNewButton.Text = "Rezerviši novi automobil";
            this.bookNewButton.UseVisualStyleBackColor = false;
            this.bookNewButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.logoutButton.Location = new System.Drawing.Point(8, 345);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(194, 40);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Tag = "logout";
            this.logoutButton.Text = "Odjavi se";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // UCSideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(210, 556);
            this.Name = "UCSideMenu";
            this.Size = new System.Drawing.Size(210, 556);
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.adminFlowLayoutPanel.ResumeLayout(false);
            this.customerFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel adminFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel customerFlowLayoutPanel;
        private System.Windows.Forms.Button carsButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button offersButton;
        private System.Windows.Forms.Button bookingsButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button currentBookingsButton;
        private System.Windows.Forms.Button bookNewButton;
        private System.Windows.Forms.Button logoutButton;
    }
}
