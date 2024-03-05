using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
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
                dgProducts.Rows.Add(product.Id, product.Name, product.Price, product.Description);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Tüm Alanlarý Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Products.Count(c => c.Name == txtName.Text) > 0)
            {
                MessageBox.Show("Girilen Ürün Adý Kayýtlýdýr!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var product = new Product()
            {
                Name = txtName.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Description = txtDescription.Text

            };
            db.Products.Add(product);
            db.SaveChanges();
            GetProductList();
            MessageBox.Show("Kayýt Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClean.PerformClick();
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgProducts.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgProducts.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgProducts.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Kayýt Seçiniz ve Tüm Alanlarý Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var price = Convert.ToDouble(txtPrice.Text);
            var product = db.Products.Where(s => s.Id == id).SingleOrDefault();

            product.Name = txtName.Text;
            product.Price = price;
            product.Description = txtDescription.Text;

            db.Products.Update(product);
            db.SaveChanges();
            GetProductList();
            MessageBox.Show("Kayýt Düzenlendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClean.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Kayýt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Kayýt Silinecek Onaylýyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var product = db.Products.Where(s => s.Id == id).SingleOrDefault();


            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                GetProductList();
                MessageBox.Show("Kayýt Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnClean.PerformClick();

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}