namespace uyg01
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
            dgProducts = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            btnClean = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtDescription = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.AllowUserToDeleteRows = false;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgProducts.Location = new Point(47, 39);
            dgProducts.Name = "dgProducts";
            dgProducts.ReadOnly = true;
            dgProducts.RowHeadersWidth = 62;
            dgProducts.RowTemplate.Height = 33;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(635, 401);
            dgProducts.TabIndex = 0;
            dgProducts.CellClick += dgProducts_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(722, 41);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "Kayıt No";
            // 
            // txtId
            // 
            txtId.Location = new Point(859, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(68, 31);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(859, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(722, 78);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 3;
            label2.Text = "Adı";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(859, 109);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(722, 115);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Fiyatı";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(732, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 47);
            btnSave.TabIndex = 7;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(916, 271);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 47);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(732, 377);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(362, 47);
            btnClose.TabIndex = 8;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(732, 324);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 47);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(916, 324);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(178, 47);
            btnClean.TabIndex = 10;
            btnClean.Text = "Temizle";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "KN";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Adı";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fiyatı";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Açıklama";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(859, 146);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(235, 93);
            txtDescription.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(722, 152);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 11;
            label4.Text = "Açıklama";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 462);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(btnClean);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgProducts);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProducts;
        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnDelete;
        private Button btnClean;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtDescription;
        private Label label4;
    }
}