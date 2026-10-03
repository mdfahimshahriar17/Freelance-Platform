using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Clint
{
    public class ClientHomeForm : Form
    {
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlProfile;

        private Label lblPlatformName;

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuProfile;
        private ToolStripMenuItem menuEditProfile;

        private Button btnLogout;

        private Label lblWelcome;
        private Label lblSubtitle;

        private Label lblProfileTitle;
        private Label lblUsername;
        private Label lblFullNameTitle;
        private Label lblFullName;
        private Label lblContactTitle;
        private Label lblContactDetails;

        private Button btnViewFreelancer;
        private Button btnPostProject;
        private Button btnMyProjects;
        private Button btnMessages;
        public ClientHomeForm()
        {
            CreateClientHomeForm();
        }

        private void CreateClientHomeForm()
        {
            // =========================
            // FORM
            // =========================

            this.Text = "Freelance Platform - Client";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 680);
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // =========================
            // NAVBAR
            // =========================

            pnlHeader = new Panel();
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(884, 75);
            pnlHeader.BackColor = Color.White;
            this.Controls.Add(pnlHeader);

            // Platform name
            lblPlatformName = new Label();
            lblPlatformName.Text = "FREELANCE PLATFORM";
            lblPlatformName.Font =
                new Font("Segoe UI", 14, FontStyle.Bold);
            lblPlatformName.ForeColor =
                Color.FromArgb(35, 40, 48);
            lblPlatformName.AutoSize = true;
            lblPlatformName.Location =
                new Point(35, 25);

            pnlHeader.Controls.Add(lblPlatformName);

            // =========================
            // PROFILE DROPDOWN
            // =========================

            menuStrip = new MenuStrip();
            menuStrip.BackColor = Color.White;
            menuStrip.Dock = DockStyle.None;
            menuStrip.Location = new Point(690, 20);
            menuStrip.Size = new Size(85, 30);

            menuProfile = new ToolStripMenuItem();
            menuProfile.Text = "Profile ▼";
            menuProfile.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            menuProfile.ForeColor =
                Color.FromArgb(45, 95, 160);

            menuEditProfile = new ToolStripMenuItem();
            menuEditProfile.Text = "Edit Profile";
            menuEditProfile.Font =
                new Font("Segoe UI", 9);

            menuProfile.DropDownItems.Add(
                menuEditProfile
            );

            menuStrip.Items.Add(menuProfile);

            pnlHeader.Controls.Add(menuStrip);

            // =========================
            // LOGOUT
            // =========================

            btnLogout = new Button();
            btnLogout.Text = "LOGOUT";
            btnLogout.Font =
                new Font("Segoe UI", 8, FontStyle.Bold);
            btnLogout.ForeColor =
                Color.FromArgb(70, 70, 70);
            btnLogout.BackColor =
                Color.FromArgb(235, 238, 243);
            btnLogout.FlatStyle =
                FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Location =
                new Point(785, 20);
            btnLogout.Size =
                new Size(70, 30);

            pnlHeader.Controls.Add(btnLogout);

            // =========================
            // MAIN CONTENT
            // =========================

            pnlContent = new Panel();
            pnlContent.Location =
                new Point(40, 105);
            pnlContent.Size =
                new Size(804, 510);
            pnlContent.BackColor =
                Color.White;

            this.Controls.Add(pnlContent);

            // Welcome
            lblWelcome = new Label();
            lblWelcome.Text = "Welcome, Client";
            lblWelcome.Font =
                new Font("Segoe UI", 22, FontStyle.Bold);
            lblWelcome.ForeColor =
                Color.FromArgb(35, 40, 48);
            lblWelcome.AutoSize = true;
            lblWelcome.Location =
                new Point(45, 30);

            pnlContent.Controls.Add(lblWelcome);

            // Subtitle
            lblSubtitle = new Label();
            lblSubtitle.Text =
                "Manage your freelance projects and connections";
            lblSubtitle.Font =
                new Font("Segoe UI", 10);
            lblSubtitle.ForeColor =
                Color.FromArgb(110, 118, 130);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location =
                new Point(48, 72);

            pnlContent.Controls.Add(lblSubtitle);

            // =========================
            // MY PROFILE CARD
            // =========================

            pnlProfile = new Panel();
            pnlProfile.Location =
                new Point(45, 115);
            pnlProfile.Size =
                new Size(714, 125);
            pnlProfile.BackColor =
                Color.FromArgb(248, 249, 251);
            pnlProfile.BorderStyle =
                BorderStyle.FixedSingle;

            pnlContent.Controls.Add(pnlProfile);

            // My Profile title
            lblProfileTitle = new Label();
            lblProfileTitle.Text = "My Profile";
            lblProfileTitle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);
            lblProfileTitle.ForeColor =
                Color.FromArgb(35, 40, 48);
            lblProfileTitle.AutoSize = true;
            lblProfileTitle.Location =
                new Point(20, 18);

            pnlProfile.Controls.Add(lblProfileTitle);

            // Username
            lblUsername = new Label();
            lblUsername.Text = "Username";
            lblUsername.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            lblUsername.ForeColor =
                Color.FromArgb(45, 95, 160);
            lblUsername.AutoSize = true;
            lblUsername.Location =
                new Point(610, 20);

            pnlProfile.Controls.Add(lblUsername);

            // Full Name title
            lblFullNameTitle = new Label();
            lblFullNameTitle.Text = "Full Name:";
            lblFullNameTitle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            lblFullNameTitle.ForeColor =
                Color.FromArgb(90, 95, 105);
            lblFullNameTitle.AutoSize = true;
            lblFullNameTitle.Location =
                new Point(20, 53);

            pnlProfile.Controls.Add(lblFullNameTitle);

            // Full Name
            lblFullName = new Label();
            lblFullName.Text = "Client Name";
            lblFullName.Font =
                new Font("Segoe UI", 9);
            lblFullName.ForeColor =
                Color.FromArgb(55, 62, 72);
            lblFullName.AutoSize = true;
            lblFullName.Location =
                new Point(100, 53);

            pnlProfile.Controls.Add(lblFullName);

            // Contact title
            lblContactTitle = new Label();
            lblContactTitle.Text = "Contact:";
            lblContactTitle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            lblContactTitle.ForeColor =
                Color.FromArgb(90, 95, 105);
            lblContactTitle.AutoSize = true;
            lblContactTitle.Location =
                new Point(20, 83);

            pnlProfile.Controls.Add(lblContactTitle);

            // Contact details
            lblContactDetails = new Label();
            lblContactDetails.Text = "Contact Details";
            lblContactDetails.Font =
                new Font("Segoe UI", 9);
            lblContactDetails.ForeColor =
                Color.FromArgb(55, 62, 72);
            lblContactDetails.AutoSize = true;
            lblContactDetails.Location =
                new Point(100, 83);

            pnlProfile.Controls.Add(lblContactDetails);

            // =========================
            // MENU BUTTONS
            // =========================

            btnViewFreelancer =
                CreateMenuButton(
                    "View Freelancer",
                    45,
                    265
                );

            pnlContent.Controls.Add(
                btnViewFreelancer
            );

            btnPostProject =
                CreateMenuButton(
                    "Post Project",
                    410,
                    265
                );

            pnlContent.Controls.Add(
                btnPostProject
            );

            btnMyProjects =
                CreateMenuButton(
                    "My Projects",
                    45,
                    345
                );

            pnlContent.Controls.Add(
                btnMyProjects
            );

            btnMessages =
                CreateMenuButton(
                    "Messages",
                    410,
                    345
                );

            pnlContent.Controls.Add(
                btnMessages
            );
        }

        private Button CreateMenuButton(
            string text,
            int x,
            int y)
        {
            Button button = new Button();

            button.Text = text;

            button.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            button.ForeColor =
                Color.FromArgb(45, 95, 160);

            button.BackColor =
                Color.FromArgb(248, 249, 251);

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderColor =
                Color.FromArgb(220, 224, 230);

            button.FlatAppearance.BorderSize = 1;

            button.Cursor = Cursors.Hand;

            button.Location =
                new Point(x, y);

            button.Size =
                new Size(335, 60);

            return button;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClientHomeForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "ClientHomeForm";
            this.Load += new System.EventHandler(this.ClientHomeForm_Load);
            this.ResumeLayout(false);

        }

        private void ClientHomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}