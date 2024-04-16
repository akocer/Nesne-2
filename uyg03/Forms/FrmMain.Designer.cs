namespace uyg03
{
    partial class FrmMain
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
            panel1 = new Panel();
            btnExit = new Button();
            btnRegister = new Button();
            btnLesson = new Button();
            btnStudent = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLesson);
            panel1.Controls.Add(btnStudent);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 944);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.DeepSkyBlue;
            btnExit.Location = new Point(7, 474);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(283, 65);
            btnExit.TabIndex = 2;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.DeepSkyBlue;
            btnRegister.Location = new Point(7, 314);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(283, 65);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Kayıt";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLesson
            // 
            btnLesson.FlatStyle = FlatStyle.Flat;
            btnLesson.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnLesson.ForeColor = Color.DeepSkyBlue;
            btnLesson.Location = new Point(7, 233);
            btnLesson.Name = "btnLesson";
            btnLesson.Size = new Size(283, 65);
            btnLesson.TabIndex = 2;
            btnLesson.Text = "Dersler";
            btnLesson.UseVisualStyleBackColor = true;
            btnLesson.Click += btnLesson_Click;
            // 
            // btnStudent
            // 
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.ForeColor = Color.DeepSkyBlue;
            btnStudent.Location = new Point(7, 153);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(283, 65);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "Öğrenciler";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(296, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1443, 108);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(468, 54);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Takip Programı";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DeepSkyBlue;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(296, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(1443, 836);
            panel3.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 944);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnStudent;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnExit;
        private Button btnRegister;
        private Button btnLesson;
    }
}