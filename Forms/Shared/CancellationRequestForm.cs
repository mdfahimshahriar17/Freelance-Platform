using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Shared
{
    public class CancellationRequestForm : Form
    {
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlProjectDetails;
        private Panel pnlRequest;

        private Label lblPlatformName;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuProfile;
        private ToolStripMenuItem menuEditProfile;
        private Button btnLogout;

        private Label lblPageTitle;
        private Label lblSubtitle;

        private Label lblProjectTitle;
        private Label lblStatus;
        private Label lblClient;
        private Label lblFreelancer;
        private Label lblAgreedAmount;

        private Label lblRequestTitle;
        private Label lblRequestedBy;
        private Label lblReasonTitle;
        private TextBox txtReason;
        private Label lblRequestStatus;

        private Button btnAccept;
        private Button btnDecline;
        private Button btnBack;

        public CancellationRequestForm()
        {
            CreateForm();
        }

        private void CreateForm()
        {
            // ============================================================
            // FORM
            // ============================================================

            this.Text =
                "Freelance Platform - Cancellation Request";

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
                "Cancellation Request";

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
                "Review the cancellation request before making a decision";

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
            // PROJECT INFORMATION
            // ============================================================

            pnlProjectDetails =
                new Panel();

            pnlProjectDetails.Location =
                new Point(45, 110);

            pnlProjectDetails.Size =
                new Size(714, 150);

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
                    14,
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
            // STATUS
            // ============================================================

            lblStatus =
                new Label();

            lblStatus.Text =
                "Status:        In Progress";

            lblStatus.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblStatus.ForeColor =
                Color.FromArgb(210, 130, 45);

            lblStatus.AutoSize =
                true;

            lblStatus.Location =
                new Point(20, 55);

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
                new Point(250, 55);

            pnlProjectDetails.Controls.Add(
                lblClient
            );


            // ============================================================
            // FREELANCER
            // ============================================================

            lblFreelancer =
                new Label();

            lblFreelancer.Text =
                "Freelancer:  John Smith";

            lblFreelancer.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblFreelancer.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblFreelancer.AutoSize =
                true;

            lblFreelancer.Location =
                new Point(20, 90);

            pnlProjectDetails.Controls.Add(
                lblFreelancer
            );


            // ============================================================
            // AGREED AMOUNT
            // ============================================================

            lblAgreedAmount =
                new Label();

            lblAgreedAmount.Text =
                "Agreed Amount:  $450";

            lblAgreedAmount.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblAgreedAmount.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblAgreedAmount.AutoSize =
                true;

            lblAgreedAmount.Location =
                new Point(250, 90);

            pnlProjectDetails.Controls.Add(
                lblAgreedAmount
            );


            // ============================================================
            // REQUEST SECTION
            // ============================================================

            pnlRequest =
                new Panel();

            pnlRequest.Location =
                new Point(45, 280);

            pnlRequest.Size =
                new Size(714, 175);

            pnlRequest.BackColor =
                Color.White;

            pnlContent.Controls.Add(
                pnlRequest
            );


            // ============================================================
            // REQUEST TITLE
            // ============================================================

            lblRequestTitle =
                new Label();

            lblRequestTitle.Text =
                "Cancellation Request";

            lblRequestTitle.Font =
                new Font(
                    "Segoe UI",
                    13,
                    FontStyle.Bold
                );

            lblRequestTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblRequestTitle.AutoSize =
                true;

            lblRequestTitle.Location =
                new Point(0, 0);

            pnlRequest.Controls.Add(
                lblRequestTitle
            );


            // ============================================================
            // REQUESTED BY
            // ============================================================

            lblRequestedBy =
                new Label();

            lblRequestedBy.Text =
                "Requested By:  Client";

            lblRequestedBy.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblRequestedBy.ForeColor =
                Color.FromArgb(75, 82, 92);

            lblRequestedBy.AutoSize =
                true;

            lblRequestedBy.Location =
                new Point(0, 32);

            pnlRequest.Controls.Add(
                lblRequestedBy
            );


            // ============================================================
            // REASON TITLE
            // ============================================================

            lblReasonTitle =
                new Label();

            lblReasonTitle.Text =
                "Reason / Issue";

            lblReasonTitle.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblReasonTitle.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblReasonTitle.AutoSize =
                true;

            lblReasonTitle.Location =
                new Point(0, 62);

            pnlRequest.Controls.Add(
                lblReasonTitle
            );


            // ============================================================
            // REASON TEXTBOX
            // ============================================================

            txtReason =
                new TextBox();

            txtReason.Multiline =
                true;

            txtReason.ReadOnly =
                true;

            txtReason.Text =
                "The project requirements have changed and the original requirements are no longer applicable.";

            txtReason.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            txtReason.ForeColor =
                Color.FromArgb(75, 82, 92);

            txtReason.BackColor =
                Color.FromArgb(248, 249, 251);

            txtReason.BorderStyle =
                BorderStyle.FixedSingle;

            txtReason.Location =
                new Point(0, 85);

            txtReason.Size =
                new Size(714, 55);

            pnlRequest.Controls.Add(
                txtReason
            );


            // ============================================================
            // REQUEST STATUS
            // ============================================================

            lblRequestStatus =
                new Label();

            lblRequestStatus.Text =
                "●  Waiting for your response";

            lblRequestStatus.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblRequestStatus.ForeColor =
                Color.FromArgb(210, 130, 45);

            lblRequestStatus.AutoSize =
                true;

            lblRequestStatus.Location =
                new Point(0, 150);

            pnlRequest.Controls.Add(
                lblRequestStatus
            );


            // ============================================================
            // ACCEPT BUTTON
            // ============================================================

            btnAccept =
                CreatePrimaryButton(
                    "ACCEPT CANCELLATION",
                    45,
                    460
                );

            btnAccept.Size =
                new Size(
                    220,
                    40
                );

            pnlContent.Controls.Add(
                btnAccept
            );


            // ============================================================
            // DECLINE BUTTON
            // ============================================================

            btnDecline =
                CreateSecondaryButton(
                    "DECLINE",
                    280,
                    460
                );

            pnlContent.Controls.Add(
                btnDecline
            );


            // ============================================================
            // BACK BUTTON
            // ============================================================

            btnBack =
                CreateSecondaryButton(
                    "BACK",
                    600,
                    460
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
                    9,
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
                    220,
                    40
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
    }
}
