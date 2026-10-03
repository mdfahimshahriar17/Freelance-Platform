using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Authentication
{
    public class RegisterForm : Form
    {
        private Panel pnlMain;
        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblUsername;
        private TextBox txtUsername;

        private Label lblEmail;
        private TextBox txtEmail;

        private Label lblPassword;
        private TextBox txtPassword;

        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;

        private Label lblRole;
        private ComboBox cmbRole;

        private Button btnRegister;
        private Button btnClear;
        private LinkLabel lnkLogin;

        public RegisterForm()
        {
            CreateRegisterForm();
        }

        private void CreateRegisterForm()
        {
            // Form
            this.Text = "Freelance Platform - Create Account";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(520, 680);
            this.MinimumSize = new Size(520, 680);
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Main panel
            pnlMain = new Panel();
            pnlMain.Size = new Size(430, 590);
            pnlMain.Location = new Point(35, 35);
            pnlMain.BackColor = Color.White;

            this.Controls.Add(pnlMain);

            // Title
            lblTitle = new Label();
            lblTitle.Text = "Create Account";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(35, 40, 48);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(105, 30);

            pnlMain.Controls.Add(lblTitle);

            // Subtitle
            lblSubtitle = new Label();
            lblSubtitle.Text = "Join our freelance community";
            lblSubtitle.Font = new Font("Segoe UI", 10);
            lblSubtitle.ForeColor = Color.FromArgb(110, 118, 130);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(112, 72);

            pnlMain.Controls.Add(lblSubtitle);

            // Username
            lblUsername = CreateLabel("Username", 45, 115);
            pnlMain.Controls.Add(lblUsername);

            txtUsername = CreateTextBox(45, 140);
            pnlMain.Controls.Add(txtUsername);

            // Email
            lblEmail = CreateLabel("Email", 45, 190);
            pnlMain.Controls.Add(lblEmail);

            txtEmail = CreateTextBox(45, 215);
            pnlMain.Controls.Add(txtEmail);

            // Password
            lblPassword = CreateLabel("Password", 45, 265);
            pnlMain.Controls.Add(lblPassword);

            txtPassword = CreateTextBox(45, 290);
            txtPassword.UseSystemPasswordChar = true;
            pnlMain.Controls.Add(txtPassword);

            // Confirm Password
            lblConfirmPassword = CreateLabel("Confirm Password", 45, 340);
            pnlMain.Controls.Add(lblConfirmPassword);

            txtConfirmPassword = CreateTextBox(45, 365);
            txtConfirmPassword.UseSystemPasswordChar = true;
            pnlMain.Controls.Add(txtConfirmPassword);

            // Role
            lblRole = CreateLabel("Account Type", 45, 415);
            pnlMain.Controls.Add(lblRole);

            cmbRole = new ComboBox();
            cmbRole.Location = new Point(45, 440);
            cmbRole.Size = new Size(340, 32);
            cmbRole.Font = new Font("Segoe UI", 10);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbRole.Items.Add("Client");
            cmbRole.Items.Add("Freelancer");
            cmbRole.SelectedIndex = -1;

            pnlMain.Controls.Add(cmbRole);

            // Register button
            btnRegister = new Button();
            btnRegister.Text = "REGISTER";
            btnRegister.Location = new Point(45, 490);
            btnRegister.Size = new Size(160, 42);
            btnRegister.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.BackColor = Color.FromArgb(45, 95, 160);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Cursor = Cursors.Hand;

            pnlMain.Controls.Add(btnRegister);

            // Clear button
            btnClear = new Button();
            btnClear.Text = "CLEAR";
            btnClear.Location = new Point(225, 490);
            btnClear.Size = new Size(160, 42);
            btnClear.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(55, 62, 72);
            btnClear.BackColor = Color.FromArgb(235, 238, 243);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Cursor = Cursors.Hand;

            pnlMain.Controls.Add(btnClear);

            // Login link
            lnkLogin = new LinkLabel();
            lnkLogin.Text = "Already have an account? Login";
            lnkLogin.Font = new Font("Segoe UI", 9);
            lnkLogin.LinkColor = Color.FromArgb(45, 95, 160);
            lnkLogin.AutoSize = true;
            lnkLogin.Location = new Point(120, 550);
            lnkLogin.Cursor = Cursors.Hand;

            pnlMain.Controls.Add(lnkLogin);
        }

        private Label CreateLabel(string text, int x, int y)
        {
            Label label = new Label();

            label.Text = text;
            label.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(55, 62, 72);
            label.AutoSize = true;
            label.Location = new Point(x, y);

            return label;
        }

        private TextBox CreateTextBox(int x, int y)
        {
            TextBox textBox = new TextBox();

            textBox.Location = new Point(x, y);
            textBox.Size = new Size(340, 32);
            textBox.Font = new Font("Segoe UI", 10);
            textBox.BorderStyle = BorderStyle.FixedSingle;

            return textBox;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(772, 429);
            this.Name = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}