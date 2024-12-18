using System;
using System.Drawing;
using System.Windows.Forms;
using UI.UserControllers;

namespace UI
{
    public partial class MemberManagementForm : Form
    {
        private MemberView _memberView;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        private bool _menuExpand = false;
        

        public MemberManagementForm()
        {
            InitializeComponent();
            InitializeEvents();
            LoadDashboard();
        }

        private void InitializeEvents()
        {
            headerPanel.MouseDown += headerPanel_MouseDown;
            headerPanel.MouseMove += headerPanel_MouseMove;
            headerPanel.MouseUp += headerPanel_MouseUp;

            menuButton1.Click += menu_Click;
            menuToggleButton.Click += menuToggleButton_Click;
        }

        private void InitializeMemberView()
        {
            _memberView = new MemberView
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None
            };
            panelContent.Controls.Add(_memberView);
            _memberView.Show();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            const int menuExpandHeight = 158;
            const int menuCollapseHeight = 53;
            const int transitionStep = 10;

            if (_menuExpand == false)
            {
                subMenuContainer.Height += transitionStep;
                if (subMenuContainer.Height >= menuExpandHeight)
                {
                    menuTransition.Stop();
                    _menuExpand = true;
                }
            }
            else
            {
                subMenuContainer.Height -= transitionStep;
                if (subMenuContainer.Height <= menuCollapseHeight)
                {
                    menuTransition.Stop();
                    _menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarPanelExpand = true;

        private void sidebarPanelTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarPanelExpand)
            {
                sidebarPanel.Width -= 10;
                if (sidebarPanel.Width <= 53)
                {
                    sidebarPanelExpand = false;
                    sidebarPanelTransition.Stop();
                    dashboardPanel.Width = sidebarPanel.Width;
                    pnAbout.Width = sidebarPanel.Width;
                    pnSettings.Width = sidebarPanel.Width;
                    pnlogout.Width = sidebarPanel.Width;
                    subMenuContainer.Width = sidebarPanel.Width;
                }
            }
            else
            {
                sidebarPanel.Width += 10;
                if (sidebarPanel.Width >= 251)
                {
                    sidebarPanelExpand = true;
                    sidebarPanelTransition.Stop();

                    dashboardPanel.Width = sidebarPanel.Width;
                    pnAbout.Width = sidebarPanel.Width;
                    pnSettings.Width = sidebarPanel.Width;
                    pnlogout.Width = sidebarPanel.Width;
                    subMenuContainer.Width = sidebarPanel.Width;
                }
            }
        }
       

      

        private void menuToggleButton_Click(object sender, EventArgs e)
        {
            sidebarPanelTransition.Start();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            panelContent.Controls.Clear();
            DashboardForm dashboardForm = new DashboardForm
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            dashboardForm.Show();
            panelContent.Controls.Add(dashboardForm);
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;
                _startPoint = new Point(e.X, e.Y);
            }
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - _startPoint.X, p.Y - _startPoint.Y);
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = false;
            }
        }

        private void subMenuButton1_Click(object sender, EventArgs e)
        {
            EnsureMemberViewIsActive();
            _memberView.mainTabControl.SelectedTab = _memberView.tabPageMemberList;
        }

        private void subMenuButton2_Click(object sender, EventArgs e)
        {
            EnsureMemberViewIsActive();
            _memberView.mainTabControl.SelectedTab = _memberView.tabPageMemberDetail;
        }

        private void EnsureMemberViewIsActive()
        {
            // Clear panelContent and add _memberView if not already added
            if (!panelContent.Controls.Contains(_memberView))
            {
                panelContent.Controls.Clear();
                _memberView = new MemberView
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None
                };
                panelContent.Controls.Add(_memberView);
                _memberView.Show();
            }
        }


    }
}
