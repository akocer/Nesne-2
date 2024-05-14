using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uyg04.Models;

namespace uyg04.Forms
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        AppDbContext db = new AppDbContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Customers.Count(c => c.Phone == txtPhone.Text) > 0)
            {
                MessageBox.Show("Girilen Telefon Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var customer = new Customer();
            customer.Name = txtName.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;

            customer.CreateDate = DateTime.Now;
            customer.UpdateDate = DateTime.Now;
            db.Customers.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Müşteri Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCustomerList();
            btnClear.PerformClick();

        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            GetCustomerList();
        }
        void GetCustomerList()
        {
            var customers = db.Customers.ToList();
            dgCustomer.Rows.Clear();
            foreach (var customer in customers)
            {
                dgCustomer.Rows.Add(customer.Id, customer.Name, customer.Email, customer.Phone);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgCustomer.CurrentRow.Cells[0].Value.ToString();

            txtName.Text = dgCustomer.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgCustomer.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgCustomer.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var customer = db.Customers.Where(s => s.Id == id).SingleOrDefault();
            if (customer == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            customer.Name = txtName.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;

            customer.UpdateDate = DateTime.Now;
            db.Customers.Update(customer);
            db.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCustomerList();
            btnClear.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var customer = db.Customers.Where(s => s.Id == id).SingleOrDefault();
            if (customer == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Customers.Remove(customer);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCustomerList();
            btnClear.PerformClick();
        }
    }
}

