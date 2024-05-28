namespace BUDGY_2._0
{
    partial class Savings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used
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
            lblSavings = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            dgvHistory = new DataGridView();
            dgvGoals = new DataGridView();
            label8 = new Label();
            btnDeleteSG = new Button();
            btnEditSG = new Button();
            btnAddSG = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnDelSG = new Button();
            btnSGEdit = new Button();
            btnSGAdd = new Button();
            lblSG = new Label();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            label1 = new Label();
            pnlSavings = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGoals).BeginInit();
            pnlSavings.SuspendLayout();
            SuspendLayout();
            // 
            // lblSavings
            // 
            lblSavings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavings.ForeColor = SystemColors.ButtonHighlight;
            lblSavings.Location = new Point(83, 135);
            lblSavings.Name = "lblSavings";
            lblSavings.Size = new Size(145, 28);
            lblSavings.TabIndex = 0;
            lblSavings.Text = "#savings_value";
            lblSavings.TextAlign = ContentAlignment.MiddleCenter;
            lblSavings.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(99, 97);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 1;
            label2.Text = "Savings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(75, 288);
            label3.Name = "label3";
            label3.Size = new Size(185, 38);
            label3.TabIndex = 5;
            label3.Text = "Saving Goals";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(15, 15);
            label7.Name = "label7";
            label7.Size = new Size(209, 38);
            label7.TabIndex = 17;
            label7.Text = "Saving History";
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(15, 56);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 29;
            dgvHistory.Size = new Size(448, 198);
            dgvHistory.TabIndex = 18;
            // 
            // dgvGoals
            // 
            dgvGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoals.Location = new Point(15, 308);
            dgvGoals.Name = "dgvGoals";
            dgvGoals.RowHeadersWidth = 51;
            dgvGoals.RowTemplate.Height = 29;
            dgvGoals.Size = new Size(448, 198);
            dgvGoals.TabIndex = 20;
            dgvGoals.CellClick += dgvGoals_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(15, 267);
            label8.Name = "label8";
            label8.Size = new Size(185, 38);
            label8.TabIndex = 19;
            label8.Text = "Saving Goals";
            // 
            // btnDeleteSG
            // 
            btnDeleteSG.Location = new Point(617, 581);
            btnDeleteSG.Name = "btnDeleteSG";
            btnDeleteSG.Size = new Size(94, 29);
            btnDeleteSG.TabIndex = 27;
            btnDeleteSG.Text = "Delete";
            btnDeleteSG.UseVisualStyleBackColor = true;
            btnDeleteSG.Click += btnDeleteSG_Click;
            // 
            // btnEditSG
            // 
            btnEditSG.Location = new Point(513, 581);
            btnEditSG.Name = "btnEditSG";
            btnEditSG.Size = new Size(94, 29);
            btnEditSG.TabIndex = 26;
            btnEditSG.Text = "Edit";
            btnEditSG.UseVisualStyleBackColor = true;
            btnEditSG.Click += btnEditSG_Click;
            // 
            // btnAddSG
            // 
            btnAddSG.Location = new Point(413, 581);
            btnAddSG.Name = "btnAddSG";
            btnAddSG.Size = new Size(94, 29);
            btnAddSG.TabIndex = 25;
            btnAddSG.Text = "Add";
            btnAddSG.UseVisualStyleBackColor = true;
            btnAddSG.Click += btnAddSG_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 183);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(116, 183);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(220, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDelSG
            // 
            btnDelSG.Location = new Point(226, 554);
            btnDelSG.Name = "btnDelSG";
            btnDelSG.Size = new Size(94, 29);
            btnDelSG.TabIndex = 30;
            btnDelSG.Text = "Delete";
            btnDelSG.UseVisualStyleBackColor = true;
            btnDelSG.Click += button1_Click;
            // 
            // btnSGEdit
            // 
            btnSGEdit.Location = new Point(122, 554);
            btnSGEdit.Name = "btnSGEdit";
            btnSGEdit.Size = new Size(94, 29);
            btnSGEdit.TabIndex = 29;
            btnSGEdit.Text = "Edit";
            btnSGEdit.UseVisualStyleBackColor = true;
            btnSGEdit.Click += btnSGEdit_Click;
            // 
            // btnSGAdd
            // 
            btnSGAdd.Location = new Point(22, 554);
            btnSGAdd.Name = "btnSGAdd";
            btnSGAdd.Size = new Size(94, 29);
            btnSGAdd.TabIndex = 28;
            btnSGAdd.Text = "Add";
            btnSGAdd.UseVisualStyleBackColor = true;
            btnSGAdd.Click += btnSGAdd_Click;
            // 
            // lblSG
            // 
            lblSG.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSG.ForeColor = SystemColors.Control;
            lblSG.Location = new Point(56, 326);
            lblSG.Name = "lblSG";
            lblSG.Size = new Size(204, 31);
            lblSG.TabIndex = 31;
            lblSG.Text = "#sgvalue";
            lblSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pieChart1
            // 
            pieChart1.ForeColor = SystemColors.Control;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(56, 360);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(204, 188);
            pieChart1.TabIndex = 33;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(142, 46);
            label1.TabIndex = 34;
            label1.Text = "Savings";
            // 
            // pnlSavings
            // 
            pnlSavings.BackColor = Color.FromArgb(24, 30, 54);
            pnlSavings.Controls.Add(dgvHistory);
            pnlSavings.Controls.Add(label7);
            pnlSavings.Controls.Add(dgvGoals);
            pnlSavings.Controls.Add(label8);
            pnlSavings.Location = new Point(319, 28);
            pnlSavings.Name = "pnlSavings";
            pnlSavings.Size = new Size(477, 537);
            pnlSavings.TabIndex = 35;
            // 
            // Savings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            Controls.Add(pnlSavings);
            Controls.Add(label1);
            Controls.Add(pieChart1);
            Controls.Add(lblSG);
            Controls.Add(btnDelSG);
            Controls.Add(btnSGEdit);
            Controls.Add(btnSGAdd);
            Controls.Add(btnDeleteSG);
            Controls.Add(btnEditSG);
            Controls.Add(btnAddSG);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSavings);
            Name = "Savings";
            Size = new Size(801, 636);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGoals).EndInit();
            pnlSavings.ResumeLayout(false);
            pnlSavings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSavings;
        private Label label2;
        private Label label3;
        private Label label7;
        private DataGridView dgvHistory;
        private DataGridView dgvGoals;
        private Label label8;
        private Button btnDeleteSG;
        private Button btnEditSG;
        private Button btnAddSG;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnDelSG;
        private Button btnSGEdit;
        private Button btnSGAdd;
        private Label lblSG;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Label label1;
        private Panel pnlSavings;
    }
}
