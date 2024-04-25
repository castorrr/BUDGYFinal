namespace BUDGY_2._0
{
    partial class Analytics
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
            pnlChoices = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlCharts = new Panel();
            pnlChoices.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChoices
            // 
            pnlChoices.Controls.Add(button3);
            pnlChoices.Controls.Add(button2);
            pnlChoices.Controls.Add(button1);
            pnlChoices.Dock = DockStyle.Bottom;
            pnlChoices.Location = new Point(0, 583);
            pnlChoices.Name = "pnlChoices";
            pnlChoices.Size = new Size(801, 53);
            pnlChoices.TabIndex = 1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(280, 0);
            button3.Name = "button3";
            button3.Size = new Size(140, 53);
            button3.TabIndex = 4;
            button3.Text = "Savings";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(140, 0);
            button2.Name = "button2";
            button2.Size = new Size(140, 53);
            button2.TabIndex = 3;
            button2.Text = "Expenses";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(140, 53);
            button1.TabIndex = 2;
            button1.Text = "Budget";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlCharts
            // 
            pnlCharts.Dock = DockStyle.Fill;
            pnlCharts.Location = new Point(0, 0);
            pnlCharts.Name = "pnlCharts";
            pnlCharts.Size = new Size(801, 583);
            pnlCharts.TabIndex = 2;
            // 
            // Analytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            Controls.Add(pnlCharts);
            Controls.Add(pnlChoices);
            Name = "Analytics";
            Size = new Size(801, 636);
            pnlChoices.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlChoices;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel pnlCharts;
    }
}
