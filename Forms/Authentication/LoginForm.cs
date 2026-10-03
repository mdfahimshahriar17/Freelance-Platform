using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Authentication
{
    public class LoginForm : Form
    {
        // Main panel
        private Panel pnlLogin;

        // Labels
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblRegister;

        // Input fields
        private TextBox txtUsername;
        private TextBox txtPassword;

        // Buttons
        private Button btnLogin;
        private Button btnClear;

        // Register link
        private LinkLabel lnkRegister;

        public LoginForm()
        {
            CreateLoginForm();
        }

        private void CreateLoginForm()
        {
            // =========================
            // FORM SETTINGS
            // =========================

            Text = "Freelance Platform - Login";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(520, 520);
            BackColor = Color.FromArgb(245, 247, 250);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = true;

            // =========================
            // MAIN PANEL
            // =========================

            pnlLogin = new Panel();
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Location = new Point(35, 35);
            pnlLogin.Size = new Size(430, 430);
            pnlLogin.BackColor = Color.White;

            Controls.Add(pnlLogin);

            // =========================
            // TITLE
            // =========================

            lblTitle = new Label();
            lblTitle.AutoSize = false;
            lblTitle.Text = "Welcome Back";
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(35, 35, 35);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Location = new Point(30, 35);
            lblTitle.Size = new Size(370, 40);

            pnlLogin.Controls.Add(lblTitle);

            // =========================
            // SUBTITLE
            // =========================

            lblSubtitle = new Label();
            lblSubtitle.AutoSize = false;
            lblSubtitle.Text = "Login to your freelance account";
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(110, 110, 110);
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.Location = new Point(30, 75);
            lblSubtitle.Size = new Size(370, 30);

            pnlLogin.Controls.Add(lblSubtitle);

            // =========================
            // USERNAME LABEL
            // =========================

            lblUsername = new Label();
            lblUsername.AutoSize = false;
            lblUsername.Text = "Username";
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(55, 55, 55);
            lblUsername.Location = new Point(45, 125);
            lblUsername.Size = new Size(340, 25);

            pnlLogin.Controls.Add(lblUsername);

            // =========================
            // USERNAME TEXTBOX
            // =========================

            txtUsername = new TextBox();
            txtUsername.Name = "txtUsername";
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(45, 150);
            txtUsername.Size = new Size(340, 30);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;

            pnlLogin.Controls.Add(txtUsername);

            // =========================
            // PASSWORD LABEL
            // =========================

            lblPassword = new Label();
            lblPassword.AutoSize = false;
            lblPassword.Text = "Password";
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(55, 55, 55);
            lblPassword.Location = new Point(45, 195);
            lblPassword.Size = new Size(340, 25);

            pnlLogin.Controls.Add(lblPassword);

            // =========================
            // PASSWORD TEXTBOX
            // =========================

            txtPassword = new TextBox();
            txtPassword.Name = "txtPassword";
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(45, 220);
            txtPassword.Size = new Size(340, 30);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.UseSystemPasswordChar = true;

            pnlLogin.Controls.Add(txtPassword);

            // =========================
            // LOGIN BUTTON
            // =========================

            btnLogin = new Button();
            btnLogin.Name = "btnLogin";
            btnLogin.Text = "LOGIN";
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.BackColor = Color.FromArgb(45, 95, 170);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(45, 270);
            btnLogin.Size = new Size(340, 42);

            btnLogin.Click += BtnLogin_Click;

            pnlLogin.Controls.Add(btnLogin);

            // =========================
            // CLEAR BUTTON
            // =========================

            btnClear = new Button();
            btnClear.Name = "btnClear";
            btnClear.Text = "CLEAR";
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(70, 70, 70);
            btnClear.BackColor = Color.FromArgb(235, 237, 240);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(45, 322);
            btnClear.Size = new Size(340, 42);

            btnClear.Click += BtnClear_Click;

            pnlLogin.Controls.Add(btnClear);

            // =========================
            // REGISTER TEXT
            // =========================

            lblRegister = new Label();
            lblRegister.AutoSize = false;
            lblRegister.Text = "Don't have an account?";
            lblRegister.Font = new Font("Segoe UI", 9.5F);
            lblRegister.ForeColor = Color.FromArgb(100, 100, 100);
            lblRegister.TextAlign = ContentAlignment.MiddleRight;
            lblRegister.Location = new Point(55, 385);
            lblRegister.Size = new Size(185, 25);

            pnlLogin.Controls.Add(lblRegister);

            // =========================
            // REGISTER LINK
            // =========================

            lnkRegister = new LinkLabel();
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Text = "Create Account";
            lnkRegister.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lnkRegister.LinkColor = Color.FromArgb(45, 95, 170);
            lnkRegister.ActiveLinkColor = Color.FromArgb(30, 70, 135);
            lnkRegister.VisitedLinkColor = Color.FromArgb(45, 95, 170);
            lnkRegister.AutoSize = false;
            lnkRegister.TextAlign = ContentAlignment.MiddleLeft;
            lnkRegister.Location = new Point(240, 385);
            lnkRegister.Size = new Size(140, 25);
            lnkRegister.Cursor = Cursors.Hand;

            lnkRegister.LinkClicked += LnkRegister_LinkClicked;

            pnlLogin.Controls.Add(lnkRegister);

            // =========================
            // ENTER KEY
            // =========================

            AcceptButton = btnLogin;

            // =========================
            // ESCAPE KEY
            // =========================

            CancelButton = btnClear;
        }

        // =========================
        // LOGIN BUTTON EVENT
        // =========================

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Login functionality will be connected to the database next.",
                "Login",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // =========================
        // CLEAR BUTTON EVENT
        // =========================

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }

        // =========================
        // REGISTER LINK EVENT
        // =========================

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            registerForm.Show();

            Hide();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}