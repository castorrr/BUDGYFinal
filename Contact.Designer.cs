namespace BUDGY_2._0
{
    partial class btnSend
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
            label2 = new Label();
            tbxEmail = new TextBox();
            tbxMessage = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 1;
            label2.Text = "Message: ";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(108, 23);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(309, 27);
            tbxEmail.TabIndex = 2;
            // 
            // tbxMessage
            // 
            tbxMessage.Location = new Point(106, 65);
            tbxMessage.Name = "tbxMessage";
            tbxMessage.Size = new Size(311, 200);
            tbxMessage.TabIndex = 3;
            tbxMessage.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(310, 271);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 5;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(438, 321);
            Controls.Add(button2);
            Controls.Add(tbxMessage);
            Controls.Add(tbxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "btnSend";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact Us";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxEmail;
        private RichTextBox tbxMessage;
        private Button button2;
    }
}