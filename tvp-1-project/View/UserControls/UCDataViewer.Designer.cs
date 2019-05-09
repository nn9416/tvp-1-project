namespace tvp_1_project.View.UserControls
{
    partial class UCDataViewer
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.crudSplitContainer = new System.Windows.Forms.SplitContainer();
            this.inputControlsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudSplitContainer)).BeginInit();
            this.crudSplitContainer.Panel1.SuspendLayout();
            this.crudSplitContainer.Panel2.SuspendLayout();
            this.crudSplitContainer.SuspendLayout();
            this.buttonsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.dataGridView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(251)))), ((int)(((byte)(8)))));
            this.mainSplitContainer.Panel2.Controls.Add(this.crudSplitContainer);
            this.mainSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mainSplitContainer.Panel2MinSize = 215;
            this.mainSplitContainer.Size = new System.Drawing.Size(885, 560);
            this.mainSplitContainer.SplitterDistance = 344;
            this.mainSplitContainer.SplitterWidth = 1;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(96)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(885, 344);
            this.dataGridView.TabIndex = 0;
            // 
            // crudSplitContainer
            // 
            this.crudSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(96)))), ((int)(((byte)(164)))));
            this.crudSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudSplitContainer.Location = new System.Drawing.Point(0, 5);
            this.crudSplitContainer.MinimumSize = new System.Drawing.Size(885, 210);
            this.crudSplitContainer.Name = "crudSplitContainer";
            // 
            // crudSplitContainer.Panel1
            // 
            this.crudSplitContainer.Panel1.Controls.Add(this.inputControlsFlowLayoutPanel);
            this.crudSplitContainer.Panel1MinSize = 475;
            // 
            // crudSplitContainer.Panel2
            // 
            this.crudSplitContainer.Panel2.Controls.Add(this.buttonsFlowLayoutPanel);
            this.crudSplitContainer.Size = new System.Drawing.Size(885, 210);
            this.crudSplitContainer.SplitterDistance = 680;
            this.crudSplitContainer.TabIndex = 0;
            // 
            // inputControlsFlowLayoutPanel
            // 
            this.inputControlsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.inputControlsFlowLayoutPanel.Name = "inputControlsFlowLayoutPanel";
            this.inputControlsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.inputControlsFlowLayoutPanel.Size = new System.Drawing.Size(680, 210);
            this.inputControlsFlowLayoutPanel.TabIndex = 0;
            // 
            // buttonsFlowLayoutPanel
            // 
            this.buttonsFlowLayoutPanel.Controls.Add(this.updateButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.addNewButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.deleteButton);
            this.buttonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsFlowLayoutPanel.Name = "buttonsFlowLayoutPanel";
            this.buttonsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonsFlowLayoutPanel.Size = new System.Drawing.Size(201, 210);
            this.buttonsFlowLayoutPanel.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(3, 8);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(190, 44);
            this.updateButton.TabIndex = 0;
            this.updateButton.Tag = "Update";
            this.updateButton.Text = "Sačuvaj izmene";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(3, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(190, 44);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Tag = "Cancel";
            this.cancelButton.Text = "Otkaži izmene";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.addNewButton.ForeColor = System.Drawing.Color.White;
            this.addNewButton.Location = new System.Drawing.Point(3, 108);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(190, 44);
            this.addNewButton.TabIndex = 2;
            this.addNewButton.Tag = "AddNew";
            this.addNewButton.Text = "Dodaj novi";
            this.addNewButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(3, 158);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(190, 44);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Tag = "Delete";
            this.deleteButton.Text = "Obriši";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // UCDataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.MinimumSize = new System.Drawing.Size(885, 560);
            this.Name = "UCDataViewer";
            this.Size = new System.Drawing.Size(885, 560);
            this.Load += new System.EventHandler(this.UCDataViewer_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.crudSplitContainer.Panel1.ResumeLayout(false);
            this.crudSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crudSplitContainer)).EndInit();
            this.crudSplitContainer.ResumeLayout(false);
            this.buttonsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.SplitContainer crudSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel inputControlsFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowLayoutPanel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
