using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tvp_1_project.View.UserControls.Input
{
    public partial class UCSelectInput : UserControl
    {
        public event EventHandler SelectionChanged;
        public UCSelectInput()
        {
            InitializeComponent();
        }

        #region Events
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionChanged?.Invoke(sender, e);
        }
        #endregion

        public string LabelText { get => label.Text; set => label.Text = value; }
        public ComboBox ComboBox { get => comboBox; }
    }
}
