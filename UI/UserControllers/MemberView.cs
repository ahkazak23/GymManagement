using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL.Managers;
using Models.Entities;

namespace UI.UserControllers
{
    public partial class MemberView : Form
    {
        private readonly MemberManager _memberManager;

        public MemberView()
        {
            InitializeComponent();

            _memberManager = new MemberManager();
            this.Load += MemberView_Load;
            
            cmbMembershipType.Items.AddRange(new object[] {"Monthly", "Yearly","Quarterly"});
            cmbGender.Items.AddRange(new Object[] {"Male","Female"});
        }

        private void MemberView_Load(object sender, EventArgs e)
        {
            InitializeDataGridViewColumns();
            RefreshMemberList();
        }
        private void InitializeDataGridViewColumns()
        {
            // Clear existing columns to avoid duplication
            membersDataGridView.Columns.Clear();

            // Define columns and map them to properties
            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MemberID",
                HeaderText = "Member ID",
                DataPropertyName = "MemberID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "First Name",
                DataPropertyName = "FirstName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Last Name",
                DataPropertyName = "LastName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "Phone",
                DataPropertyName = "Phone",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DateOfBirth",
                HeaderText = "Date of Birth",
                DataPropertyName = "DateOfBirth",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Gender",
                HeaderText = "Gender",
                DataPropertyName = "Gender",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MembershipType",
                HeaderText = "Membership Type",
                DataPropertyName = "MembershipType",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StartDate",
                HeaderText = "Start Date",
                DataPropertyName = "StartDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            membersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EndDate",
                HeaderText = "End Date",
                DataPropertyName = "EndDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            membersDataGridView.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsActive",
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }


        private void RefreshMemberList(string searchQuery = "")
        {
            try
            {
                var members = string.IsNullOrWhiteSpace(searchQuery)
                    ? _memberManager.GetAllMembers()
                    : _memberManager.SearchMembers(searchQuery);

                membersDataGridView.AutoGenerateColumns = false;
                membersDataGridView.DataSource = members ?? new List<Member>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtMemberSearch.Text.Trim();
            RefreshMemberList(searchQuery);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            ClearMemberDetailFields();
            mainTabControl.SelectedTab = tabPageMemberDetail;
        }

        private void ClearMemberDetailFields()
        {
            txtMemberId.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cmbMembershipType.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            chkIsActive.Checked = false;
            dtpDateOfBirth.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (membersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to edit.", "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedMember = membersDataGridView.SelectedRows[0].DataBoundItem as Member;

            if (selectedMember == null)
            {
                MessageBox.Show("Unable to retrieve selected member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMemberId.Text = selectedMember.MemberID.ToString();
            txtMemberName.Text = selectedMember.FirstName;
            txtLastName.Text = selectedMember.LastName;
            txtPhone.Text = selectedMember.Phone;
            txtEmail.Text = selectedMember.Email;
            cmbMembershipType.Text = selectedMember.MembershipType;
            cmbGender.Text = selectedMember.Gender;
            chkIsActive.Checked = selectedMember.IsActive;
            dtpDateOfBirth.Value = selectedMember.DateOfBirth ?? DateTime.Now;
            dtpStartDate.Value = selectedMember.StartDate;
            dtpEndDate.Value = selectedMember.EndDate;

            mainTabControl.SelectedTab = tabPageMemberDetail;
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (membersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to delete.", "Delete Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedMember = membersDataGridView.SelectedRows[0].DataBoundItem as Member;

            if (selectedMember == null)
            {
                MessageBox.Show("Unable to retrieve selected member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show($"Are you sure you want to delete {selectedMember.FirstName} {selectedMember.LastName}?",
                "Delete Member", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                _memberManager.DeleteMember(selectedMember.MemberID);
                RefreshMemberList();
                MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberID = string.IsNullOrWhiteSpace(txtMemberId.Text) ? 0 : int.Parse(txtMemberId.Text),
                    FirstName = txtMemberName.Text,
                    LastName = txtLastName.Text,
                    MembershipType = cmbMembershipType.Text,
                    Gender = cmbGender.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    IsActive = chkIsActive.Checked,
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    DateOfBirth = dtpDateOfBirth.Value
                };

                if (member.MemberID == 0)
                    _memberManager.AddMember(member);
                else
                    _memberManager.UpdateMember(member);

                RefreshMemberList();
                mainTabControl.SelectedTab = tabPageMemberList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = tabPageMemberList;
        }
    }
}
