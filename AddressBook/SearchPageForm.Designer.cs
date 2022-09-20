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
            this.dataGridAddresses = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserStreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCounty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSearchCriteria = new System.Windows.Forms.ComboBox();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.lstBoxUserInfo = new System.Windows.Forms.ListBox();
            this.btnShowUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(14, 12);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(200, 31);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Skapa ny användare";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(14, 51);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(200, 31);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Uppdatera vald användare";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // dataGridAddresses
            // 
            this.dataGridAddresses.AllowUserToAddRows = false;
            this.dataGridAddresses.AllowUserToDeleteRows = false;
            this.dataGridAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.UserStreetAddress,
            this.UserPostalCode,
            this.UserCounty,
            this.UserPhoneNumber,
            this.UserEmail});
            this.dataGridAddresses.Location = new System.Drawing.Point(14, 328);
            this.dataGridAddresses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridAddresses.Name = "dataGridAddresses";
            this.dataGridAddresses.RowHeadersWidth = 51;
            this.dataGridAddresses.RowTemplate.Height = 25;
            this.dataGridAddresses.RowTemplate.ReadOnly = true;
            this.dataGridAddresses.Size = new System.Drawing.Size(576, 241);
            this.dataGridAddresses.TabIndex = 3;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            this.UserID.Width = 125;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.HeaderText = "Namn";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserStreetAddress
            // 
            this.UserStreetAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserStreetAddress.HeaderText = "Gatuadress";
            this.UserStreetAddress.MinimumWidth = 6;
            this.UserStreetAddress.Name = "UserStreetAddress";
            this.UserStreetAddress.ReadOnly = true;
            // 
            // UserPostalCode
            // 
            this.UserPostalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserPostalCode.HeaderText = "Postnummer";
            this.UserPostalCode.MinimumWidth = 6;
            this.UserPostalCode.Name = "UserPostalCode";
            this.UserPostalCode.ReadOnly = true;
            // 
            // UserCounty
            // 
            this.UserCounty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserCounty.HeaderText = "Postort";
            this.UserCounty.MinimumWidth = 6;
            this.UserCounty.Name = "UserCounty";
            this.UserCounty.ReadOnly = true;
            // 
            // UserPhoneNumber
            // 
            this.UserPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserPhoneNumber.HeaderText = "Telefon-nummer";
            this.UserPhoneNumber.MinimumWidth = 6;
            this.UserPhoneNumber.Name = "UserPhoneNumber";
            this.UserPhoneNumber.ReadOnly = true;
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserEmail.HeaderText = "Epost";
            this.UserEmail.MinimumWidth = 6;
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Location = new System.Drawing.Point(14, 90);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(200, 31);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Radera vald användare";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(23, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 27);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(267, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 36);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(23, 65);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(71, 20);
            this.lblSearchFor.TabIndex = 8;
            this.lblSearchFor.Text = "Sök efter:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSearchFor);
            this.panel1.Controls.Add(this.comboBoxSearchCriteria);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 131);
            this.panel1.TabIndex = 9;
            // 
            // comboBoxSearchCriteria
            // 
            this.comboBoxSearchCriteria.FormattingEnabled = true;
            this.comboBoxSearchCriteria.Items.AddRange(new object[] {
            "Namn",
            "Gatuadress",
            "Postnummer",
            "Postort",
            "Telefon-nummer",
            "Epost"});
            this.comboBoxSearchCriteria.Location = new System.Drawing.Point(94, 61);
            this.comboBoxSearchCriteria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSearchCriteria.Name = "comboBoxSearchCriteria";
            this.comboBoxSearchCriteria.Size = new System.Drawing.Size(204, 28);
            this.comboBoxSearchCriteria.TabIndex = 12;
            this.comboBoxSearchCriteria.SelectedValueChanged += new System.EventHandler(this.comboBoxSearchCriteria_SelectedValueChanged);
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.Location = new System.Drawing.Point(203, 605);
            this.btnCloseProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(183, 31);
            this.btnCloseProgram.TabIndex = 11;
            this.btnCloseProgram.Text = "Avsluta program";
            this.btnCloseProgram.UseVisualStyleBackColor = true;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // lstBoxUserInfo
            // 
            this.lstBoxUserInfo.FormattingEnabled = true;
            this.lstBoxUserInfo.ItemHeight = 20;
            this.lstBoxUserInfo.Location = new System.Drawing.Point(234, 20);
            this.lstBoxUserInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBoxUserInfo.Name = "lstBoxUserInfo";
            this.lstBoxUserInfo.Size = new System.Drawing.Size(324, 124);
            this.lstBoxUserInfo.TabIndex = 13;
            // 
            // btnShowUser
            // 
            this.btnShowUser.Location = new System.Drawing.Point(24, 64);
            this.btnShowUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowUser.Name = "btnShowUser";
            this.btnShowUser.Size = new System.Drawing.Size(183, 31);
            this.btnShowUser.TabIndex = 14;
            this.btnShowUser.Text = "Visa vald användare";
            this.btnShowUser.UseVisualStyleBackColor = true;
            this.btnShowUser.Click += new System.EventHandler(this.btnShowUser_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEditUser);
            this.panel2.Controls.Add(this.btnCreateUser);
            this.panel2.Controls.Add(this.btnDeleteUser);
            this.panel2.Location = new System.Drawing.Point(361, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 131);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnShowUser);
            this.panel3.Controls.Add(this.lstBoxUserInfo);
            this.panel3.Location = new System.Drawing.Point(14, 155);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 165);
            this.panel3.TabIndex = 16;
            // 
            // SearchPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 663);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCloseProgram);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridAddresses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchPageForm";
            this.Text = "Sök";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblSearchFor;
        private DataGridView dataGridAddresses;
        private Panel panel1;
        private Button btnCloseProgram;
        private ComboBox comboBoxSearchCriteria;
        private ListBox lstBoxUserInfo;
        private Button btnShowUser;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserStreetAddress;
        private DataGridViewTextBoxColumn UserPostalCode;
        private DataGridViewTextBoxColumn UserCounty;
        private DataGridViewTextBoxColumn UserPhoneNumber;
        private DataGridViewTextBoxColumn UserEmail;
        private Panel panel2;
        private Panel panel3;
    }
}