namespace BUDGY_2._0
{
    partial class AddBills
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
            label3 = new Label();
            tbxName = new TextBox();
            tbxPrice = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            dtpDue = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(42, 62);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Bill Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(50, 111);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Bill Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(42, 155);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Due Date:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(125, 59);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(248, 27);
            tbxName.TabIndex = 3;
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(125, 108);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(248, 27);
            tbxPrice.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(184, 205);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(279, 205);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpDue
            // 
            dtpDue.Format = DateTimePickerFormat.Short;
            dtpDue.Location = new Point(123, 155);
            dtpDue.Name = "dtpDue";
            dtpDue.Size = new Size(250, 27);
            dtpDue.TabIndex = 8;
            // 
            // AddBills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(415, 296);
            Controls.Add(dtpDue);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(tbxPrice);
            Controls.Add(tbxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBills";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxName;
        private TextBox tbxPrice;
        private Button btnCancel;
        private Button btnAdd;
        private DateTimePicker dtpDue;
    }
}