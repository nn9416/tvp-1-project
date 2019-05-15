namespace tvp_1_project.View
{
    partial class FMain
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
            this.windowButtonsflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.maximizeLabel = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.pagesPanel = new System.Windows.Forms.Panel();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.ucSideMenu = new tvp_1_project.View.UserControls.UCSideMenu();
            this.windowButtonsflowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowButtonsflowLayoutPanel
            // 
            this.windowButtonsflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowButtonsflowLayoutPanel.Controls.Add(this.closeLabel);
            this.windowButtonsflowLayoutPanel.Controls.Add(this.maximizeLabel);
            this.windowButtonsflowLayoutPanel.Controls.Add(this.minimizeLabel);
            this.windowButtonsflowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.windowButtonsflowLayoutPanel.Location = new System.Drawing.Point(1033, 4);
            this.windowButtonsflowLayoutPanel.Name = "windowButtonsflowLayoutPanel";
            this.windowButtonsflowLayoutPanel.Size = new System.Drawing.Size(81, 26);
            this.windowButtonsflowLayoutPanel.TabIndex = 2;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Operator Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.Location = new System.Drawing.Point(60, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(18, 19);
            this.closeLabel.TabIndex = 0;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // maximizeLabel
            // 
            this.maximizeLabel.AutoSize = true;
            this.maximizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeLabel.Location = new System.Drawing.Point(36, 0);
            this.maximizeLabel.Name = "maximizeLabel";
            this.maximizeLabel.Size = new System.Drawing.Size(18, 19);
            this.maximizeLabel.TabIndex = 1;
            this.maximizeLabel.Text = "■";
            this.maximizeLabel.Click += new System.EventHandler(this.MaximizeLabel_Click);
            this.maximizeLabel.MouseEnter += new System.EventHandler(this.MaximizeLabel_MouseEnter);
            this.maximizeLabel.MouseLeave += new System.EventHandler(this.MaximizeLabel_MouseLeave);
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.minimizeLabel.Location = new System.Drawing.Point(12, 0);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(18, 19);
            this.minimizeLabel.TabIndex = 2;
            this.minimizeLabel.Text = "-";
            this.minimizeLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.minimizeLabel.MouseEnter += new System.EventHandler(this.MinimizeLabel_MouseEnter);
            this.minimizeLabel.MouseLeave += new System.EventHandler(this.MinimizeLabel_MouseLeave);
            // 
            // pagesPanel
            // 
            this.pagesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.pagesPanel.Location = new System.Drawing.Point(214, 35);
            this.pagesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pagesPanel.Name = "pagesPanel";
            this.pagesPanel.Size = new System.Drawing.Size(900, 585);
            this.pagesPanel.TabIndex = 3;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(12, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(109, 13);
            this.currentUserLabel.TabIndex = 4;
            this.currentUserLabel.Text = "currentUserLlabel";
            // 
            // ucSideMenu
            // 
            this.ucSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ucSideMenu.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ucSideMenu.ForeColor = System.Drawing.Color.White;
            this.ucSideMenu.Location = new System.Drawing.Point(4, 30);
            this.ucSideMenu.MinimumSize = new System.Drawing.Size(210, 590);
            this.ucSideMenu.Name = "ucSideMenu";
            this.ucSideMenu.Size = new System.Drawing.Size(210, 590);
            this.ucSideMenu.TabIndex = 0;
            this.ucSideMenu.ButtonClick += new System.EventHandler(this.UcSideMenu_ButtonClick);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1118, 624);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.pagesPanel);
            this.Controls.Add(this.windowButtonsflowLayoutPanel);
            this.Controls.Add(this.ucSideMenu);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1118, 624);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FMain_MouseUp);
            this.Resize += new System.EventHandler(this.FMain_Resize);
            this.windowButtonsflowLayoutPanel.ResumeLayout(false);
            this.windowButtonsflowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UCSideMenu ucSideMenu;
        private System.Windows.Forms.FlowLayoutPanel windowButtonsflowLayoutPanel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label maximizeLabel;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Panel pagesPanel;
        private System.Windows.Forms.Label currentUserLabel;
    }
}