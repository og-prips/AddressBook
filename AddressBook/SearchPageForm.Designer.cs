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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridUserInfo = new System.Windows.Forms.DataGridView();
            this.InfoType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(62, 169);
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
            this.btnEditUser.Location = new System.Drawing.Point(61, 52);
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
            this.dataGridAddresses.Location = new System.Drawing.Point(13, 15);
            this.dataGridAddresses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridAddresses.MultiSelect = false;
            this.dataGridAddresses.Name = "dataGridAddresses";
            this.dataGridAddresses.RowHeadersWidth = 51;
            this.dataGridAddresses.RowTemplate.Height = 25;
            this.dataGridAddresses.RowTemplate.ReadOnly = true;
            this.dataGridAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddresses.Size = new System.Drawing.Size(576, 230);
            this.dataGridAddresses.TabIndex = 3;
            this.dataGridAddresses.SelectionChanged += new System.EventHandler(this.dataGridAddresses_SelectionChanged);
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
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Location = new System.Drawing.Point(61, 91);
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
            this.txtSearch.Location = new System.Drawing.Point(23, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 27);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(267, 25);
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
            this.lblSearchFor.Location = new System.Drawing.Point(23, 73);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(71, 20);
            this.lblSearchFor.TabIndex = 8;
            this.lblSearchFor.Text = "Sök efter:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSearchFor);
            this.panel1.Controls.Add(this.btnCreateUser);
            this.panel1.Controls.Add(this.comboBoxSearchCriteria);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(606, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 230);
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
            this.comboBoxSearchCriteria.Location = new System.Drawing.Point(94, 69);
            this.comboBoxSearchCriteria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSearchCriteria.Name = "comboBoxSearchCriteria";
            this.comboBoxSearchCriteria.Size = new System.Drawing.Size(204, 28);
            this.comboBoxSearchCriteria.TabIndex = 12;
            this.comboBoxSearchCriteria.SelectedValueChanged += new System.EventHandler(this.comboBoxSearchCriteria_SelectedValueChanged);
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.Location = new System.Drawing.Point(419, 540);
            this.btnCloseProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(183, 31);
            this.btnCloseProgram.TabIndex = 11;
            this.btnCloseProgram.Text = "Avsluta program";
            this.btnCloseProgram.UseVisualStyleBackColor = true;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEditUser);
            this.panel2.Controls.Add(this.btnDeleteUser);
            this.panel2.Location = new System.Drawing.Point(607, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 178);
            this.panel2.TabIndex = 15;
            // 
            // dataGridUserInfo
            // 
            this.dataGridUserInfo.AllowUserToAddRows = false;
            this.dataGridUserInfo.AllowUserToDeleteRows = false;
            this.dataGridUserInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserInfo.ColumnHeadersVisible = false;
            this.dataGridUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfoType,
            this.UserInfo});
            this.dataGridUserInfo.Enabled = false;
            this.dataGridUserInfo.Location = new System.Drawing.Point(14, 18);
            this.dataGridUserInfo.MultiSelect = false;
            this.dataGridUserInfo.Name = "dataGridUserInfo";
            this.dataGridUserInfo.RowHeadersWidth = 51;
            this.dataGridUserInfo.RowTemplate.Height = 29;
            this.dataGridUserInfo.RowTemplate.ReadOnly = true;
            this.dataGridUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridUserInfo.Size = new System.Drawing.Size(575, 178);
            this.dataGridUserInfo.TabIndex = 17;
            this.dataGridUserInfo.SelectionChanged += new System.EventHandler(this.dataGridUserInfo_SelectionChanged);
            // 
            // InfoType
            // 
            this.InfoType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InfoType.HeaderText = "";
            this.InfoType.MinimumWidth = 6;
            this.InfoType.Name = "InfoType";
            // 
            // UserInfo
            // 
            this.UserInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserInfo.HeaderText = "";
            this.UserInfo.MinimumWidth = 6;
            this.UserInfo.Name = "UserInfo";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridAddresses);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 266);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridUserInfo);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(12, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(942, 215);
            this.panel4.TabIndex = 19;
            // 
            // SearchPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 584);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCloseProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchPageForm";
            this.Text = "Sök";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserStreetAddress;
        private DataGridViewTextBoxColumn UserPostalCode;
        private DataGridViewTextBoxColumn UserCounty;
        private DataGridViewTextBoxColumn UserPhoneNumber;
        private DataGridViewTextBoxColumn UserEmail;
        private Panel panel2;
        private DataGridView dataGridUserInfo;
        private DataGridViewTextBoxColumn InfoType;
        private DataGridViewTextBoxColumn UserInfo;
        private Panel panel3;
        private Panel panel4;
    }
}