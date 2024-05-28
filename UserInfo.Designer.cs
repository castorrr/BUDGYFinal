namespace BUDGY_2._0
{
    partial class UserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUser = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(16, 49);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 29;
            dgvUser.Size = new Size(755, 330);
            dgvUser.TabIndex = 0;
            dgvUser.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 1;
            label1.Text = "User Information";
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            Controls.Add(label1);
            Controls.Add(dgvUser);
            Name = "UserInfo";
            Size = new Size(800, 413);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUser;
        private Label label1;
    }
}
