namespace tvp_1_project.View.Pages.Admin
{
    partial class PageBookings
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
            this.ucDataViewer = new tvp_1_project.View.UserControls.UCDataViewer();
            this.offersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.offersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDataViewer
            // 
            this.ucDataViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.ucDataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDataViewer.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ucDataViewer.ForeColor = System.Drawing.Color.LightGray;
            this.ucDataViewer.InputControls = null;
            this.ucDataViewer.Location = new System.Drawing.Point(0, 0);
            this.ucDataViewer.MinimumSize = new System.Drawing.Size(900, 390);
            this.ucDataViewer.Name = "ucDataViewer";
            this.ucDataViewer.Size = new System.Drawing.Size(900, 590);
            this.ucDataViewer.TabIndex = 0;
            // 
            // offersDataGridView
            // 
            this.offersDataGridView.AllowUserToAddRows = false;
            this.offersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.offersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.offersDataGridView.Name = "offersDataGridView";
            this.offersDataGridView.ReadOnly = true;
            this.offersDataGridView.Size = new System.Drawing.Size(900, 200);
            this.offersDataGridView.TabIndex = 1;
            // 
            // PageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.offersDataGridView);
            this.Controls.Add(this.ucDataViewer);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "PageBookings";
            this.Size = new System.Drawing.Size(900, 590);
            ((System.ComponentModel.ISupportInitialize)(this.offersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCDataViewer ucDataViewer;
        private System.Windows.Forms.DataGridView offersDataGridView;
    }
}
