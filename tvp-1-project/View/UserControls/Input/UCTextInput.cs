using System.Windows.Forms;

namespace tvp_1_project.View.UserControls.Input
{
    public partial class UCTextInput : UserControl
    {
        public UCTextInput()
        {
            InitializeComponent();
        }

        public string LabelText { get => label.Text; set => label.Text = value; }
        public TextBox TextBox { get => textBox; }
    }
}
