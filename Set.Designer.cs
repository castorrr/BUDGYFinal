namespace BUDGY_2._0
{
    partial class Set
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
            label1 = new Label();
            tbxInput = new TextBox();
            btnSet = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 0;
            label1.Text = "Set Budget";
            // 
            // tbxInput
            // 
            tbxInput.Location = new Point(28, 64);
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(194, 27);
            tbxInput.TabIndex = 2;
            tbxInput.TextChanged += textBox2_TextChanged;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(128, 97);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(94, 29);
            btnSet.TabIndex = 3;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(28, 97);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Set
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(247, 150);
            Controls.Add(btnCancel);
            Controls.Add(btnSet);
            Controls.Add(tbxInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Set";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set";
            Load += Set_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxInput;
        private Button btnSet;
        private Button btnCancel;
    }
}