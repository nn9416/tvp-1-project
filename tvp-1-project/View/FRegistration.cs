using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using tvp_1_project.Presenter;

namespace tvp_1_project.View
{
    public partial class FRegistration : Form, IRegistrationView
    {
        public FRegistration()
        {
            InitializeComponent();            
        }

        #region IRegistrationView
        public PRegistration Presenter { get; set; }

        public string FirstName => firstNameUcTextInput.TextBox.Text;

        public string LastName => lastNameUcTextInput.TextBox.Text;

        public string Ssn => ssnUcTextInput.TextBox.Text;

        public DateTime BirthDate => birthDateUcDateSelect.DateTimePicker.Value;

        public string PhoneNumber => phoneUcTextInput.TextBox.Text;

        public string Username => usernameUcTextInput.TextBox.Text;

        public string Password => passwordUcTextInput.TextBox.Text;

        public void RegistrationProcessInfo(bool success)
        {
            if (success)
            {
                // TODO: Notify user that account is successfully created and close form
            } else
            {
                // TODO: Notify user which fields failed validation

            }
        }
        #endregion

        #region Events
        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>()
            {
                {"FirstName", FirstName },
                {"LastName", LastName },
                {"Ssn", Ssn },
                {"BirthDate", BirthDate.Date.ToString("dd.MM.yyyy.") },
                {"PhoneNumber", PhoneNumber },
                {"Username", Username },
                {"Password", Password }
            };

            RegistrationProcessInfo(Presenter.TryCreateNew(values));
        }

        private void Cancel_Click(object sender, EventArgs e) => Close();

        #region Form custom title bar events
        private void CloseLabel_MouseEnter(object sender, EventArgs e) => closeLabel.ForeColor = Color.FromArgb(239, 89, 111);

        private void CloseLabel_MouseLeave(object sender, EventArgs e) => closeLabel.ForeColor = Color.White;
        #endregion
        #region Move form without borders
        private bool mouseDown;
        private Point lastLocation;

        private void FRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void FRegistration_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;
        #endregion
        #endregion
    }
}
