namespace uyg04.Forms
{
    partial class FrmWork
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
            dtDate = new DateTimePicker();
            label2 = new Label();
            txtCustomerId = new TextBox();
            txtTitle = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPaid = new TextBox();
            label8 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            txtName = new TextBox();
            label9 = new Label();
            txtPhone = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 0;
            label1.Text = "Tarih";
            // 
            // dtDate
            // 
            dtDate.Location = new Point(148, 37);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(300, 31);
            dtDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 86);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 2;
            label2.Text = "Müşteri No";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(148, 80);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(122, 31);
            txtCustomerId.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(148, 229);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(300, 31);
            txtTitle.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 235);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 4;
            label3.Text = "Başlık";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(148, 266);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 105);
            txtDescription.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 272);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 6;
            label4.Text = "Açıklama";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(148, 377);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(122, 31);
            txtPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 383);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 8;
            label5.Text = "Ücreti";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 383);
            label6.Name = "label6";
            label6.Size = new Size(29, 25);
            label6.TabIndex = 10;
            label6.Text = "TL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 483);
            label7.Name = "label7";
            label7.Size = new Size(29, 25);
            label7.TabIndex = 13;
            label7.Text = "TL";
            // 
            // txtPaid
            // 
            txtPaid.Location = new Point(148, 477);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(122, 31);
            txtPaid.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 483);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 11;
            label8.Text = "Ödeme";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(148, 553);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 50);
            btnSave.TabIndex = 14;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(298, 553);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 50);
            btnClear.TabIndex = 14;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.HotTrack;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(298, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 39);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Gözat";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 31);
            txtName.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 128);
            label9.Name = "label9";
            label9.Size = new Size(98, 25);
            label9.TabIndex = 16;
            label9.Text = "Adı Soyadı";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(148, 159);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 31);
            txtPhone.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 165);
            label10.Name = "label10";
            label10.Size = new Size(68, 25);
            label10.TabIndex = 18;
            label10.Text = "Telefon";
            // 
            // FrmWork
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1232, 646);
            Controls.Add(txtPhone);
            Controls.Add(label10);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(txtPaid);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(txtCustomerId);
            Controls.Add(label2);
            Controls.Add(dtDate);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmWork";
            Text = "FrmWork";
            WindowState = FormWindowState.Maximized;
            Load += FrmWork_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtDate;
        private Label label2;
        private TextBox txtCustomerId;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPaid;
        private Label label8;
        private Button btnSave;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtName;
        private Label label9;
        private TextBox txtPhone;
        private Label label10;
    }
}