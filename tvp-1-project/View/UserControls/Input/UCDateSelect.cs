using System;
using System.Windows.Forms;

namespace tvp_1_project.View.UserControls.Input
{
    public partial class UCDateSelect : UserControl
    {
        public UCDateSelect()
        {
            InitializeComponent();
            DateTimePicker.CustomFormat = "dd.MM.yyyy.";
        }
        
        public string LabelText { get => label.Text; set => label.Text = value; }
        public DateTimePicker DateTimePicker { get => dateTimePicker; }
    }
}
