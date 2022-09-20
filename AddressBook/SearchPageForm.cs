using System.Text.RegularExpressions;

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
            lstBoxUserInfo.Items.Clear();
            comboBoxSearchCriteria.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            User user = new User();
            user.UserID = Guid.Parse(dataGridAddresses.CurrentRow.Cells[0].Value.ToString());

            user.Delete();

            UpdateAddressGrid();
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            lstBoxUserInfo.Items.Clear();

            for (int i = 1; i < dataGridAddresses.ColumnCount; i++)
            {
                lstBoxUserInfo.Items.Add($"{dataGridAddresses.Columns[i].HeaderText}: {dataGridAddresses.CurrentRow.Cells[i].Value.ToString()}");
            }
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateAddressGrid()
        {
            List<string> addresses = fileHandler.GetAllRowsFromFile();
            
            dataGridAddresses.Rows.Clear();

            foreach (string address in addresses)
            {
                dataGridAddresses.Rows.Add(address.Split(','));
            }
        }

        private void UpdateAddressGrid(List<string> addresses)
        {
            dataGridAddresses.Rows.Clear();

            foreach (string adress in addresses)
            {
                dataGridAddresses.Rows.Add(adress.Split(','));
            }
        }

        private void comboBoxSearchCriteria_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowColumn(comboBoxSearchCriteria.SelectedIndex + 1);
        }

        private void ShowColumn(int index)
        {
            // Hide all columns except for 'Namn'
            for (int i = 2; i < dataGridAddresses.Columns.Count; i++)
            {
                dataGridAddresses.Columns[i].Visible = false;
            }

            dataGridAddresses.Columns[index].Visible = true;
        }
    }
}
