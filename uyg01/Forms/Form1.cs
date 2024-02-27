using uyg01.Models;

namespace uyg01
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
            GetProductList();
        }

        void GetProductList()
        {
            dgProducts.Rows.Clear();
            var products = db.Products.ToList();
            foreach (var product in products)
            {
                dgProducts.Rows.Add(product.Id, product.Name, product.Price);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Tüm Alanlarý Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = new Product()
            {
                Name = txtName.Text,
                Price = Convert.ToDouble(txtPrice.Text)

            };
            db.Products.Add(product);
            db.SaveChanges();
            GetProductList();
            MessageBox.Show("Kayýt Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}