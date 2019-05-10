using System;
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
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Presenter.TryLogin(Username, Password))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void SignupButton_Click(object sender, EventArgs e) => Presenter.ShowFRegistration();

        private void CloseLabel_Click(object sender, EventArgs e) => Close();
        #endregion
    }
}
