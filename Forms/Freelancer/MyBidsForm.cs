using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Freelancer
{
    public class MyBidsForm : Form
    {
        private Panel pnlHeader;
        private Label lblPlatformName;
        private Button btnBack;

        private Panel pnlContent;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlBid1;
        private Panel pnlBid2;
        private Panel pnlBid3;

        public MyBidsForm()
        {
            CreateMyBidsForm();
        }

        private void CreateMyBidsForm()
        {
            // -----------------------------
            // FORM
            // -----------------------------
            this.Text = "Freelance Platform - My Bids";
            this.Size = new Size(900, 680);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(245, 247, 250);

            // -----------------------------
            // HEADER
            // -----------------------------
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
            lblPlatformName.Location = new Point(32, 25);
            pnlHeader.Controls.Add(lblPlatformName);

            btnBack = new Button();
            btnBack.Text = "BACK";
            btnBack.Size = new Size(70, 30);
            btnBack.Location = new Point(785, 20);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderColor =
                Color.FromArgb(220, 224, 230);
            btnBack.BackColor =
                Color.FromArgb(248, 249, 251);
            btnBack.ForeColor =
                Color.FromArgb(50, 55, 60);
            btnBack.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Regular
            );
            btnBack.Cursor = Cursors.Hand;
            pnlHeader.Controls.Add(btnBack);

            // -----------------------------
            // MAIN CONTENT
            // -----------------------------
            pnlContent = new Panel();
            pnlContent.Location = new Point(40, 105);
            pnlContent.Size = new Size(804, 510);
            pnlContent.BackColor = Color.White;
            this.Controls.Add(pnlContent);

            // -----------------------------
            // TITLE
            // -----------------------------
            lblTitle = new Label();
            lblTitle.Text = "My Bids";
            lblTitle.Font = new Font(
                "Segoe UI",
                22,
                FontStyle.Bold
            );
            lblTitle.ForeColor =
                Color.FromArgb(25, 45, 70);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(45, 25);
            pnlContent.Controls.Add(lblTitle);

            // -----------------------------
            // SUBTITLE
            // -----------------------------
            lblSubtitle = new Label();
            lblSubtitle.Text =
                "View and manage the projects you have submitted bids for";
            lblSubtitle.Font = new Font(
                "Segoe UI",
                10,
                FontStyle.Regular
            );
            lblSubtitle.ForeColor =
                Color.FromArgb(105, 115, 125);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(48, 65);
            pnlContent.Controls.Add(lblSubtitle);

            // -----------------------------
            // BID 1
            // -----------------------------
            pnlBid1 = CreateBidCard(
                "Website Development",
                "Client Name",
                "$500",
                "$450",
                "3 October 2026",
                "Pending"
            );

            pnlBid1.Location = new Point(45, 105);
            pnlContent.Controls.Add(pnlBid1);

            // -----------------------------
            // BID 2
            // -----------------------------
            pnlBid2 = CreateBidCard(
                "E-commerce Website",
                "Sarah Ahmed",
                "$800",
                "$700",
                "1 October 2026",
                "Accepted"
            );

            pnlBid2.Location = new Point(45, 225);
            pnlContent.Controls.Add(pnlBid2);

            // -----------------------------
            // BID 3
            // -----------------------------
            pnlBid3 = CreateBidCard(
                "Mobile App Backend API",
                "Michael Brown",
                "$650",
                "$600",
                "28 September 2026",
                "Rejected"
            );

            pnlBid3.Location = new Point(45, 345);
            pnlContent.Controls.Add(pnlBid3);
        }

        // ============================================================
        // CREATE BID CARD
        // ============================================================
        private Panel CreateBidCard(
            string projectTitle,
            string clientName,
            string projectBudget,
            string bidAmount,
            string submittedDate,
            string status)
        {
            Panel card = new Panel();

            card.Size = new Size(714, 105);
            card.BackColor =
                Color.FromArgb(248, 249, 251);
            card.BorderStyle = BorderStyle.FixedSingle;

            // -----------------------------
            // PROJECT TITLE
            // -----------------------------
            Label lblProjectTitle = new Label();
            lblProjectTitle.Text = projectTitle;
            lblProjectTitle.Font = new Font(
                "Segoe UI",
                11,
                FontStyle.Bold
            );
            lblProjectTitle.ForeColor =
                Color.FromArgb(25, 45, 70);
            lblProjectTitle.AutoSize = true;
            lblProjectTitle.Location = new Point(20, 12);
            card.Controls.Add(lblProjectTitle);

            // -----------------------------
            // STATUS
            // -----------------------------
            Label lblStatus = new Label();
            lblStatus.Text = status;
            lblStatus.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Bold
            );
            lblStatus.ForeColor =
                GetStatusColor(status);
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(630, 15);
            card.Controls.Add(lblStatus);

            // -----------------------------
            // CLIENT
            // -----------------------------
            Label lblClientTitle = new Label();
            lblClientTitle.Text = "Client:";
            lblClientTitle.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            lblClientTitle.ForeColor =
                Color.FromArgb(90, 95, 100);
            lblClientTitle.AutoSize = true;
            lblClientTitle.Location = new Point(20, 42);
            card.Controls.Add(lblClientTitle);

            Label lblClient = new Label();
            lblClient.Text = clientName;
            lblClient.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Regular
            );
            lblClient.ForeColor =
                Color.FromArgb(35, 40, 45);
            lblClient.AutoSize = true;
            lblClient.Location = new Point(62, 42);
            card.Controls.Add(lblClient);

            // -----------------------------
            // PROJECT BUDGET
            // -----------------------------
            Label lblBudgetTitle = new Label();
            lblBudgetTitle.Text = "Project Budget:";
            lblBudgetTitle.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            lblBudgetTitle.ForeColor =
                Color.FromArgb(90, 95, 100);
            lblBudgetTitle.AutoSize = true;
            lblBudgetTitle.Location = new Point(150, 42);
            card.Controls.Add(lblBudgetTitle);

            Label lblBudget = new Label();
            lblBudget.Text = projectBudget;
            lblBudget.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Regular
            );
            lblBudget.ForeColor =
                Color.FromArgb(35, 40, 45);
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(238, 42);
            card.Controls.Add(lblBudget);

            // -----------------------------
            // YOUR BID
            // -----------------------------
            Label lblBidTitle = new Label();
            lblBidTitle.Text = "Your Bid:";
            lblBidTitle.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            lblBidTitle.ForeColor =
                Color.FromArgb(90, 95, 100);
            lblBidTitle.AutoSize = true;
            lblBidTitle.Location = new Point(300, 42);
            card.Controls.Add(lblBidTitle);

            Label lblBid = new Label();
            lblBid.Text = bidAmount;
            lblBid.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Regular
            );
            lblBid.ForeColor =
                Color.FromArgb(35, 40, 45);
            lblBid.AutoSize = true;
            lblBid.Location = new Point(355, 42);
            card.Controls.Add(lblBid);

            // -----------------------------
            // SUBMITTED DATE
            // -----------------------------
            Label lblDateTitle = new Label();
            lblDateTitle.Text = "Submitted:";
            lblDateTitle.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            lblDateTitle.ForeColor =
                Color.FromArgb(90, 95, 100);
            lblDateTitle.AutoSize = true;
            lblDateTitle.Location = new Point(20, 70);
            card.Controls.Add(lblDateTitle);

            Label lblDate = new Label();
            lblDate.Text = submittedDate;
            lblDate.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Regular
            );
            lblDate.ForeColor =
                Color.FromArgb(35, 40, 45);
            lblDate.AutoSize = true;
            lblDate.Location = new Point(82, 70);
            card.Controls.Add(lblDate);

            // -----------------------------
            // VIEW BUTTON
            // -----------------------------
            Button btnView = new Button();
            btnView.Text = "VIEW";
            btnView.Size = new Size(80, 30);
            btnView.Location = new Point(610, 58);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.FlatAppearance.BorderColor =
                Color.FromArgb(40, 120, 220);
            btnView.BackColor =
                Color.FromArgb(40, 120, 220);
            btnView.ForeColor = Color.White;
            btnView.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            btnView.Cursor = Cursors.Hand;
            card.Controls.Add(btnView);

            return card;
        }

        // ============================================================
        // STATUS COLOR
        // ============================================================
        private Color GetStatusColor(string status)
        {
            if (status == "Accepted")
            {
                return Color.FromArgb(40, 130, 80);
            }

            if (status == "Rejected")
            {
                return Color.FromArgb(190, 70, 70);
            }

            return Color.FromArgb(40, 120, 220);
        }
    }
}