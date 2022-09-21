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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.dataGridAddresses = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserStreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCounty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.comboBoxSearchCriteria = new System.Windows.Forms.ComboBox();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.dataGridUserInfo = new System.Windows.Forms.DataGridView();
            this.InfoType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(49, 119);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(175, 25);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Skapa ny användare";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
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
            this.dataGridAddresses.Location = new System.Drawing.Point(-51, 11);
            this.dataGridAddresses.MultiSelect = false;
            this.dataGridAddresses.Name = "dataGridAddresses";
            this.dataGridAddresses.RowHeadersWidth = 51;
            this.dataGridAddresses.RowTemplate.Height = 25;
            this.dataGridAddresses.RowTemplate.ReadOnly = true;
            this.dataGridAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddresses.Size = new System.Drawing.Size(617, 172);
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 23);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(228, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 40);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lblSearchFor.Location = new System.Drawing.Point(12, 73);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(56, 15);
            this.lblSearchFor.TabIndex = 8;
            this.lblSearchFor.Text = "Sök efter:";
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
            this.comboBoxSearchCriteria.Location = new System.Drawing.Point(74, 70);
            this.comboBoxSearchCriteria.Name = "comboBoxSearchCriteria";
            this.comboBoxSearchCriteria.Size = new System.Drawing.Size(197, 23);
            this.comboBoxSearchCriteria.TabIndex = 12;
            this.comboBoxSearchCriteria.SelectedValueChanged += new System.EventHandler(this.comboBoxSearchCriteria_SelectedValueChanged);
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseProgram.Location = new System.Drawing.Point(390, 530);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(122, 26);
            this.btnCloseProgram.TabIndex = 11;
            this.btnCloseProgram.Text = "Avsluta program";
            this.btnCloseProgram.UseVisualStyleBackColor = true;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // dataGridUserInfo
            // 
            this.dataGridUserInfo.AllowUserToAddRows = false;
            this.dataGridUserInfo.AllowUserToDeleteRows = false;
            this.dataGridUserInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUserInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserInfo.ColumnHeadersVisible = false;
            this.dataGridUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfoType,
            this.UserInfo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUserInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUserInfo.Enabled = false;
            this.dataGridUserInfo.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridUserInfo.Location = new System.Drawing.Point(-51, 12);
            this.dataGridUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridUserInfo.MultiSelect = false;
            this.dataGridUserInfo.Name = "dataGridUserInfo";
            this.dataGridUserInfo.RowHeadersWidth = 51;
            this.dataGridUserInfo.RowTemplate.Height = 29;
            this.dataGridUserInfo.RowTemplate.ReadOnly = true;
            this.dataGridUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridUserInfo.Size = new System.Drawing.Size(617, 181);
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
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.dataGridAddresses);
            this.panel3.Location = new System.Drawing.Point(15, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 201);
            this.panel3.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblSearchFor);
            this.panel6.Controls.Add(this.btnCreateUser);
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Controls.Add(this.comboBoxSearchCriteria);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Location = new System.Drawing.Point(566, 11);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 172);
            this.panel6.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.dataGridUserInfo);
            this.panel4.Location = new System.Drawing.Point(15, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(862, 188);
            this.panel4.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEditUser);
            this.panel2.Controls.Add(this.btnDeleteUser);
            this.panel2.Location = new System.Drawing.Point(566, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 176);
            this.panel2.TabIndex = 18;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Location = new System.Drawing.Point(49, 61);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(175, 25);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Uppdatera vald användare";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Location = new System.Drawing.Point(49, 92);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(175, 25);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Radera vald användare";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(21, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 225);
            this.panel1.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(21, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(888, 229);
            this.panel5.TabIndex = 21;
            // 
            // SearchPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(929, 579);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchPageForm";
            this.Text = "Sök";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateUser;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblSearchFor;
        private DataGridView dataGridAddresses;
        private Button btnCloseProgram;
        private ComboBox comboBoxSearchCriteria;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserStreetAddress;
        private DataGridViewTextBoxColumn UserPostalCode;
        private DataGridViewTextBoxColumn UserCounty;
        private DataGridViewTextBoxColumn UserPhoneNumber;
        private DataGridViewTextBoxColumn UserEmail;
        private DataGridView dataGridUserInfo;
        private DataGridViewTextBoxColumn InfoType;
        private DataGridViewTextBoxColumn UserInfo;
        private Panel panel3;
        private Panel panel4;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private Panel panel2;
        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
    }
}