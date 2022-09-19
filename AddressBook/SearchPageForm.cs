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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AddressBook\\users.txt");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = txtSearchCriteria.Text.ToLower();
            List<string> matches = fileHandler.ReadAllRowsFromFile(searchCriteria);

            dataGridAddresses.Rows.Clear();

            if (txtSearchCriteria.Text.Equals(string.Empty))
            {
                UpdateAddressGrid();
            }
            else
            {
                UpdateAddressGrid(matches);
            }
        }

        private void UpdateAddressGrid()
        {
            List<string> addresses = fileHandler.ReadAllRowsFromFile();

            foreach (string address in addresses)
            {
                dataGridAddresses.Rows.Add(address.Split(','));
            }
        }

        private void UpdateAddressGrid(List<string> addresses)
        {
            foreach (string adress in addresses)
            {
                dataGridAddresses.Rows.Add(adress.Split(','));
            }
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
