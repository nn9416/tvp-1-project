namespace tvp_1_project.View.Pages.Admin
{
    partial class PageCars
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
            this.ucDataViewer.Margin = new System.Windows.Forms.Padding(0);
            this.ucDataViewer.MinimumSize = new System.Drawing.Size(900, 590);
            this.ucDataViewer.Name = "ucDataViewer";
            this.ucDataViewer.Size = new System.Drawing.Size(900, 590);
            this.ucDataViewer.TabIndex = 0;
            this.ucDataViewer.ButtonClick += new System.EventHandler<tvp_1_project.BussinesLogic.CustomEventArgs>(this.UcDataViewerButtons_Click);
            this.ucDataViewer.Load += new System.EventHandler(this.UcDataViewer_Load);
            // 
            // PageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.ucDataViewer);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "PageCars";
            this.Size = new System.Drawing.Size(900, 590);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCDataViewer ucDataViewer;
    }
}
