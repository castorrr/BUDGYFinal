namespace BUDGY_2._0
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            lblContact = new LinkLabel();
            btnBills = new Button();
            btnLogout = new Button();
            btnSavings = new Button();
            c = new Button();
            bntBudget = new Button();
            btnHome = new Button();
            panel3 = new Panel();
            pbUser = new CircularPictureBox();
            lblEditAccount = new LinkLabel();
            lblAnalytics = new LinkLabel();
            lblName1 = new Label();
            lblName = new Label();
            pnlDash = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(lblContact);
            panel1.Controls.Add(btnBills);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnSavings);
            panel1.Controls.Add(c);
            panel1.Controls.Add(bntBudget);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 636);
            panel1.TabIndex = 0;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(78, 556);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(80, 20);
            lblContact.TabIndex = 7;
            lblContact.TabStop = true;
            lblContact.Text = "Contact Us";
            lblContact.LinkClicked += lblContact_LinkClicked;
            // 
            // btnBills
            // 
            btnBills.BackColor = Color.FromArgb(24, 30, 54);
            btnBills.BackgroundImage = (Image)resources.GetObject("btnBills.BackgroundImage");
            btnBills.Dock = DockStyle.Top;
            btnBills.FlatAppearance.BorderSize = 0;
            btnBills.FlatStyle = FlatStyle.Flat;
            btnBills.ForeColor = SystemColors.Control;
            btnBills.Location = new Point(0, 407);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(247, 57);
            btnBills.TabIndex = 5;
            btnBills.UseVisualStyleBackColor = false;
            btnBills.Click += btnBills_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(24, 30, 54);
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(0, 579);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(247, 57);
            btnLogout.TabIndex = 4;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSavings
            // 
            btnSavings.BackColor = Color.FromArgb(24, 30, 54);
            btnSavings.BackgroundImage = (Image)resources.GetObject("btnSavings.BackgroundImage");
            btnSavings.Dock = DockStyle.Top;
            btnSavings.FlatAppearance.BorderSize = 0;
            btnSavings.FlatStyle = FlatStyle.Flat;
            btnSavings.ForeColor = SystemColors.Control;
            btnSavings.Location = new Point(0, 350);
            btnSavings.Name = "btnSavings";
            btnSavings.Size = new Size(247, 57);
            btnSavings.TabIndex = 3;
            btnSavings.UseVisualStyleBackColor = false;
            btnSavings.Click += button4_Click;
            // 
            // c
            // 
            c.BackColor = Color.FromArgb(24, 30, 54);
            c.BackgroundImage = (Image)resources.GetObject("c.BackgroundImage");
            c.Dock = DockStyle.Top;
            c.FlatAppearance.BorderSize = 0;
            c.FlatStyle = FlatStyle.Flat;
            c.ForeColor = SystemColors.Control;
            c.Location = new Point(0, 293);
            c.Name = "c";
            c.Size = new Size(247, 57);
            c.TabIndex = 2;
            c.UseVisualStyleBackColor = false;
            c.Click += button3_Click;
            // 
            // bntBudget
            // 
            bntBudget.BackColor = Color.FromArgb(24, 30, 54);
            bntBudget.BackgroundImage = (Image)resources.GetObject("bntBudget.BackgroundImage");
            bntBudget.Dock = DockStyle.Top;
            bntBudget.FlatAppearance.BorderSize = 0;
            bntBudget.FlatStyle = FlatStyle.Flat;
            bntBudget.ForeColor = SystemColors.Control;
            bntBudget.Location = new Point(0, 236);
            bntBudget.Name = "bntBudget";
            bntBudget.Size = new Size(247, 57);
            bntBudget.TabIndex = 1;
            bntBudget.UseVisualStyleBackColor = false;
            bntBudget.Click += bntBudget_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = SystemColors.Control;
            btnHome.Location = new Point(0, 179);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(247, 57);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnDash_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pbUser);
            panel3.Controls.Add(lblEditAccount);
            panel3.Controls.Add(lblAnalytics);
            panel3.Controls.Add(lblName1);
            panel3.Controls.Add(lblName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 179);
            panel3.TabIndex = 0;
            // 
            // pbUser
            // 
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(71, 23);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(93, 83);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 8;
            pbUser.TabStop = false;
            // 
            // lblEditAccount
            // 
            lblEditAccount.AutoSize = true;
            lblEditAccount.Location = new Point(12, 146);
            lblEditAccount.Name = "lblEditAccount";
            lblEditAccount.Size = new Size(93, 20);
            lblEditAccount.TabIndex = 5;
            lblEditAccount.TabStop = true;
            lblEditAccount.Text = "Edit Account";
            lblEditAccount.LinkClicked += lblEditAccount_LinkClicked;
            // 
            // lblAnalytics
            // 
            lblAnalytics.AutoSize = true;
            lblAnalytics.Location = new Point(147, 146);
            lblAnalytics.Name = "lblAnalytics";
            lblAnalytics.Size = new Size(68, 20);
            lblAnalytics.TabIndex = 6;
            lblAnalytics.TabStop = true;
            lblAnalytics.Text = "Analytics";
            lblAnalytics.LinkClicked += lblAnalytics_LinkClicked;
            // 
            // lblName1
            // 
            lblName1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName1.ForeColor = SystemColors.ControlLightLight;
            lblName1.Location = new Point(12, 109);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(213, 25);
            lblName1.TabIndex = 4;
            lblName1.Text = "Name_User";
            lblName1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(121, 109);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 3;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDash
            // 
            pnlDash.BackColor = Color.FromArgb(43, 48, 72);
            pnlDash.Dock = DockStyle.Fill;
            pnlDash.Location = new Point(247, 0);
            pnlDash.Name = "pnlDash";
            pnlDash.Size = new Size(801, 636);
            pnlDash.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 636);
            Controls.Add(pnlDash);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlDash;
        private Panel panel3;
        private Button btnLogout;
        private Button btnSavings;
        private Button btnExpenses;
        private Button bntBudget;
        private Button btnHome;
        private Label lblName;
        private Button btnBills;
        private Label lblName1;
        private LinkLabel lblEditAccount;
        private LinkLabel lblAnalytics;
        private LinkLabel lblContact;
        private Button c;
        private CircularPictureBox pbUser;
    }
}