using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace P_219934_MD_FAHIM_SHAHRIAR_Freelancer.Forms.Shared
{
    public class MessageForm : Form
    {
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlConversations;
        private Panel pnlChat;

        private Label lblPlatformName;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblConversationTitle;

        private Panel pnlJohn;
        private Panel pnlSarah;
        private Panel pnlMichael;

        private Panel pnlChatHeader;
        private Label lblChatAvatar;
        private Label lblChatName;
        private Label lblChatExpertise;

        private FlowLayoutPanel flpMessages;

        private TextBox txtMessage;
        private Button btnSend;
        private Button btnBack;

        public MessageForm()
        {
            CreateMessageForm();
        }

        private void CreateMessageForm()
        {
            // ============================================================
            // FORM
            // ============================================================

            this.Text = "Freelance Platform - Messages";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 680);
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ============================================================
            // HEADER
            // ============================================================

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
                new Point(27, 25);

            pnlHeader.Controls.Add(
                lblPlatformName
            );

            // ============================================================
            // MAIN CONTENT
            // ============================================================

            pnlContent = new Panel();

            pnlContent.Location =
                new Point(18, 104);

            pnlContent.Size =
                new Size(804, 510);

            pnlContent.BackColor =
                Color.White;

            this.Controls.Add(
                pnlContent
            );

            // ============================================================
            // TITLE
            // ============================================================

            lblTitle = new Label();

            lblTitle.Text =
                "Messages";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    22,
                    FontStyle.Bold
                );

            lblTitle.ForeColor =
                Color.FromArgb(25, 45, 70);

            lblTitle.AutoSize = true;

            lblTitle.Location =
                new Point(42, 25);

            pnlContent.Controls.Add(
                lblTitle
            );

            // ============================================================
            // SUBTITLE
            // ============================================================

            lblSubtitle = new Label();

            lblSubtitle.Text =
                "Your conversations with freelancers";

            lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    10
                );

            lblSubtitle.ForeColor =
                Color.FromArgb(110, 118, 130);

            lblSubtitle.AutoSize = true;

            lblSubtitle.Location =
                new Point(45, 67);

            pnlContent.Controls.Add(
                lblSubtitle
            );

            // ============================================================
            // CONVERSATIONS SECTION
            // ============================================================

            pnlConversations = new Panel();

            pnlConversations.Location =
                new Point(30, 105);

            pnlConversations.Size =
                new Size(205, 330);

            pnlConversations.BackColor =
                Color.FromArgb(249, 250, 252);

            pnlContent.Controls.Add(
                pnlConversations
            );

            // ============================================================
            // CONVERSATIONS TITLE
            // ============================================================

            lblConversationTitle = new Label();

            lblConversationTitle.Text =
                "Conversations";

            lblConversationTitle.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );

            lblConversationTitle.ForeColor =
                Color.FromArgb(30, 40, 50);

            lblConversationTitle.AutoSize = true;

            lblConversationTitle.Location =
                new Point(10, 5);

            pnlConversations.Controls.Add(
                lblConversationTitle
            );

            // ============================================================
            // JOHN SMITH
            // ============================================================

            pnlJohn = CreateConversationItem(
                "JS",
                "John Smith",
                "The backend is almost...",
                true
            );

            pnlJohn.Location =
                new Point(0, 40);

            pnlConversations.Controls.Add(
                pnlJohn
            );

            // ============================================================
            // SARAH AHMED
            // ============================================================

            pnlSarah = CreateConversationItem(
                "SA",
                "Sarah Ahmed",
                "Okay, I will check it.",
                false
            );

            pnlSarah.Location =
                new Point(0, 102);

            pnlConversations.Controls.Add(
                pnlSarah
            );

            // ============================================================
            // MICHAEL BROWN
            // ============================================================

            pnlMichael = CreateConversationItem(
                "MB",
                "Michael Brown",
                "Thanks for the update.",
                false
            );

            pnlMichael.Location =
                new Point(0, 164);

            pnlConversations.Controls.Add(
                pnlMichael
            );

            // ============================================================
            // VERTICAL DIVIDER
            // ============================================================

            Panel sectionDivider = new Panel();

            sectionDivider.Location =
                new Point(245, 105);

            sectionDivider.Size =
                new Size(1, 330);

            sectionDivider.BackColor =
                Color.FromArgb(225, 229, 235);

            pnlContent.Controls.Add(
                sectionDivider
            );

            // ============================================================
            // CHAT SECTION
            // ============================================================

            pnlChat = new Panel();

            pnlChat.Location =
                new Point(260, 105);

            pnlChat.Size =
                new Size(514, 330);

            pnlChat.BackColor =
                Color.White;

            pnlContent.Controls.Add(
                pnlChat
            );

            // ============================================================
            // CHAT HEADER
            // ============================================================

            pnlChatHeader = new Panel();

            pnlChatHeader.Location =
                new Point(0, 0);

            pnlChatHeader.Size =
                new Size(514, 58);

            pnlChatHeader.BackColor =
                Color.White;

            pnlChat.Controls.Add(
                pnlChatHeader
            );

            // ============================================================
            // CHAT AVATAR - SQUARE
            // ============================================================

            lblChatAvatar = new Label();

            lblChatAvatar.Text =
                "JS";

            lblChatAvatar.Font =
                new Font(
                    "Segoe UI",
                    8,
                    FontStyle.Bold
                );

            lblChatAvatar.ForeColor =
                Color.White;

            lblChatAvatar.BackColor =
                Color.FromArgb(45, 95, 160);

            lblChatAvatar.TextAlign =
                ContentAlignment.MiddleCenter;

            lblChatAvatar.Size =
                new Size(34, 34);

            lblChatAvatar.Location =
                new Point(10, 8);

            pnlChatHeader.Controls.Add(
                lblChatAvatar
            );

            // ============================================================
            // CHAT NAME
            // ============================================================

            lblChatName = new Label();

            lblChatName.Text =
                "John Smith";

            lblChatName.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );

            lblChatName.ForeColor =
                Color.FromArgb(25, 35, 48);

            lblChatName.AutoSize = true;

            lblChatName.Location =
                new Point(55, 7);

            pnlChatHeader.Controls.Add(
                lblChatName
            );

            // ============================================================
            // CHAT EXPERTISE
            // ============================================================

            lblChatExpertise = new Label();

            lblChatExpertise.Text =
                "Backend Developer";

            lblChatExpertise.Font =
                new Font(
                    "Segoe UI",
                    8
                );

            lblChatExpertise.ForeColor =
                Color.FromArgb(100, 110, 122);

            lblChatExpertise.AutoSize = true;

            lblChatExpertise.Location =
                new Point(55, 28);

            pnlChatHeader.Controls.Add(
                lblChatExpertise
            );

            // ============================================================
            // HEADER DIVIDER
            // ============================================================

            Panel headerLine = new Panel();

            headerLine.Location =
                new Point(0, 57);

            headerLine.Size =
                new Size(514, 1);

            headerLine.BackColor =
                Color.FromArgb(225, 229, 235);

            pnlChatHeader.Controls.Add(
                headerLine
            );

            // ============================================================
            // MESSAGE AREA
            // ============================================================

            flpMessages = new FlowLayoutPanel();

            flpMessages.Location =
                new Point(10, 65);

            flpMessages.Size =
                new Size(494, 175);

            flpMessages.FlowDirection =
                FlowDirection.TopDown;

            flpMessages.WrapContents =
                false;

            flpMessages.AutoScroll =
                true;

            flpMessages.BackColor =
                Color.White;

            flpMessages.BorderStyle =
                BorderStyle.None;

            pnlChat.Controls.Add(
                flpMessages
            );

            // ============================================================
            // SAMPLE MESSAGES
            // ============================================================

            AddMessage(
                "How is the project going?",
                "10:32 AM",
                true
            );

            AddMessage(
                "The backend is almost complete.",
                "10:35 AM",
                false
            );

            AddMessage(
                "Great. Please let me know when it's ready.",
                "10:37 AM",
                true
            );

            // ============================================================
            // MESSAGE INPUT AREA
            // ============================================================

            Panel pnlInput = new Panel();

            pnlInput.Location =
                new Point(10, 250);

            pnlInput.Size =
                new Size(494, 45);

            pnlInput.BackColor =
                Color.White;

            pnlChat.Controls.Add(
                pnlInput
            );

            // ============================================================
            // MESSAGE TEXTBOX
            // ============================================================

            txtMessage = new TextBox();

            txtMessage.Font =
                new Font(
                    "Segoe UI",
                    9
                );

            txtMessage.Location =
                new Point(0, 5);

            txtMessage.Size =
                new Size(385, 32);

            txtMessage.BorderStyle =
                BorderStyle.FixedSingle;

            pnlInput.Controls.Add(
                txtMessage
            );

            // ============================================================
            // SEND BUTTON
            // ============================================================

            btnSend = new Button();

            btnSend.Text =
                "SEND";

            btnSend.Font =
                new Font(
                    "Segoe UI",
                    8,
                    FontStyle.Bold
                );

            btnSend.ForeColor =
                Color.White;

            btnSend.BackColor =
                Color.FromArgb(45, 95, 160);

            btnSend.FlatStyle =
                FlatStyle.Flat;

            btnSend.FlatAppearance.BorderSize =
                0;

            btnSend.Cursor =
                Cursors.Hand;

            btnSend.Location =
                new Point(390, 3);

            btnSend.Size =
                new Size(85, 35);

            pnlInput.Controls.Add(
                btnSend
            );

            // ============================================================
            // BACK BUTTON
            // ============================================================

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
                new Point(30, 455);

            btnBack.Size =
                new Size(100, 35);

            pnlContent.Controls.Add(
                btnBack
            );
        }

        // ============================================================
        // CREATE CONVERSATION ITEM
        // ============================================================

        private Panel CreateConversationItem(
            string initials,
            string name,
            string preview,
            bool selected)
        {
            Panel item =
                new Panel();

            item.Size =
                new Size(195, 58);

            item.BackColor =
                selected
                    ? Color.FromArgb(235, 243, 253)
                    : Color.Transparent;

            item.Cursor =
                Cursors.Hand;

            // ========================================================
            // SQUARE AVATAR
            // ========================================================

            Label lblAvatar =
                new Label();

            lblAvatar.Text =
                initials;

            lblAvatar.Font =
                new Font(
                    "Segoe UI",
                    7,
                    FontStyle.Bold
                );

            lblAvatar.ForeColor =
                Color.White;

            lblAvatar.BackColor =
                selected
                    ? Color.FromArgb(45, 95, 160)
                    : Color.FromArgb(105, 120, 140);

            lblAvatar.TextAlign =
                ContentAlignment.MiddleCenter;

            lblAvatar.Size =
                new Size(32, 32);

            lblAvatar.Location =
                new Point(8, 11);

            // Square icon - no circular region

            item.Controls.Add(
                lblAvatar
            );

            // ========================================================
            // NAME
            // ========================================================

            Label lblName =
                new Label();

            lblName.Text =
                name;

            lblName.Font =
                new Font(
                    "Segoe UI",
                    9.5f,
                    FontStyle.Bold
                );

            lblName.ForeColor =
                Color.FromArgb(25, 35, 48);

            lblName.AutoSize = true;

            lblName.Location =
                new Point(50, 7);

            item.Controls.Add(
                lblName
            );

            // ========================================================
            // PREVIEW
            // ========================================================

            Label lblPreview =
                new Label();

            lblPreview.Text =
                preview;

            lblPreview.Font =
                new Font(
                    "Segoe UI",
                    8
                );

            lblPreview.ForeColor =
                Color.FromArgb(95, 105, 118);

            lblPreview.AutoSize = false;

            lblPreview.Size =
                new Size(135, 22);

            lblPreview.Location =
                new Point(50, 29);

            item.Controls.Add(
                lblPreview
            );

            return item;
        }

        // ============================================================
        // ADD MESSAGE
        // ============================================================

        private void AddMessage(
            string message,
            string time,
            bool isYou)
        {
            Panel container =
                new Panel();

            container.Width =
                470;

            container.Height =
                52;

            container.BackColor =
                Color.Transparent;

            Label bubble =
                new Label();

            bubble.Text =
                message +
                "\n" +
                time;

            bubble.Font =
                new Font(
                    "Segoe UI",
                    8.5f
                );

            bubble.ForeColor =
                Color.FromArgb(45, 50, 58);

            bubble.TextAlign =
                ContentAlignment.TopLeft;

            bubble.Padding =
                new Padding(
                    10,
                    6,
                    10,
                    5
                );

            bubble.AutoSize = false;

            bubble.Size =
                new Size(
                    isYou ? 275 : 230,
                    42
                );

            bubble.BackColor =
                isYou
                    ? Color.FromArgb(232, 241, 252)
                    : Color.FromArgb(245, 246, 248);

            if (isYou)
            {
                bubble.Location =
                    new Point(195, 3);
            }
            else
            {
                bubble.Location =
                    new Point(0, 3);
            }

            container.Controls.Add(
                bubble
            );

            flpMessages.Controls.Add(
                container
            );
        }
    }
}