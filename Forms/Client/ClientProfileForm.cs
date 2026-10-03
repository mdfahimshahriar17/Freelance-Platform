using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Clint
{
    public class ClientProfileForm : Form
    {
        private Panel pnlMain;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblFullName;
        private TextBox txtFullName;

        private Label lblContactDetails;
        private TextBox txtContactDetails;

        private Button btnSave;
        private Button btnClear;
        private Button btnBack;

        public ClientProfileForm()
        {
            CreateClientProfileForm();
        }

        private void CreateClientProfileForm()
        {
            // =========================
            // FORM
            // =========================

            this.Text = "Freelance Platform - Client Profile";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(620, 560);
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // =========================
            // MAIN PANEL
            // =========================

            pnlMain = new Panel();

            pnlMain.Location = new Point(50, 35);
            pnlMain.Size = new Size(500, 450);
            pnlMain.BackColor = Color.White;

            this.Controls.Add(pnlMain);

            // =========================
            // TITLE
            // =========================

            lblTitle = new Label();

            lblTitle.Text = "Client Profile";
            lblTitle.Font = new Font(
                "Segoe UI",
                22,
                FontStyle.Bold
            );

            lblTitle.ForeColor = Color.FromArgb(
                35,
                40,
                48
            );

            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(170, 35);

            pnlMain.Controls.Add(lblTitle);

            // =========================
            // SUBTITLE
            // =========================

            lblSubtitle = new Label();

            lblSubtitle.Text =
                "Create and manage your profile information";

            lblSubtitle.Font = new Font(
                "Segoe UI",
                10
            );

            lblSubtitle.ForeColor = Color.FromArgb(
                110,
                118,
                130
            );

            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(125, 78);

            pnlMain.Controls.Add(lblSubtitle);

            // =========================
            // FULL NAME LABEL
            // =========================

            lblFullName = CreateLabel(
                "Full Name",
                55,
                130
            );

            pnlMain.Controls.Add(lblFullName);

            // =========================
            // FULL NAME TEXTBOX
            // =========================

            txtFullName = CreateTextBox(
                55,
                155
            );

            pnlMain.Controls.Add(txtFullName);

            // =========================
            // CONTACT DETAILS LABEL
            // =========================

            lblContactDetails = CreateLabel(
                "Contact Details",
                55,
                210
            );

            pnlMain.Controls.Add(lblContactDetails);

            // =========================
            // CONTACT DETAILS TEXTBOX
            // =========================

            txtContactDetails = new TextBox();

            txtContactDetails.Location =
                new Point(55, 235);

            txtContactDetails.Size =
                new Size(390, 85);

            txtContactDetails.Font =
                new Font("Segoe UI", 10);

            txtContactDetails.BorderStyle =
                BorderStyle.FixedSingle;

            txtContactDetails.Multiline = true;

            txtContactDetails.ScrollBars =
                ScrollBars.Vertical;

            pnlMain.Controls.Add(txtContactDetails);

            // =========================
            // SAVE BUTTON
            // =========================

            btnSave = new Button();

            btnSave.Text = "SAVE PROFILE";

            btnSave.Location =
                new Point(55, 350);

            btnSave.Size =
                new Size(185, 42);

            btnSave.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            btnSave.ForeColor = Color.White;

            btnSave.BackColor =
                Color.FromArgb(45, 95, 160);

            btnSave.FlatStyle =
                FlatStyle.Flat;

            btnSave.FlatAppearance.BorderSize = 0;

            btnSave.Cursor = Cursors.Hand;

            pnlMain.Controls.Add(btnSave);

            // =========================
            // CLEAR BUTTON
            // =========================

            btnClear = new Button();

            btnClear.Text = "CLEAR";

            btnClear.Location =
                new Point(260, 350);

            btnClear.Size =
                new Size(185, 42);

            btnClear.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            btnClear.ForeColor =
                Color.FromArgb(55, 62, 72);

            btnClear.BackColor =
                Color.FromArgb(235, 238, 243);

            btnClear.FlatStyle =
                FlatStyle.Flat;

            btnClear.FlatAppearance.BorderSize = 0;

            btnClear.Cursor = Cursors.Hand;

            pnlMain.Controls.Add(btnClear);

            // =========================
            // BACK BUTTON
            // =========================

            btnBack = new Button();

            btnBack.Text = "BACK";

            btnBack.Location =
                new Point(200, 405);

            btnBack.Size =
                new Size(100, 30);

            btnBack.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold
                );

            btnBack.ForeColor =
                Color.FromArgb(70, 70, 70);

            btnBack.BackColor =
                Color.Transparent;

            btnBack.FlatStyle =
                FlatStyle.Flat;

            btnBack.FlatAppearance.BorderSize = 0;

            btnBack.Cursor = Cursors.Hand;

            pnlMain.Controls.Add(btnBack);
        }

        // =========================
        // LABEL CREATOR
        // =========================

        private Label CreateLabel(
            string text,
            int x,
            int y)
        {
            Label label = new Label();

            label.Text = text;

            label.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Bold
            );

            label.ForeColor =
                Color.FromArgb(
                    55,
                    62,
                    72
                );

            label.AutoSize = true;

            label.Location =
                new Point(x, y);

            return label;
        }

        // =========================
        // TEXTBOX CREATOR
        // =========================

        private TextBox CreateTextBox(
            int x,
            int y)
        {
            TextBox textBox = new TextBox();

            textBox.Location =
                new Point(x, y);

            textBox.Size =
                new Size(390, 32);

            textBox.Font =
                new Font(
                    "Segoe UI",
                    10
                );

            textBox.BorderStyle =
                BorderStyle.FixedSingle;

            return textBox;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClientProfileForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "ClientProfileForm";
            this.Load += new System.EventHandler(this.ClientProfileForm_Load);
            this.ResumeLayout(false);

        }

        private void ClientProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}