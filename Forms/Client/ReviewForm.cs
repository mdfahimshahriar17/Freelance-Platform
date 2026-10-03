using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Clint
{
    public class ReviewForm : Form
    {
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlReview;

        private Label lblPlatformName;
        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblCompletedTitle;
        private Label lblProjectTitle;
        private Label lblFreelancer;
        private Label lblCompletedDate;

        private Label lblRatingTitle;
        private Label lblStar1;
        private Label lblStar2;
        private Label lblStar3;
        private Label lblStar4;
        private Label lblStar5;

        private Label lblCommentTitle;
        private TextBox txtComment;

        private Button btnSubmit;
        private Button btnBack;

        public ReviewForm()
        {
            CreateReviewForm();
        }

        private void CreateReviewForm()
        {
            // =========================
            // FORM
            // =========================

            this.Text = "Freelance Platform - Reviews & Ratings";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 680);
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // =========================
            // HEADER
            // =========================

            pnlHeader = new Panel();

            pnlHeader.Location =
                new Point(0, 0);

            pnlHeader.Size =
                new Size(884, 75);

            pnlHeader.BackColor =
                Color.White;

            this.Controls.Add(pnlHeader);

            lblPlatformName = new Label();

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
                "Reviews & Ratings";

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
                "Review freelancers for your completed projects";

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
            // REVIEW CARD
            // =========================

            pnlReview = new Panel();

            pnlReview.Location =
                new Point(45, 115);

            pnlReview.Size =
                new Size(714, 330);

            pnlReview.BackColor =
                Color.FromArgb(248, 249, 251);

            pnlReview.BorderStyle =
                BorderStyle.FixedSingle;

            pnlContent.Controls.Add(
                pnlReview
            );

            // =========================
            // COMPLETED PROJECT
            // =========================

            lblCompletedTitle = new Label();

            lblCompletedTitle.Text =
                "Completed Project";

            lblCompletedTitle.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );

            lblCompletedTitle.ForeColor =
                Color.FromArgb(35, 40, 48);

            lblCompletedTitle.AutoSize = true;

            lblCompletedTitle.Location =
                new Point(20, 18);

            pnlReview.Controls.Add(
                lblCompletedTitle
            );

            // Project title
            lblProjectTitle = new Label();

            lblProjectTitle.Text =
                "Website Development";

            lblProjectTitle.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            lblProjectTitle.ForeColor =
                Color.FromArgb(45, 95, 160);

            lblProjectTitle.AutoSize = true;

            lblProjectTitle.Location =
                new Point(20, 50);

            pnlReview.Controls.Add(
                lblProjectTitle
            );

            // Freelancer
            lblFreelancer = new Label();

            lblFreelancer.Text =
                "Freelancer: John Smith";

            lblFreelancer.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblFreelancer.ForeColor =
                Color.FromArgb(80, 86, 96);

            lblFreelancer.AutoSize = true;

            lblFreelancer.Location =
                new Point(20, 78);

            pnlReview.Controls.Add(
                lblFreelancer
            );

            // Completed date
            lblCompletedDate = new Label();

            lblCompletedDate.Text =
                "Completed: 28 Sep 2026";

            lblCompletedDate.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            lblCompletedDate.ForeColor =
                Color.FromArgb(80, 86, 96);

            lblCompletedDate.AutoSize = true;

            lblCompletedDate.Location =
                new Point(20, 103);

            pnlReview.Controls.Add(
                lblCompletedDate
            );

            // =========================
            // RATING
            // =========================

            lblRatingTitle = new Label();

            lblRatingTitle.Text =
                "Your Rating";

            lblRatingTitle.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            lblRatingTitle.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblRatingTitle.AutoSize = true;

            lblRatingTitle.Location =
                new Point(20, 140);

            pnlReview.Controls.Add(
                lblRatingTitle
            );

            // Stars
            lblStar1 = CreateStarLabel(20, 168);
            lblStar2 = CreateStarLabel(52, 168);
            lblStar3 = CreateStarLabel(84, 168);
            lblStar4 = CreateStarLabel(116, 168);
            lblStar5 = CreateStarLabel(148, 168);

            pnlReview.Controls.Add(lblStar1);
            pnlReview.Controls.Add(lblStar2);
            pnlReview.Controls.Add(lblStar3);
            pnlReview.Controls.Add(lblStar4);
            pnlReview.Controls.Add(lblStar5);

            // =========================
            // COMMENT
            // =========================

            lblCommentTitle = new Label();

            lblCommentTitle.Text =
                "Your Review";

            lblCommentTitle.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            lblCommentTitle.ForeColor =
                Color.FromArgb(55, 62, 72);

            lblCommentTitle.AutoSize = true;

            lblCommentTitle.Location =
                new Point(300, 140);

            pnlReview.Controls.Add(
                lblCommentTitle
            );

            txtComment = new TextBox();

            txtComment.Multiline = true;

            txtComment.ScrollBars =
                ScrollBars.Vertical;

            txtComment.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            txtComment.Location =
                new Point(300, 168);

            txtComment.Size =
                new Size(390, 105);

            pnlReview.Controls.Add(
                txtComment
            );

            // =========================
            // SUBMIT BUTTON
            // =========================

            btnSubmit = new Button();

            btnSubmit.Text =
                "SUBMIT REVIEW";

            btnSubmit.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            btnSubmit.ForeColor =
                Color.White;

            btnSubmit.BackColor =
                Color.FromArgb(45, 95, 160);

            btnSubmit.FlatStyle =
                FlatStyle.Flat;

            btnSubmit.FlatAppearance.BorderSize =
                0;

            btnSubmit.Cursor =
                Cursors.Hand;

            btnSubmit.Location =
                new Point(560, 455);

            btnSubmit.Size =
                new Size(150, 38);

            pnlContent.Controls.Add(
                btnSubmit
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
                new Point(45, 455);

            btnBack.Size =
                new Size(100, 38);

            pnlContent.Controls.Add(
                btnBack
            );
        }

        private Label CreateStarLabel(int x, int y)
        {
            Label star = new Label();

            star.Text = "★";

            star.Font =
                new Font(
                    "Segoe UI",
                    18,
                    FontStyle.Regular
                );

            star.ForeColor =
                Color.FromArgb(190, 195, 202);

            star.AutoSize = true;

            star.Cursor =
                Cursors.Hand;

            star.Location =
                new Point(x, y);

            return star;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ReviewForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);

        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}