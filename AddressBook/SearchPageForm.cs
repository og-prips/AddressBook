namespace AddressBook
{
    public partial class SearchPageForm : Form
    {
        UserEditorForm userEditorForm;

        public SearchPageForm()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            userEditorForm = new UserEditorForm();
            userEditorForm.ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User user = new User("bengt", "aa", "bb", "cc", "123", "bengt@me.com");

            userEditorForm = new UserEditorForm(user);
            userEditorForm.ShowDialog();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileHandler fileHandler = new FileHandler();
            List<string> addresses = fileHandler.ReadAllRowsFromFile();
            
            foreach (string address in addresses)
            {
                string[] addressValues = address.Split(',');

                dataGridAddresses.Rows.Add(addressValues);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AddressBook\\users.txt");
        }
    }
}
