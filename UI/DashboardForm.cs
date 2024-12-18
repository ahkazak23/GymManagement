using System;
using System.Drawing;
using System.Windows.Forms;
using BLL.Managers;

namespace UI
{
    public partial class DashboardForm : Form
    {
        private readonly MemberManager _memberManager;
        private readonly PaymentManager _paymentManager;

        public DashboardForm()
        {
            InitializeComponent();
            
            // Initialize managers
            _memberManager = new MemberManager();
            _paymentManager = new PaymentManager();

            // Populate dashboard panels
            PopulateDashboard();
            
            dataGridUpcomingExpirations.BackgroundColor = Color.FromArgb(46, 51, 73); // Koyu gri arka plan rengi
            dataGridUpcomingExpirations.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73); // Hücre arka plan rengi
            dataGridUpcomingExpirations.DefaultCellStyle.ForeColor = Color.White; // Metin rengi
            
            dataGridRecentMembers.BackgroundColor = Color.FromArgb(46, 51, 73); // Koyu gri arka plan rengi
            dataGridRecentMembers.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73); // Hücre arka plan rengi
            dataGridRecentMembers.DefaultCellStyle.ForeColor = Color.White; // Metin rengi
            
        }

        /// <summary>
        /// Populates the dashboard panels with relevant data.
        /// </summary>
        private void PopulateDashboard()
        {
            PopulateTotalMembers();
            PopulateActiveMemberships();
            PopulateExpiredMemberships();
            PopulateTotalRevenue();
            PopulateMonthlyRevenue();
            PopulateUpcomingExpirations();
            PopulateRecentMembers();
            PopulateGenderDistribution();
            PopulateAgeDistributionChart();
            PopulateMembershipTypeChart();
        }
        
        private void PopulateMembershipTypeChart()
        {
            try
            {
                var typeDistribution = _memberManager.GetMembershipTypeDistribution();

                chartMembershipType.Series["Series1"].Points.Clear();
                foreach (var entry in typeDistribution)
                {
                    chartMembershipType.Series["Series1"].Points.AddXY(entry.Key, entry.Value);
                }
                chartMembershipType.Series["Series1"].LabelForeColor = Color.Transparent;  // Etiketleri gizle
                chartMembershipType.Series["Series1"].IsValueShownAsLabel = false; // Etiketleri gizle
                chartMembershipType.Series["Series1"].LabelBackColor = Color.Transparent; // Etiket arka planını şeffaf yap
                chartMembershipType.Series["Series1"].LabelBorderWidth = 0;  // Etiket kenarlıklarını kaldır
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Üyelik türü dağılımı yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAgeDistributionChart()
        {
            try
            {
                var ageDistribution = _memberManager.GetAgeDistribution();
        
                chartAgeDistribution.Series["Series1"].Points.Clear();
                foreach (var entry in ageDistribution)
                {
                    chartAgeDistribution.Series["Series1"].Points.AddXY(entry.Key, entry.Value);
                }
                chartAgeDistribution.Series["Series1"].LabelForeColor = Color.Transparent;  // Etiketleri gizle
                chartAgeDistribution.Series["Series1"].IsValueShownAsLabel = false; // Etiketleri gizle
                chartAgeDistribution.Series["Series1"].LabelBackColor = Color.Transparent; // Etiket arka planını şeffaf yap
                chartAgeDistribution.Series["Series1"].LabelBorderWidth = 0;  // Etiket kenarlıklarını kaldır

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yaş dağılımı verileri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateGenderDistribution()
        {
            try
            {
                // Get the gender distribution from MemberManager
                var genderDistribution = _memberManager.GetGenderDistribution();

                // Clear existing chart data
                chartGenderDistribution.Series[0].Points.Clear();

                // Populate the chart
                foreach (var gender in genderDistribution)
                {
                    chartGenderDistribution.Series[0].Points.AddXY(gender.Key, gender.Value);
                }
                chartGenderDistribution.Series[0].LabelForeColor = Color.Transparent;  // Etiketleri gizle
                chartGenderDistribution.Series[0].IsValueShownAsLabel = false; // Etiketleri gizle
                chartGenderDistribution.Series[0].LabelBackColor = Color.Transparent; // Etiket arka planını şeffaf yap
                chartGenderDistribution.Series[0].LabelBorderWidth = 0;  // Etiket kenarlıklarını kaldır

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gender distribution could not be loaded: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the "Total Members" panel with the total number of members.
        /// </summary>
        private void PopulateTotalMembers()
        {
            try
            {
                int totalMembers = _memberManager.GetTotalMemberCount();
                lblTotalMembers.Text = totalMembers.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading total members: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the "Active Memberships" panel with the count of active members.
        /// </summary>
        private void PopulateActiveMemberships()
        {
            try
            {
                int activeMemberships = _memberManager.GetActiveMemberCount();
                lblActiveMemberships.Text = activeMemberships.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading active memberships: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the "Expired Memberships" panel with the count of expired memberships.
        /// </summary>
        private void PopulateExpiredMemberships()
        {
            try
            {
                int expiredMemberships = _memberManager.GetExpiredMemberCount();
                lblExpiredMemberships.Text = expiredMemberships.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading expired memberships: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the "Total Revenue" panel with the total revenue amount.
        /// </summary>
        private void PopulateTotalRevenue()
        {
            try
            {
                decimal totalRevenue = _paymentManager.GetTotalRevenue();
                lblTotalRevenue.Text = totalRevenue.ToString("C"); // Format as currency
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading total revenue: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void PopulateMonthlyRevenue()
        {
            try
            {
                // Fetch monthly revenue data
                var monthlyRevenueData = _paymentManager.GetMonthlyRevenue();

                // Clear existing data points in the chart
                chartMonthlyRevenue.Series[0].Points.Clear();

                foreach (var dataPoint in monthlyRevenueData)
                {
                    // Add data points to the chart (X = Month, Y = TotalRevenue)
                    chartMonthlyRevenue.Series[0].Points.AddXY(dataPoint.Month, dataPoint.TotalRevenue);
                }
                chartMonthlyRevenue.Series[0].LabelForeColor = Color.Transparent;
                chartMonthlyRevenue.Series[0].IsValueShownAsLabel = false;
                chartMonthlyRevenue.Series[0].LabelBackColor = Color.Transparent;
                chartMonthlyRevenue.Series[0].LabelBorderWidth = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading monthly revenue data: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateUpcomingExpirations()
        {
            try
            {
                DateTime startDate = DateTime.Now;
                DateTime endDate = DateTime.Now.AddDays(30);

                var upcomingExpirations = _memberManager.GetUpcomingExpirations(startDate, endDate);

                // Clear existing rows in the data grid
                dataGridUpcomingExpirations.Rows.Clear();

                foreach (var member in upcomingExpirations)
                {
                    dataGridUpcomingExpirations.Rows.Add(
                        member.MemberID,
                        member.FirstName + " " + member.LastName,
                        member.MembershipType,
                        member.EndDate.ToShortDateString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Upcoming expirations could not be loaded: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateRecentMembers()
        {
            try
            {
                // Define columns if not already added
                if (dataGridRecentMembers.Columns.Count == 0)
                {
                    dataGridRecentMembers.Columns.Add("MemberID", "Member ID");
                    dataGridRecentMembers.Columns.Add("Name", "Name");
                    dataGridRecentMembers.Columns.Add("MembershipType", "Membership Type");
                    dataGridRecentMembers.Columns.Add("StartDate", "Start Date");
                }

                // Clear existing rows
                dataGridRecentMembers.Rows.Clear();

                // Fetch recent members (last 30 days)
                DateTime startDate = DateTime.Now.AddDays(-30);
                var recentMembers = _memberManager.GetRecentMembers(startDate);

                foreach (var member in recentMembers)
                {
                    dataGridRecentMembers.Rows.Add(
                        member.MemberID,
                        member.FirstName + " " + member.LastName,
                        member.MembershipType,
                        member.StartDate.ToShortDateString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Recent members could not be loaded: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
