using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Freelancer
{
    public class CompletedProjectsForm : Form
    {
        private Panel pnlHeader;
        private Label lblPlatformName;
        private Button btnBack;

        private Panel pnlContent;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlProject1;
        private Panel pnlProject2;

        public CompletedProjectsForm()
        {
            CreateCompletedProjectsForm();
        }

        private void CreateCompletedProjectsForm()
        {
            // -----------------------------
            // FORM
            // -----------------------------
            this.Text = "Freelance Platform - Completed Projects";
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
            lblTitle.Text = "Completed Projects";
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
                "View the projects you have successfully completed";
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
            // PROJECT 1
            // -----------------------------
            pnlProject1 = CreateProjectCard(
                "Website Development",
                "Client Name",
                "$450",
                "25 October 2026",
                "Completed"
            );

            pnlProject1.Location = new Point(45, 105);
            pnlContent.Controls.Add(pnlProject1);

            // -----------------------------
            // PROJECT 2
            // -----------------------------
            pnlProject2 = CreateProjectCard(
                "Portfolio Website",
                "Sarah Ahmed",
                "$350",
                "18 September 2026",
                "Completed"
            );

            pnlProject2.Location = new Point(45, 225);
            pnlContent.Controls.Add(pnlProject2);
        }

        // ============================================================
        // CREATE PROJECT CARD
        // ============================================================
        private Panel CreateProjectCard(
            string projectTitle,
            string clientName,
            string agreedAmount,
            string completedDate,
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
                Color.FromArgb(40, 130, 80);
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(610, 15);
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
            // AGREED AMOUNT
            // -----------------------------
            Label lblAmountTitle = new Label();
            lblAmountTitle.Text = "Agreed Amount:";
            lblAmountTitle.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            lblAmountTitle.ForeColor =
                Color.FromArgb(90, 95, 100);
            lblAmountTitle.AutoSize = true;
            lblAmountTitle.Location = new Point(160, 42);
            card.Controls.Add(lblAmountTitle);

            Label lblAmount = new Label();
            lblAmount.Text = agreedAmount;
            lblAmount.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Regular
            );
            lblAmount.ForeColor =
                Color.FromArgb(35, 40, 45);
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(250, 42);
            card.Controls.Add(lblAmount);

            // -----------------------------
            // COMPLETED DATE
            // -----------------------------
            Label lblDateTitle = new Label();
            lblDateTitle.Text = "Completed:";
            lblDateTitle.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Bold
            );
            lblDateTitle.ForeColor =
                Color.FromArgb(90, 95, 100);
            lblDateTitle.AutoSize = true;
            lblDateTitle.Location = new Point(330, 42);
            card.Controls.Add(lblDateTitle);

            Label lblDate = new Label();
            lblDate.Text = completedDate;
            lblDate.Font = new Font(
                "Segoe UI",
                8,
                FontStyle.Regular
            );
            lblDate.ForeColor =
                Color.FromArgb(35, 40, 45);
            lblDate.AutoSize = true;
            lblDate.Location = new Point(398, 42);
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CompletedProjectsForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "CompletedProjectsForm";
            this.Load += new System.EventHandler(this.CompletedProjectsForm_Load);
            this.ResumeLayout(false);

        }

        private void CompletedProjectsForm_Load(object sender, EventArgs e)
        {

        }
    }
}