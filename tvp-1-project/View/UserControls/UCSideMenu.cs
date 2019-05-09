using System;
using System.Windows.Forms;

namespace tvp_1_project.View.UserControls
{
    public partial class UCSideMenu : UserControl
    {
        public event EventHandler ButtonClick;

        public UCSideMenu()
        {
            InitializeComponent();
        }

        public void HideButtons(bool isAdmin)
        {
            if (isAdmin)
            {
                adminFlowLayoutPanel.Visible = true;
                customerFlowLayoutPanel.Visible = false;
            }
            else
            {
                adminFlowLayoutPanel.Visible = false;
                customerFlowLayoutPanel.Visible = true;
            }
        }

        protected void Button_Click(object sender, EventArgs e) => ButtonClick?.Invoke(sender, e);

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
