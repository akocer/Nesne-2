using uyg04.Forms;

namespace uyg04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmWork());
            lbTitle.Text = "Ýþ Kayýt";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCustomer());
            lbTitle.Text = "Müþteriler";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPayment());
            lbTitle.Text = "Ödemeler";
        }

        void OpenForm(Form f)
        {
            panel2.Controls.Clear();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.WindowState = FormWindowState.Maximized;
            f.BackColor = SystemColors.ActiveCaption;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ForeColor = SystemColors.HotTrack;
            f.Show();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenForm(new FrmWork());
            lbTitle.Text = "Ýþ Kayýt";
        }
    }
}