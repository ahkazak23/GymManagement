namespace UI 
{
    partial class MemberManagementForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberManagementForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.windowControlBox = new ReaLTaiizor.Controls.NightControlBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuToggleButton = new System.Windows.Forms.PictureBox();
            this.sidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.subMenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menuPanel1 = new System.Windows.Forms.Panel();
            this.menuButton1 = new System.Windows.Forms.Button();
            this.menuPanel2 = new System.Windows.Forms.Panel();
            this.subMenuButton1 = new System.Windows.Forms.Button();
            this.menuPanel3 = new System.Windows.Forms.Panel();
            this.subMenuButton2 = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlogout = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarPanelTransition = new System.Windows.Forms.Timer(this.components);
            this.panelContent = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuToggleButton)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.subMenuContainer.SuspendLayout();
            this.menuPanel1.SuspendLayout();
            this.menuPanel2.SuspendLayout();
            this.menuPanel3.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.pnlogout.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.windowControlBox);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.menuToggleButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1134, 40);
            this.headerPanel.TabIndex = 0;
            // 
            // windowControlBox
            // 
            this.windowControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowControlBox.BackColor = System.Drawing.Color.Transparent;
            this.windowControlBox.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.windowControlBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.windowControlBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowControlBox.DefaultLocation = true;
            this.windowControlBox.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.windowControlBox.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.windowControlBox.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.windowControlBox.EnableMaximizeButton = true;
            this.windowControlBox.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.windowControlBox.EnableMinimizeButton = true;
            this.windowControlBox.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.windowControlBox.Location = new System.Drawing.Point(995, 0);
            this.windowControlBox.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.windowControlBox.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.windowControlBox.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.windowControlBox.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.windowControlBox.Name = "windowControlBox";
            this.windowControlBox.Size = new System.Drawing.Size(139, 31);
            this.windowControlBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(39, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(181, 23);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Member Management";
            // 
            // menuToggleButton
            // 
            this.menuToggleButton.Image = ((System.Drawing.Image)(resources.GetObject("menuToggleButton.Image")));
            this.menuToggleButton.Location = new System.Drawing.Point(3, 3);
            this.menuToggleButton.Name = "menuToggleButton";
            this.menuToggleButton.Size = new System.Drawing.Size(33, 31);
            this.menuToggleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuToggleButton.TabIndex = 1;
            this.menuToggleButton.TabStop = false;
            this.menuToggleButton.Click += new System.EventHandler(this.menuToggleButton_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebarPanel.Controls.Add(this.dashboardPanel);
            this.sidebarPanel.Controls.Add(this.subMenuContainer);
            this.sidebarPanel.Controls.Add(this.pnAbout);
            this.sidebarPanel.Controls.Add(this.pnlogout);
            this.sidebarPanel.Controls.Add(this.pnSettings);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 40);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.sidebarPanel.Size = new System.Drawing.Size(249, 746);
            this.sidebarPanel.TabIndex = 1;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.dashboardButton);
            this.dashboardPanel.Location = new System.Drawing.Point(3, 23);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(248, 53);
            this.dashboardPanel.TabIndex = 3;
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(-14, -18);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(278, 91);
            this.dashboardButton.TabIndex = 2;
            this.dashboardButton.Text = "          Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // subMenuContainer
            // 
            this.subMenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.subMenuContainer.Controls.Add(this.menuPanel1);
            this.subMenuContainer.Controls.Add(this.menuPanel2);
            this.subMenuContainer.Controls.Add(this.menuPanel3);
            this.subMenuContainer.Location = new System.Drawing.Point(0, 79);
            this.subMenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuContainer.Name = "subMenuContainer";
            this.subMenuContainer.Size = new System.Drawing.Size(248, 53);
            this.subMenuContainer.TabIndex = 7;
            // 
            // menuPanel1
            // 
            this.menuPanel1.Controls.Add(this.menuButton1);
            this.menuPanel1.Location = new System.Drawing.Point(0, 0);
            this.menuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel1.Name = "menuPanel1";
            this.menuPanel1.Size = new System.Drawing.Size(248, 53);
            this.menuPanel1.TabIndex = 9;
            // 
            // menuButton1
            // 
            this.menuButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton1.ForeColor = System.Drawing.Color.White;
            this.menuButton1.Image = ((System.Drawing.Image)(resources.GetObject("menuButton1.Image")));
            this.menuButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton1.Location = new System.Drawing.Point(-11, -18);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.menuButton1.Size = new System.Drawing.Size(278, 91);
            this.menuButton1.TabIndex = 2;
            this.menuButton1.Text = "          Menu";
            this.menuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton1.UseVisualStyleBackColor = false;
            this.menuButton1.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuPanel2
            // 
            this.menuPanel2.Controls.Add(this.subMenuButton1);
            this.menuPanel2.Location = new System.Drawing.Point(0, 53);
            this.menuPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel2.Name = "menuPanel2";
            this.menuPanel2.Size = new System.Drawing.Size(248, 53);
            this.menuPanel2.TabIndex = 8;
            // 
            // subMenuButton1
            // 
            this.subMenuButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.subMenuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuButton1.ForeColor = System.Drawing.Color.White;
            this.subMenuButton1.Image = ((System.Drawing.Image)(resources.GetObject("subMenuButton1.Image")));
            this.subMenuButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuButton1.Location = new System.Drawing.Point(-14, -18);
            this.subMenuButton1.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuButton1.Name = "subMenuButton1";
            this.subMenuButton1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.subMenuButton1.Size = new System.Drawing.Size(278, 91);
            this.subMenuButton1.TabIndex = 3;
            this.subMenuButton1.Text = "          Member's List";
            this.subMenuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuButton1.UseVisualStyleBackColor = false;
            this.subMenuButton1.Click += new System.EventHandler(this.subMenuButton1_Click);
            // 
            // menuPanel3
            // 
            this.menuPanel3.Controls.Add(this.subMenuButton2);
            this.menuPanel3.Location = new System.Drawing.Point(0, 106);
            this.menuPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel3.Name = "menuPanel3";
            this.menuPanel3.Size = new System.Drawing.Size(248, 53);
            this.menuPanel3.TabIndex = 10;
            // 
            // subMenuButton2
            // 
            this.subMenuButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.subMenuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuButton2.ForeColor = System.Drawing.Color.White;
            this.subMenuButton2.Image = ((System.Drawing.Image)(resources.GetObject("subMenuButton2.Image")));
            this.subMenuButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuButton2.Location = new System.Drawing.Point(-14, -18);
            this.subMenuButton2.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuButton2.Name = "subMenuButton2";
            this.subMenuButton2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.subMenuButton2.Size = new System.Drawing.Size(278, 91);
            this.subMenuButton2.TabIndex = 2;
            this.subMenuButton2.Text = "          New Member";
            this.subMenuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subMenuButton2.UseVisualStyleBackColor = false;
            this.subMenuButton2.Click += new System.EventHandler(this.subMenuButton2_Click);
            // 
            // pnAbout
            // 
            this.pnAbout.Controls.Add(this.button2);
            this.pnAbout.Location = new System.Drawing.Point(3, 135);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(248, 53);
            this.pnAbout.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-14, -18);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(278, 91);
            this.button2.TabIndex = 2;
            this.button2.Text = "          About";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pnlogout
            // 
            this.pnlogout.Controls.Add(this.button4);
            this.pnlogout.Location = new System.Drawing.Point(3, 194);
            this.pnlogout.Name = "pnlogout";
            this.pnlogout.Size = new System.Drawing.Size(248, 53);
            this.pnlogout.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-14, -18);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(278, 91);
            this.button4.TabIndex = 2;
            this.button4.Text = "          Logout           ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.button3);
            this.pnSettings.Location = new System.Drawing.Point(3, 253);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(248, 53);
            this.pnSettings.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-14, -18);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(278, 91);
            this.button3.TabIndex = 2;
            this.button3.Text = "          Settings";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarPanelTransition
            // 
            this.sidebarPanelTransition.Interval = 10;
            this.sidebarPanelTransition.Tick += new System.EventHandler(this.sidebarPanelTransition_Tick);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.AutoSize = true;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(249, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(885, 746);
            this.panelContent.TabIndex = 3;
            // 
            // MemberManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1134, 786);
            this.ControlBox = false;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.headerPanel);
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MemberManagementForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuToggleButton)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.dashboardPanel.ResumeLayout(false);
            this.subMenuContainer.ResumeLayout(false);
            this.menuPanel1.ResumeLayout(false);
            this.menuPanel2.ResumeLayout(false);
            this.menuPanel3.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.pnlogout.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel menuPanel1;
        private System.Windows.Forms.Panel menuPanel3;
        private System.Windows.Forms.Button subMenuButton2;

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox menuToggleButton;
        private ReaLTaiizor.Controls.NightControlBox windowControlBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel sidebarPanel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlogout;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel subMenuContainer;
        private System.Windows.Forms.Button menuButton1;
        private System.Windows.Forms.Panel menuPanel2;
        private System.Windows.Forms.Button subMenuButton1;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarPanelTransition;
    }
}

