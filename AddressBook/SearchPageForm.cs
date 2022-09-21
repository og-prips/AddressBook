using System.Diagnostics;

namespace AddressBook
{
    public partial class SearchPageForm : Form
    {
        UserEditorForm userEditorForm;
        FileHandler fileHandler = new FileHandler();

        public SearchPageForm()
        {
            InitializeComponent();
            UpdateAddressGrid();
            comboBoxSearchCriteria.SelectedIndex = 0;
        }

        // Shows the column of specified index in datagrid
        private void ShowColumn(int index)
        {
            // Hide all columns except for Name Column
            for (int i = 2; i < dataGridAddresses.Columns.Count; i++)
            {
                dataGridAddresses.Columns[i].Visible = false;
            }

            dataGridAddresses.Columns[index].Visible = true;
        }

        // Search for user and update datagrid
        private void SearchUser()
        {
            string searchText = txtSearch.Text.ToLower();
            List<string> matches = fileHandler.GetRowFromSearchCritera(searchText, comboBoxSearchCriteria.SelectedIndex + 1);

            if (txtSearch.Text.Equals(" "))
            {
                UpdateAddressGrid();
            }
            else
            {
                UpdateAddressGrid(matches);
            }
        }

        // Update address grid with all rows from file
        private void UpdateAddressGrid()
        {
            //_hasClearedDataGrid = true;
            List<string> addresses = fileHandler.GetAllRowsFromFile();

            dataGridAddresses.Rows.Clear();
            Debug.Print($"rowcount: {dataGridAddresses.RowCount}");

            foreach (string address in addresses)
            {
                dataGridAddresses.Rows.Add(address.Split(','));
            }
        }

        // Update address grid with specified list
        private void UpdateAddressGrid(List<string> addresses)
        {
            dataGridAddresses.Rows.Clear();

            foreach (string adress in addresses)
            {
                dataGridAddresses.Rows.Add(adress.Split(','));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            userEditorForm = new UserEditorForm();
            userEditorForm.ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            
            string guid = dataGridAddresses.CurrentRow.Cells[0].Value.ToString();
            User user = new User(Guid.Parse(dataGridAddresses.CurrentRow.Cells[0].Value.ToString()),
                                            dataGridAddresses.CurrentRow.Cells[1].Value.ToString(),
                                            dataGridAddresses.CurrentRow.Cells[2].Value.ToString(),
                                            dataGridAddresses.CurrentRow.Cells[3].Value.ToString(),
                                            dataGridAddresses.CurrentRow.Cells[4].Value.ToString(),
                                            dataGridAddresses.CurrentRow.Cells[5].Value.ToString(),
                                            dataGridAddresses.CurrentRow.Cells[6].Value.ToString());

            userEditorForm = new UserEditorForm(user);
            userEditorForm.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show($"Vill du verkligen radera {dataGridAddresses.CurrentRow.Cells[1].Value}?", "Radera användare", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2))
            {
                User user = new User();
                user.UserID = Guid.Parse(dataGridAddresses.CurrentRow.Cells[0].Value.ToString());

                user.Delete();

                UpdateAddressGrid();
            }

        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxSearchCriteria_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowColumn(comboBoxSearchCriteria.SelectedIndex + 1);
        }

        private void dataGridAddresses_SelectionChanged(object sender, EventArgs e)
        {
            dataGridUserInfo.Rows.Clear();

            for (int i = 1; i < dataGridAddresses.ColumnCount; i++)
            {
                string userInfo = $"{dataGridAddresses.Columns[i].HeaderText},{dataGridAddresses.CurrentRow.Cells[i].Value.ToString()}";

                dataGridUserInfo.Rows.Add(userInfo.Split(','));
            }
        }

        private void dataGridUserInfo_SelectionChanged(object sender, EventArgs e)
        {
            dataGridUserInfo.ClearSelection();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchUser();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(','))
            {
                e.Handled = true;
            }

            //if (e.KeyChar.Equals(Keys.Enter))
            //{
            //    MessageBox.Show("tjo");
            //}
        }
    }
}
