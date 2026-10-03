using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Shared
{
    public class ProjectDetailsForm : Form
    {
        // ============================================================
        // FORM MODE
        // ============================================================

        private bool isClientView;
        private string projectStatus;

        // ============================================================
        // MAIN PANELS
        // ============================================================

        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlProjectDetails;
        private Panel pnlBids;
        private Panel pnlFreelancerInfo;
        private Panel pnlReview;

        // ============================================================
        // NAVBAR
        // ============================================================

        private Label lblPlatformName;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuProfile;
        private ToolStripMenuItem menuEditProfile;
        private Button btnLogout;

        // ============================================================
        // PAGE
        // ============================================================

        private Label lblPageTitle;
        private Label lblSubtitle;

        // ============================================================
        // PROJECT DETAILS
        // ============================================================

        private Label lblProjectTitle;
        private Label lblDescription;
        private Label lblBudget;
        private Label lblDeadline;
        private Label lblStatus;
        private Label lblClient;

        // ============================================================
        // BUTTONS
        // ============================================================

        private Button btnPrimary;
        private Button btnBack;

        // ============================================================
        // DEFAULT CONSTRUCTOR
        // ============================================================

        public ProjectDetailsForm()
        {
            // Default view = Freelancer
            isClientView = false;

            projectStatus = "Open";

            CreateProjectDetailsForm();
        }

        // ============================================================
        // CLIENT / FREELANCER CONSTRUCTOR
        // ============================================================

        public ProjectDetailsForm(bool clientView)
        {
            isClientView = clientView;

            projectStatus = "Open";

            CreateProjectDetailsForm();
        }

        // ============================================================
        // CLIENT / FREELANCER + PROJECT STATUS
        // ============================================================

        public ProjectDetailsForm(
            bool clientView,
            string status)
        {
            isClientView = clientView;

            projectStatus = status;

            CreateProjectDetailsForm();
        }

        // ============================================================
        // CREATE FORM
        // ============================================================

        private void CreateProjectDetailsForm()
        {
            // ========================================================
            // FORM
            // ========================================================

            this.Text =
                "Freelance Platform - Project Details";

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Size =
                new Size(900, 680);

            this.BackColor =
                Color.FromArgb(245, 247, 250);

            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.MaximizeBox =
                false;

            // ========================================================
            // NAVBAR
            // ========================================================

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

            // ========================================================
            // PLATFORM NAME
            // ========================================================

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

            // ========================================================
            // PROFILE MENU
            // ========================================================

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

            // ========================================================
            // LOGOUT
            // ========================================================

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

            // ========================================================
            // MAIN CONTENT
            // ========================================================

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

            // ========================================================
            // PAGE TITLE
            // ========================================================

            lblPageTitle =
                new Label();

            lblPageTitle.Text =
                "Project Details";

            lblPageTitle.Font =
                new Font(
                    "Segoe UI",
                    22,
                    FontStyle.Bold
                );

            lblPageTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblPageTitle.AutoSize =
                true;

            lblPageTitle.Location =
                new Point(45, 30);

            pnlContent.Controls.Add(
                lblPageTitle
            );

            // ========================================================
            // SUBTITLE
            // ========================================================

            lblSubtitle =
                new Label();

            if (isClientView)
            {
                lblSubtitle.Text =
                    "View project information and manage project progress";
            }
            else
            {
                lblSubtitle.Text =
                    "View project information and submit your bid";
            }

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

            // ========================================================
            // PROJECT DETAILS CARD
            // ========================================================

            pnlProjectDetails =
                new Panel();

            pnlProjectDetails.Location =
                new Point(45, 110);

            pnlProjectDetails.Size =
                new Size(714, 205);

            pnlProjectDetails.BackColor =
                Color.FromArgb(248, 249, 251);

            pnlProjectDetails.BorderStyle =
                BorderStyle.FixedSingle;

            pnlContent.Controls.Add(
                pnlProjectDetails
            );

            // ========================================================
            // PROJECT TITLE
            // ========================================================

            lblProjectTitle =
                new Label();

            lblProjectTitle.Text =
                "Website Development";

            lblProjectTitle.Font =
                new Font(
                    "Segoe UI",
                    15,
                    FontStyle.Bold
                );

            lblProjectTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblProjectTitle.AutoSize =
                true;

            lblProjectTitle.Location =
                new Point(20, 18);

            pnlProjectDetails.Controls.Add(
                lblProjectTitle
            );

            // ========================================================
            // DESCRIPTION
            // ========================================================

            lblDescription =
                new Label();

            lblDescription.Text =
                "Description:  Build a responsive business website with a modern design.";

            lblDescription.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblDescription.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblDescription.AutoSize =
                true;

            lblDescription.Location =
                new Point(20, 55);

            pnlProjectDetails.Controls.Add(
                lblDescription
            );

            // ========================================================
            // BUDGET
            // ========================================================

            lblBudget =
                new Label();

            lblBudget.Text =
                "Budget:        $500";

            lblBudget.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblBudget.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblBudget.AutoSize =
                true;

            lblBudget.Location =
                new Point(20, 95);

            pnlProjectDetails.Controls.Add(
                lblBudget
            );

            // ========================================================
            // DEADLINE
            // ========================================================

            lblDeadline =
                new Label();

            lblDeadline.Text =
                "Deadline:      20 October 2026";

            lblDeadline.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblDeadline.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblDeadline.AutoSize =
                true;

            lblDeadline.Location =
                new Point(250, 95);

            pnlProjectDetails.Controls.Add(
                lblDeadline
            );

            // ========================================================
            // STATUS
            // ========================================================

            lblStatus =
                new Label();

            lblStatus.Text =
                "Status:        " + projectStatus;

            lblStatus.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblStatus.ForeColor =
                GetStatusColor();

            lblStatus.AutoSize =
                true;

            lblStatus.Location =
                new Point(20, 135);

            pnlProjectDetails.Controls.Add(
                lblStatus
            );

            // ========================================================
            // CLIENT
            // ========================================================

            lblClient =
                new Label();

            lblClient.Text =
                "Client:        Client Name";

            lblClient.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblClient.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblClient.AutoSize =
                true;

            lblClient.Location =
                new Point(250, 135);

            pnlProjectDetails.Controls.Add(
                lblClient
            );

            // ========================================================
            // CONTENT BASED ON ROLE + STATUS
            // ========================================================

            if (!isClientView)
            {
                CreateFreelancerSection();
            }
            else
            {
                CreateClientSection();
            }

            // ========================================================
            // BACK BUTTON
            // ========================================================

            btnBack =
                CreateSecondaryButton(
                    "BACK",
                    600,
                    455
                );

            pnlContent.Controls.Add(
                btnBack
            );
        }

        // ============================================================
        // GET STATUS COLOR
        // ============================================================

        private Color GetStatusColor()
        {
            if (projectStatus == "Completed")
            {
                return Color.FromArgb(
                    55,
                    130,
                    85
                );
            }

            if (projectStatus == "In Progress")
            {
                return Color.FromArgb(
                    210,
                    130,
                    45
                );
            }

            return Color.FromArgb(
                45,
                95,
                160
            );
        }

        // ============================================================
        // FREELANCER SECTION
        // ============================================================

        private void CreateFreelancerSection()
        {
            btnPrimary =
                CreatePrimaryButton(
                    "BID THE PROJECT",
                    45,
                    350
                );

            pnlContent.Controls.Add(
                btnPrimary
            );
        }

        // ============================================================
        // CLIENT SECTION
        // ============================================================

        private void CreateClientSection()
        {
            if (projectStatus == "Open")
            {
                CreateOpenProjectSection();
            }
            else if (projectStatus == "In Progress")
            {
                CreateInProgressSection();
            }
            else if (projectStatus == "Completed")
            {
                CreateCompletedSection();
            }
            else
            {
                CreateOpenProjectSection();
            }
        }

        // ============================================================
        // OPEN PROJECT
        // ============================================================

        private void CreateOpenProjectSection()
        {
            // ========================================================
            // BIDS TITLE
            // ========================================================

            Label lblBidsTitle =
                new Label();

            lblBidsTitle.Text =
                "Received Bids";

            lblBidsTitle.Font =
                new Font(
                    "Segoe UI",
                    13,
                    FontStyle.Bold
                );

            lblBidsTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblBidsTitle.AutoSize =
                true;

            lblBidsTitle.Location =
                new Point(45, 330);

            pnlContent.Controls.Add(
                lblBidsTitle
            );

            // ========================================================
            // BID CARD
            // ========================================================

            pnlBids =
                new Panel();

            pnlBids.Location =
                new Point(45, 360);

            pnlBids.Size =
                new Size(714, 105);

            pnlBids.BackColor =
                Color.FromArgb(248, 249, 251);

            pnlBids.BorderStyle =
                BorderStyle.FixedSingle;

            pnlContent.Controls.Add(
                pnlBids
            );

            // ========================================================
            // FREELANCER NAME
            // ========================================================

            Label lblFreelancer =
                new Label();

            lblFreelancer.Text =
                "John Smith";

            lblFreelancer.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            lblFreelancer.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblFreelancer.AutoSize =
                true;

            lblFreelancer.Location =
                new Point(15, 12);

            pnlBids.Controls.Add(
                lblFreelancer
            );

            // ========================================================
            // BID AMOUNT
            // ========================================================

            Label lblBidAmount =
                new Label();

            lblBidAmount.Text =
                "Bid: $450";

            lblBidAmount.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblBidAmount.ForeColor =
                Color.FromArgb(45, 95, 160);

            lblBidAmount.AutoSize =
                true;

            lblBidAmount.Location =
                new Point(180, 13);

            pnlBids.Controls.Add(
                lblBidAmount
            );

            // ========================================================
            // PROPOSAL
            // ========================================================

            Label lblProposal =
                new Label();

            lblProposal.Text =
                "Proposal: I can complete the project within the required deadline.";

            lblProposal.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblProposal.ForeColor =
                Color.FromArgb(75, 82, 92);

            lblProposal.AutoSize =
                true;

            lblProposal.Location =
                new Point(15, 45);

            pnlBids.Controls.Add(
                lblProposal
            );

            // ========================================================
            // ACCEPT
            // ========================================================

            Button btnAccept =
                CreateSmallButton(
                    "ACCEPT",
                    520,
                    10
                );

            pnlBids.Controls.Add(
                btnAccept
            );

            // ========================================================
            // REJECT
            // ========================================================

            Button btnReject =
                CreateSmallButton(
                    "REJECT",
                    520,
                    52
                );

            pnlBids.Controls.Add(
                btnReject
            );
        }

        // ============================================================
        // IN PROGRESS PROJECT
        // ============================================================

        private void CreateInProgressSection()
        {
            // ========================================================
            // SECTION TITLE
            // ========================================================

            Label lblProgressTitle =
                new Label();

            lblProgressTitle.Text =
                "Assigned Freelancer";

            lblProgressTitle.Font =
                new Font(
                    "Segoe UI",
                    13,
                    FontStyle.Bold
                );

            lblProgressTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblProgressTitle.AutoSize =
                true;

            lblProgressTitle.Location =
                new Point(45, 330);

            pnlContent.Controls.Add(
                lblProgressTitle
            );

            // ========================================================
            // FREELANCER CARD
            // ========================================================

            pnlFreelancerInfo =
                new Panel();

            pnlFreelancerInfo.Location =
                new Point(45, 360);

            pnlFreelancerInfo.Size =
                new Size(714, 90);

            pnlFreelancerInfo.BackColor =
                Color.FromArgb(248, 249, 251);

            pnlFreelancerInfo.BorderStyle =
                BorderStyle.FixedSingle;

            pnlContent.Controls.Add(
                pnlFreelancerInfo
            );

            // ========================================================
            // FREELANCER NAME
            // ========================================================

            Label lblFreelancer =
                new Label();

            lblFreelancer.Text =
                "Freelancer:  John Smith";

            lblFreelancer.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            lblFreelancer.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblFreelancer.AutoSize =
                true;

            lblFreelancer.Location =
                new Point(15, 15);

            pnlFreelancerInfo.Controls.Add(
                lblFreelancer
            );

            // ========================================================
            // AGREED AMOUNT
            // ========================================================

            Label lblAgreedAmount =
                new Label();

            lblAgreedAmount.Text =
                "Agreed Amount: $450";

            lblAgreedAmount.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblAgreedAmount.ForeColor =
                Color.FromArgb(75, 82, 92);

            lblAgreedAmount.AutoSize =
                true;

            lblAgreedAmount.Location =
                new Point(15, 48);

            pnlFreelancerInfo.Controls.Add(
                lblAgreedAmount
            );

            // ========================================================
            // MARK AS COMPLETED
            // ========================================================

            btnPrimary =
                CreatePrimaryButton(
                    "MARK AS COMPLETED",
                    45,
                    465
                );

            btnPrimary.Size =
                new Size(
                    210,
                    40
                );

            pnlContent.Controls.Add(
                btnPrimary
            );
        }

        // ============================================================
        // COMPLETED PROJECT
        // ============================================================

        private void CreateCompletedSection()
        {
            // ========================================================
            // SECTION TITLE
            // ========================================================

            Label lblCompletedTitle =
                new Label();

            lblCompletedTitle.Text =
                "Project Completed";

            lblCompletedTitle.Font =
                new Font(
                    "Segoe UI",
                    13,
                    FontStyle.Bold
                );

            lblCompletedTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblCompletedTitle.AutoSize =
                true;

            lblCompletedTitle.Location =
                new Point(45, 330);

            pnlContent.Controls.Add(
                lblCompletedTitle
            );

            // ========================================================
            // FREELANCER CARD
            // ========================================================

            pnlFreelancerInfo =
                new Panel();

            pnlFreelancerInfo.Location =
                new Point(45, 360);

            pnlFreelancerInfo.Size =
                new Size(714, 90);

            pnlFreelancerInfo.BackColor =
                Color.FromArgb(248, 249, 251);

            pnlFreelancerInfo.BorderStyle =
                BorderStyle.FixedSingle;

            pnlContent.Controls.Add(
                pnlFreelancerInfo
            );

            // ========================================================
            // FREELANCER LABEL
            // ========================================================

            Label lblFreelancerLabel =
                new Label();

            lblFreelancerLabel.Text =
                "Freelancer:";

            lblFreelancerLabel.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblFreelancerLabel.ForeColor =
                Color.FromArgb(75, 82, 92);

            lblFreelancerLabel.AutoSize =
                true;

            lblFreelancerLabel.Location =
                new Point(15, 15);

            pnlFreelancerInfo.Controls.Add(
                lblFreelancerLabel
            );

            // ========================================================
            // CLICKABLE FREELANCER NAME
            // ========================================================

            LinkLabel lnkFreelancer =
                new LinkLabel();

            lnkFreelancer.Text =
                "John Smith";

            lnkFreelancer.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            lnkFreelancer.LinkColor =
                Color.FromArgb(45, 95, 160);

            lnkFreelancer.ActiveLinkColor =
                Color.FromArgb(30, 75, 130);

            lnkFreelancer.AutoSize =
                true;

            lnkFreelancer.Location =
                new Point(85, 13);

            lnkFreelancer.Cursor =
                Cursors.Hand;

            pnlFreelancerInfo.Controls.Add(
                lnkFreelancer
            );

            // ========================================================
            // FREELANCER ID
            // ========================================================

            Label lblFreelancerID =
                new Label();

            lblFreelancerID.Text =
                "Freelancer ID: 1024";

            lblFreelancerID.Font =
                new Font(
                    "Segoe UI",
                    8
                );

            lblFreelancerID.ForeColor =
                Color.FromArgb(105, 112, 122);

            lblFreelancerID.AutoSize =
                true;

            lblFreelancerID.Location =
                new Point(15, 48);

            pnlFreelancerInfo.Controls.Add(
                lblFreelancerID
            );

            // ========================================================
            // REVIEW SECTION
            // ========================================================

            pnlReview =
                new Panel();

            pnlReview.Location =
                new Point(390, 10);

            pnlReview.Size =
                new Size(305, 70);

            pnlReview.BackColor =
                Color.White;

            pnlReview.BorderStyle =
                BorderStyle.FixedSingle;

            pnlFreelancerInfo.Controls.Add(
                pnlReview
            );

            // ========================================================
            // REVIEW LABEL
            // ========================================================

            Label lblReviewTitle =
                new Label();

            lblReviewTitle.Text =
                "Given Review";

            lblReviewTitle.Font =
                new Font(
                    "Segoe UI",
                    8,
                    FontStyle.Bold
                );

            lblReviewTitle.ForeColor =
                Color.FromArgb(75, 82, 92);

            lblReviewTitle.AutoSize =
                true;

            lblReviewTitle.Location =
                new Point(12, 8);

            pnlReview.Controls.Add(
                lblReviewTitle
            );

            // ========================================================
            // RATING
            // ========================================================

            Label lblRating =
                new Label();

            lblRating.Text =
                "★★★★★  5/5";

            lblRating.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblRating.ForeColor =
                Color.FromArgb(45, 95, 160);

            lblRating.AutoSize =
                true;

            lblRating.Location =
                new Point(12, 28);

            pnlReview.Controls.Add(
                lblRating
            );

            // ========================================================
            // REVIEW COMMENT
            // ========================================================

            Label lblReviewComment =
                new Label();

            lblReviewComment.Text =
                "\"Excellent work and communication.\"";

            lblReviewComment.Font =
                new Font(
                    "Segoe UI",
                    7.5f
                );

            lblReviewComment.ForeColor =
                Color.FromArgb(90, 98, 108);

            lblReviewComment.AutoSize =
                true;

            lblReviewComment.Location =
                new Point(105, 30);

            pnlReview.Controls.Add(
                lblReviewComment
            );

            // ========================================================
            // FREELANCER LINK ACTION
            // ========================================================

            lnkFreelancer.LinkClicked +=
                (sender, e) =>
                {
                    FreelancerProfileDetailsForm profileForm =
                        new FreelancerProfileDetailsForm();

                    profileForm.ShowDialog();
                };
        }

        // ============================================================
        // PRIMARY BUTTON
        // ============================================================

        private Button CreatePrimaryButton(
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
                Color.White;

            button.BackColor =
                Color.FromArgb(45, 95, 160);

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize =
                0;

            button.Cursor =
                Cursors.Hand;

            button.Location =
                new Point(x, y);

            button.Size =
                new Size(
                    335,
                    55
                );

            return button;
        }

        // ============================================================
        // SECONDARY BUTTON
        // ============================================================

        private Button CreateSecondaryButton(
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
                    9,
                    FontStyle.Bold
                );

            button.ForeColor =
                Color.FromArgb(70, 70, 70);

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
                new Size(
                    115,
                    40
                );

            return button;
        }

        // ============================================================
        // SMALL BUTTON
        // ============================================================

        private Button CreateSmallButton(
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
                    8,
                    FontStyle.Bold
                );

            button.ForeColor =
                Color.FromArgb(45, 95, 160);

            button.BackColor =
                Color.White;

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderColor =
                Color.FromArgb(210, 215, 222);

            button.FlatAppearance.BorderSize =
                1;

            button.Cursor =
                Cursors.Hand;

            button.Location =
                new Point(x, y);

            button.Size =
                new Size(
                    75,
                    30
                );

            return button;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ProjectDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "ProjectDetailsForm";
            this.Load += new System.EventHandler(this.ProjectDetailsForm_Load);
            this.ResumeLayout(false);

        }

        private void ProjectDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}