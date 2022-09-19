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
            this.txtSearchCriteria = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddresses)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(778, 69);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(160, 23);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Skapa ny användare";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(778, 98);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(160, 23);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Uppdatera vald användare";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(460, 106);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Läs";
            this.btnRead.UseVisualStyleBackColor = true;
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
            this.dataGridAddresses.Location = new System.Drawing.Point(47, 432);
            this.dataGridAddresses.Name = "dataGridAddresses";
            this.dataGridAddresses.RowTemplate.Height = 25;
            this.dataGridAddresses.RowTemplate.ReadOnly = true;
            this.dataGridAddresses.Size = new System.Drawing.Size(891, 150);
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
            this.UserName.Width = 140;
            // 
            // UserStreetAddress
            // 
            this.UserStreetAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserStreetAddress.HeaderText = "Gatuadress";
            this.UserStreetAddress.Name = "UserStreetAddress";
            this.UserStreetAddress.ReadOnly = true;
            // 
            // UserPostalCode
            // 
            this.UserPostalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserPostalCode.HeaderText = "Postnummer";
            this.UserPostalCode.Name = "UserPostalCode";
            this.UserPostalCode.ReadOnly = true;
            this.UserPostalCode.Width = 101;
            // 
            // UserCounty
            // 
            this.UserCounty.HeaderText = "Postort";
            this.UserCounty.Name = "UserCounty";
            this.UserCounty.ReadOnly = true;
            this.UserCounty.Width = 90;
            // 
            // UserPhoneNumber
            // 
            this.UserPhoneNumber.HeaderText = "Telefon-nummer";
            this.UserPhoneNumber.Name = "UserPhoneNumber";
            this.UserPhoneNumber.ReadOnly = true;
            this.UserPhoneNumber.Width = 110;
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserEmail.HeaderText = "Epost";
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(778, 127);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(160, 23);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Radera vald användare";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // txtSearchCriteria
            // 
            this.txtSearchCriteria.Location = new System.Drawing.Point(11, 13);
            this.txtSearchCriteria.Name = "txtSearchCriteria";
            this.txtSearchCriteria.Size = new System.Drawing.Size(210, 23);
            this.txtSearchCriteria.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(225, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(62, 7);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(56, 15);
            this.lblSearchFor.TabIndex = 8;
            this.lblSearchFor.Text = "Sök efter:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchCriteria);
            this.panel1.Location = new System.Drawing.Point(47, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 235);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.lblSearchFor);
            this.panel2.Location = new System.Drawing.Point(11, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 177);
            this.panel2.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Radera";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.Location = new System.Drawing.Point(778, 158);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(160, 23);
            this.btnCloseProgram.TabIndex = 11;
            this.btnCloseProgram.Text = "Avsluta program";
            this.btnCloseProgram.UseVisualStyleBackColor = true;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(124, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(124, 53);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 19);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(124, 78);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 19);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(124, 102);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(94, 19);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(124, 127);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(94, 19);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // SearchPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 666);
            this.Controls.Add(this.btnCloseProgram);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateUser;
        private Button btnEditUser;
        private Button btnRead;
        private Button btnDeleteUser;
        private TextBox txtSearchCriteria;
        private Button btnSearch;
        private Label lblSearchFor;
        private DataGridView dataGridAddresses;
        private Panel panel1;
        private Button btnDelete;
        private Button btnCloseProgram;
        private Panel panel2;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserStreetAddress;
        private DataGridViewTextBoxColumn UserPostalCode;
        private DataGridViewTextBoxColumn UserCounty;
        private DataGridViewTextBoxColumn UserPhoneNumber;
        private DataGridViewTextBoxColumn UserEmail;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}