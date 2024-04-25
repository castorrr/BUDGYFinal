namespace BUDGY_2._0
{
    partial class Bills
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvPay = new DataGridView();
            label4 = new Label();
            dgvPaid = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnPay = new Button();
            pnlBills = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPaid).BeginInit();
            pnlBills.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(356, 240);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(8, 15);
            label2.Name = "label2";
            label2.Size = new Size(109, 38);
            label2.TabIndex = 2;
            label2.Text = "To Pay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(106, 46);
            label3.TabIndex = 3;
            label3.Text = "BILLS";
            // 
            // dgvPay
            // 
            dgvPay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPay.Location = new Point(13, 56);
            dgvPay.Name = "dgvPay";
            dgvPay.RowHeadersWidth = 51;
            dgvPay.RowTemplate.Height = 29;
            dgvPay.Size = new Size(406, 249);
            dgvPay.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(457, 15);
            label4.Name = "label4";
            label4.Size = new Size(81, 38);
            label4.TabIndex = 5;
            label4.Text = "Paid:";
            // 
            // dgvPaid
            // 
            dgvPaid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaid.Location = new Point(454, 56);
            dgvPaid.Name = "dgvPaid";
            dgvPaid.RowHeadersWidth = 51;
            dgvPaid.RowTemplate.Height = 29;
            dgvPaid.Size = new Size(306, 249);
            dgvPaid.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 460);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(133, 460);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(233, 460);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(333, 460);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 29);
            btnPay.TabIndex = 10;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // pnlBills
            // 
            pnlBills.BackColor = Color.FromArgb(24, 30, 54);
            pnlBills.Controls.Add(dgvPay);
            pnlBills.Controls.Add(label2);
            pnlBills.Controls.Add(label4);
            pnlBills.Controls.Add(dgvPaid);
            pnlBills.Location = new Point(12, 108);
            pnlBills.Name = "pnlBills";
            pnlBills.Size = new Size(780, 332);
            pnlBills.TabIndex = 11;
            // 
            // Bills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 48, 72);
            Controls.Add(pnlBills);
            Controls.Add(btnPay);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Bills";
            Size = new Size(801, 636);
            ((System.ComponentModel.ISupportInitialize)dgvPay).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPaid).EndInit();
            pnlBills.ResumeLayout(false);
            pnlBills.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvPay;
        private Label label4;
        private DataGridView dgvPaid;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnPay;
        private Panel pnlBills;
    }
}
