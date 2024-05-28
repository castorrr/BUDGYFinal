namespace BUDGY_2._0
{
    partial class AddExpenses
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
            label1 = new Label();
            tbxName = new TextBox();
            label2 = new Label();
            tbxPrice = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 0;
            label1.Text = "Expenses Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(183, 49);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(247, 27);
            tbxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 2;
            label2.Text = "Expenses Price:";
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(183, 118);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(247, 27);
            tbxPrice.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(236, 165);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(336, 165);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            ClientSize = new Size(448, 226);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbxPrice);
            Controls.Add(label2);
            Controls.Add(tbxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddExpenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddExpenses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxName;
        private Label label2;
        private TextBox tbxPrice;
        private Button button1;
        private Button button2;
    }
}