namespace BUDGY_2._0
{
    partial class Expenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvExpenses = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            lblTotal = new Label();
            btnTry = new Button();
            pnlExpenses = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            pnlExpenses.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 0;
            label1.Text = "Expenses";
            // 
            // dgvExpenses
            // 
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(15, 47);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.RowTemplate.Height = 29;
            dgvExpenses.Size = new Size(385, 337);
            dgvExpenses.TabIndex = 9;
            dgvExpenses.CellContentClick += dgvExpenses_CellContentClick;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(319, 567);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(454, 567);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(20, 111);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(370, 372);
            pieChart1.TabIndex = 15;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.Control;
            lblTotal.Location = new Point(20, 486);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(358, 45);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "#totalValue";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTry
            // 
            btnTry.Location = new Point(177, 567);
            btnTry.Name = "btnTry";
            btnTry.Size = new Size(94, 29);
            btnTry.TabIndex = 17;
            btnTry.Text = "Add";
            btnTry.UseVisualStyleBackColor = true;
            btnTry.Click += btnTry_Click;
            // 
            // pnlExpenses
            // 
            pnlExpenses.BackColor = Color.FromArgb(24, 30, 54);
            pnlExpenses.Controls.Add(dgvExpenses);
            pnlExpenses.Location = new Point(373, 89);
            pnlExpenses.Name = "pnlExpenses";
            pnlExpenses.Size = new Size(415, 429);
            pnlExpenses.TabIndex = 18;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            Controls.Add(pnlExpenses);
            Controls.Add(btnTry);
            Controls.Add(lblTotal);
            Controls.Add(pieChart1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Name = "Expenses";
            Size = new Size(801, 636);
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            pnlExpenses.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvExpenses;
        private Button btnEdit;
        private Button btnDelete;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Label lblTotal;
        private Button btnTry;
        private Panel pnlExpenses;
    }
}
