using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tvp_1_project.View
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Presenter.TryLogin(Username, Password))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            Presenter.ShowFRegistration();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
