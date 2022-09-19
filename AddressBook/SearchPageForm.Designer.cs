namespace AddressBook
{
    partial class SearchPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPageForm));
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.dataGridAddresses = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserStreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCounty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.checkedListBoxSearchCritera = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(37, 41);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(160, 23);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Skapa ny användare";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(37, 70);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(160, 23);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Uppdatera vald användare";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(161, 164);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Läs";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridAddresses
            // 
            this.dataGridAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.UserStreetAddress,
            this.UserPostalCode,
            this.UserCounty,
            this.UserPhoneNumber,
            this.UserEmail});
            this.dataGridAddresses.Location = new System.Drawing.Point(47, 248);
            this.dataGridAddresses.Name = "dataGridAddresses";
            this.dataGridAddresses.RowTemplate.Height = 25;
            this.dataGridAddresses.RowTemplate.ReadOnly = true;
            this.dataGridAddresses.Size = new System.Drawing.Size(682, 150);
            this.dataGridAddresses.TabIndex = 3;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Namn";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserStreetAddress
            // 
            this.UserStreetAddress.HeaderText = "Gatuadress";
            this.UserStreetAddress.Name = "UserStreetAddress";
            this.UserStreetAddress.ReadOnly = true;
            // 
            // UserPostalCode
            // 
            this.UserPostalCode.HeaderText = "Postnummer";
            this.UserPostalCode.Name = "UserPostalCode";
            this.UserPostalCode.ReadOnly = true;
            // 
            // UserCounty
            // 
            this.UserCounty.HeaderText = "Postort";
            this.UserCounty.Name = "UserCounty";
            this.UserCounty.ReadOnly = true;
            // 
            // UserPhoneNumber
            // 
            this.UserPhoneNumber.HeaderText = "Telefon-nummer";
            this.UserPhoneNumber.Name = "UserPhoneNumber";
            this.UserPhoneNumber.ReadOnly = true;
            // 
            // UserEmail
            // 
            this.UserEmail.HeaderText = "Epost";
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(37, 99);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(160, 23);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Radera vald användare";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxSearchCritera
            // 
            this.checkedListBoxSearchCritera.FormattingEnabled = true;
            this.checkedListBoxSearchCritera.Items.AddRange(new object[] {
            "Namn",
            "Gatuadress",
            "Postnummer",
            "Postort",
            "Telefon-nummer",
            "Epost"});
            this.checkedListBoxSearchCritera.Location = new System.Drawing.Point(132, 42);
            this.checkedListBoxSearchCritera.Name = "checkedListBoxSearchCritera";
            this.checkedListBoxSearchCritera.Size = new System.Drawing.Size(120, 112);
            this.checkedListBoxSearchCritera.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 23);
            this.textBox1.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(225, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(73, 42);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(53, 15);
            this.lblSearchFor.TabIndex = 8;
            this.lblSearchFor.Text = "Sök efter";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkedListBoxSearchCritera);
            this.panel1.Controls.Add(this.lblSearchFor);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(348, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 166);
            this.panel1.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(55, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Radera";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SearchPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.dataGridAddresses);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnCreateUser);
            this.Name = "SearchPageForm";
            this.Text = "Sök";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateUser;
        private Button btnEditUser;
        private Button btnRead;
        private Button btnDeleteUser;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserStreetAddress;
        private DataGridViewTextBoxColumn UserPostalCode;
        private DataGridViewTextBoxColumn UserCounty;
        private DataGridViewTextBoxColumn UserPhoneNumber;
        private DataGridViewTextBoxColumn UserEmail;
        private CheckedListBox checkedListBoxSearchCritera;
        private TextBox textBox1;
        private Button btnSearch;
        private Label lblSearchFor;
        private DataGridView dataGridAddresses;
        private Panel panel1;
        private Button btnDelete;
    }
}