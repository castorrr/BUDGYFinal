namespace BUDGY_2._0
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxName = new TextBox();
            tbxUserName = new TextBox();
            tbxPass = new TextBox();
            tbxConfirmPass = new TextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            cbxShow = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(582, 193);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(582, 263);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(582, 337);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 410);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(582, 216);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(229, 27);
            tbxName.TabIndex = 4;
            // 
            // tbxUserName
            // 
            tbxUserName.Location = new Point(582, 286);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(229, 27);
            tbxUserName.TabIndex = 5;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(582, 360);
            tbxPass.Name = "tbxPass";
            tbxPass.PasswordChar = '●';
            tbxPass.Size = new Size(229, 27);
            tbxPass.TabIndex = 6;
            // 
            // tbxConfirmPass
            // 
            tbxConfirmPass.Location = new Point(582, 433);
            tbxConfirmPass.Name = "tbxConfirmPass";
            tbxConfirmPass.PasswordChar = '●';
            tbxConfirmPass.Size = new Size(229, 27);
            tbxConfirmPass.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(574, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(698, 498);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(118, 29);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // cbxShow
            // 
            cbxShow.AutoSize = true;
            cbxShow.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            cbxShow.Location = new Point(585, 466);
            cbxShow.Name = "cbxShow";
            cbxShow.Size = new Size(122, 21);
            cbxShow.TabIndex = 16;
            cbxShow.Text = "Show password";
            cbxShow.UseVisualStyleBackColor = true;
            cbxShow.CheckedChanged += cbxShow_CheckedChanged;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(864, 638);
            Controls.Add(cbxShow);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(tbxConfirmPass);
            Controls.Add(tbxPass);
            Controls.Add(tbxUserName);
            Controls.Add(tbxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosing += SignUpForm_FormClosing;
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxName;
        private TextBox tbxUserName;
        private TextBox tbxPass;
        private TextBox tbxConfirmPass;
        private Button btnCancel;
        private Button btnCreate;
        private CheckBox cbxShow;
    }
}