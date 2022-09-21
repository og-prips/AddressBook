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

        private bool IsValidEmail(string email)
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

        // Either creates or updates a user, based on how the form is loaded
        private void btnAssign_Click(object sender, EventArgs e)
        {
            bool commaExists = false;

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = textBox.Text.Trim();

                if (textBox.Text.Contains(','))
                {
                    commaExists = true;
                    textBox.ForeColor = Color.Red;
                }
            }

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
            else if (commaExists)
            {
                UpdateMessage("Inga kommatecken, tack!", Color.IndianRed);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Prevent inputs of commas in all textboxex and input of letters in number-only textboxes
        private void anyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Name == "txtPostalCode" || (sender as TextBox).Name == "txtPhoneNumber")
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar.Equals(','))
            {
                e.Handled = true;
            }
            
            (sender as TextBox).ForeColor = TextBox.DefaultForeColor;
        }
    }
}
