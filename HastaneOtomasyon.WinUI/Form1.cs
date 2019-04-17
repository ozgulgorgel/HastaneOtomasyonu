using HastaneOtomasyon.BLL.Repositories;
using HastaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.WinUI
{
    public partial class Form1 : Form
    {
        AdminRepository ar = new AdminRepository();
        HastanelerContext context = new HastanelerContext();
        Customer c = new Customer();
        CustomerRepository cu = new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c =context.Customers.Where(x => x.Username == textBox1.Text && x.Password == textBox2.Text).SingleOrDefault();
            if (c == null) //Müsteri bulunmadıysa , messagebox ile bilgilendiyoruz.
            {
                MessageBox.Show("Customer not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (c != null) //Müşteri bulduysa
            {
                Form2 ts = new Form2(); //Müşteri giris formundan nesne olusturuyoruz.
                ts.Show(); //formu acıyoruz
                this.Hide(); //giriş formu kapatıyoruz
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Kullanıcı adı giriniz");
                return;
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Şifre giriniz");
                return;
            }
            if (string.IsNullOrEmpty(txtmail.Text))
            {
                MessageBox.Show("Mail giriniz");
                return;
            }
         
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Adınızı giriniz");
                return;
            }
            if (string.IsNullOrEmpty(txtsurname.Text))
            {
                MessageBox.Show("Soyadınızı giriniz");
                return;
            }
          
            if (string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Telefon numaranızı giriniz");
                return;
            }
            if (string.IsNullOrEmpty(rchtxtaddress.Text))
            {
                MessageBox.Show("Adresi giriniz");
                return;
            }

            //DateTime bTarih = Convert.ToDateTime(DateTime.Now.Year);
            //DateTime kTarih = Convert.ToDateTime(dateTimePicker1.Value.Year);
            //TimeSpan Sonuc = bTarih - kTarih;


            c.Username = txtusername.Text;
            c.Surname = txtsurname.Text;
            c.Password = txtpassword.Text;
            c.Mail = txtmail.Text;
            c.Name = txtname.Text;
            c.Phone = txtphone.Text;
            //c.Birthdate = Convert.ToDateTime(dateTimePicker1.Value);
            c.Address = rchtxtaddress.Text;
         

            context.Customers.Add(c);
            context.SaveChanges();
            MessageBox.Show("ekleme yapılmışır");

        }
    }
}
