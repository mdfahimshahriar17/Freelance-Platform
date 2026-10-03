using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Clint
{
    public class PostProjectForm : Form
    {
        private Panel pnlHeader;
        private Panel pnlContent;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblProjectTitle;
        private Label lblDescription;
        private Label lblBudget;
        private Label lblDeadline;

        private TextBox txtProjectTitle;
        private TextBox txtDescription;
        private TextBox txtBudget;
        private DateTimePicker dtpDeadline;

        private Button btnPostProject;
        private Button btnClear;
        private Button btnBack;

        public PostProjectForm()
        {
            CreatePostProjectForm();
        }

        private void CreatePostProjectForm()
        {
            // =========================
            // FORM
            // =========================

            this.Text = "Freelance Platform - Post Project";
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

            // =========================
            // TITLE
            // =========================

            lblTitle = new Label();

            lblTitle.Text = "Post Project";

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
                "Create a project and find the right freelancer";

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
            // PROJECT TITLE
            // =========================

            lblProjectTitle = CreateLabel(
                "Project Title",
                45,
                125
            );

            pnlContent.Controls.Add(
                lblProjectTitle
            );

            txtProjectTitle = new TextBox();

            txtProjectTitle.Font =
                new Font(
                    "Segoe UI",
                    10
                );

            txtProjectTitle.Location =
                new Point(45, 150);

            txtProjectTitle.Size =
                new Size(650, 30);

            pnlContent.Controls.Add(
                txtProjectTitle
            );

            // =========================
            // DESCRIPTION
            // =========================

            lblDescription = CreateLabel(
                "Project Description",
                45,
                195
            );

            pnlContent.Controls.Add(
                lblDescription
            );

            txtDescription = new TextBox();

            txtDescription.Multiline = true;

            txtDescription.ScrollBars =
                ScrollBars.Vertical;

            txtDescription.Font =
                new Font(
                    "Segoe UI",
                    10
                );

            txtDescription.Location =
                new Point(45, 220);

            txtDescription.Size =
                new Size(650, 120);

            pnlContent.Controls.Add(
                txtDescription
            );

            // =========================
            // BUDGET
            // =========================

            lblBudget = CreateLabel(
                "Budget",
                45,
                365
            );

            pnlContent.Controls.Add(
                lblBudget
            );

            txtBudget = new TextBox();

            txtBudget.Font =
                new Font(
                    "Segoe UI",
                    10
                );

            txtBudget.Location =
                new Point(45, 390);

            txtBudget.Size =
                new Size(250, 30);

            pnlContent.Controls.Add(
                txtBudget
            );

            // =========================
            // DEADLINE
            // =========================

            lblDeadline = CreateLabel(
                "Deadline",
                330,
                365
            );

            pnlContent.Controls.Add(
                lblDeadline
            );

            dtpDeadline = new DateTimePicker();

            dtpDeadline.Font =
                new Font(
                    "Segoe UI",
                    10
                );

            dtpDeadline.Format =
                DateTimePickerFormat.Custom;

            dtpDeadline.CustomFormat =
                "dd MMM yyyy";

            dtpDeadline.Location =
                new Point(330, 390);

            dtpDeadline.Size =
                new Size(250, 30);

            dtpDeadline.MinDate =
                DateTime.Today;

            pnlContent.Controls.Add(
                dtpDeadline
            );

            // =========================
            // POST PROJECT
            // =========================

            btnPostProject = new Button();

            btnPostProject.Text =
                "POST PROJECT";

            btnPostProject.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            btnPostProject.ForeColor =
                Color.White;

            btnPostProject.BackColor =
                Color.FromArgb(45, 95, 160);

            btnPostProject.FlatStyle =
                FlatStyle.Flat;

            btnPostProject.FlatAppearance.BorderSize = 0;

            btnPostProject.Cursor =
                Cursors.Hand;

            btnPostProject.Location =
                new Point(45, 445);

            btnPostProject.Size =
                new Size(145, 38);

            pnlContent.Controls.Add(
                btnPostProject
            );

            // =========================
            // CLEAR
            // =========================

            btnClear = new Button();

            btnClear.Text = "CLEAR";

            btnClear.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            btnClear.ForeColor =
                Color.FromArgb(70, 70, 70);

            btnClear.BackColor =
                Color.FromArgb(235, 238, 243);

            btnClear.FlatStyle =
                FlatStyle.Flat;

            btnClear.FlatAppearance.BorderSize = 0;

            btnClear.Cursor =
                Cursors.Hand;

            btnClear.Location =
                new Point(205, 445);

            btnClear.Size =
                new Size(100, 38);

            pnlContent.Controls.Add(
                btnClear
            );

            // =========================
            // BACK
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
                new Point(650, 445);

            btnBack.Size =
                new Size(100, 38);

            pnlContent.Controls.Add(
                btnBack
            );
        }

        private Label CreateLabel(
            string text,
            int x,
            int y)
        {
            Label label = new Label();

            label.Text = text;

            label.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            label.ForeColor =
                Color.FromArgb(55, 62, 72);

            label.AutoSize = true;

            label.Location =
                new Point(x, y);

            return label;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PostProjectForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "PostProjectForm";
            this.Load += new System.EventHandler(this.PostProjectForm_Load);
            this.ResumeLayout(false);

        }

        private void PostProjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}