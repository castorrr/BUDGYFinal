namespace BUDGY_2._0
{
    partial class Budget
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
            btnDelete = new Button();
            btnEdit = new Button();
            btnSet = new Button();
            dgvBudget = new DataGridView();
            label2 = new Label();
            lblRemBudget = new Label();
            label3 = new Label();
            label1 = new Label();
            lblBudget = new Label();
            label4 = new Label();
            pnlBudget = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBudget).BeginInit();
            pnlBudget.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(212, 235);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button3_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(112, 235);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit Budget";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(12, 235);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(94, 29);
            btnSet.TabIndex = 16;
            btnSet.Text = "Set Budget";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += button1_Click;
            // 
            // dgvBudget
            // 
            dgvBudget.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBudget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudget.Location = new Point(14, 77);
            dgvBudget.Name = "dgvBudget";
            dgvBudget.RowHeadersWidth = 51;
            dgvBudget.RowTemplate.Height = 29;
            dgvBudget.Size = new Size(445, 412);
            dgvBudget.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(21, 12);
            label2.Name = "label2";
            label2.Size = new Size(201, 38);
            label2.TabIndex = 14;
            label2.Text = "Budget History";
            // 
            // lblRemBudget
            // 
            lblRemBudget.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRemBudget.ForeColor = SystemColors.ButtonFace;
            lblRemBudget.Location = new Point(59, 409);
            lblRemBudget.Name = "lblRemBudget";
            lblRemBudget.Size = new Size(217, 28);
            lblRemBudget.TabIndex = 13;
            lblRemBudget.Text = "0";
            lblRemBudget.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(32, 353);
            label3.Name = "label3";
            label3.Size = new Size(260, 38);
            label3.TabIndex = 12;
            label3.Text = "Remaining Budget";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(89, 108);
            label1.Name = "label1";
            label1.Size = new Size(157, 50);
            label1.TabIndex = 10;
            label1.Text = "BUDGET";
            // 
            // lblBudget
            // 
            lblBudget.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblBudget.ForeColor = SystemColors.ControlLightLight;
            lblBudget.Location = new Point(80, 158);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(174, 31);
            lblBudget.TabIndex = 19;
            lblBudget.Text = "0";
            lblBudget.TextAlign = ContentAlignment.MiddleCenter;
            lblBudget.Click += lblBudget_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(154, 46);
            label4.TabIndex = 20;
            label4.Text = "BUDGET";
            // 
            // pnlBudget
            // 
            pnlBudget.BackColor = Color.FromArgb(24, 30, 54);
            pnlBudget.Controls.Add(dgvBudget);
            pnlBudget.Controls.Add(label2);
            pnlBudget.Location = new Point(312, 47);
            pnlBudget.Name = "pnlBudget";
            pnlBudget.Size = new Size(471, 537);
            pnlBudget.TabIndex = 21;
            // 
            // Budget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            Controls.Add(pnlBudget);
            Controls.Add(label4);
            Controls.Add(lblBudget);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSet);
            Controls.Add(lblRemBudget);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Budget";
            Size = new Size(801, 636);
            Load += Budget_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBudget).EndInit();
            pnlBudget.ResumeLayout(false);
            pnlBudget.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnEdit;
        private Button btnSet;
        private DataGridView dgvBudget;
        private Label label2;
        private Label lblRemBudget;
        private Label label3;
        private Label label1;
        private Label lblBudget;
        private Label label4;
        private Panel pnlBudget;
    }
}
