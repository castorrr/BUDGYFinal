namespace BUDGY_2._0
{
    partial class EditGoals
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
            btnEdit = new Button();
            btnCancel = new Button();
            tbxPrice = new TextBox();
            tbxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvGoals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGoals).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(540, 429);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(440, 429);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(452, 384);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(182, 27);
            tbxPrice.TabIndex = 11;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(150, 384);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(182, 27);
            tbxName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(393, 383);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 9;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 384);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 8;
            label1.Text = "Goals Name:";
            // 
            // dgvGoals
            // 
            dgvGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoals.Location = new Point(12, 12);
            dgvGoals.Name = "dgvGoals";
            dgvGoals.ReadOnly = true;
            dgvGoals.RowHeadersWidth = 51;
            dgvGoals.RowTemplate.Height = 29;
            dgvGoals.Size = new Size(622, 336);
            dgvGoals.TabIndex = 7;
            dgvGoals.CellClick += dgvGoals_CellClick;
            dgvGoals.CellContentClick += dgvGoals_CellContentClick;
            // 
            // EditGoals
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
            Controls.Add(dgvGoals);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditGoals";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditGoals";
            ((System.ComponentModel.ISupportInitialize)dgvGoals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnCancel;
        private TextBox tbxPrice;
        private TextBox tbxName;
        private Label label2;
        private Label label1;
        private DataGridView dgvGoals;
    }
}