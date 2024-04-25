namespace BUDGY_2._0
{
    partial class EditBills
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
            dgvPay = new DataGridView();
            label1 = new Label();
            tbxName = new TextBox();
            tbxPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            btnCancel = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPay).BeginInit();
            SuspendLayout();
            // 
            // dgvPay
            // 
            dgvPay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPay.Location = new Point(61, 26);
            dgvPay.Name = "dgvPay";
            dgvPay.RowHeadersWidth = 51;
            dgvPay.RowTemplate.Height = 29;
            dgvPay.Size = new Size(666, 296);
            dgvPay.TabIndex = 0;
            dgvPay.CellClick += dgvPay_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(79, 350);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(137, 347);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(136, 27);
            tbxName.TabIndex = 2;
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(364, 347);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(136, 27);
            tbxPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(306, 350);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(541, 354);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(591, 349);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(136, 27);
            dtpDate.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(514, 396);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(633, 396);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Update";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // EditBills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(tbxPrice);
            Controls.Add(label2);
            Controls.Add(tbxName);
            Controls.Add(label1);
            Controls.Add(dgvPay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditBills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditBills";
            ((System.ComponentModel.ISupportInitialize)dgvPay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPay;
        private Label label1;
        private TextBox tbxName;
        private TextBox tbxPrice;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDate;
        private Button btnCancel;
        private Button btnAdd;
    }
}