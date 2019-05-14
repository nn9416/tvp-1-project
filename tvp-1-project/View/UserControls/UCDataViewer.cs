using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using tvp_1_project.View.UserControls.Input;
using tvp_1_project.BussinesLogic;

namespace tvp_1_project.View.UserControls
{
    public partial class UCDataViewer : UserControl
    {
        private object selectedObject;
        private string currentTypeOfObject;
        private bool isAddNewMode;

        public event EventHandler LoadDataView;
        public event EventHandler<CustomEventArgs> ButtonClick;

        public UCDataViewer()
        {
            InitializeComponent();
            AddButtonEvents();
            isAddNewMode = false;
        }

        #region Events
        private void UCDataViewer_Load(object sender, EventArgs e)
        {
            LoadDataView?.Invoke(sender, e);
            
            if (DataGridView.Rows.Count == 0)
            {
                isAddNewMode = true;
                ToggleAddNewMode(isAddNewMode);
            }            
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.Rows.Count > 0 && DataGridView.SelectedRows.Count > 0)
            {
                selectedObject = dataGridView.SelectedRows[0].DataBoundItem;
                UpdateInputControls();
                isAddNewMode = false;
                ToggleAddNewMode(isAddNewMode);
            }
            else
            {
                selectedObject = null;
                isAddNewMode = true;
                ToggleAddNewMode(isAddNewMode);
            }
        }

        private void Button_Click(object sender, CustomEventArgs e)
        {
            Button button = sender as Button;
            // Get type of object from DataGridView DataSource that we need to create
            currentTypeOfObject = ListBindingHelper.GetListItemType(dataGridView.DataSource).ToString();

            if (button.Tag.ToString().Equals("AddNew"))
            {
                isAddNewMode = true;
                ToggleAddNewMode(isAddNewMode);
                return;
            }
            else if (button.Tag.ToString().Equals("Create"))
            {
                selectedObject = Activator.CreateInstance(Type.GetType(currentTypeOfObject), GetAllParametersFromInputControls());
            }
            else if (button.Tag.ToString().Equals("Update"))
            {
                // Get 'Id' of current selection from DataGridView so we could find object with that 'Id' in records and update it
                string id = selectedObject.GetType().GetProperty("Id").GetValue(selectedObject).ToString();
                // Create list that contains 'Id' of selected object and all the params from input controls
                List<object> objectParameters = new List<object> { id };
                objectParameters.AddRange(GetAllParametersFromInputControls());
                try
                {
                    selectedObject = Activator.CreateInstance(Type.GetType(currentTypeOfObject), objectParameters.ToArray());
                }
                catch
                {
                    UpdateInputControls();
                }
            }
            ButtonClick?.Invoke(sender, new CustomEventArgs(selectedObject));
            isAddNewMode = false;
            ToggleAddNewMode(isAddNewMode);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.Rows.Count > 0)
            {
                if (isAddNewMode)
                {
                    isAddNewMode = false;
                    ToggleAddNewMode(isAddNewMode);
                }
                DataGridView.Rows[0].Selected = true;
                UpdateInputControls();
            }
            else
            {
                selectedObject = null;
                ClearInputControls();
            }
        }

        private void SearchValueTextBox_TextChanged(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn temp = searchCategoryComboBox.SelectedValue as DataGridViewTextBoxColumn;
            try
            {
                foreach (DataGridViewRow row in DataGridView.Rows)
                {
                    if (row.Cells[$"{temp.Name}"].Value.ToString().ToLower().Contains(searchValueTextBox.Text.ToLower()))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        internal void PopulateInputControlsFlowLayoutPanel() => InputControlsFlowLayoutPanel.Controls.AddRange(InputControls.ToArray());

        internal void AddButtonEvents()
        {
            foreach (Button button in buttonsFlowLayoutPanel.Controls.OfType<Button>())
            {
                if (!button.Tag.ToString().Equals("Cancel"))
                    button.Click += (sender, e) => Button_Click(sender, e as CustomEventArgs);
            }
        }

        private void ToggleAddNewMode(bool isAddNewMode)
        {
            if (isAddNewMode)
            {
                addNewButton.Enabled = deleteButton.Enabled = false;
                updateButton.Tag = "Create";
                DataGridView.ClearSelection();                
                ClearInputControls();
                DataGridView.Enabled = false;
                dataSearchSplitContainer.Panel1Collapsed = true;
                mainSplitContainer.Panel2.BackColor = Color.FromArgb(97, 175, 239);
            }
            else
            {
                addNewButton.Enabled = deleteButton.Enabled = true;
                updateButton.Tag = "Update";
                DataGridView.Enabled = true;
                dataSearchSplitContainer.Panel1Collapsed = false;
                mainSplitContainer.Panel2.BackColor = Color.FromArgb(137, 202, 120);
            }
        }

        private object[] GetAllParametersFromInputControls()
        {
            List<object> parameters = new List<object>();

            foreach (Control control in InputControlsFlowLayoutPanel.Controls)
            {
                if (control is UCSelectInput)
                {
                    UCSelectInput uCSelect = control as UCSelectInput;
                    parameters.Add(uCSelect.ComboBox.SelectedItem);
                }
                else if (control is UCTextInput)
                {
                    UCTextInput uCTextInput = control as UCTextInput;
                    if (!uCTextInput.TextBox.ReadOnly)
                        parameters.Add(uCTextInput.TextBox.Text);
                }
                else if (control is UCDateSelect)
                {
                    UCDateSelect uCDatePicker = control as UCDateSelect;
                    parameters.Add(uCDatePicker.DateTimePicker.Value);
                }
            }

            return parameters.ToArray();
        }

        public void UpdateInputControls()
        {
            List<string> values = new List<string>();

            if (DataGridView.Rows.Count > 0)
            {
                // MultipleSelect for DataGridView is disabled so there is only one selectedRow
                DataGridViewRow selectedRow = DataGridView.SelectedRows[0];

                // valueCounter starts from one because we don't have controls for 'Id' (values.ElementAt(0)) values
                int valueCounter = 1;

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    values.Add(cell.Value.ToString());
                }

                foreach (Control control in InputControlsFlowLayoutPanel.Controls)
                {
                    if (control is UCSelectInput)
                    {
                        UCSelectInput uCSelect = control as UCSelectInput;
                        uCSelect.ComboBox.SelectedItem = values.ElementAt(valueCounter++);
                    }
                    else if (control is UCTextInput)
                    {
                        UCTextInput uCTextInput = control as UCTextInput;
                        uCTextInput.TextBox.Text = values.ElementAt(valueCounter++);
                    }
                    else if (control is UCDateSelect)
                    {
                        UCDateSelect uCDatePicker = control as UCDateSelect;
                        uCDatePicker.DateTimePicker.Value = DateTime.Parse(values.ElementAt(valueCounter++), CultureInfo.InvariantCulture);
                    }
                }
            }
        }

        private void ClearInputControls()
        {
            foreach (Control control in InputControlsFlowLayoutPanel.Controls)
            {
                if (control is UCSelectInput)
                {
                    UCSelectInput uCSelect = control as UCSelectInput;
                    uCSelect.ComboBox.SelectedIndex = 0;
                }
                else if (control is UCTextInput)
                {
                    UCTextInput uCTextInput = control as UCTextInput;
                    uCTextInput.TextBox.Text = "";
                }
                else if (control is UCDateSelect)
                {
                    UCDateSelect uCDatePicker = control as UCDateSelect;
                    uCDatePicker.DateTimePicker.Value = DateTime.Now;
                }
            }
        }

        public void SetSearchCategoriesComboBox()
        {
            DataGridViewColumn[] arrayOfColumns = new DataGridViewColumn[DataGridView.Columns.Count];
            List<DataGridViewColumn> listOfColumns = new List<DataGridViewColumn>();
            DataGridView.Columns.CopyTo(arrayOfColumns, 0);

            foreach (DataGridViewColumn column in arrayOfColumns)
            {
                if (column.HeaderText != "Id" && column.HeaderText != "Display" && column.HeaderText != "Lozinka")
                    listOfColumns.Add(column);
            }

            SearchCategoryComboBox.DisplayMember = "HeaderText";
            SearchCategoryComboBox.ValueMember = "Name";
            SearchCategoryComboBox.DataSource = listOfColumns;
        }        

        public DataGridView DataGridView { get => dataGridView; }
        public ComboBox SearchCategoryComboBox { get => searchCategoryComboBox; }
        public TextBox SearchValueTextBox { get => searchValueTextBox; }
        public FlowLayoutPanel InputControlsFlowLayoutPanel { get => inputControlsFlowLayoutPanel; }
        public List<Control> InputControls { get; set; }                
    }
}
