using uyg02.Models;

namespace uyg02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgCategories.DataSource = db.Categories.ToList();
        }
    }
}