using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Freelancer
{
    public class FreelancerHomeForm : Form
    {
        // =========================
        // NAVBAR
        // =========================

        private Panel pnlHeader;
        private Label lblPlatformName;

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuProfile;
        private ToolStripMenuItem menuEditProfile;

        private Button btnLogout;


        // =========================
        // MAIN CONTENT
        // =========================

        private Panel pnlContent;

        private Label lblWelcome;
        private Label lblSubtitle;


        // =========================
        // MY PROFILE
        // =========================

        private Panel pnlProfile;

        private Label lblProfileTitle;
        private Label lblUsername;

        private Label lblFullNameTitle;
        private Label lblFullName;

        private Label lblSkillsTitle;
        private Label lblSkills;

        private Label lblExpertiseTitle;
        private Label lblExpertise;


        // =========================
        // MENU BUTTONS
        // =========================

        private Button btnBrowseProjects;
        private Button btnMyBids;
        private Button btnOngoingProjects;
        private Button btnCompletedProjects;
        private Button btnMessages;


        public FreelancerHomeForm()
        {
            CreateFreelancerHomeForm();
        }


        private void CreateFreelancerHomeForm()
        {
            // =========================
            // FORM
            // =========================

            this.Text =
                "Freelance Platform - Freelancer";

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Size =
                new Size(900, 680);

            this.BackColor =
                Color.FromArgb(245, 247, 250);

            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;


            // =========================
            // NAVBAR
            // =========================

            pnlHeader =
                new Panel();

            pnlHeader.Location =
                new Point(0, 0);

            pnlHeader.Size =
                new Size(884, 75);

            pnlHeader.BackColor =
                Color.White;

            this.Controls.Add(
                pnlHeader
            );


            // =========================
            // PLATFORM NAME
            // =========================

            lblPlatformName =
                new Label();

            lblPlatformName.Text =
                "FREELANCE PLATFORM";

            lblPlatformName.Font =
                new Font(
                    "Segoe UI",
                    14,
                    FontStyle.Bold
                );

            lblPlatformName.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblPlatformName.AutoSize =
                true;

            lblPlatformName.Location =
                new Point(35, 25);

            pnlHeader.Controls.Add(
                lblPlatformName
            );


            // =========================
            // PROFILE DROPDOWN
            // =========================

            menuStrip =
                new MenuStrip();

            menuStrip.BackColor =
                Color.White;

            menuStrip.Dock =
                DockStyle.None;

            menuStrip.Location =
                new Point(690, 20);

            menuStrip.Size =
                new Size(85, 30);


            menuProfile =
                new ToolStripMenuItem();

            menuProfile.Text =
                "Profile ▼";

            menuProfile.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            menuProfile.ForeColor =
                Color.FromArgb(45, 95, 160);


            // =========================
            // EDIT PROFILE
            // =========================

            menuEditProfile =
                new ToolStripMenuItem();

            menuEditProfile.Text =
                "Edit Profile";

            menuEditProfile.Font =
                new Font(
                    "Segoe UI",
                    9
                );


            menuProfile.DropDownItems.Add(
                menuEditProfile
            );

            menuStrip.Items.Add(
                menuProfile
            );

            pnlHeader.Controls.Add(
                menuStrip
            );


            // =========================
            // LOGOUT
            // =========================

            btnLogout =
                new Button();

            btnLogout.Text =
                "LOGOUT";

            btnLogout.Font =
                new Font(
                    "Segoe UI",
                    8,
                    FontStyle.Bold
                );

            btnLogout.ForeColor =
                Color.FromArgb(70, 70, 70);

            btnLogout.BackColor =
                Color.FromArgb(235, 238, 243);

            btnLogout.FlatStyle =
                FlatStyle.Flat;

            btnLogout.FlatAppearance.BorderSize =
                0;

            btnLogout.Cursor =
                Cursors.Hand;

            btnLogout.Location =
                new Point(785, 20);

            btnLogout.Size =
                new Size(70, 30);

            pnlHeader.Controls.Add(
                btnLogout
            );


            // =========================
            // MAIN CONTENT
            // =========================

            pnlContent =
                new Panel();

            pnlContent.Location =
                new Point(40, 105);

            pnlContent.Size =
                new Size(804, 510);

            pnlContent.BackColor =
                Color.White;

            this.Controls.Add(
                pnlContent
            );


            // =========================
            // WELCOME
            // =========================

            lblWelcome =
                new Label();

            lblWelcome.Text =
                "Welcome, Freelancer";

            lblWelcome.Font =
                new Font(
                    "Segoe UI",
                    22,
                    FontStyle.Bold
                );

            lblWelcome.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblWelcome.AutoSize =
                true;

            lblWelcome.Location =
                new Point(45, 30);

            pnlContent.Controls.Add(
                lblWelcome
            );


            // =========================
            // SUBTITLE
            // =========================

            lblSubtitle =
                new Label();

            lblSubtitle.Text =
                "Manage your profile, projects and freelance activities";

            lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    10
                );

            lblSubtitle.ForeColor =
                Color.FromArgb(110, 118, 130);

            lblSubtitle.AutoSize =
                true;

            lblSubtitle.Location =
                new Point(48, 72);

            pnlContent.Controls.Add(
                lblSubtitle
            );


            // =========================
            // MY PROFILE CARD
            // =========================

            pnlProfile =
                new Panel();

            pnlProfile.Location =
                new Point(45, 115);

            // Increased height for bottom spacing
            pnlProfile.Size =
                new Size(714, 140);

            pnlProfile.BackColor =
                Color.FromArgb(248, 249, 251);

            pnlProfile.BorderStyle =
                BorderStyle.FixedSingle;

            pnlContent.Controls.Add(
                pnlProfile
            );


            // =========================
            // MY PROFILE TITLE
            // =========================

            lblProfileTitle =
                new Label();

            lblProfileTitle.Text =
                "My Profile";

            lblProfileTitle.Font =
                new Font(
                    "Segoe UI",
                    12,
                    FontStyle.Bold
                );

            lblProfileTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblProfileTitle.AutoSize =
                true;

            lblProfileTitle.Location =
                new Point(20, 18);

            pnlProfile.Controls.Add(
                lblProfileTitle
            );


            // =========================
            // USERNAME
            // =========================

            lblUsername =
                new Label();

            lblUsername.Text =
                "Username";

            lblUsername.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblUsername.ForeColor =
                Color.FromArgb(45, 95, 160);

            lblUsername.AutoSize =
                true;

            lblUsername.Location =
                new Point(610, 20);

            pnlProfile.Controls.Add(
                lblUsername
            );


            // =========================
            // FULL NAME TITLE
            // =========================

            lblFullNameTitle =
                new Label();

            lblFullNameTitle.Text =
                "Full Name:";

            lblFullNameTitle.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblFullNameTitle.ForeColor =
                Color.FromArgb(90, 95, 105);

            lblFullNameTitle.AutoSize =
                true;

            lblFullNameTitle.Location =
                new Point(20, 53);

            pnlProfile.Controls.Add(
                lblFullNameTitle
            );


            // =========================
            // FULL NAME
            // =========================

            lblFullName =
                new Label();

            lblFullName.Text =
                "John Smith";

            lblFullName.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblFullName.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblFullName.AutoSize =
                true;

            lblFullName.Location =
                new Point(100, 53);

            pnlProfile.Controls.Add(
                lblFullName
            );


            // =========================
            // SKILLS TITLE
            // =========================

            lblSkillsTitle =
                new Label();

            lblSkillsTitle.Text =
                "Skills:";

            lblSkillsTitle.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblSkillsTitle.ForeColor =
                Color.FromArgb(90, 95, 105);

            lblSkillsTitle.AutoSize =
                true;

            lblSkillsTitle.Location =
                new Point(20, 82);

            pnlProfile.Controls.Add(
                lblSkillsTitle
            );


            // =========================
            // SKILLS
            // =========================

            lblSkills =
                new Label();

            lblSkills.Text =
                "C#, .NET, SQL Server";

            lblSkills.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblSkills.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblSkills.AutoSize =
                true;

            lblSkills.Location =
                new Point(100, 82);

            pnlProfile.Controls.Add(
                lblSkills
            );


            // =========================
            // EXPERTISE TITLE
            // =========================

            lblExpertiseTitle =
                new Label();

            lblExpertiseTitle.Text =
                "Expertise:";

            lblExpertiseTitle.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblExpertiseTitle.ForeColor =
                Color.FromArgb(90, 95, 105);

            lblExpertiseTitle.AutoSize =
                true;

            lblExpertiseTitle.Location =
                new Point(20, 108);

            pnlProfile.Controls.Add(
                lblExpertiseTitle
            );


            // =========================
            // EXPERTISE
            // =========================

            lblExpertise =
                new Label();

            lblExpertise.Text =
                "Backend Development";

            lblExpertise.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblExpertise.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblExpertise.AutoSize =
                true;

            lblExpertise.Location =
                new Point(100, 108);

            pnlProfile.Controls.Add(
                lblExpertise
            );


            // =========================
            // BROWSE PROJECTS
            // =========================

            btnBrowseProjects =
                CreateMenuButton(
                    "Browse Projects",
                    45,
                    265
                );

            pnlContent.Controls.Add(
                btnBrowseProjects
            );


            // =========================
            // MY BIDS
            // =========================

            btnMyBids =
                CreateMenuButton(
                    "My Bids",
                    410,
                    265
                );

            pnlContent.Controls.Add(
                btnMyBids
            );


            // =========================
            // ONGOING PROJECTS
            // =========================

            btnOngoingProjects =
                CreateMenuButton(
                    "Ongoing Projects    3",
                    45,
                    345
                );

            pnlContent.Controls.Add(
                btnOngoingProjects
            );


            // =========================
            // COMPLETED PROJECTS
            // =========================

            btnCompletedProjects =
                CreateMenuButton(
                    "Completed Projects    12",
                    410,
                    345
                );

            pnlContent.Controls.Add(
                btnCompletedProjects
            );


            // =========================
            // MESSAGES
            // =========================

            btnMessages =
                CreateMenuButton(
                    "Messages",
                    45,
                    425
                );

            pnlContent.Controls.Add(
                btnMessages
            );
        }


        // =========================
        // CREATE MENU BUTTON
        // =========================

        private Button CreateMenuButton(
            string text,
            int x,
            int y)
        {
            Button button =
                new Button();

            button.Text =
                text;

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

            button.FlatAppearance.BorderSize =
                1;

            button.Cursor =
                Cursors.Hand;

            button.Location =
                new Point(x, y);

            button.Size =
                new Size(335, 60);

            return button;
        }
    }
}