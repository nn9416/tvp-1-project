﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using tvp_1_project.BussinesLogic;
using tvp_1_project.Model;
using tvp_1_project.Presenter.Pages.Admin;
using tvp_1_project.View.UserControls.Input;

namespace tvp_1_project.View.Pages.Admin
{
    public partial class PageBookings : UserControl, IBookingsView
    {
        public PBookings Presenter { get; set; }

        public event EventHandler<CustomEventArgs> CrudButtonClick;

        public PageBookings()
        {
            InitializeComponent();
        }

        #region IBookingsView
        public void PopulateDataViewer(List<Booking> data)
        {
            UpdateDataViewer(data);
            ucDataViewer.InputControls = GenerateInputControls();
            ucDataViewer.PopulateInputControlsFlowLayoutPanel();
            ucDataViewer.UpdateInputControls();

            // Hide 'Id' and 'Display' columns
            ucDataViewer.DataGridView.Columns["Id"].Visible = false;
            ucDataViewer.DataGridView.Columns["Display"].Visible = false;
        }

        public void UpdateDataViewer(List<Booking> data) => ucDataViewer.DataGridView.DataSource = data;

        public void SetCustomersComboBox(List<Customer> customers)
        {
            SelectCustomer.ComboBox.DataSource = customers;
            SelectCustomer.ComboBox.DisplayMember = "Display";
            SelectCustomer.ComboBox.ValueMember = "Id";
        }

        public void SetCarsComboBox(List<Car> cars)
        {
            SelectCar.ComboBox.DataSource = cars;
            SelectCar.ComboBox.DisplayMember = "Display";
            SelectCar.ComboBox.ValueMember = "Id";
        }
        #endregion

        #region Events
        private void UcDataViewer_Load(object sender, EventArgs e)
        {
            Presenter.GetBookings();
            ucDataViewer.DataGridView.Columns["Customer"].HeaderText = "Korisnik";
            ucDataViewer.DataGridView.Columns["Car"].HeaderText = "Automobil";
            ucDataViewer.DataGridView.Columns["DateFrom"].HeaderText = "Datum preuzimanja";
            ucDataViewer.DataGridView.Columns["DateTo"].HeaderText = "Datum vraćanja";
            ucDataViewer.DataGridView.Columns["Price"].HeaderText = "Cena";
        }

        private void UcDataViewerButtons_Click(object sender, CustomEventArgs e)
        {
            Dictionary<string, object> values = new Dictionary<string, object>()
            {
                {"Customer", SelectCustomer.ComboBox.SelectedItem },
                {"Car", SelectCar.ComboBox.SelectedItem },
                {"DateFrom", DateFrom.DateTimePicker.Value.Date.ToString("dd.MM.yyyy.") },
                {"DateTo", DateTo.DateTimePicker.Value.Date.ToString("dd.MM.yyyy.") },
            };

            if (Presenter.TryCreateNew(values))
            {
                CrudButtonClick?.Invoke(sender, e);
                Presenter.UpdateData();
            }
            else
            {
                // TODO: Notify user that input is wrong
            }
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucDataViewer.DataGridView.DataSource = Presenter.GetBookingsForCustomer(SelectCustomer.ComboBox.SelectedItem as Customer);
        }

        private void CarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDataGridViewOffers(Presenter.GetOffersForCar(SelectCar.ComboBox.SelectedItem as Car));
            OffersDataGridView.Enabled = false;
        }
        #endregion

        private List<Control> GenerateInputControls()
        {
            SelectCustomer = new UCSelectInput() { LabelText = "Odaberite korisnika:" };
            SelectCar = new UCSelectInput() { LabelText = "Odaberite automobil:" };
            DateFrom = new UCDateSelect() { LabelText = "Unesite datum preuzimanja:" };
            DateTo = new UCDateSelect() { LabelText = "Unesite datum vraćanja:" };
            Price = new UCTextInput() { LabelText = "Ukupna cena:" };
            Price.TextBox.ReadOnly = true;

            SelectCustomer.ComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            SelectCar.ComboBox.SelectedIndexChanged += CarComboBox_SelectedIndexChanged;

            Presenter.UpdateCustomersComboBox();
            Presenter.UpdateCarsComboBox();

            return new List<Control>() {
                SelectCustomer,
                SelectCar,
                DateFrom,
                DateTo,
                Price
            };
        }

        public void PopulateDataGridViewOffers(List<Offer> data)
        {
            OffersDataGridView.DataSource = data;
            OffersDataGridView.ClearSelection();

            // DataGridViewOffers style
            OffersDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            OffersDataGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(22, 57, 98);
            OffersDataGridView.Columns["Id"].Visible = false;
            OffersDataGridView.Columns["Display"].Visible = false;

            OffersDataGridView.Columns["Car"].HeaderText = "Automobil";
            OffersDataGridView.Columns["DateFrom"].HeaderText = "Datum od";
            OffersDataGridView.Columns["DateTo"].HeaderText = "Datum do";
            OffersDataGridView.Columns["DayPrice"].HeaderText = "Cena za dan";
        }
        
        private DataGridView OffersDataGridView { get => offersDataGridView; }
        public UCSelectInput SelectCustomer { get; set; }
        public UCSelectInput SelectCar { get; set; }
        public UCDateSelect DateFrom { get; set; }
        public UCDateSelect DateTo { get; set; }
        public UCTextInput Price { get; set; }        
    }
}
