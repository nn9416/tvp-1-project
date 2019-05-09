namespace tvp_1_project.View.UserControls.Input
{
    partial class UCTextInput
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
            this.textInputLabel = new System.Windows.Forms.Label();
            this.textInputTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textInputLabel
            // 
            this.textInputLabel.AutoSize = true;
            this.textInputLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.textInputLabel.ForeColor = System.Drawing.Color.White;
            this.textInputLabel.Location = new System.Drawing.Point(5, 0);
            this.textInputLabel.Name = "textInputLabel";
            this.textInputLabel.Size = new System.Drawing.Size(49, 15);
            this.textInputLabel.TabIndex = 0;
            this.textInputLabel.Text = "label1";
            // 
            // textInputTextBox
            // 
            this.textInputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(96)))), ((int)(((byte)(164)))));
            this.textInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInputTextBox.ForeColor = System.Drawing.Color.White;
            this.textInputTextBox.Location = new System.Drawing.Point(15, 19);
            this.textInputTextBox.Name = "textInputTextBox";
            this.textInputTextBox.Size = new System.Drawing.Size(180, 13);
            this.textInputTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 2);
            this.panel1.TabIndex = 2;
            // 
            // UCTextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(96)))), ((int)(((byte)(164)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textInputTextBox);
            this.Controls.Add(this.textInputLabel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Name = "UCTextInput";
            this.Size = new System.Drawing.Size(210, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textInputLabel;
        private System.Windows.Forms.TextBox textInputTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}
