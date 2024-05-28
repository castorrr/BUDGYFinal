namespace BUDGY_2._0
{
    partial class EditExpenses
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
            dgvExpenses = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbxName = new TextBox();
            tbxPrice = new TextBox();
            btnCancel = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // dgvExpenses
            // 
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(12, 12);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.RowTemplate.Height = 29;
            dgvExpenses.Size = new Size(622, 336);
            dgvExpenses.TabIndex = 0;
            dgvExpenses.CellClick += dgvExpenses_CellClick;
            dgvExpenses.CellContentClick += dgvExpenses_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 384);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 1;
            label1.Text = "Expense Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(393, 383);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(150, 384);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(182, 27);
            tbxName.TabIndex = 3;
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(452, 384);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(182, 27);
            tbxPrice.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(440, 429);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(540, 429);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(646, 481);
            Controls.Add(btnEdit);
            Controls.Add(btnCancel);
            Controls.Add(tbxPrice);
            Controls.Add(tbxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvExpenses);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditExpenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditExpenses";
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvExpenses;
        private Label label1;
        private Label label2;
        private TextBox tbxName;
        private TextBox tbxPrice;
        private Button btnCancel;
        private Button btnEdit;
    }
}