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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.offersDataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.ucDataViewer = new tvp_1_project.View.UserControls.UCDataViewer();
            ((System.ComponentModel.ISupportInitialize)(this.offersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // offersDataGridView
            // 
            this.offersDataGridView.AllowUserToAddRows = false;
            this.offersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.offersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.offersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.offersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.offersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.offersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.offersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.offersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offersDataGridView.EnableHeadersVisualStyles = false;
            this.offersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.offersDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.offersDataGridView.Name = "offersDataGridView";
            this.offersDataGridView.ReadOnly = true;
            this.offersDataGridView.RowHeadersVisible = false;
            this.offersDataGridView.Size = new System.Drawing.Size(900, 174);
            this.offersDataGridView.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.offersDataGridView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.ucDataViewer);
            this.splitContainer.Panel2MinSize = 415;
            this.splitContainer.Size = new System.Drawing.Size(900, 590);
            this.splitContainer.SplitterDistance = 174;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 2;
            // 
            // ucDataViewer
            // 
            this.ucDataViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ucDataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDataViewer.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ucDataViewer.ForeColor = System.Drawing.Color.LightGray;
            this.ucDataViewer.InputControls = null;
            this.ucDataViewer.Location = new System.Drawing.Point(0, 0);
            this.ucDataViewer.Margin = new System.Windows.Forms.Padding(0);
            this.ucDataViewer.MinimumSize = new System.Drawing.Size(900, 415);
            this.ucDataViewer.Name = "ucDataViewer";
            this.ucDataViewer.Size = new System.Drawing.Size(900, 415);
            this.ucDataViewer.TabIndex = 0;
            this.ucDataViewer.ButtonClick += new System.EventHandler<tvp_1_project.BussinesLogic.CustomEventArgs>(this.UcDataViewerButtons_Click);
            this.ucDataViewer.Load += new System.EventHandler(this.UcDataViewer_Load);
            // 
            // PageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "PageBookings";
            this.Size = new System.Drawing.Size(900, 590);
            ((System.ComponentModel.ISupportInitialize)(this.offersDataGridView)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCDataViewer ucDataViewer;
        private System.Windows.Forms.DataGridView offersDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}
