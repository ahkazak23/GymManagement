
namespace UI.UserControllers
{
    partial class MemberView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberView));
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageMemberList = new System.Windows.Forms.TabPage();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnMemberSearch = new System.Windows.Forms.Button();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.tabPageMemberDetail = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.cmbMembershipType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSaveMember = new System.Windows.Forms.Button();
            this.memberDetailsLabel = new System.Windows.Forms.Label();
            this.memberTypeLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.memberIdLabel = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.headerPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPageMemberList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            this.tabPageMemberDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(44, 13);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(141, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "MEMBERS";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1125, 56);
            this.headerPanel.TabIndex = 1;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.mainTabControl.Controls.Add(this.tabPageMemberList);
            this.mainTabControl.Controls.Add(this.tabPageMemberDetail);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.mainTabControl.Location = new System.Drawing.Point(0, 56);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1125, 627);
            this.mainTabControl.TabIndex = 2;
            // 
            // tabPageMemberList
            // 
            this.tabPageMemberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPageMemberList.Controls.Add(this.membersDataGridView);
            this.tabPageMemberList.Controls.Add(this.searchLabel);
            this.tabPageMemberList.Controls.Add(this.btnDeleteMember);
            this.tabPageMemberList.Controls.Add(this.btnEditMember);
            this.tabPageMemberList.Controls.Add(this.btnAddMember);
            this.tabPageMemberList.Controls.Add(this.btnMemberSearch);
            this.tabPageMemberList.Controls.Add(this.txtMemberSearch);
            this.tabPageMemberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMemberList.Location = new System.Drawing.Point(4, 4);
            this.tabPageMemberList.Name = "tabPageMemberList";
            this.tabPageMemberList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMemberList.Size = new System.Drawing.Size(1117, 597);
            this.tabPageMemberList.TabIndex = 0;
            this.tabPageMemberList.Text = "Member List";
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AllowUserToAddRows = false;
            this.membersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.membersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.membersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.membersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Location = new System.Drawing.Point(24, 67);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.membersDataGridView.Size = new System.Drawing.Size(970, 578);
            this.membersDataGridView.TabIndex = 7;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(24, 3);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(158, 25);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Search Member:";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.Location = new System.Drawing.Point(1000, 139);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(99, 30);
            this.btnDeleteMember.TabIndex = 4;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEditMember.ForeColor = System.Drawing.Color.White;
            this.btnEditMember.Location = new System.Drawing.Point(1000, 103);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(99, 30);
            this.btnEditMember.TabIndex = 3;
            this.btnEditMember.Text = "Edit";
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(1000, 67);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(99, 30);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "Add new";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMemberSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMemberSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMemberSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMemberSearch.ForeColor = System.Drawing.Color.White;
            this.btnMemberSearch.Location = new System.Drawing.Point(901, 31);
            this.btnMemberSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(93, 30);
            this.btnMemberSearch.TabIndex = 1;
            this.btnMemberSearch.Text = "Search";
            this.btnMemberSearch.UseVisualStyleBackColor = false;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemberSearch.BackColor = System.Drawing.Color.White;
            this.txtMemberSearch.Location = new System.Drawing.Point(24, 31);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(871, 30);
            this.txtMemberSearch.TabIndex = 0;
            // 
            // tabPageMemberDetail
            // 
            this.tabPageMemberDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPageMemberDetail.Controls.Add(this.pictureBox1);
            this.tabPageMemberDetail.Controls.Add(this.chkIsActive);
            this.tabPageMemberDetail.Controls.Add(this.lblEndDate);
            this.tabPageMemberDetail.Controls.Add(this.dtpEndDate);
            this.tabPageMemberDetail.Controls.Add(this.lblStartDate);
            this.tabPageMemberDetail.Controls.Add(this.dtpStartDate);
            this.tabPageMemberDetail.Controls.Add(this.lblMembershipType);
            this.tabPageMemberDetail.Controls.Add(this.cmbMembershipType);
            this.tabPageMemberDetail.Controls.Add(this.label7);
            this.tabPageMemberDetail.Controls.Add(this.lblGender);
            this.tabPageMemberDetail.Controls.Add(this.cmbGender);
            this.tabPageMemberDetail.Controls.Add(this.lblDateOfBirth);
            this.tabPageMemberDetail.Controls.Add(this.dtpDateOfBirth);
            this.tabPageMemberDetail.Controls.Add(this.lblEmail);
            this.tabPageMemberDetail.Controls.Add(this.txtEmail);
            this.tabPageMemberDetail.Controls.Add(this.lblLastName);
            this.tabPageMemberDetail.Controls.Add(this.txtLastName);
            this.tabPageMemberDetail.Controls.Add(this.lblPhone);
            this.tabPageMemberDetail.Controls.Add(this.txtPhone);
            this.tabPageMemberDetail.Controls.Add(this.btnCancelEdit);
            this.tabPageMemberDetail.Controls.Add(this.btnSaveMember);
            this.tabPageMemberDetail.Controls.Add(this.memberDetailsLabel);
            this.tabPageMemberDetail.Controls.Add(this.memberTypeLabel);
            this.tabPageMemberDetail.Controls.Add(this.memberNameLabel);
            this.tabPageMemberDetail.Controls.Add(this.txtMemberName);
            this.tabPageMemberDetail.Controls.Add(this.memberIdLabel);
            this.tabPageMemberDetail.Controls.Add(this.txtMemberId);
            this.tabPageMemberDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMemberDetail.Location = new System.Drawing.Point(4, 4);
            this.tabPageMemberDetail.Name = "tabPageMemberDetail";
            this.tabPageMemberDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMemberDetail.Size = new System.Drawing.Size(1117, 597);
            this.tabPageMemberDetail.TabIndex = 1;
            this.tabPageMemberDetail.Text = "Member Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // chkIsActive
            // 
            this.chkIsActive.BackColor = System.Drawing.Color.White;
            this.chkIsActive.Location = new System.Drawing.Point(465, 374);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.chkIsActive.Size = new System.Drawing.Size(154, 37);
            this.chkIsActive.TabIndex = 33;
            this.chkIsActive.Text = "is Active";
            this.chkIsActive.UseVisualStyleBackColor = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(0, 382);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 25);
            this.lblEndDate.TabIndex = 32;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(115, 374);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(154, 34);
            this.dtpEndDate.TabIndex = 31;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(0, 313);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 25);
            this.lblStartDate.TabIndex = 30;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(115, 305);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(154, 34);
            this.dtpStartDate.TabIndex = 29;
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipType.ForeColor = System.Drawing.Color.White;
            this.lblMembershipType.Location = new System.Drawing.Point(293, 314);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(165, 25);
            this.lblMembershipType.TabIndex = 28;
            this.lblMembershipType.Text = "MembershipType";
            // 
            // cmbMembershipType
            // 
            this.cmbMembershipType.FormattingEnabled = true;
            this.cmbMembershipType.Location = new System.Drawing.Point(465, 306);
            this.cmbMembershipType.Name = "cmbMembershipType";
            this.cmbMembershipType.Size = new System.Drawing.Size(154, 37);
            this.cmbMembershipType.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(498, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 26;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(293, 235);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(77, 25);
            this.lblGender.TabIndex = 25;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(465, 222);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(154, 37);
            this.cmbGender.TabIndex = 24;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(0, 234);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(118, 25);
            this.lblDateOfBirth.TabIndex = 23;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(115, 226);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(154, 34);
            this.dtpDateOfBirth.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(293, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(465, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 34);
            this.txtEmail.TabIndex = 20;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(0, 160);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(115, 151);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 34);
            this.txtLastName.TabIndex = 18;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(293, 96);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 25);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(465, 86);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 34);
            this.txtPhone.TabIndex = 16;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(465, 470);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(183, 44);
            this.btnCancelEdit.TabIndex = 15;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnSaveMember
            // 
            this.btnSaveMember.Location = new System.Drawing.Point(86, 470);
            this.btnSaveMember.Name = "btnSaveMember";
            this.btnSaveMember.Size = new System.Drawing.Size(183, 44);
            this.btnSaveMember.TabIndex = 14;
            this.btnSaveMember.Text = "Save";
            this.btnSaveMember.UseVisualStyleBackColor = true;
            this.btnSaveMember.Click += new System.EventHandler(this.btnSaveMember_Click);
            // 
            // memberDetailsLabel
            // 
            this.memberDetailsLabel.AutoSize = true;
            this.memberDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDetailsLabel.Location = new System.Drawing.Point(301, 307);
            this.memberDetailsLabel.Name = "memberDetailsLabel";
            this.memberDetailsLabel.Size = new System.Drawing.Size(0, 25);
            this.memberDetailsLabel.TabIndex = 13;
            // 
            // memberTypeLabel
            // 
            this.memberTypeLabel.AutoSize = true;
            this.memberTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberTypeLabel.Location = new System.Drawing.Point(498, 234);
            this.memberTypeLabel.Name = "memberTypeLabel";
            this.memberTypeLabel.Size = new System.Drawing.Size(0, 25);
            this.memberTypeLabel.TabIndex = 11;
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLabel.ForeColor = System.Drawing.Color.White;
            this.memberNameLabel.Location = new System.Drawing.Point(0, 96);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(106, 25);
            this.memberNameLabel.TabIndex = 9;
            this.memberNameLabel.Text = "First Name";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(115, 87);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(154, 34);
            this.txtMemberName.TabIndex = 8;
            // 
            // memberIdLabel
            // 
            this.memberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIdLabel.ForeColor = System.Drawing.Color.White;
            this.memberIdLabel.Location = new System.Drawing.Point(245, 20);
            this.memberIdLabel.Name = "memberIdLabel";
            this.memberIdLabel.Size = new System.Drawing.Size(28, 34);
            this.memberIdLabel.TabIndex = 7;
            this.memberIdLabel.Text = "Id";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(293, 20);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(154, 34);
            this.txtMemberId.TabIndex = 6;
            // 
            // MemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1125, 683);
            this.ControlBox = false;
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MemberView_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPageMemberList.ResumeLayout(false);
            this.tabPageMemberList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            this.tabPageMemberDetail.ResumeLayout(false);
            this.tabPageMemberDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;


        private System.Windows.Forms.CheckBox chkIsActive;

        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;

        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;

        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.ComboBox cmbMembershipType;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;

        private System.Windows.Forms.Label lblDateOfBirth;

        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;

        private System.Windows.Forms.TextBox txtPhone;

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel headerPanel;
        internal System.Windows.Forms.TabControl mainTabControl;
        internal System.Windows.Forms.TabPage tabPageMemberList;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnMemberSearch;
        private System.Windows.Forms.TextBox txtMemberSearch;
        internal System.Windows.Forms.TabPage tabPageMemberDetail;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSaveMember;
        private System.Windows.Forms.Label memberDetailsLabel;
        private System.Windows.Forms.Label memberTypeLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label memberIdLabel;
        private System.Windows.Forms.TextBox txtMemberId;
    }
}