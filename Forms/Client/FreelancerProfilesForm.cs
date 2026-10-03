using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Clint
{
    public class FreelancerProfilesForm : Form
    {
        private Panel pnlHeader;
        private Panel pnlContent;

        private Label lblTitle;
        private Label lblSubtitle;

        private Button btnBack;

        public FreelancerProfilesForm()
        {
            CreateFreelancerProfilesForm();
        }

        private void CreateFreelancerProfilesForm()
        {
            // =========================
            // FORM
            // =========================

            this.Text = "Freelance Platform - View Freelancer";
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

            // Platform name
            Label lblPlatformName = new Label();

            lblPlatformName.Text = "FREELANCE PLATFORM";

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

            // Title
            lblTitle = new Label();

            lblTitle.Text = "View Freelancer";

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

            // Subtitle
            lblSubtitle = new Label();

            lblSubtitle.Text =
                "Browse available freelancers and view their profiles";

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
            // FREELANCER CARDS
            // =========================

            Panel freelancerCard1 =
                CreateFreelancerCard(
                    "John Smith",
                    "C#, .NET, SQL Server",
                    "Backend Development",
                    45,
                    120
                );

            pnlContent.Controls.Add(
                freelancerCard1
            );

            Panel freelancerCard2 =
                CreateFreelancerCard(
                    "Sarah Ahmed",
                    "React, JavaScript, HTML, CSS",
                    "Frontend Development",
                    45,
                    235
                );

            pnlContent.Controls.Add(
                freelancerCard2
            );

            Panel freelancerCard3 =
                CreateFreelancerCard(
                    "Michael Brown",
                    "Python, Django, REST API",
                    "Web Development",
                    45,
                    350
                );

            pnlContent.Controls.Add(
                freelancerCard3
            );

            // =========================
            // BACK BUTTON
            // =========================

            btnBack = new Button();

            btnBack.Text = "BACK";

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

            btnBack.FlatAppearance.BorderSize = 0;

            btnBack.Cursor =
                Cursors.Hand;

            btnBack.Location =
                new Point(45, 455);

            btnBack.Size =
                new Size(100, 35);

            pnlContent.Controls.Add(
                btnBack
            );
        }

        private Panel CreateFreelancerCard(
            string name,
            string skills,
            string expertise,
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
            // NAME
            // =========================

            Label lblName = new Label();

            lblName.Text = name;

            lblName.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );

            lblName.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblName.AutoSize = true;

            lblName.Location =
                new Point(20, 15);

            card.Controls.Add(
                lblName
            );

            // =========================
            // SKILLS
            // =========================

            Label lblSkills = new Label();

            lblSkills.Text =
                "Skills: " + skills;

            lblSkills.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblSkills.ForeColor =
                Color.FromArgb(80, 86, 96);

            lblSkills.AutoSize = true;

            lblSkills.Location =
                new Point(20, 43);

            card.Controls.Add(
                lblSkills
            );

            // =========================
            // EXPERTISE
            // =========================

            Label lblExpertise = new Label();

            lblExpertise.Text =
                "Expertise: " + expertise;

            lblExpertise.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblExpertise.ForeColor =
                Color.FromArgb(80, 86, 96);

            lblExpertise.AutoSize = true;

            lblExpertise.Location =
                new Point(20, 67);

            card.Controls.Add(
                lblExpertise
            );

            // =========================
            // VIEW BUTTON
            // =========================

            Button btnView = new Button();

            btnView.Text = "VIEW";

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

            btnView.FlatAppearance.BorderSize = 0;

            btnView.Cursor =
                Cursors.Hand;

            btnView.Location =
                new Point(600, 32);

            btnView.Size =
                new Size(90, 35);

            card.Controls.Add(
                btnView
            );

            return card;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FreelancerProfilesForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FreelancerProfilesForm";
            this.Load += new System.EventHandler(this.FreelancerProfilesForm_Load);
            this.ResumeLayout(false);

        }

        private void FreelancerProfilesForm_Load(object sender, EventArgs e)
        {

        }
    }
}