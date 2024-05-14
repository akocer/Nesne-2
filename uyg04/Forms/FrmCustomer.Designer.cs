namespace uyg04.Forms
{
    partial class FrmCustomer
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
            txtPhone = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            dgCustomer = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(883, 216);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(203, 31);
            txtPhone.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(762, 225);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 63;
            label6.Text = "Telefon";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(883, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 31);
            txtEmail.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(762, 188);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 61;
            label4.Text = "E-Posta";
            // 
            // txtName
            // 
            txtName.Location = new Point(883, 142);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 31);
            txtName.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(762, 151);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 59;
            label5.Text = "Adı Soyadı";
            // 
            // txtId
            // 
            txtId.Location = new Point(883, 95);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 31);
            txtId.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(762, 104);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 55;
            label2.Text = "Kayıt No";
            // 
            // dgCustomer
            // 
            dgCustomer.AllowUserToAddRows = false;
            dgCustomer.AllowUserToDeleteRows = false;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column5 });
            dgCustomer.Location = new Point(25, 68);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dgCustomer.RowHeadersWidth = 62;
            dgCustomer.RowTemplate.Height = 33;
            dgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomer.Size = new Size(697, 412);
            dgCustomer.TabIndex = 54;
            dgCustomer.CellClick += dgCustomer_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefon";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(941, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 46);
            btnClear.TabIndex = 52;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.HotTrack;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(787, 318);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 46);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(941, 266);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 46);
            btnUpdate.TabIndex = 50;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(787, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 46);
            btnSave.TabIndex = 51;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 629);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dgCustomer);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            Load += FrmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhone;
        private Label label6;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtName;
        private Label label5;
        private TextBox txtId;
        private Label label2;
        private DataGridView dgCustomer;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column5;
    }
}