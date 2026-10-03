using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Clint
{
    public class ClientProjectsForm : Form
    {
        private Panel pnlHeader;
        private Panel pnlContent;

        private Label lblTitle;
        private Label lblSubtitle;

        private Button btnBack;

        public ClientProjectsForm()
        {
            CreateClientProjectsForm();
        }

        private void CreateClientProjectsForm()
        {
            // =========================
            // FORM
            // =========================

            this.Text = "Freelance Platform - My Projects";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 680);
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // =========================
            // HEADER
            // =========================

            pnlHeader = new Panel();
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(884, 75);
            pnlHeader.BackColor = Color.White;

            this.Controls.Add(pnlHeader);

            Label lblPlatformName = new Label();

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

            lblPlatformName.AutoSize = true;

            lblPlatformName.Location =
                new Point(35, 25);

            pnlHeader.Controls.Add(
                lblPlatformName
            );

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

            // =========================
            // TITLE
            // =========================

            lblTitle = new Label();

            lblTitle.Text =
                "My Projects";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    22,
                    FontStyle.Bold
                );

            lblTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblTitle.AutoSize = true;

            lblTitle.Location =
                new Point(45, 30);

            pnlContent.Controls.Add(
                lblTitle
            );

            // =========================
            // SUBTITLE
            // =========================

            lblSubtitle = new Label();

            lblSubtitle.Text =
                "View and manage your posted projects";

            lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    10
                );

            lblSubtitle.ForeColor =
                Color.FromArgb(110, 118, 130);

            lblSubtitle.AutoSize = true;

            lblSubtitle.Location =
                new Point(48, 72);

            pnlContent.Controls.Add(
                lblSubtitle
            );

            // =========================
            // PROJECT 1 - OPEN
            // =========================

            Panel projectCard1 =
                CreateProjectCard(
                    "Website Development",
                    "25,000",
                    "20 Oct 2026",
                    "03 Oct 2026",
                    "Open",
                    45,
                    120
                );

            pnlContent.Controls.Add(
                projectCard1
            );

            // =========================
            // PROJECT 2 - COMPLETED
            // =========================

            Panel projectCard2 =
                CreateProjectCard(
                    "Mobile App Development",
                    "40,000",
                    "15 Sep 2026",
                    "01 Sep 2026",
                    "Completed",
                    45,
                    235
                );

            pnlContent.Controls.Add(
                projectCard2
            );

            // =========================
            // PROJECT 3 - IN PROGRESS
            // =========================

            Panel projectCard3 =
                CreateProjectCard(
                    "E-Commerce Website",
                    "35,000",
                    "30 Oct 2026",
                    "05 Oct 2026",
                    "In Progress",
                    45,
                    350
                );

            pnlContent.Controls.Add(
                projectCard3
            );

            // =========================
            // BACK BUTTON
            // =========================

            btnBack = new Button();

            btnBack.Text =
                "BACK";

            btnBack.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            btnBack.ForeColor =
                Color.FromArgb(70, 70, 70);

            btnBack.BackColor =
                Color.FromArgb(235, 238, 243);

            btnBack.FlatStyle =
                FlatStyle.Flat;

            btnBack.FlatAppearance.BorderSize =
                0;

            btnBack.Cursor =
                Cursors.Hand;

            btnBack.Location =
                new Point(45, 465);

            btnBack.Size =
                new Size(100, 35);

            pnlContent.Controls.Add(
                btnBack
            );
        }

        // ============================================================
        // CREATE PROJECT CARD
        // ============================================================

        private Panel CreateProjectCard(
            string title,
            string budget,
            string deadline,
            string postedDate,
            string status,
            int x,
            int y)
        {
            Panel card = new Panel();

            card.Location =
                new Point(x, y);

            card.Size =
                new Size(714, 100);

            card.BackColor =
                Color.FromArgb(248, 249, 251);

            card.BorderStyle =
                BorderStyle.FixedSingle;

            // =========================
            // PROJECT TITLE
            // =========================

            Label lblProjectTitle =
                new Label();

            lblProjectTitle.Text =
                title;

            lblProjectTitle.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );

            lblProjectTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblProjectTitle.AutoSize = true;

            lblProjectTitle.Location =
                new Point(20, 12);

            card.Controls.Add(
                lblProjectTitle
            );

            // =========================
            // BUDGET
            // =========================

            Label lblBudget =
                new Label();

            lblBudget.Text =
                "Budget: " + budget;

            lblBudget.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblBudget.ForeColor =
                Color.FromArgb(80, 86, 96);

            lblBudget.AutoSize = true;

            lblBudget.Location =
                new Point(20, 42);

            card.Controls.Add(
                lblBudget
            );

            // =========================
            // DEADLINE
            // =========================

            Label lblDeadline =
                new Label();

            lblDeadline.Text =
                "Deadline: " + deadline;

            lblDeadline.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblDeadline.ForeColor =
                Color.FromArgb(80, 86, 96);

            lblDeadline.AutoSize = true;

            lblDeadline.Location =
                new Point(20, 66);

            card.Controls.Add(
                lblDeadline
            );

            // =========================
            // POSTED DATE
            // =========================

            Label lblPostedDate =
                new Label();

            lblPostedDate.Text =
                "Posted: " + postedDate;

            lblPostedDate.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblPostedDate.ForeColor =
                Color.FromArgb(80, 86, 96);

            lblPostedDate.AutoSize = true;

            lblPostedDate.Location =
                new Point(300, 42);

            card.Controls.Add(
                lblPostedDate
            );

            // =========================
            // STATUS
            // =========================

            Label lblStatus =
                new Label();

            lblStatus.Text =
                status;

            lblStatus.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            lblStatus.ForeColor =
                Color.FromArgb(45, 95, 160);

            lblStatus.AutoSize = true;

            lblStatus.Location =
                new Point(300, 66);

            card.Controls.Add(
                lblStatus
            );

            // =========================
            // VIEW BUTTON
            // =========================

            Button btnView =
                new Button();

            btnView.Text =
                "VIEW";

            btnView.Font =
                new Font(
                    "Segoe UI",
                    8,
                    FontStyle.Bold
                );

            btnView.ForeColor =
                Color.White;

            btnView.BackColor =
                Color.FromArgb(45, 95, 160);

            btnView.FlatStyle =
                FlatStyle.Flat;

            btnView.FlatAppearance.BorderSize =
                0;

            btnView.Cursor =
                Cursors.Hand;

            // --------------------------------------------------------
            // BUTTON POSITION
            // --------------------------------------------------------

            if (status == "In Progress")
            {
                btnView.Location =
                    new Point(500, 32);
            }
            else if (status == "Completed")
            {
                btnView.Location =
                    new Point(500, 32);
            }
            else
            {
                btnView.Location =
                    new Point(600, 32);
            }

            btnView.Size =
                new Size(90, 35);

            card.Controls.Add(
                btnView
            );

            // ========================================================
            // COMPLETE BUTTON
            // ========================================================

            if (status == "In Progress")
            {
                Button btnComplete =
                    new Button();

                btnComplete.Text =
                    "COMPLETE";

                btnComplete.Font =
                    new Font(
                        "Segoe UI",
                        8,
                        FontStyle.Bold
                    );

                btnComplete.ForeColor =
                    Color.White;

                btnComplete.BackColor =
                    Color.FromArgb(55, 130, 85);

                btnComplete.FlatStyle =
                    FlatStyle.Flat;

                btnComplete.FlatAppearance.BorderSize =
                    0;

                btnComplete.Cursor =
                    Cursors.Hand;

                btnComplete.Location =
                    new Point(600, 32);

                btnComplete.Size =
                    new Size(90, 35);

                card.Controls.Add(
                    btnComplete
                );
            }

            // ========================================================
            // REVIEW BUTTON
            // ========================================================

            if (status == "Completed")
            {
                Button btnReview =
                    new Button();

                btnReview.Text =
                    "REVIEW";

                btnReview.Font =
                    new Font(
                        "Segoe UI",
                        8,
                        FontStyle.Bold
                    );

                btnReview.ForeColor =
                    Color.White;

                btnReview.BackColor =
                    Color.FromArgb(55, 130, 85);

                btnReview.FlatStyle =
                    FlatStyle.Flat;

                btnReview.FlatAppearance.BorderSize =
                    0;

                btnReview.Cursor =
                    Cursors.Hand;

                btnReview.Location =
                    new Point(600, 32);

                btnReview.Size =
                    new Size(90, 35);

                // Open Review Form
                btnReview.Click +=
                    (sender, e) =>
                    {
                        ReviewForm reviewForm =
                            new ReviewForm();

                        reviewForm.ShowDialog();
                    };

                card.Controls.Add(
                    btnReview
                );
            }

            return card;
        }
    }
}