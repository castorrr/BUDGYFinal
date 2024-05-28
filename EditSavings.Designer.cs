namespace BUDGY_2._0
{
    partial class EditSavings
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
            btnCancel = new Button();
            btnSet = new Button();
            tbxInput = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(26, 99);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(126, 99);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(94, 29);
            btnSet.TabIndex = 11;
            btnSet.Text = "Edit";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // tbxInput
            // 
            tbxInput.Location = new Point(26, 66);
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(194, 27);
            tbxInput.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(164, 38);
            label1.TabIndex = 9;
            label1.Text = "Edit Savings";
            // 
            // EditSavings
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
            Name = "EditSavings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditSavings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSet;
        private TextBox tbxInput;
        private Label label1;
    }
}