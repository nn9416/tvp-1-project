using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tvp_1_project.Model;
using tvp_1_project.Presenter.Pages.Admin;
using tvp_1_project.BussinesLogic;
using tvp_1_project.View.UserControls.Input;

namespace tvp_1_project.View.Pages.Admin
{
    public partial class PageCustomers : UserControl, ICustomersView
    {
        public event EventHandler<CustomEventArgs> CrudButtonClick;

        public PageCustomers()
        {
            InitializeComponent();
        }

        #region ICustomersView
        public PCustomers Presenter { get; set; }

        public void PopulateDataViewer(List<Customer> data)
        {
            UpdateDataViewer(data);
            ucDataViewer.InputControls = GenerateInputControls();
            ucDataViewer.PopulateInputControlsFlowLayoutPanel();
            ucDataViewer.UpdateInputControls();

            // Hide 'Id' and 'Display' columns
            ucDataViewer.DataGridView.Columns["Id"].Visible = false;
            ucDataViewer.DataGridView.Columns["Display"].Visible = false;
        }

        public void UpdateDataViewer(List<Customer> data) => ucDataViewer.DataGridView.DataSource = data;
        #endregion

        #region Events
        private void UcDataViewer_Load(object sender, EventArgs e)
        {
            Presenter.GetCustomers();
            ucDataViewer.DataGridView.Columns["FirstName"].HeaderText = "Ime";
            ucDataViewer.DataGridView.Columns["LastName"].HeaderText = "Prezime";
            ucDataViewer.DataGridView.Columns["Ssn"].HeaderText = "JMBG";
            ucDataViewer.DataGridView.Columns["BirthDate"].HeaderText = "Datum rođenja";
            ucDataViewer.DataGridView.Columns["PhoneNumber"].HeaderText = "Broj telefona";
            ucDataViewer.DataGridView.Columns["Username"].HeaderText = "Korisničko ime";
            ucDataViewer.DataGridView.Columns["Password"].HeaderText = "Lozinka";
            ucDataViewer.SetSearchCategoriesComboBox();
        }

        private void UcDataViewerButtons_Click(object sender, CustomEventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>()
            {
                {"FirstName", FirstName.TextBox.Text },
                {"LastName", LastName.TextBox.Text },
                {"Ssn", Ssn.TextBox.Text },
                {"BirthDate", BirthDate.DateTimePicker.Value.Date.ToString("dd.MM.yyyy.") },
                {"PhoneNumber", PhoneNumber.TextBox.Text },
                {"Username", Username.TextBox.Text },
                {"Password", Password.TextBox.Text }
            };

            if (Presenter.TryCreateNew(values))
            {
                CrudButtonClick?.Invoke(sender, e);
                Presenter.UpdateData();
            }
            else
            {
                // TODO: Notify user of wrong inputs
            }
        }
        #endregion

        private List<Control> GenerateInputControls()
        {
            FirstName = new UCTextInput() { LabelText = "Unesite ime:" };
            LastName = new UCTextInput() { LabelText = "Unesite prezime:" };
            Ssn = new UCTextInput() { LabelText = "Unesite JMBG:" };
            BirthDate = new UCDateSelect() { LabelText = "Unesite datum rođenja:" };
            PhoneNumber = new UCTextInput() { LabelText = "Unesite broj telefona:" };
            Username = new UCTextInput() { LabelText = "Unesite korisničko ime:" };
            Password = new UCTextInput() { LabelText = "Unesite lozinku:" };

            return new List<Control>() {
                FirstName,
                LastName,
                Ssn,
                BirthDate,
                PhoneNumber,
                Username,
                Password
            };
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private UCTextInput FirstName { get; set; }
        private UCTextInput LastName { get; set; }
        private UCTextInput Ssn { get; set; }
        private UCDateSelect BirthDate { get; set; }
        private UCTextInput PhoneNumber { get; set; }
        private UCTextInput Username { get; set; }
        private UCTextInput Password { get; set; }
    }
}
