using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uyg03.Models;

namespace uyg03.Forms
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        AppDbContext db = new AppDbContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var student = new Student();
            student.Name = txtName.Text;
            student.Email = txtEmail.Text;
            student.Phone = txtPhone.Text;
            student.Number = txtNumber.Text;
            student.Created = DateTime.Now;
            student.Updated = DateTime.Now;
            db.Students.Add(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetStudentList();

        }
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            GetStudentList();
        }
        void GetStudentList()
        {
            var students = db.Students.ToList();
            dgStudent.Rows.Clear();
            foreach (var student in students)
            {
                dgStudent.Rows.Add(student.Id, student.Number, student.Name, student.Email, student.Phone);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
