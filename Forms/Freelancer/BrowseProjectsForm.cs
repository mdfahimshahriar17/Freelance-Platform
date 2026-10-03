using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Freelancer
{
    public class BrowseProjectsForm : Form
    {
        private Panel pnlHeader;
        private Label lblPlatformName;
        private Button btnBack;

        private Panel pnlContent;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlProject1;
        private Panel pnlProject2;
        private Panel pnlProject3;

        public BrowseProjectsForm()
        {
            CreateBrowseProjectsForm();
        }

        private void CreateBrowseProjectsForm()
        {
            // -----------------------------
            // FORM
            // -----------------------------
            this.Text = "Freelance Platform - Browse Projects";
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
            lblPlatformName.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblPlatformName.ForeColor = Color.FromArgb(25, 45, 70);
            lblPlatformName.AutoSize = true;
            lblPlatformName.Location = new Point(32, 25);
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
            this.Controls.Add(pnlContent);

            // -----------------------------
            // TITLE
            // -----------------------------
            lblTitle = new Label();
            lblTitle.Text = "Browse Projects";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 70);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(45, 25);
            pnlContent.Controls.Add(lblTitle);

            // -----------------------------
            // SUBTITLE
            // -----------------------------
            lblSubtitle = new Label();
            lblSubtitle.Text = "Find projects that match your skills and interests";
            lblSubtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblSubtitle.ForeColor = Color.FromArgb(105, 115, 125);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(48, 65);
            pnlContent.Controls.Add(lblSubtitle);

            // -----------------------------
            // PROJECT 1
            // -----------------------------
            pnlProject1 = CreateProjectCard(
                "Website Development",
                "Build a responsive business website with a modern design.",
                "$500",
                "20 October 2026",
                "Client Name"
            );

            pnlProject1.Location = new Point(45, 105);
            pnlContent.Controls.Add(pnlProject1);

            // -----------------------------
            // PROJECT 2
            // -----------------------------
            pnlProject2 = CreateProjectCard(
                "E-commerce Website",
                "Develop an online store for a growing business.",
                "$800",
                "30 October 2026",
                "Sarah Ahmed"
            );

            pnlProject2.Location = new Point(45, 225);
            pnlContent.Controls.Add(pnlProject2);

            // -----------------------------
            // PROJECT 3
            // -----------------------------
            pnlProject3 = CreateProjectCard(
                "Mobile App Backend API",
                "Create REST APIs for a mobile application.",
                "$650",
                "5 November 2026",
                "Michael Brown"
            );

            pnlProject3.Location = new Point(45, 345);
            pnlContent.Controls.Add(pnlProject3);
        }

        // ============================================================
        // CREATE PROJECT CARD
        // ============================================================
        private Panel CreateProjectCard(
            string projectTitle,
            string description,
            string budget,
            string deadline,
            string clientName)
        {
            Panel card = new Panel();

            card.Size = new Size(714, 105);
            card.BackColor = Color.FromArgb(248, 249, 251);
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
            lblProjectTitle.ForeColor = Color.FromArgb(25, 45, 70);
            lblProjectTitle.AutoSize = true;
            lblProjectTitle.Location = new Point(20, 12);
            card.Controls.Add(lblProjectTitle);

            // -----------------------------
            // STATUS
            // -----------------------------
            Label lblStatus = new Label();
            lblStatus.Text = "Open";
            lblStatus.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Bold
            );
            lblStatus.ForeColor = Color.FromArgb(40, 120, 220);
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(630, 15);
            card.Controls.Add(lblStatus);

            // -----------------------------
            // DESCRIPTION
            // -----------------------------
            Label lblDescription = new Label();
            lblDescription.Text = description;
            lblDescription.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Regular
            );
            lblDescription.ForeColor = Color.FromArgb(70, 75, 80);
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 38);
            card.Controls.Add(lblDescription);

            // -----------------------------
            // BUDGET
            // -----------------------------
            Label lblBudgetTitle = new Label();
            lblBudgetTitle.Text = "Budget:";
            lblBudgetTitle.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            lblBudgetTitle.ForeColor = Color.FromArgb(90, 95, 100);
            lblBudgetTitle.AutoSize = true;
            lblBudgetTitle.Location = new Point(20, 70);
            card.Controls.Add(lblBudgetTitle);

            Label lblBudget = new Label();
            lblBudget.Text = budget;
            lblBudget.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Regular
            );
            lblBudget.ForeColor = Color.FromArgb(35, 40, 45);
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(68, 70);
            card.Controls.Add(lblBudget);

            // -----------------------------
            // DEADLINE
            // -----------------------------
            Label lblDeadlineTitle = new Label();
            lblDeadlineTitle.Text = "Deadline:";
            lblDeadlineTitle.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            lblDeadlineTitle.ForeColor = Color.FromArgb(90, 95, 100);
            lblDeadlineTitle.AutoSize = true;
            lblDeadlineTitle.Location = new Point(150, 70);
            card.Controls.Add(lblDeadlineTitle);

            Label lblDeadline = new Label();
            lblDeadline.Text = deadline;
            lblDeadline.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Regular
            );
            lblDeadline.ForeColor = Color.FromArgb(35, 40, 45);
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(208, 70);
            card.Controls.Add(lblDeadline);

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
            lblClientTitle.ForeColor = Color.FromArgb(90, 95, 100);
            lblClientTitle.AutoSize = true;
            lblClientTitle.Location = new Point(350, 70);
            card.Controls.Add(lblClientTitle);

            Label lblClient = new Label();
            lblClient.Text = clientName;
            lblClient.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Regular
            );
            lblClient.ForeColor = Color.FromArgb(35, 40, 45);
            lblClient.AutoSize = true;
            lblClient.Location = new Point(395, 70);
            card.Controls.Add(lblClient);

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
            btnView.BackColor = Color.FromArgb(40, 120, 220);
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
    }
}