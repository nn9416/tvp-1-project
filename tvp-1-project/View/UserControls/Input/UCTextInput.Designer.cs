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
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.underLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 15);
            this.label.TabIndex = 0;
            this.label.Text = "Text Label";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(15, 19);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(180, 13);
            this.textBox.TabIndex = 1;
            this.textBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // underLine
            // 
            this.underLine.BackColor = System.Drawing.Color.DarkGray;
            this.underLine.ForeColor = System.Drawing.Color.White;
            this.underLine.Location = new System.Drawing.Point(10, 34);
            this.underLine.Name = "underLine";
            this.underLine.Size = new System.Drawing.Size(190, 2);
            this.underLine.TabIndex = 2;
            // 
            // UCTextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.underLine);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCTextInput";
            this.Size = new System.Drawing.Size(210, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel underLine;
    }
}
