namespace uyg03.Forms
{
    partial class FrmLesson
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
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dgLesson = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtCredit = new TextBox();
            label7 = new Label();
            txtName = new TextBox();
            label8 = new Label();
            txtCode = new TextBox();
            label9 = new Label();
            txtId = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgLesson).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(158, 54);
            label1.TabIndex = 1;
            label1.Text = "Dersler";
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(949, 341);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 34);
            btnClear.TabIndex = 42;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(795, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 34);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(949, 301);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 34);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(795, 301);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 34);
            btnSave.TabIndex = 41;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgLesson
            // 
            dgLesson.AllowUserToAddRows = false;
            dgLesson.AllowUserToDeleteRows = false;
            dgLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLesson.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgLesson.Location = new Point(46, 86);
            dgLesson.Name = "dgLesson";
            dgLesson.ReadOnly = true;
            dgLesson.RowHeadersWidth = 62;
            dgLesson.RowTemplate.Height = 33;
            dgLesson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLesson.Size = new Size(697, 412);
            dgLesson.TabIndex = 44;
            dgLesson.CellClick += dgLesson_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ders Kodu";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ders Adı";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kredi";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(920, 212);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(203, 31);
            txtCredit.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(799, 221);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 51;
            label7.Text = "Kredi";
            // 
            // txtName
            // 
            txtName.Location = new Point(920, 175);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 31);
            txtName.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(799, 184);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 49;
            label8.Text = "Ders Adı";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(920, 138);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(203, 31);
            txtCode.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(799, 147);
            label9.Name = "label9";
            label9.Size = new Size(100, 25);
            label9.TabIndex = 47;
            label9.Text = "Ders Kodu";
            // 
            // txtId
            // 
            txtId.Location = new Point(920, 101);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 31);
            txtId.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(799, 110);
            label10.Name = "label10";
            label10.Size = new Size(86, 25);
            label10.TabIndex = 45;
            label10.Text = "Kayıt No";
            // 
            // FrmLesson
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1351, 544);
            Controls.Add(txtCredit);
            Controls.Add(label7);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(txtCode);
            Controls.Add(label9);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(dgLesson);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Peru;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLesson";
            Text = "FrmLesson";
            Load += FrmLesson_Load;
            ((System.ComponentModel.ISupportInitialize)dgLesson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtEmail;
        private Label label4;

        private Label label5;
        private TextBox txtNumber;
        private Label label3;

        private Label label2;
        private DataGridView dgStudent;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dgLesson;
        private TextBox txtCredit;
        private Label label7;
        private TextBox txtName;
        private Label label8;
        private TextBox txtCode;
        private Label label9;
        private TextBox txtId;
        private Label label10;
    }
}