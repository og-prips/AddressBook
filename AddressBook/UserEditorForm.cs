using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Metrics;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AddressBook
{
    public partial class UserEditorForm : Form
    {
        User user = new User();

        public UserEditorForm()
        {
            InitializeComponent();
            _toCreateUser = true;
        }

        public UserEditorForm(User selectedUser)
        {
            InitializeComponent();

            user = selectedUser;

            //temp
            lblGuid.Text = user.UserID.ToString();

            txtName.Text = user.Name;
            txtStreetAddress.Text = user.StreetAddress;
            txtPostalCode.Text = user.PostalCode;
            txtCounty.Text = user.County;
            txtPhoneNumber.Text = user.PhoneNumber;
            txtEmail.Text = user.Email;

            this.Text = "Uppdatera användare";
            btnAssign.Text = "Uppdatera";
        }

        private bool _toCreateUser;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.Text == String.Empty)
                {
                    UpdateMessage("Var god fyll i alla fält", Color.IndianRed); 
                    return;
                }
            }

            if (IsValidEmail(txtEmail.Text))
            {
                user.Name = txtName.Text;
                user.StreetAddress = txtStreetAddress.Text;
                user.PostalCode = txtPostalCode.Text;
                user.County = txtCounty.Text;
                user.PhoneNumber = txtPhoneNumber.Text;
                user.Email = txtEmail.Text;

                if (_toCreateUser)
                {


                    user.Create();
                    
                    foreach (TextBox textBox in this.Controls.OfType<TextBox>())
                    {
                        textBox.Text = String.Empty;
                    }

                    UpdateMessage($"Användare {user.Name} blev skapad!", Color.PaleGreen);
                }
                else
                {
                    FileHandler fileHandler = new FileHandler();
                    fileHandler.UpdateRow(user);
                    //user.Update();
                    UpdateMessage($"Användare {user.Name} blev uppdaterad!", Color.PaleGreen);
                }
            }
            else
            {
                txtEmail.ForeColor = Color.Red;
                UpdateMessage("Epost i fel format!", Color.IndianRed);
            }
        }

        bool IsValidEmail(string email)
        {
            var validEmail = true;
            //email.
            //if (email.Substring(email.IndexOf("@") + 1, email.Length - 1) == "@")

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                validEmail = false;
            }

            return validEmail;
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            txtEmail.ForeColor = TextBox.DefaultForeColor;
        }

        private void UpdateMessage(string text, Color backColor)
        {
            lblMessage.Visible = true;
            lblMessage.Text = text;
            lblMessage.BackColor = backColor;
        }
    }
}
