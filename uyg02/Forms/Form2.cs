using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uyg02.Models;

namespace uyg02.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void Form2_Load(object sender, EventArgs e)
        {

            GetCategoryList();
        }

        void GetCategoryList()
        {
            var categories = db.Categories.ToList();

            cbCategories.ValueMember = "Id";
            cbCategories.DisplayMember = "Name";
            cbCategories.DataSource = categories;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = new Product();
            product.Name = txtName.Text;
            product.Price = Convert.ToDouble(txtPrice.Text);
            product.CategoryId = Convert.ToInt32(cbCategories.SelectedValue);

            db.Products.Add(product);
            db.SaveChanges();

            MessageBox.Show("Ürün Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
