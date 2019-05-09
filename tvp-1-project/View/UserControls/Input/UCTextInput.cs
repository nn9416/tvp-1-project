using System.Windows.Forms;

namespace tvp_1_project.View.UserControls.Input
{
    public partial class UCTextInput : UserControl
    {
        public UCTextInput()
        {
            InitializeComponent();
        }

        public string TextInputLabelText { get => textInputLabel.Text; set => textInputLabel.Text = value; }
        public TextBox TextBox { get => textInputTextBox; }
        public bool IsPasswordField { get => textInputTextBox.UseSystemPasswordChar; set => textInputTextBox.UseSystemPasswordChar = value; }
    }
}
