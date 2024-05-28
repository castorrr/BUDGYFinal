namespace BUDGY_2._0
{
    partial class Inquires
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
            dgvInquiry = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lblEmail = new Label();
            lblMSG = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInquiry).BeginInit();
            SuspendLayout();
            // 
            // dgvInquiry
            // 
            dgvInquiry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInquiry.Location = new Point(16, 25);
            dgvInquiry.Name = "dgvInquiry";
            dgvInquiry.RowHeadersWidth = 51;
            dgvInquiry.RowTemplate.Height = 29;
            dgvInquiry.Size = new Size(274, 345);
            dgvInquiry.TabIndex = 0;
            dgvInquiry.CellContentClick += dgvInquiry_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(314, 25);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(314, 63);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Message:";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.Control;
            lblEmail.Location = new Point(379, 23);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(274, 25);
            lblEmail.TabIndex = 3;
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            lblEmail.Click += lblEmail_Click;
            // 
            // lblMSG
            // 
            lblMSG.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMSG.ForeColor = SystemColors.Control;
            lblMSG.Location = new Point(411, 63);
            lblMSG.Name = "lblMSG";
            lblMSG.Size = new Size(371, 326);
            lblMSG.TabIndex = 4;
            // 
            // Inquires
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            Controls.Add(lblMSG);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvInquiry);
            Name = "Inquires";
            Size = new Size(800, 413);
            ((System.ComponentModel.ISupportInitialize)dgvInquiry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInquiry;
        private Label label1;
        private Label label2;
        private Label lblEmail;
        private Label lblMSG;
    }
}
