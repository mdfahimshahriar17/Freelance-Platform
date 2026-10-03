using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms
{
    public class FreelancerProfileForm : Form
    {
        private Panel pnlHeader;
        private Label lblPlatformName;
        private Button btnBack;

        private Panel pnlContent;
        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblFullName;
        private TextBox txtFullName;

        private Label lblContactDetails;
        private TextBox txtContactDetails;

        private Label lblSkills;
        private TextBox txtSkills;

        private Label lblExpertise;
        private TextBox txtExpertise;

        private Label lblPortfolio;
        private TextBox txtPortfolio;

        private Label lblCompletedProjects;

        private Panel pnlProject1;
        private Panel pnlProject2;

        private Button btnSave;
        private Button btnClear;

        public FreelancerProfileForm()
        {
            CreateFreelancerProfileForm();
        }

        private void CreateFreelancerProfileForm()
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
            lblPlatformName.Location = new Point(22, 25);
            pnlHeader.Controls.Add(lblPlatformName);

            btnBack = new Button();
            btnBack.Text = "BACK";
            btnBack.Size = new Size(70, 30);
            btnBack.Location = new Point(773, 20);
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

            // ============================================================
            // MAIN CONTENT
            // ============================================================
            pnlContent = new Panel();

            pnlContent.Location = new Point(24, 105);

            // Increased height so there is space below the buttons
            pnlContent.Size = new Size(804, 530);

            pnlContent.BackColor = Color.White;
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
            lblTitle.Location = new Point(45, 25);
            pnlContent.Controls.Add(lblTitle);

            // ============================================================
            // SUBTITLE
            // ============================================================
            lblSubtitle = new Label();
            lblSubtitle.Text =
                "Create and manage your professional profile";
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

            // ============================================================
            // FULL NAME
            // ============================================================
            lblFullName = CreateLabel(
                "Full Name",
                new Point(45, 105)
            );
            pnlContent.Controls.Add(lblFullName);

            txtFullName = CreateTextBox(
                new Point(45, 130),
                new Size(330, 32)
            );
            pnlContent.Controls.Add(txtFullName);

            // ============================================================
            // CONTACT DETAILS
            // ============================================================
            lblContactDetails = CreateLabel(
                "Contact Details",
                new Point(405, 105)
            );
            pnlContent.Controls.Add(lblContactDetails);

            txtContactDetails = CreateTextBox(
                new Point(405, 130),
                new Size(354, 32)
            );
            pnlContent.Controls.Add(txtContactDetails);

            // ============================================================
            // SKILLS
            // ============================================================
            lblSkills = CreateLabel(
                "Skills",
                new Point(45, 180)
            );
            pnlContent.Controls.Add(lblSkills);

            txtSkills = CreateMultilineTextBox(
                new Point(45, 205),
                new Size(330, 55)
            );
            pnlContent.Controls.Add(txtSkills);

            // ============================================================
            // EXPERTISE
            // ============================================================
            lblExpertise = CreateLabel(
                "Expertise",
                new Point(405, 180)
            );
            pnlContent.Controls.Add(lblExpertise);

            txtExpertise = CreateMultilineTextBox(
                new Point(405, 205),
                new Size(354, 55)
            );
            pnlContent.Controls.Add(txtExpertise);

            // ============================================================
            // PORTFOLIO
            // ============================================================
            lblPortfolio = new Label();
            lblPortfolio.Text =
                "Portfolio (Website / GitHub / Other Links)";
            lblPortfolio.Font = new Font(
                "Segoe UI",
                10,
                FontStyle.Bold
            );
            lblPortfolio.ForeColor =
                Color.FromArgb(50, 55, 60);
            lblPortfolio.AutoSize = true;
            lblPortfolio.Location =
                new Point(45, 280);
            pnlContent.Controls.Add(lblPortfolio);

            txtPortfolio = CreateMultilineTextBox(
                new Point(45, 305),
                new Size(714, 45)
            );
            pnlContent.Controls.Add(txtPortfolio);

            // ============================================================
            // COMPLETED PROJECTS
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
                new Point(45, 365);
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
                new Point(45, 390);

            pnlContent.Controls.Add(pnlProject1);

            // ============================================================
            // COMPLETED PROJECT 2
            // ============================================================
            pnlProject2 = CreateCompletedProjectCard(
                "Portfolio Website",
                "Completed: 18 September 2026",
                "$350"
            );

            pnlProject2.Location =
                new Point(405, 390);

            pnlContent.Controls.Add(pnlProject2);

            // ============================================================
            // SAVE PROFILE BUTTON
            // ============================================================
            btnSave = new Button();
            btnSave.Text = "SAVE PROFILE";
            btnSave.Size = new Size(150, 40);

            btnSave.Location =
                new Point(45, 475);

            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderColor =
                Color.FromArgb(40, 120, 220);
            btnSave.BackColor =
                Color.FromArgb(40, 120, 220);
            btnSave.ForeColor = Color.White;
            btnSave.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Bold
            );
            btnSave.Cursor = Cursors.Hand;
            pnlContent.Controls.Add(btnSave);

            // ============================================================
            // CLEAR BUTTON
            // ============================================================
            btnClear = new Button();
            btnClear.Text = "CLEAR";
            btnClear.Size = new Size(110, 40);

            btnClear.Location =
                new Point(210, 475);

            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderColor =
                Color.FromArgb(220, 224, 230);
            btnClear.BackColor =
                Color.FromArgb(248, 249, 251);
            btnClear.ForeColor =
                Color.FromArgb(50, 55, 60);
            btnClear.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Bold
            );
            btnClear.Cursor = Cursors.Hand;
            pnlContent.Controls.Add(btnClear);
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

            card.Size = new Size(334, 60);
            card.BackColor =
                Color.FromArgb(248, 249, 251);
            card.BorderStyle =
                BorderStyle.FixedSingle;

            // -----------------------------
            // PROJECT TITLE
            // -----------------------------
            Label lblProjectTitle = new Label();
            lblProjectTitle.Text = projectTitle;
            lblProjectTitle.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Bold
            );
            lblProjectTitle.ForeColor =
                Color.FromArgb(25, 45, 70);
            lblProjectTitle.AutoSize = true;
            lblProjectTitle.Location =
                new Point(12, 8);
            card.Controls.Add(lblProjectTitle);

            // -----------------------------
            // COMPLETED DATE
            // -----------------------------
            Label lblDate = new Label();
            lblDate.Text = completedDate;
            lblDate.Font = new Font(
                "Segoe UI",
                8
            );
            lblDate.ForeColor =
                Color.FromArgb(90, 95, 100);
            lblDate.AutoSize = true;
            lblDate.Location =
                new Point(12, 32);
            card.Controls.Add(lblDate);

            // -----------------------------
            // AGREED AMOUNT
            // -----------------------------
            Label lblAmount = new Label();
            lblAmount.Text = amount;
            lblAmount.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            lblAmount.ForeColor =
                Color.FromArgb(40, 130, 80);
            lblAmount.AutoSize = true;
            lblAmount.Location =
                new Point(230, 32);
            card.Controls.Add(lblAmount);

            return card;
        }

        // ============================================================
        // CREATE NORMAL LABEL
        // ============================================================
        private Label CreateLabel(
            string text,
            Point location)
        {
            Label label = new Label();

            label.Text = text;
            label.Font = new Font(
                "Segoe UI",
                10,
                FontStyle.Bold
            );
            label.ForeColor =
                Color.FromArgb(50, 55, 60);
            label.AutoSize = true;
            label.Location = location;

            return label;
        }

        // ============================================================
        // CREATE NORMAL TEXTBOX
        // ============================================================
        private TextBox CreateTextBox(
            Point location,
            Size size)
        {
            TextBox textBox = new TextBox();

            textBox.Location = location;
            textBox.Size = size;
            textBox.Font = new Font(
                "Segoe UI",
                10
            );
            textBox.BorderStyle =
                BorderStyle.FixedSingle;

            return textBox;
        }

        // ============================================================
        // CREATE MULTILINE TEXTBOX
        // ============================================================
        private TextBox CreateMultilineTextBox(
            Point location,
            Size size)
        {
            TextBox textBox = new TextBox();

            textBox.Location = location;
            textBox.Size = size;
            textBox.Font = new Font(
                "Segoe UI",
                10
            );
            textBox.Multiline = true;
            textBox.ScrollBars =
                ScrollBars.Vertical;
            textBox.BorderStyle =
                BorderStyle.FixedSingle;

            return textBox;
        }
    }
}