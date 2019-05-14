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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataSearchSplitContainer = new System.Windows.Forms.SplitContainer();
            this.searchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchCategoryLabel = new System.Windows.Forms.Label();
            this.searchCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.searchValueLabel = new System.Windows.Forms.Label();
            this.searchValueTextBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchSplitContainer)).BeginInit();
            this.dataSearchSplitContainer.Panel1.SuspendLayout();
            this.dataSearchSplitContainer.Panel2.SuspendLayout();
            this.dataSearchSplitContainer.SuspendLayout();
            this.searchFlowLayoutPanel.SuspendLayout();
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
            this.mainSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.dataSearchSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(202)))), ((int)(((byte)(120)))));
            this.mainSplitContainer.Panel2.Controls.Add(this.crudSplitContainer);
            this.mainSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.mainSplitContainer.Panel2MinSize = 215;
            this.mainSplitContainer.Size = new System.Drawing.Size(900, 590);
            this.mainSplitContainer.SplitterDistance = 374;
            this.mainSplitContainer.SplitterWidth = 1;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // dataSearchSplitContainer
            // 
            this.dataSearchSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.dataSearchSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSearchSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.dataSearchSplitContainer.IsSplitterFixed = true;
            this.dataSearchSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.dataSearchSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.dataSearchSplitContainer.Name = "dataSearchSplitContainer";
            this.dataSearchSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // dataSearchSplitContainer.Panel1
            // 
            this.dataSearchSplitContainer.Panel1.Controls.Add(this.searchFlowLayoutPanel);
            // 
            // dataSearchSplitContainer.Panel2
            // 
            this.dataSearchSplitContainer.Panel2.Controls.Add(this.dataGridView);
            this.dataSearchSplitContainer.Size = new System.Drawing.Size(900, 374);
            this.dataSearchSplitContainer.SplitterDistance = 25;
            this.dataSearchSplitContainer.SplitterWidth = 1;
            this.dataSearchSplitContainer.TabIndex = 1;
            // 
            // searchFlowLayoutPanel
            // 
            this.searchFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.searchFlowLayoutPanel.Controls.Add(this.searchCategoryLabel);
            this.searchFlowLayoutPanel.Controls.Add(this.searchCategoryComboBox);
            this.searchFlowLayoutPanel.Controls.Add(this.searchValueLabel);
            this.searchFlowLayoutPanel.Controls.Add(this.searchValueTextBox);
            this.searchFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchFlowLayoutPanel.ForeColor = System.Drawing.Color.White;
            this.searchFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.searchFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchFlowLayoutPanel.Name = "searchFlowLayoutPanel";
            this.searchFlowLayoutPanel.Size = new System.Drawing.Size(900, 25);
            this.searchFlowLayoutPanel.TabIndex = 1;
            // 
            // searchCategoryLabel
            // 
            this.searchCategoryLabel.AutoSize = true;
            this.searchCategoryLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.searchCategoryLabel.Location = new System.Drawing.Point(3, 6);
            this.searchCategoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.searchCategoryLabel.Name = "searchCategoryLabel";
            this.searchCategoryLabel.Size = new System.Drawing.Size(97, 13);
            this.searchCategoryLabel.TabIndex = 0;
            this.searchCategoryLabel.Text = "Pretraga prema:";
            // 
            // searchCategoryComboBox
            // 
            this.searchCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCategoryComboBox.FormattingEnabled = true;
            this.searchCategoryComboBox.Location = new System.Drawing.Point(106, 2);
            this.searchCategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCategoryComboBox.Name = "searchCategoryComboBox";
            this.searchCategoryComboBox.Size = new System.Drawing.Size(190, 21);
            this.searchCategoryComboBox.TabIndex = 1;
            // 
            // searchValueLabel
            // 
            this.searchValueLabel.AutoSize = true;
            this.searchValueLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.searchValueLabel.Location = new System.Drawing.Point(302, 6);
            this.searchValueLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.searchValueLabel.Name = "searchValueLabel";
            this.searchValueLabel.Size = new System.Drawing.Size(61, 13);
            this.searchValueLabel.TabIndex = 2;
            this.searchValueLabel.Text = "Vrednost:";
            // 
            // searchValueTextBox
            // 
            this.searchValueTextBox.Location = new System.Drawing.Point(369, 3);
            this.searchValueTextBox.Name = "searchValueTextBox";
            this.searchValueTextBox.Size = new System.Drawing.Size(190, 20);
            this.searchValueTextBox.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(181)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(900, 348);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // crudSplitContainer
            // 
            this.crudSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.crudSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.crudSplitContainer.ForeColor = System.Drawing.Color.White;
            this.crudSplitContainer.Location = new System.Drawing.Point(0, 3);
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
            this.crudSplitContainer.Size = new System.Drawing.Size(900, 212);
            this.crudSplitContainer.SplitterDistance = 691;
            this.crudSplitContainer.TabIndex = 0;
            // 
            // inputControlsFlowLayoutPanel
            // 
            this.inputControlsFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.inputControlsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlsFlowLayoutPanel.ForeColor = System.Drawing.Color.White;
            this.inputControlsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.inputControlsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.inputControlsFlowLayoutPanel.Name = "inputControlsFlowLayoutPanel";
            this.inputControlsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.inputControlsFlowLayoutPanel.Size = new System.Drawing.Size(691, 212);
            this.inputControlsFlowLayoutPanel.TabIndex = 0;
            // 
            // buttonsFlowLayoutPanel
            // 
            this.buttonsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.buttonsFlowLayoutPanel.Controls.Add(this.updateButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.addNewButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.deleteButton);
            this.buttonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsFlowLayoutPanel.Name = "buttonsFlowLayoutPanel";
            this.buttonsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonsFlowLayoutPanel.Size = new System.Drawing.Size(205, 210);
            this.buttonsFlowLayoutPanel.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
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
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
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
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
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
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.mainSplitContainer);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "UCDataViewer";
            this.Size = new System.Drawing.Size(900, 590);
            this.Load += new System.EventHandler(this.UCDataViewer_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.dataSearchSplitContainer.Panel1.ResumeLayout(false);
            this.dataSearchSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchSplitContainer)).EndInit();
            this.dataSearchSplitContainer.ResumeLayout(false);
            this.searchFlowLayoutPanel.ResumeLayout(false);
            this.searchFlowLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.SplitContainer dataSearchSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel searchFlowLayoutPanel;
        private System.Windows.Forms.Label searchCategoryLabel;
        public System.Windows.Forms.ComboBox searchCategoryComboBox;
        private System.Windows.Forms.Label searchValueLabel;
        private System.Windows.Forms.TextBox searchValueTextBox;
    }
}
