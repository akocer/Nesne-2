namespace uyg04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            btnWork = new ToolStripButton();
            btnCustomer = new ToolStripButton();
            btnPayment = new ToolStripButton();
            btnExit = new ToolStripButton();
            label1 = new Label();
            lbTitle = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 221);
            panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(64, 64);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnWork, btnCustomer, btnPayment, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1173, 73);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnWork
            // 
            btnWork.ForeColor = SystemColors.HotTrack;
            btnWork.Image = (Image)resources.GetObject("btnWork.Image");
            btnWork.ImageTransparentColor = Color.Magenta;
            btnWork.Name = "btnWork";
            btnWork.Size = new Size(138, 68);
            btnWork.Text = "İş Takip";
            btnWork.Click += btnWork_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.ForeColor = SystemColors.HotTrack;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageTransparentColor = Color.Magenta;
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(158, 68);
            btnCustomer.Text = "Müşteriler";
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnPayment
            // 
            btnPayment.ForeColor = SystemColors.HotTrack;
            btnPayment.Image = (Image)resources.GetObject("btnPayment.Image");
            btnPayment.ImageTransparentColor = Color.Magenta;
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(160, 68);
            btnPayment.Text = "Ödeme Al";
            btnPayment.Click += btnPayment_Click;
            // 
            // btnExit
            // 
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 68);
            btnExit.Text = "Çıkış";
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 96);
            label1.Name = "label1";
            label1.Size = new Size(344, 48);
            label1.TabIndex = 0;
            label1.Text = "İş Takip Modülü";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(29, 158);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(145, 34);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Alt Başlık";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(1173, 397);
            panel2.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 618);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbTitle;
        private ToolStrip toolStrip1;
        private ToolStripButton btnWork;
        private ToolStripButton btnCustomer;
        private ToolStripButton btnPayment;
        private ToolStripButton btnExit;
        private Label label1;
    }
}