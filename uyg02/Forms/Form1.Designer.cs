namespace uyg02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgCategories = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            cbCategories = new ComboBox();
            label3 = new Label();
            dgProducts = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnList = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // dgCategories
            // 
            dgCategories.AllowUserToAddRows = false;
            dgCategories.AllowUserToDeleteRows = false;
            dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategories.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgCategories.Location = new Point(45, 35);
            dgCategories.Name = "dgCategories";
            dgCategories.ReadOnly = true;
            dgCategories.RowHeadersWidth = 62;
            dgCategories.RowTemplate.Height = 33;
            dgCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCategories.Size = new Size(361, 290);
            dgCategories.TabIndex = 0;
            dgCategories.CellClick += dgCategories_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Adı";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 356);
            label1.Name = "label1";
            label1.Size = new Size(29, 25);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 350);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(98, 31);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 387);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 31);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 393);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 3;
            label2.Text = "Adı";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(109, 433);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(263, 433);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 34);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(263, 473);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 34);
            btnClear.TabIndex = 6;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(109, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(652, 27);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(182, 33);
            cbCategories.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 35);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 9;
            label3.Text = "Kategori Seçiniz";
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.AllowUserToDeleteRows = false;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Column3 });
            dgProducts.Location = new Point(487, 75);
            dgProducts.Name = "dgProducts";
            dgProducts.ReadOnly = true;
            dgProducts.RowHeadersWidth = 62;
            dgProducts.RowTemplate.Height = 33;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(583, 250);
            dgProducts.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Adı";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fiyatı";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // btnList
            // 
            btnList.Location = new Point(840, 27);
            btnList.Name = "btnList";
            btnList.Size = new Size(146, 34);
            btnList.TabIndex = 11;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 597);
            Controls.Add(btnList);
            Controls.Add(dgProducts);
            Controls.Add(label3);
            Controls.Add(cbCategories);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgCategories);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCategories;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private ComboBox cbCategories;
        private Label label3;
        private DataGridView dgProducts;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnList;
    }
}