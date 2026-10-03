using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Shared
{
    public class ClientProjectDetailsTestForm : Form
    {
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlProjectDetails;
        private Panel pnlBid;

        private Label lblPlatformName;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuProfile;
        private ToolStripMenuItem menuEditProfile;
        private Button btnLogout;

        private Label lblPageTitle;
        private Label lblSubtitle;

        private Label lblProjectTitle;
        private Label lblDescription;
        private Label lblBudget;
        private Label lblDeadline;
        private Label lblStatus;
        private Label lblClient;

        private Button btnAccept;
        private Button btnReject;
        private Button btnBack;

        public ClientProjectDetailsTestForm()
        {
            CreateForm();
        }

        private void CreateForm()
        {
            // ============================================================
            // FORM
            // ============================================================

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


            // ============================================================
            // NAVBAR
            // ============================================================

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


            // ============================================================
            // PLATFORM NAME
            // ============================================================

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


            // ============================================================
            // PROFILE MENU
            // ============================================================

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


            // ============================================================
            // LOGOUT
            // ============================================================

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


            // ============================================================
            // MAIN CONTENT
            // ============================================================

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


            // ============================================================
            // PAGE TITLE
            // ============================================================

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


            // ============================================================
            // SUBTITLE
            // ============================================================

            lblSubtitle =
                new Label();

            lblSubtitle.Text =
                "View project information and manage project progress";

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


            // ============================================================
            // PROJECT DETAILS CARD
            // ============================================================

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


            // ============================================================
            // PROJECT TITLE
            // ============================================================

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


            // ============================================================
            // DESCRIPTION
            // ============================================================

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


            // ============================================================
            // BUDGET
            // ============================================================

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


            // ============================================================
            // DEADLINE
            // ============================================================

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


            // ============================================================
            // STATUS
            // ============================================================

            lblStatus =
                new Label();

            lblStatus.Text =
                "Status:        Open";

            lblStatus.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblStatus.ForeColor =
                Color.FromArgb(45, 95, 160);

            lblStatus.AutoSize =
                true;

            lblStatus.Location =
                new Point(20, 135);

            pnlProjectDetails.Controls.Add(
                lblStatus
            );


            // ============================================================
            // CLIENT
            // ============================================================

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


            // ============================================================
            // RECEIVED BIDS TITLE
            // ============================================================

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


            // ============================================================
            // BID CARD
            // ============================================================

            pnlBid =
                new Panel();

            pnlBid.Location =
                new Point(45, 360);

            pnlBid.Size =
                new Size(714, 105);

            pnlBid.BackColor =
                Color.FromArgb(248, 249, 251);

            pnlBid.BorderStyle =
                BorderStyle.FixedSingle;

            pnlContent.Controls.Add(
                pnlBid
            );


            // ============================================================
            // FREELANCER NAME
            // ============================================================

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

            pnlBid.Controls.Add(
                lblFreelancer
            );


            // ============================================================
            // BID AMOUNT
            // ============================================================

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

            pnlBid.Controls.Add(
                lblBidAmount
            );


            // ============================================================
            // PROPOSAL
            // ============================================================

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

            pnlBid.Controls.Add(
                lblProposal
            );


            // ============================================================
            // ACCEPT BUTTON
            // ============================================================

            btnAccept =
                CreateSmallButton(
                    "ACCEPT",
                    520,
                    10
                );

            pnlBid.Controls.Add(
                btnAccept
            );


            // ============================================================
            // REJECT BUTTON
            // ============================================================

            btnReject =
                CreateSmallButton(
                    "REJECT",
                    520,
                    52
                );

            pnlBid.Controls.Add(
                btnReject
            );


            // ============================================================
            // BACK BUTTON
            // ============================================================

            btnBack =
                CreateSecondaryButton(
                    "BACK",
                    600,
                    455
                );

            btnBack.Click +=
                (sender, e) =>
                {
                    this.Close();
                };

            pnlContent.Controls.Add(
                btnBack
            );
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
                new Size(75, 30);

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
                new Size(115, 40);

            return button;
        }
    }
}