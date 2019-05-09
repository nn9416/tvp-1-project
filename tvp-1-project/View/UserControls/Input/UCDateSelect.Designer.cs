namespace tvp_1_project.View.UserControls.Input
{
    partial class UCDateSelect
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(174)))), ((int)(((byte)(226)))));
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(98)))));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(10, 20);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // UCDateSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCDateSelect";
            this.Size = new System.Drawing.Size(210, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}
