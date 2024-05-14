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
    public partial class FrmWork : Form
    {
        public FrmWork()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void FrmWork_Load(object sender, EventArgs e)
        {
            GetCustomerList();
            dgCustomer.Visible = false;
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
        private void btnSearch_Click(object sender, EventArgs e)
        {

            dgCustomer.Visible = true;
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerId.Text = dgCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgCustomer.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = dgCustomer.CurrentRow.Cells[3].Value.ToString();

            dgCustomer.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "" || txtTitle.Text == "" || txtDescription.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Work work = new Work();
            work.Name = txtTitle.Text;
            work.Description = txtDescription.Text;
            work.Price = Convert.ToDouble(txtPrice.Text);
            work.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            work.CreateDate = dtDate.Value;
            work.UpdateDate = dtDate.Value;
            db.Works.Add(work);
            db.SaveChanges();

            if (txtPaid.Text != "")
            {
                Payment payment = new Payment();

                payment.CustomerId = Convert.ToInt32(txtCustomerId.Text);
                payment.Paid = Convert.ToDouble(txtPaid.Text);
                payment.CreateDate = dtDate.Value;
                payment.UpdateDate = dtDate.Value;
                db.Payments.Add(payment);
                db.SaveChanges();
            }

            MessageBox.Show("İş Kaydı Yapılmıştır", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }

            }
        }
    }
}
