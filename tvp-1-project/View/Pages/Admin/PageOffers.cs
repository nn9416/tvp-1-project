using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tvp_1_project.Model;
using tvp_1_project.Presenter.Pages.Admin;
using tvp_1_project.View.UserControls.Input;
using tvp_1_project.BussinesLogic;

namespace tvp_1_project.View.Pages.Admin
{
    public partial class PageOffers : UserControl, IOffersView
    {
        public event EventHandler<CustomEventArgs> CrudButtonClick;

        public PageOffers()
        {
            InitializeComponent();
        }

        #region IOffersView
        public POffers Presenter { get; set; }

        public void PopulateDataViewer(List<Offer> data)
        {
            UpdateDataViewer(data);
            ucDataViewer.InputControls = GenerateInputControls();
            ucDataViewer.PopulateInputControlsFlowLayoutPanel();
            ucDataViewer.UpdateInputControls();

            // Hide 'Id' and 'Display' columns
            ucDataViewer.DataGridView.Columns["Id"].Visible = false;
            ucDataViewer.DataGridView.Columns["Bookings"].Visible = false;
            ucDataViewer.DataGridView.Columns["Display"].Visible = false;
        }

        public void SetCarsComboBox(List<Car> cars)
        {
            Car.ComboBox.DataSource = cars;
            Car.ComboBox.DisplayMember = "Display";
            Car.ComboBox.ValueMember = "Id";
        }

        public void UpdateDataViewer(List<Offer> data) => ucDataViewer.DataGridView.DataSource = data;
        #endregion

        #region Events
        private void UcDataViewer_Load(object sender, EventArgs e)
        {
            Presenter.GetOffers();
            ucDataViewer.DataGridView.Columns["Car"].HeaderText = "Automobil";
            ucDataViewer.DataGridView.Columns["DateFrom"].HeaderText = "Datum od";
            ucDataViewer.DataGridView.Columns["DateTo"].HeaderText = "Datum do";
            ucDataViewer.DataGridView.Columns["DayPrice"].HeaderText = "Cena za dan";
        }

        private void UcDataViewerButtons_Click(object sender, CustomEventArgs e)
        {
            Dictionary<string, object> values = new Dictionary<string, object>()
            {
                { "Car", Car.ComboBox.SelectedItem as Car },
                { "DateFrom", DateFrom.DateTimePicker.Value.Date.Date.ToString("dd.MM.yyyy.") },
                { "DateTo", DateTo.DateTimePicker.Value.Date.ToString("dd.MM.yyyy.") },
                { "Price", Price.TextBox.Text }
            };

            if (Presenter.TryCreateNew(values))
            {
                CrudButtonClick?.Invoke(sender, e);
                Presenter.UpdateData();
            }
            else
            {
                // TODO: Notify user of wrong input
            }
        }
        #endregion

        private List<Control> GenerateInputControls()
        {
            Car = new UCSelectInput() { LabelText = "Odaberite automobil:" };
            DateFrom = new UCDateSelect() { LabelText = "Unesite početni datum ponude:" };
            DateTo = new UCDateSelect() { LabelText = "Unesite krajnji datum ponude:" };
            Price = new UCTextInput() { LabelText = "Unesite cenu za jedan dan:" };

            Presenter.UpdateCarsComboBox();

            return new List<Control>() {
                Car,
                DateFrom,
                DateTo,
                Price
            };
        }

        private UCSelectInput Car { get; set; }
        private UCDateSelect DateFrom { get; set; }
        private UCDateSelect DateTo { get; set; }
        private UCTextInput Price { get; set; }
    }
}
