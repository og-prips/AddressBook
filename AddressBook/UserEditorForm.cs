using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Metrics;
using System.Net.Mail;
using static System.Net.Mime.MediaTypeNames;
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

        public bool IsValidEmail(string email)
        {
            bool validEmail = true;
            string forbiddenLetters = "åäö";
            email = email.Trim();

            for (int i = 0; i < forbiddenLetters.Length; i++)
            {
                foreach (char c in email)
                {
                    if (c == forbiddenLetters[i])
                    {
                        return false;
                    }
                }
            }

            try
            {
                var emailAddress = new MailAddress(email);
                if (!emailAddress.Host.Contains('.') || emailAddress.ToString().Last().Equals('.'))
                {
                    return false;
                }
            }
            catch
            {
                validEmail = false;
            }

            return validEmail;
        }

        // Update the message label to tell user current status with specified text and backcolor
        private void UpdateMessage(string text, Color backColor)
        {
            lblMessage.Visible = true;
            lblMessage.Text = text;
            lblMessage.BackColor = backColor;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Either creates or updates a user, based on how the form is loaded
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

            if (!IsValidEmail(txtEmail.Text))
            {
                txtEmail.ForeColor = Color.Red;
                UpdateMessage("Epost i fel format!", Color.IndianRed);
            }
            else if (!txtName.Text.Contains(' '))
            {
                txtName.ForeColor = Color.Red;
                UpdateMessage("Var god fyll i för- och efternamn", Color.IndianRed);
            }
            else
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
                    user.Update();
                    UpdateMessage($"Användare {user.Name} blev uppdaterad!", Color.PaleGreen);
                }
            }
        }

        private void anyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(188))
            {
                e.SuppressKeyPress = true;
            }
            else
            {
                // Either sets forecolor or restricts letter input
                switch ((sender as TextBox).Name)
                {
                    case "txtEmail":
                        txtEmail.ForeColor = TextBox.DefaultForeColor;
                        break;

                    case "txtName":
                        txtName.ForeColor = TextBox.DefaultForeColor;
                        break;

                    case "txtPostalCode":
                        if (char.IsNumber((char)e.KeyValue) || e.KeyValue.Equals(' '))
                        {
                            e.SuppressKeyPress = false;
                        }
                        else
                        {
                            e.SuppressKeyPress = true;
                        }
                        break;

                    case "txtPhoneNumber":
                        if (char.IsNumber((char)e.KeyValue) || e.KeyValue.Equals(' ') || e.KeyValue.Equals('-'))
                        {
                            e.SuppressKeyPress = false;
                        }
                        else
                        {
                            e.SuppressKeyPress = true;
                        }
                        break;
                }
            }
        }
    }
}
