using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tvp_1_project.Model;
using tvp_1_project.Presenter.Pages.Admin;
using tvp_1_project.BussinesLogic;
using tvp_1_project.View.UserControls.Input;

namespace tvp_1_project.View.Pages.Admin
{
    public partial class PageCars : UserControl, ICarsView
    {
        public event EventHandler<CustomEventArgs> CrudButtonClick;

        public PageCars()
        {
            InitializeComponent();
        }

        #region ICarsView
        public PCars Presenter { get; set; }

        public void PopulateDataViewer(List<Car> data)
        {
            UpdateDataViewer(data);
            ucDataViewer.InputControls = GenerateInputControls();
            ucDataViewer.PopulateInputControlsFlowLayoutPanel();
            ucDataViewer.UpdateInputControls();

            // Hide 'Id' and 'Display' columns
            ucDataViewer.DataGridView.Columns["Id"].Visible = false;
            ucDataViewer.DataGridView.Columns["Display"].Visible = false;
        }

        public void UpdateDataViewer(List<Car> data)
        {
            ucDataViewer.DataGridView.DataSource = data;
        }
        #endregion

        #region Events
        private void UcDataViewer_Load(object sender, EventArgs e)
        {
            Presenter.GetCars();
            ucDataViewer.DataGridView.Columns["ProductionYear"].HeaderText = "Godina proizvodnje";
            ucDataViewer.DataGridView.Columns["Make"].HeaderText = "Proizvođač";
            ucDataViewer.DataGridView.Columns["Displacement"].HeaderText = "Kubikaža";
            ucDataViewer.DataGridView.Columns["Fuel"].HeaderText = "Gorivo";
            ucDataViewer.DataGridView.Columns["Drive"].HeaderText = "Pogon";
            ucDataViewer.DataGridView.Columns["Transmission"].HeaderText = "Menjač";
            ucDataViewer.DataGridView.Columns["Body"].HeaderText = "Karoserija";
            ucDataViewer.DataGridView.Columns["NumberOfDoors"].HeaderText = "Broj vrata";
            SetSearchCategoriesComboBox();
        }

        private void UcDataViewerButtons_Click(object sender, CustomEventArgs e)
        {
            CrudButtonClick?.Invoke(sender, e);
            Presenter.UpdateData();
        }

        private void SelectYearComboBox_SelectionChanged(object sender, EventArgs e)
        {
            SelectMake.ComboBox.DataSource = Presenter.SetMakes(((ComboBox)sender).Text);
        }

        private void SelectMakeComboBox_SelectionChanged(object sender, EventArgs e)
        {
            SelectModel.ComboBox.DataSource = Presenter.SetModels(((ComboBox)sender).Text);
        }

        private void SelectModelComboBox_SelectionChanged(object sender, EventArgs e)
        {
            SelectDisplacement.ComboBox.DataSource = Presenter.SetDisplacement(((ComboBox)sender).Text);
            SelectFuel.ComboBox.DataSource = Presenter.SetFuel(((ComboBox)sender).Text);
            SelectDrive.ComboBox.DataSource = Presenter.SetDrive(((ComboBox)sender).Text);
            SelectTransmission.ComboBox.DataSource = Presenter.SetTransmission(((ComboBox)sender).Text);
            SelectBody.ComboBox.DataSource = Presenter.SetBody(((ComboBox)sender).Text);
            SelectNumberOfDoors.ComboBox.DataSource = Presenter.SetNumberOfDoors(((ComboBox)sender).Text);
        }
        #endregion

        private List<Control> GenerateInputControls()
        {
            SelectYear = new UCSelectInput() { LabelText = "Odaberite godinu:" };
            SelectMake = new UCSelectInput() { LabelText = "Odaberite marku:" };
            SelectModel = new UCSelectInput() { LabelText = "Odaberite model:" };
            SelectDisplacement = new UCSelectInput() { LabelText = "Odaberite kubikazu:" };
            SelectFuel = new UCSelectInput() { LabelText = "Odaberite gorivo:" };
            SelectDrive = new UCSelectInput() { LabelText = "Odaberite pogon:" };
            SelectTransmission = new UCSelectInput() { LabelText = "Odaberite menjač:" };
            SelectBody = new UCSelectInput() { LabelText = "Odaberite karoseriju:" };
            SelectNumberOfDoors = new UCSelectInput() { LabelText = "Odaberite broj vrata:" };

            SelectYear.ComboBox.DataSource = Presenter.GetYears();

            SelectYear.SelectionChanged += SelectYearComboBox_SelectionChanged;
            SelectMake.SelectionChanged += SelectMakeComboBox_SelectionChanged;
            SelectModel.SelectionChanged += SelectModelComboBox_SelectionChanged;            

            return new List<Control>() {
                SelectYear,
                SelectMake,
                SelectModel,
                SelectDisplacement,
                SelectFuel,
                SelectDrive,
                SelectTransmission,
                SelectBody,
                SelectNumberOfDoors
            };
        }

        private void SetSearchCategoriesComboBox()
        {                     
            ucDataViewer.SearchCategoryComboBox.DisplayMember = "HeaderText";
            ucDataViewer.SearchCategoryComboBox.ValueMember = "Name";
            ucDataViewer.SearchCategoryComboBox.DataSource = ucDataViewer.DataGridView.Columns;
        }

        private UCSelectInput SelectYear { get; set; }
        private UCSelectInput SelectMake { get; set; }
        private UCSelectInput SelectModel { get; set; }
        private UCSelectInput SelectDisplacement { get; set; }
        private UCSelectInput SelectFuel { get; set; }
        private UCSelectInput SelectDrive { get; set; }
        private UCSelectInput SelectTransmission { get; set; }
        private UCSelectInput SelectBody { get; set; }
        private UCSelectInput SelectNumberOfDoors { get; set; }
    }
}
