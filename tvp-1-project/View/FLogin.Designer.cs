namespace tvp_1_project.View
{
    partial class FLogin
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameUcTextInput = new tvp_1_project.View.UserControls.Input.UCTextInput();
            this.passwordUcTextInput = new tvp_1_project.View.UserControls.Input.UCTextInput();
            this.loginButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.closeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 30);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(360, 187);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel.Controls.Add(this.usernameUcTextInput);
            this.flowLayoutPanel.Controls.Add(this.passwordUcTextInput);
            this.flowLayoutPanel.Controls.Add(this.loginButton);
            this.flowLayoutPanel.Controls.Add(this.button1);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(72, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(216, 181);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // usernameUcTextInput
            // 
            this.usernameUcTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.usernameUcTextInput.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.usernameUcTextInput.ForeColor = System.Drawing.Color.White;
            this.usernameUcTextInput.LabelText = "Korisničko ime:";
            this.usernameUcTextInput.Location = new System.Drawing.Point(3, 3);
            this.usernameUcTextInput.Name = "usernameUcTextInput";
            this.usernameUcTextInput.Size = new System.Drawing.Size(210, 45);
            this.usernameUcTextInput.TabIndex = 0;
            // 
            // passwordUcTextInput
            // 
            this.passwordUcTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.passwordUcTextInput.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.passwordUcTextInput.ForeColor = System.Drawing.Color.White;
            this.passwordUcTextInput.LabelText = "Lozinka:";
            this.passwordUcTextInput.Location = new System.Drawing.Point(3, 54);
            this.passwordUcTextInput.Name = "passwordUcTextInput";
            this.passwordUcTextInput.Size = new System.Drawing.Size(210, 45);
            this.passwordUcTextInput.TabIndex = 1;
            this.passwordUcTextInput.Load += new System.EventHandler(this.PasswordUcTextInput_Load);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(10, 105);
            this.loginButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(196, 30);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Prijavite se";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(10, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Napravite nalog";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Operator Mono Medium", 12F, System.Drawing.FontStyle.Bold);
            this.closeLabel.Location = new System.Drawing.Point(354, 8);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(18, 19);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(384, 220);
            this.ControlBox = false;
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.tableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private UserControls.Input.UCTextInput usernameUcTextInput;
        private UserControls.Input.UCTextInput passwordUcTextInput;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label closeLabel;
    }
}