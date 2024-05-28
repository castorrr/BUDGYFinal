namespace BUDGY_2._0
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable
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
            panel1 = new Panel();
            btnUI = new Button();
            btnLogout = new Button();
            btnInquires = new Button();
            btnAccounts = new Button();
            pnlDGV = new Panel();
            btnDel = new Button();
            btnReset = new Button();
            dgvAccounts = new DataGridView();
            panel1.SuspendLayout();
            pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUI);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnInquires);
            panel1.Controls.Add(btnAccounts);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 413);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 37);
            panel1.TabIndex = 0;
            // 
            // btnUI
            // 
            btnUI.Dock = DockStyle.Left;
            btnUI.Location = new Point(230, 0);
            btnUI.Name = "btnUI";
            btnUI.Size = new Size(129, 37);
            btnUI.TabIndex = 3;
            btnUI.Text = "User Information";
            btnUI.UseVisualStyleBackColor = true;
            btnUI.Click += btnUI_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Right;
            btnLogout.Location = new Point(685, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(115, 37);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnInquires
            // 
            btnInquires.Dock = DockStyle.Left;
            btnInquires.Location = new Point(115, 0);
            btnInquires.Name = "btnInquires";
            btnInquires.Size = new Size(115, 37);
            btnInquires.TabIndex = 1;
            btnInquires.Text = "Inquires";
            btnInquires.UseVisualStyleBackColor = true;
            btnInquires.Click += btnInquires_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.Dock = DockStyle.Left;
            btnAccounts.Location = new Point(0, 0);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(115, 37);
            btnAccounts.TabIndex = 0;
            btnAccounts.Text = "Accounts";
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // pnlDGV
            // 
            pnlDGV.Controls.Add(btnDel);
            pnlDGV.Controls.Add(btnReset);
            pnlDGV.Controls.Add(dgvAccounts);
            pnlDGV.Dock = DockStyle.Fill;
            pnlDGV.Location = new Point(0, 0);
            pnlDGV.Name = "pnlDGV";
            pnlDGV.Size = new Size(800, 413);
            pnlDGV.TabIndex = 1;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(694, 354);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 2;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(594, 354);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgvAccounts
            // 
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(12, 12);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.RowHeadersWidth = 51;
            dgvAccounts.RowTemplate.Height = 29;
            dgvAccounts.Size = new Size(776, 336);
            dgvAccounts.TabIndex = 0;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDGV);
            Controls.Add(panel1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnInquires;
        private Button btnAccounts;
        private Panel pnlDGV;
        private Button btnDel;
        private Button btnReset;
        private DataGridView dgvAccounts;
        private Button btnUI;
    }
}