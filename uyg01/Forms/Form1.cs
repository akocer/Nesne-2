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
                dgProducts.Rows.Add(product.Id, product.Name, product.Price);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("T�m Alanlar� Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Products.Count(c => c.Name == txtName.Text) > 0)
            {
                MessageBox.Show("Girilen �r�n Ad� Kay�tl�d�r!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show("Kay�t Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgProducts.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgProducts.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgProducts.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Kay�t Se�iniz ve T�m Alanlar� Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var price = Convert.ToDouble(txtPrice.Text);
            var product = db.Products.Where(s => s.Id == id).SingleOrDefault();

            product.Name = txtName.Text;
            product.Price = price;

            db.Products.Update(product);
            db.SaveChanges();
            GetProductList();
            MessageBox.Show("Kay�t D�zenlendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Kay�t Se�iniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Kay�t Silinecek Onayl�yor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var product = db.Products.Where(s => s.Id == id).SingleOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();
            GetProductList();
            MessageBox.Show("Kay�t Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}