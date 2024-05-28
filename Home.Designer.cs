namespace BUDGY_2._0
{
    partial class Home
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
            label1 = new Label();
            lblBudget = new Label();
            label3 = new Label();
            lblRemBudget = new Label();
            label4 = new Label();
            label2 = new Label();
            lblSavings = new Label();
            label6 = new Label();
            lblTotal = new Label();
            pnlBudget = new Panel();
            pnlSavings = new Panel();
            pieChart2 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            pnlExpenses = new Panel();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            label5 = new Label();
            pnlBudget.SuspendLayout();
            pnlSavings.SuspendLayout();
            pnlExpenses.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(70, 15);
            label1.Name = "label1";
            label1.Size = new Size(144, 46);
            label1.TabIndex = 0;
            label1.Text = "BUDGET";
            label1.Click += label1_Click;
            // 
            // lblBudget
            // 
            lblBudget.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblBudget.ForeColor = SystemColors.ButtonFace;
            lblBudget.Location = new Point(51, 55);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(181, 26);
            lblBudget.TabIndex = 1;
            lblBudget.Text = "#budget_value";
            lblBudget.TextAlign = ContentAlignment.MiddleCenter;
            lblBudget.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(21, 98);
            label3.Name = "label3";
            label3.Size = new Size(244, 38);
            label3.TabIndex = 3;
            label3.Text = "Remaining Budget";
            // 
            // lblRemBudget
            // 
            lblRemBudget.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRemBudget.ForeColor = SystemColors.ButtonFace;
            lblRemBudget.Location = new Point(75, 130);
            lblRemBudget.Name = "lblRemBudget";
            lblRemBudget.Size = new Size(137, 26);
            lblRemBudget.TabIndex = 4;
            lblRemBudget.Text = "#remValue";
            lblRemBudget.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(143, 11);
            label4.Name = "label4";
            label4.Size = new Size(156, 46);
            label4.TabIndex = 6;
            label4.Text = "Expenses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(80, 19);
            label2.Name = "label2";
            label2.Size = new Size(132, 46);
            label2.TabIndex = 9;
            label2.Text = "Savings";
            // 
            // lblSavings
            // 
            lblSavings.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSavings.ForeColor = SystemColors.ButtonFace;
            lblSavings.Location = new Point(21, 58);
            lblSavings.Name = "lblSavings";
            lblSavings.Size = new Size(233, 26);
            lblSavings.TabIndex = 10;
            lblSavings.Text = "#savingsValue";
            lblSavings.TextAlign = ContentAlignment.MiddleCenter;
            lblSavings.Click += lblSavings_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(41, 95);
            label6.Name = "label6";
            label6.Size = new Size(209, 46);
            label6.TabIndex = 11;
            label6.Text = "Saving Goals";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.Control;
            lblTotal.Location = new Point(38, 444);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(359, 25);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Some Text Here...";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBudget
            // 
            pnlBudget.BackColor = Color.FromArgb(24, 30, 54);
            pnlBudget.Controls.Add(label1);
            pnlBudget.Controls.Add(lblBudget);
            pnlBudget.Controls.Add(label3);
            pnlBudget.Controls.Add(lblRemBudget);
            pnlBudget.Location = new Point(20, 93);
            pnlBudget.Name = "pnlBudget";
            pnlBudget.Size = new Size(305, 204);
            pnlBudget.TabIndex = 16;
            // 
            // pnlSavings
            // 
            pnlSavings.BackColor = Color.FromArgb(24, 30, 54);
            pnlSavings.Controls.Add(pieChart2);
            pnlSavings.Controls.Add(label6);
            pnlSavings.Controls.Add(label2);
            pnlSavings.Controls.Add(lblSavings);
            pnlSavings.Location = new Point(20, 313);
            pnlSavings.Name = "pnlSavings";
            pnlSavings.Size = new Size(305, 280);
            pnlSavings.TabIndex = 17;
            // 
            // pieChart2
            // 
            pieChart2.InitialRotation = 0D;
            pieChart2.IsClockwise = true;
            pieChart2.Location = new Point(53, 136);
            pieChart2.MaxAngle = 360D;
            pieChart2.MaxValue = null;
            pieChart2.MinValue = 0D;
            pieChart2.Name = "pieChart2";
            pieChart2.Size = new Size(181, 126);
            pieChart2.TabIndex = 12;
            pieChart2.Total = null;
            pieChart2.Load += pieChart2_Load;
            // 
            // pnlExpenses
            // 
            pnlExpenses.BackColor = Color.FromArgb(24, 30, 54);
            pnlExpenses.Controls.Add(pieChart1);
            pnlExpenses.Controls.Add(lblTotal);
            pnlExpenses.Controls.Add(label4);
            pnlExpenses.Location = new Point(344, 93);
            pnlExpenses.Name = "pnlExpenses";
            pnlExpenses.Size = new Size(436, 500);
            pnlExpenses.TabIndex = 18;
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(17, 60);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(416, 376);
            pieChart1.TabIndex = 14;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(20, 10);
            label5.Name = "label5";
            label5.Size = new Size(196, 46);
            label5.TabIndex = 15;
            label5.Text = "OVERVIEW";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            Controls.Add(label5);
            Controls.Add(pnlExpenses);
            Controls.Add(pnlSavings);
            Controls.Add(pnlBudget);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Home";
            Size = new Size(801, 636);
            Load += Home_Load;
            pnlBudget.ResumeLayout(false);
            pnlBudget.PerformLayout();
            pnlSavings.ResumeLayout(false);
            pnlSavings.PerformLayout();
            pnlExpenses.ResumeLayout(false);
            pnlExpenses.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBudget;
        private Label label3;
        private Label lblRemBudget;
        private Label label4;
        private Label label2;
        private Label lblSavings;
        private Label label6;
        private Label lblTotal;
        private Panel pnlBudget;
        private Panel pnlSavings;
        private Panel pnlExpenses;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart2;
        private Label label5;
    }
}
