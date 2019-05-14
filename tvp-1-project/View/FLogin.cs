using System;
using System.Drawing;
using System.Windows.Forms;

namespace tvp_1_project.View
{
    public partial class FLogin : Form, ILoginView
    {       
        public FLogin()
        {
            InitializeComponent();
        }

        #region ILoginView
        public Presenter.PLogin Presenter { get; set; }

        public string Username { get => usernameUcTextInput.TextBox.Text; }

        public string Password { get => passwordUcTextInput.TextBox.Text; }
        #endregion

        #region Events
        private void PasswordUcTextInput_Load(object sender, EventArgs e)
        {
            passwordUcTextInput.TextBox.UseSystemPasswordChar = true;
            passwordUcTextInput.TextBox.BackColor = Color.FromArgb(33, 37, 43);
            usernameUcTextInput.TextBox.BackColor = Color.FromArgb(33, 37, 43);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Presenter.TryLogin(Username, Password))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void SignupButton_Click(object sender, EventArgs e) => Presenter.ShowFRegistration();

        #region Form custom title bar events
        private void CloseLabel_Click(object sender, EventArgs e) => Close();
        private void CloseLabel_MouseEnter(object sender, EventArgs e) => closeLabel.ForeColor = Color.FromArgb(239, 89, 111);
        private void CloseLabel_MouseLeave(object sender, EventArgs e) => closeLabel.ForeColor = Color.White;
        #endregion
        #endregion
    }
}
