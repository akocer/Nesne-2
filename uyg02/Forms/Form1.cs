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
            CategoryList();
        }

        void CategoryList()
        {
            var categories = db.Categories.ToList();

            foreach (var category in categories)
            {
                dgCategories.Rows.Add(category.Id, category.Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Kategori Adý Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Categories.Count(c => c.Name == txtName.Text) > 0)
            {
                MessageBox.Show("Girilen Kategori Adý Kayýtlýdýr!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var category = new Category();
            category.Name = txtName.Text;
            db.Categories.Add(category);
            db.SaveChanges();
            CategoryList();
            MessageBox.Show("Kategori Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}