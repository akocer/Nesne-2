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
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void FrmPayment_Load(object sender, EventArgs e)
        {
            GetCustomerList("");
        }
        void GetCustomerList(string searchText)
        {
            var customers = db.Customers.Where(s => s.Name.Contains(searchText) || s.Email.Contains(searchText) || s.Phone.Contains(searchText)).ToList();
            dgCustomer.Rows.Clear();
            foreach (var customer in customers)
            {
                dgCustomer.Rows.Add(customer.Id, customer.Name, customer.Email, customer.Phone);
            }

        }
        void GetWorkList(int customerId)
        {
            var works = db.Works.Where(s => s.CustomerId == customerId).ToList();
            dgWork.Rows.Clear();
            foreach (var work in works)
            {
                dgWork.Rows.Add(work.Id, work.Name, work.CreateDate.ToShortDateString(), work.Price);
            }
            Calculate();
        }
        void GetPaymentList(int customerId)
        {
            var payments = db.Payments.Where(s => s.CustomerId == customerId).ToList();
            dgPayment.Rows.Clear();
            foreach (var payment in payments)
            {
                dgPayment.Rows.Add(payment.Id, payment.CreateDate.ToShortDateString(), payment.Paid);
            }
            Calculate();
        }
        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int customerId = Convert.ToInt32(dgCustomer.CurrentRow.Cells[0].Value.ToString());
            GetWorkList(customerId);
            GetPaymentList(customerId);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetCustomerList(txtSearch.Text);
        }

        void Calculate()
        {
            double prices = 0;
            for (int i = 0; i < dgWork.Rows.Count; i++)
            {
                prices += Convert.ToDouble(dgWork.Rows[i].Cells[3].Value.ToString());
            }
            lbWork.Text = prices.ToString("0.00 TL");

            double paids = 0;
            for (int i = 0; i < dgPayment.Rows.Count; i++)
            {
                paids += Convert.ToDouble(dgPayment.Rows[i].Cells[2].Value.ToString());
            }
            lbPayment.Text = paids.ToString("0.00 TL");

            double diff = paids - prices;
            lbDiff.Text = diff.ToString("0.00 TL");
            if (diff < 0)
            {
                lbDiff.ForeColor = Color.Red;
            }
            else
            {
                lbDiff.ForeColor = Color.Green;
            }
        }
    }
}
