namespace BUDGY_2._0
{
    partial class AddSG
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxPrice = new TextBox();
            tbxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(179, 85);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(215, 27);
            tbxPrice.TabIndex = 11;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(179, 42);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(215, 27);
            tbxName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(125, 84);
            label2.Name = "label2";
            label2.Size = new Size(59, 50);
            label2.TabIndex = 9;
            label2.Text = "Price:\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(181, 50);
            label1.TabIndex = 8;
            label1.Text = "Saving Goals Name:\r\n\r\n";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(300, 132);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(179, 132);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddSG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(434, 202);
            Controls.Add(tbxPrice);
            Controls.Add(tbxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSG";
            Load += AddSG_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxPrice;
        private TextBox tbxName;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private Button btnCancel;
    }
}