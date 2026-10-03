using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Shared
{
    public class FreelancerProfileDetailsForm : Form
    {
        private Panel pnlHeader;
        private Label lblPlatformName;
        private Button btnBack;

        private Panel pnlContent;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlProfile;

        private Label lblFullNameTitle;
        private Label lblFullName;

        private Label lblContactTitle;
        private Label lblContact;

        private Label lblSkillsTitle;
        private Label lblSkills;

        private Label lblExpertiseTitle;
        private Label lblExpertise;

        private Label lblPortfolioTitle;
        private Label lblPortfolio;

        private Label lblCompletedProjects;

        private Panel pnlProject1;
        private Panel pnlProject2;

        private Button btnMessage;

        public FreelancerProfileDetailsForm()
        {
            CreateFreelancerProfileDetailsForm();
        }

        private void CreateFreelancerProfileDetailsForm()
        {
            // ============================================================
            // FORM
            // ============================================================
            this.Text = "Freelance Platform - Freelancer Profile";
            this.Size = new Size(900, 680);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 250);

            // ============================================================
            // HEADER
            // ============================================================
            pnlHeader = new Panel();
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(884, 75);
            pnlHeader.BackColor = Color.White;
            this.Controls.Add(pnlHeader);

            lblPlatformName = new Label();
            lblPlatformName.Text = "FREELANCE PLATFORM";
            lblPlatformName.Font = new Font(
                "Segoe UI",
                14,
                FontStyle.Bold
            );
            lblPlatformName.ForeColor =
                Color.FromArgb(25, 45, 70);
            lblPlatformName.AutoSize = true;
            lblPlatformName.Location =
                new Point(22, 25);
            pnlHeader.Controls.Add(lblPlatformName);

            btnBack = new Button();
            btnBack.Text = "BACK";
            btnBack.Size = new Size(70, 30);
            btnBack.Location =
                new Point(773, 20);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderColor =
                Color.FromArgb(220, 224, 230);
            btnBack.BackColor =
                Color.FromArgb(248, 249, 251);
            btnBack.ForeColor =
                Color.FromArgb(50, 55, 60);
            btnBack.Font = new Font(
                "Segoe UI",
                9
            );
            btnBack.Cursor = Cursors.Hand;
            pnlHeader.Controls.Add(btnBack);

            // ============================================================
            // MAIN CONTENT
            // ============================================================
            pnlContent = new Panel();
            pnlContent.Location =
                new Point(24, 105);
            pnlContent.Size =
                new Size(804, 530);
            pnlContent.BackColor =
                Color.White;
            this.Controls.Add(pnlContent);

            // ============================================================
            // TITLE
            // ============================================================
            lblTitle = new Label();
            lblTitle.Text = "Freelancer Profile";
            lblTitle.Font = new Font(
                "Segoe UI",
                22,
                FontStyle.Bold
            );
            lblTitle.ForeColor =
                Color.FromArgb(25, 45, 70);
            lblTitle.AutoSize = true;
            lblTitle.Location =
                new Point(45, 25);
            pnlContent.Controls.Add(lblTitle);

            // ============================================================
            // SUBTITLE
            // ============================================================
            lblSubtitle = new Label();
            lblSubtitle.Text =
                "View freelancer information, portfolio and completed work";
            lblSubtitle.Font = new Font(
                "Segoe UI",
                10
            );
            lblSubtitle.ForeColor =
                Color.FromArgb(105, 115, 125);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location =
                new Point(48, 65);
            pnlContent.Controls.Add(lblSubtitle);

            // ============================================================
            // PROFILE CARD
            // ============================================================
            pnlProfile = new Panel();
            pnlProfile.Location =
                new Point(45, 105);
            pnlProfile.Size =
                new Size(714, 230);
            pnlProfile.BackColor =
                Color.FromArgb(248, 249, 251);
            pnlProfile.BorderStyle =
                BorderStyle.FixedSingle;
            pnlContent.Controls.Add(pnlProfile);

            // ============================================================
            // FULL NAME
            // ============================================================
            lblFullNameTitle = CreateInfoTitle(
                "Full Name",
                new Point(20, 18)
            );
            pnlProfile.Controls.Add(lblFullNameTitle);

            lblFullName = CreateInfoValue(
                "John Smith",
                new Point(20, 40)
            );
            pnlProfile.Controls.Add(lblFullName);

            // ============================================================
            // CONTACT
            // ============================================================
            lblContactTitle = CreateInfoTitle(
                "Contact Details",
                new Point(365, 18)
            );
            pnlProfile.Controls.Add(lblContactTitle);

            lblContact = CreateInfoValue(
                "john@example.com",
                new Point(365, 40)
            );
            pnlProfile.Controls.Add(lblContact);

            // ============================================================
            // SKILLS
            // ============================================================
            lblSkillsTitle = CreateInfoTitle(
                "Skills",
                new Point(20, 78)
            );
            pnlProfile.Controls.Add(lblSkillsTitle);

            lblSkills = CreateInfoValue(
                "C#, ASP.NET, SQL Server, REST API",
                new Point(20, 100)
            );
            pnlProfile.Controls.Add(lblSkills);

            // ============================================================
            // EXPERTISE
            // ============================================================
            lblExpertiseTitle = CreateInfoTitle(
                "Expertise",
                new Point(365, 78)
            );
            pnlProfile.Controls.Add(lblExpertiseTitle);

            lblExpertise = CreateInfoValue(
                "Backend Web Development",
                new Point(365, 100)
            );
            pnlProfile.Controls.Add(lblExpertise);

            // ============================================================
            // PORTFOLIO
            // ============================================================
            lblPortfolioTitle = CreateInfoTitle(
                "Portfolio",
                new Point(20, 140)
            );
            pnlProfile.Controls.Add(lblPortfolioTitle);

            lblPortfolio = CreateInfoValue(
                "GitHub: github.com/johnsmith\r\n" +
                "Website: johnsmith.dev",
                new Point(20, 162)
            );
            lblPortfolio.AutoSize = false;
            lblPortfolio.Size =
                new Size(650, 50);
            pnlProfile.Controls.Add(lblPortfolio);

            // ============================================================
            // COMPLETED PROJECTS TITLE
            // ============================================================
            lblCompletedProjects = new Label();
            lblCompletedProjects.Text =
                "Completed Projects";
            lblCompletedProjects.Font = new Font(
                "Segoe UI",
                10,
                FontStyle.Bold
            );
            lblCompletedProjects.ForeColor =
                Color.FromArgb(50, 55, 60);
            lblCompletedProjects.AutoSize = true;
            lblCompletedProjects.Location =
                new Point(45, 355);
            pnlContent.Controls.Add(lblCompletedProjects);

            // ============================================================
            // COMPLETED PROJECT 1
            // ============================================================
            pnlProject1 = CreateCompletedProjectCard(
                "Website Development",
                "Completed: 25 October 2026",
                "$450"
            );

            pnlProject1.Location =
                new Point(45, 380);
            pnlContent.Controls.Add(pnlProject1);

            // ============================================================
            // COMPLETED PROJECT 2
            // ============================================================
            pnlProject2 = CreateCompletedProjectCard(
                "E-commerce API",
                "Completed: 10 September 2026",
                "$600"
            );

            pnlProject2.Location =
                new Point(405, 380);
            pnlContent.Controls.Add(pnlProject2);

            // ============================================================
            // MESSAGE FREELANCER BUTTON
            // ============================================================
            btnMessage = new Button();
            btnMessage.Text =
                "MESSAGE FREELANCER";
            btnMessage.Size =
                new Size(180, 40);
            btnMessage.Location =
                new Point(45, 465);
            btnMessage.FlatStyle =
                FlatStyle.Flat;
            btnMessage.FlatAppearance.BorderColor =
                Color.FromArgb(40, 120, 220);
            btnMessage.BackColor =
                Color.FromArgb(40, 120, 220);
            btnMessage.ForeColor =
                Color.White;
            btnMessage.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Bold
            );
            btnMessage.Cursor =
                Cursors.Hand;
            pnlContent.Controls.Add(btnMessage);
        }

        // ============================================================
        // CREATE INFO TITLE
        // ============================================================
        private Label CreateInfoTitle(
            string text,
            Point location)
        {
            Label label = new Label();

            label.Text = text;
            label.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Bold
            );
            label.ForeColor =
                Color.FromArgb(90, 95, 100);
            label.AutoSize = true;
            label.Location =
                location;

            return label;
        }

        // ============================================================
        // CREATE INFO VALUE
        // ============================================================
        private Label CreateInfoValue(
            string text,
            Point location)
        {
            Label label = new Label();

            label.Text = text;
            label.Font = new Font(
                "Segoe UI",
                10,
                FontStyle.Regular
            );
            label.ForeColor =
                Color.FromArgb(35, 40, 45);
            label.AutoSize = true;
            label.Location =
                location;

            return label;
        }

        // ============================================================
        // COMPLETED PROJECT CARD
        // ============================================================
        private Panel CreateCompletedProjectCard(
            string projectTitle,
            string completedDate,
            string amount)
        {
            Panel card = new Panel();

            card.Size =
                new Size(334, 60);
            card.BackColor =
                Color.FromArgb(248, 249, 251);
            card.BorderStyle =
                BorderStyle.FixedSingle;

            // Project title
            Label lblProjectTitle =
                new Label();

            lblProjectTitle.Text =
                projectTitle;

            lblProjectTitle.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblProjectTitle.ForeColor =
                Color.FromArgb(25, 45, 70);

            lblProjectTitle.AutoSize = true;

            lblProjectTitle.Location =
                new Point(12, 8);

            card.Controls.Add(
                lblProjectTitle
            );

            // Completed date
            Label lblDate =
                new Label();

            lblDate.Text =
                completedDate;

            lblDate.Font =
                new Font(
                    "Segoe UI",
                    8
                );

            lblDate.ForeColor =
                Color.FromArgb(90, 95, 100);

            lblDate.AutoSize = true;

            lblDate.Location =
                new Point(12, 32);

            card.Controls.Add(
                lblDate
            );

            // Amount
            Label lblAmount =
                new Label();

            lblAmount.Text =
                amount;

            lblAmount.Font =
                new Font(
                    "Segoe UI",
                    8,
                    FontStyle.Bold
                );

            lblAmount.ForeColor =
                Color.FromArgb(40, 130, 80);

            lblAmount.AutoSize = true;

            lblAmount.Location =
                new Point(230, 32);

            card.Controls.Add(
                lblAmount
            );

            return card;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FreelancerProfileDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FreelancerProfileDetailsForm";
            this.Load += new System.EventHandler(this.FreelancerProfileDetailsForm_Load);
            this.ResumeLayout(false);

        }

        private void FreelancerProfileDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}