namespace BUDGY_2._0
{
    partial class SavingsAnalytics
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
            view1 = new View();
            panel1 = new Panel();
            lblTotal = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // view1
            // 
            view1.Location = new Point(3, 3);
            view1.Name = "view1";
            view1.Size = new Size(798, 409);
            view1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(13, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 184);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.Control;
            lblTotal.Location = new Point(43, 61);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(730, 36);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "lblTotal";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SavingsAnalytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            Controls.Add(panel1);
            Controls.Add(view1);
            Name = "SavingsAnalytics";
            Size = new Size(801, 583);
            Load += SavingsAnalytics_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private View view1;
        private Panel panel1;
        private Label lblTotal;
    }
}
