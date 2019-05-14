using System.Drawing;
using System.Windows.Forms;

namespace tvp_1_project.View.UserControls.Input
{
    public partial class UCTextInput : UserControl
    {
        public UCTextInput()
        {
            InitializeComponent();
        }

        private void TextBox_Enter(object sender, System.EventArgs e) => underLine.BackColor = Color.White;

        private void TextBox_Leave(object sender, System.EventArgs e) => underLine.BackColor = Color.DarkGray;

        public string LabelText { get => label.Text; set => label.Text = value; }
        public TextBox TextBox { get => textBox; }        
    }
}
