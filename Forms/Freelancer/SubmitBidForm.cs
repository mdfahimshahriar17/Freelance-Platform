using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Freelancer
{
    public class SubmitBidForm : Form
    {
        private Panel pnlHeader;
        private Label lblPlatformName;
        private Button btnBack;

        private Panel pnlContent;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlProject;
        private Label lblProjectTitle;
        private Label lblProjectName;
        private Label lblClientTitle;
        private Label lblClientName;
        private Label lblBudgetTitle;
        private Label lblBudget;

        private Label lblBidAmountTitle;
        private TextBox txtBidAmount;

        private Label lblProposalTitle;
        private TextBox txtProposal;

        private Button btnSubmitBid;
        private Button btnCancel;

        public SubmitBidForm()
        {
            CreateSubmitBidForm();
        }

        private void CreateSubmitBidForm()
        {
            // -----------------------------
            // FORM
            // -----------------------------
            this.Text = "Submit Bid";
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
            lblPlatformName.Text = "Freelance Platform";
            lblPlatformName.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblPlatformName.ForeColor = Color.FromArgb(35, 40, 45);
            lblPlatformName.AutoSize = true;
            lblPlatformName.Location = new Point(35, 25);
            pnlHeader.Controls.Add(lblPlatformName);

            btnBack = new Button();
            btnBack.Text = "BACK";
            btnBack.Size = new Size(70, 30);
            btnBack.Location = new Point(785, 20);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnBack.BackColor = Color.FromArgb(248, 249, 251);
            btnBack.ForeColor = Color.FromArgb(50, 55, 60);
            btnBack.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btnBack.Cursor = Cursors.Hand;
            pnlHeader.Controls.Add(btnBack);

            // -----------------------------
            // MAIN CONTENT
            // -----------------------------
            pnlContent = new Panel();
            pnlContent.Location = new Point(40, 105);
            pnlContent.Size = new Size(804, 510);
            pnlContent.BackColor = Color.White;
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(pnlContent);

            // -----------------------------
            // TITLE
            // -----------------------------
            lblTitle = new Label();
            lblTitle.Text = "Submit Your Bid";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(35, 40, 45);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(45, 25);
            pnlContent.Controls.Add(lblTitle);

            // -----------------------------
            // SUBTITLE
            // -----------------------------
            lblSubtitle = new Label();
            lblSubtitle.Text = "Send your proposed price and proposal to the client";
            lblSubtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblSubtitle.ForeColor = Color.FromArgb(110, 115, 120);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(48, 65);
            pnlContent.Controls.Add(lblSubtitle);

            // -----------------------------
            // PROJECT INFORMATION CARD
            // -----------------------------
            pnlProject = new Panel();
            pnlProject.Location = new Point(45, 105);
            pnlProject.Size = new Size(714, 105);
            pnlProject.BackColor = Color.FromArgb(248, 249, 251);
            pnlProject.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Controls.Add(pnlProject);

            lblProjectTitle = new Label();
            lblProjectTitle.Text = "Project";
            lblProjectTitle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblProjectTitle.ForeColor = Color.FromArgb(110, 115, 120);
            lblProjectTitle.AutoSize = true;
            lblProjectTitle.Location = new Point(20, 15);
            pnlProject.Controls.Add(lblProjectTitle);

            lblProjectName = new Label();
            lblProjectName.Text = "Website Development";
            lblProjectName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblProjectName.ForeColor = Color.FromArgb(35, 40, 45);
            lblProjectName.AutoSize = true;
            lblProjectName.Location = new Point(20, 37);
            pnlProject.Controls.Add(lblProjectName);

            lblClientTitle = new Label();
            lblClientTitle.Text = "Client";
            lblClientTitle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblClientTitle.ForeColor = Color.FromArgb(110, 115, 120);
            lblClientTitle.AutoSize = true;
            lblClientTitle.Location = new Point(310, 15);
            pnlProject.Controls.Add(lblClientTitle);

            lblClientName = new Label();
            lblClientName.Text = "Client Name";
            lblClientName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblClientName.ForeColor = Color.FromArgb(35, 40, 45);
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(310, 37);
            pnlProject.Controls.Add(lblClientName);

            lblBudgetTitle = new Label();
            lblBudgetTitle.Text = "Project Budget";
            lblBudgetTitle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblBudgetTitle.ForeColor = Color.FromArgb(110, 115, 120);
            lblBudgetTitle.AutoSize = true;
            lblBudgetTitle.Location = new Point(540, 15);
            pnlProject.Controls.Add(lblBudgetTitle);

            lblBudget = new Label();
            lblBudget.Text = "$500";
            lblBudget.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblBudget.ForeColor = Color.FromArgb(35, 40, 45);
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(540, 37);
            pnlProject.Controls.Add(lblBudget);

            // -----------------------------
            // BID AMOUNT
            // -----------------------------
            lblBidAmountTitle = new Label();
            lblBidAmountTitle.Text = "Your Bid Amount";
            lblBidAmountTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblBidAmountTitle.ForeColor = Color.FromArgb(50, 55, 60);
            lblBidAmountTitle.AutoSize = true;
            lblBidAmountTitle.Location = new Point(45, 230);
            pnlContent.Controls.Add(lblBidAmountTitle);

            txtBidAmount = new TextBox();
            txtBidAmount.Size = new Size(714, 32);
            txtBidAmount.Location = new Point(45, 255);
            txtBidAmount.Font = new Font("Segoe UI", 10);
            txtBidAmount.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Controls.Add(txtBidAmount);

            // -----------------------------
            // PROPOSAL
            // -----------------------------
            lblProposalTitle = new Label();
            lblProposalTitle.Text = "Your Proposal";
            lblProposalTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblProposalTitle.ForeColor = Color.FromArgb(50, 55, 60);
            lblProposalTitle.AutoSize = true;
            lblProposalTitle.Location = new Point(45, 305);
            pnlContent.Controls.Add(lblProposalTitle);

            txtProposal = new TextBox();
            txtProposal.Multiline = true;
            txtProposal.ScrollBars = ScrollBars.Vertical;
            txtProposal.Size = new Size(714, 100);
            txtProposal.Location = new Point(45, 330);
            txtProposal.Font = new Font("Segoe UI", 10);
            txtProposal.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Controls.Add(txtProposal);

            // -----------------------------
            // SUBMIT BUTTON
            // -----------------------------
            btnSubmitBid = new Button();
            btnSubmitBid.Text = "SUBMIT BID";
            btnSubmitBid.Size = new Size(160, 40);
            btnSubmitBid.Location = new Point(45, 445);
            btnSubmitBid.FlatStyle = FlatStyle.Flat;
            btnSubmitBid.FlatAppearance.BorderColor = Color.FromArgb(40, 120, 220);
            btnSubmitBid.BackColor = Color.FromArgb(40, 120, 220);
            btnSubmitBid.ForeColor = Color.White;
            btnSubmitBid.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnSubmitBid.Cursor = Cursors.Hand;
            pnlContent.Controls.Add(btnSubmitBid);

            // -----------------------------
            // CANCEL BUTTON
            // -----------------------------
            btnCancel = new Button();
            btnCancel.Text = "CANCEL";
            btnCancel.Size = new Size(120, 40);
            btnCancel.Location = new Point(220, 445);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btnCancel.BackColor = Color.FromArgb(248, 249, 251);
            btnCancel.ForeColor = Color.FromArgb(50, 55, 60);
            btnCancel.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnCancel.Cursor = Cursors.Hand;
            pnlContent.Controls.Add(btnCancel);
        }
    }
}