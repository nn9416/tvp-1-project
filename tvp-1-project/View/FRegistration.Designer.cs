namespace tvp_1_project.View
{
    partial class FRegistration
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.firstNameUcTextInput = new tvp_1_project.View.UserControls.Input.UCTextInput();
            this.lastNameUcTextInput = new tvp_1_project.View.UserControls.Input.UCTextInput();
            this.ssnUcTextInput = new tvp_1_project.View.UserControls.Input.UCTextInput();
            this.birthDateUcDateSelect = new tvp_1_project.View.UserControls.Input.UCDateSelect();
            this.phoneUcTextInput = new tvp_1_project.View.UserControls.Input.UCTextInput();
            this.usernameUcTextInput = new tvp_1_project.View.UserControls.Input.UCTextInput();
            this.passwordUcTextInput = new tvp_1_project.View.UserControls.Input.UCTextInput();
            this.createUserButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.closeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 30);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(299, 448);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.Controls.Add(this.firstNameUcTextInput);
            this.flowLayoutPanel1.Controls.Add(this.lastNameUcTextInput);
            this.flowLayoutPanel1.Controls.Add(this.ssnUcTextInput);
            this.flowLayoutPanel1.Controls.Add(this.birthDateUcDateSelect);
            this.flowLayoutPanel1.Controls.Add(this.phoneUcTextInput);
            this.flowLayoutPanel1.Controls.Add(this.usernameUcTextInput);
            this.flowLayoutPanel1.Controls.Add(this.passwordUcTextInput);
            this.flowLayoutPanel1.Controls.Add(this.createUserButton);
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 442);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // firstNameUcTextInput
            // 
            this.firstNameUcTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.firstNameUcTextInput.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.firstNameUcTextInput.ForeColor = System.Drawing.Color.White;
            this.firstNameUcTextInput.LabelText = "Ime:";
            this.firstNameUcTextInput.Location = new System.Drawing.Point(3, 3);
            this.firstNameUcTextInput.Name = "firstNameUcTextInput";
            this.firstNameUcTextInput.Size = new System.Drawing.Size(210, 45);
            this.firstNameUcTextInput.TabIndex = 0;
            // 
            // lastNameUcTextInput
            // 
            this.lastNameUcTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.lastNameUcTextInput.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lastNameUcTextInput.ForeColor = System.Drawing.Color.White;
            this.lastNameUcTextInput.LabelText = "Prezime:";
            this.lastNameUcTextInput.Location = new System.Drawing.Point(3, 54);
            this.lastNameUcTextInput.Name = "lastNameUcTextInput";
            this.lastNameUcTextInput.Size = new System.Drawing.Size(210, 45);
            this.lastNameUcTextInput.TabIndex = 1;
            // 
            // ssnUcTextInput
            // 
            this.ssnUcTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.ssnUcTextInput.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ssnUcTextInput.ForeColor = System.Drawing.Color.White;
            this.ssnUcTextInput.LabelText = "JMBG:";
            this.ssnUcTextInput.Location = new System.Drawing.Point(3, 105);
            this.ssnUcTextInput.Name = "ssnUcTextInput";
            this.ssnUcTextInput.Size = new System.Drawing.Size(210, 45);
            this.ssnUcTextInput.TabIndex = 2;
            // 
            // birthDateUcDateSelect
            // 
            this.birthDateUcDateSelect.BackColor = System.Drawing.Color.Transparent;
            this.birthDateUcDateSelect.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.birthDateUcDateSelect.ForeColor = System.Drawing.Color.White;
            this.birthDateUcDateSelect.LabelText = "Datum rođenja:";
            this.birthDateUcDateSelect.Location = new System.Drawing.Point(3, 156);
            this.birthDateUcDateSelect.Name = "birthDateUcDateSelect";
            this.birthDateUcDateSelect.Size = new System.Drawing.Size(210, 45);
            this.birthDateUcDateSelect.TabIndex = 3;
            // 
            // phoneUcTextInput
            // 
            this.phoneUcTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.phoneUcTextInput.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.phoneUcTextInput.ForeColor = System.Drawing.Color.White;
            this.phoneUcTextInput.LabelText = "Telefon:";
            this.phoneUcTextInput.Location = new System.Drawing.Point(3, 207);
            this.phoneUcTextInput.Name = "phoneUcTextInput";
            this.phoneUcTextInput.Size = new System.Drawing.Size(210, 45);
            this.phoneUcTextInput.TabIndex = 4;
            // 
            // usernameUcTextInput
            // 
            this.usernameUcTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.usernameUcTextInput.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.usernameUcTextInput.ForeColor = System.Drawing.Color.White;
            this.usernameUcTextInput.LabelText = "Korisničko ime:";
            this.usernameUcTextInput.Location = new System.Drawing.Point(3, 258);
            this.usernameUcTextInput.Name = "usernameUcTextInput";
            this.usernameUcTextInput.Size = new System.Drawing.Size(210, 45);
            this.usernameUcTextInput.TabIndex = 5;
            // 
            // passwordUcTextInput
            // 
            this.passwordUcTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.passwordUcTextInput.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.passwordUcTextInput.ForeColor = System.Drawing.Color.White;
            this.passwordUcTextInput.LabelText = "Lozinka:";
            this.passwordUcTextInput.Location = new System.Drawing.Point(3, 309);
            this.passwordUcTextInput.Name = "passwordUcTextInput";
            this.passwordUcTextInput.Size = new System.Drawing.Size(210, 45);
            this.passwordUcTextInput.TabIndex = 6;
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.createUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.createUserButton.Location = new System.Drawing.Point(20, 360);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(176, 30);
            this.createUserButton.TabIndex = 7;
            this.createUserButton.Text = "Napravi nalog";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Location = new System.Drawing.Point(20, 396);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(176, 30);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Odustani";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Operator Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.closeLabel.Location = new System.Drawing.Point(293, 8);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(18, 19);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(323, 478);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(323, 478);
            this.MinimumSize = new System.Drawing.Size(323, 478);
            this.Name = "FRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRegistration";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRegistration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRegistration_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FRegistration_MouseUp);
            this.tableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControls.Input.UCTextInput firstNameUcTextInput;
        private UserControls.Input.UCTextInput lastNameUcTextInput;
        private UserControls.Input.UCTextInput ssnUcTextInput;
        private UserControls.Input.UCDateSelect birthDateUcDateSelect;
        private UserControls.Input.UCTextInput phoneUcTextInput;
        private UserControls.Input.UCTextInput usernameUcTextInput;
        private UserControls.Input.UCTextInput passwordUcTextInput;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label closeLabel;
    }
}