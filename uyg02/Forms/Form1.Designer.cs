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
            ((System.ComponentModel.ISupportInitialize)dgCategories).BeginInit();
            SuspendLayout();
            // 
            // dgCategories
            // 
            dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategories.Location = new Point(41, 35);
            dgCategories.Name = "dgCategories";
            dgCategories.RowHeadersWidth = 62;
            dgCategories.RowTemplate.Height = 33;
            dgCategories.Size = new Size(619, 307);
            dgCategories.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgCategories);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgCategories;
    }
}