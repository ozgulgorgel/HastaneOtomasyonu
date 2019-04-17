using HastaneOtomasyon.BLL;
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
    public partial class Form2 : Form
    {
        HastanelerContext context = new HastanelerContext();
        HastanelerRepository hsRepos = new HastanelerRepository();
        DoktorlarRepository DrRepos = new DoktorlarRepository();
        İllerRepository ilRepos = new İllerRepository();
        İlcelerRepository ilcRepos = new İlcelerRepository();
        KliniklerRepository krRepos = new KliniklerRepository();
        Hastaneler hsn = new Hastaneler();
        Ilceler ilcc = new Ilceler();
        Iller iln = new Iller();
        Klinikler kl = new Klinikler();
        Doktorlar dr = new Doktorlar();


        void hastaneListele()
        {

            //HastanelerContext c = new HastanelerContext();
            var hastanelerList =
            (from aa in context.Illers
             join bb in context.Ilcelers
             on aa.IllerID equals bb.IllerID
             join cc in context.Hastanelers
             on bb.IlcelerID equals cc.IlcelerID
             join dd in context.Kliniklers
              on cc.HastanelerID equals dd.HastanelerID
             select new
             {
                 ID = cc.HastanelerID,
                 HastaneAdi = cc.HastaneAdı,
                 SehirAdı = aa.Il,
                 İlceAdı = bb.Ilce,
                 klinikadı = dd.KlinikAdı
             }).ToList();

            dvgHastaneler.DataSource = hastanelerList;
           
        }
        public Form2()
        {
            InitializeComponent();
        }
        
        public void ComboboxiDoldur()
        {
            cmbIller.DataSource = ilRepos.SelectAll();
            cmbIller.DisplayMember = "Il";
            cmbIller.ValueMember = "IllerID";
        }
     private  void ildoldur()
        {
            cmbdIller.DataSource = ilRepos.SelectAll();
            cmbdIller.DisplayMember = "Il";
            cmbdIller.ValueMember = "IllerID";
        }
    
        void hastaneKlinik()
        {
            comboBox1.DataSource = krRepos.SelectAll();
            comboBox1.DisplayMember = "KlinikAdı";
            comboBox1.ValueMember = "KliniklerID";
        }

        private void KlinikleriListele()
        {
            dgvKlinikler.DataSource = krRepos.SelectAll();
        }
        private void hastaneleriDoldur()
        {
          
        }
        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
          
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            hastaneKlinik();
            ildoldur();
            ComboboxiDoldur();
            KlinikleriListele();
            hastaneListele();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //ComboboxiDoldur();
        
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        void DoktorlarListele()
        {
          var DoktorList=
              (from d in context.Doktorlars
              join k in context.Kliniklers
              on d.KliniklerID equals k.KliniklerID
              join h in context.Hastanelers
              on d.HastanelerID equals h.HastanelerID
              select new
              {
                ID=d.DoktorlarId,
                Ad=d.Adı,
                soyad=d.Soyad,
                telefon=d.Telefon,
                Ünvan=d.Unvan,
                hastaneadı=h.HastaneAdı,
                Klinik=k.KlinikAdı
              }).ToList();
          dvgDoktor.DataSource = DoktorList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hsn.HastaneAdı = txthastane.Text;
            hsn.IllerID = Convert.ToInt32(cmbIller.SelectedValue);
            hsn.IlcelerID = Convert.ToInt32(cmbIlce.SelectedValue);
            hsRepos.Insert(hsn);
            int hID = context.Hastanelers.OrderByDescending(s => s.HastanelerID).FirstOrDefault().HastanelerID;

            krRepos.Insert(new Klinikler
            {
                HastanelerID = hID,
                KlinikAdı=comboBox1.Text
              
            });
            hastaneListele();
            MessageBox.Show("Kayıt işlemi yapılmıştır");
            Tools.Temizle(tbHastane.Controls);

        
            //klinik tablosuna insert etmen lazım

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbKlinikler.SelectedIndex)
            {
                case 0:
                    ComboboxiDoldur();
                    hastaneListele();
                    hastaneKlinik();
                    break;
                case 1:
                    ildoldur();

                    DoktorlarListele();
                    break;
                case 2:
                    KlinikleriListele();
                    break;
            }
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbSehir_SelectionChangeCommitted(object sender, EventArgs e)
        {
    

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                kl.KlinikAdı = txtKlinik.Text;
                krRepos.Insert(kl);
                KlinikleriListele();
                Tools.Temizle(tbKLİNİKLER.Controls);
                MessageBox.Show("klinikler kayıdı gerçekleştirildi");

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void dgvKlinikler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("secili kayıt silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes && dgvKlinikler.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvKlinikler.SelectedRows[0].Cells[0].Value);
                krRepos.Delete(id);
                KlinikleriListele();
                Tools.Temizle(tbKLİNİKLER.Controls);
            }

        }

        private void btnKlinikGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                kl.KlinikAdı = txtKlinik.Text;
                krRepos.Update(kl);
                MessageBox.Show("Kayıt Güncellendi");
                KlinikleriListele();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme işlemi başarısız");
            }
        }

        private void dgvKlinikler_DoubleClick(object sender, EventArgs e)
        {
            if (dgvKlinikler.SelectedRows.Count > 0)
            {
                int id1 = Convert.ToInt32(dgvKlinikler.SelectedRows[0].Cells[0].Value);
                kl = krRepos.SelectById(id1);
                txtKlinik.Text = kl.KlinikAdı;
            }


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                hsn.HastaneAdı = txthastane.Text;
                hsn.IlcelerID = Convert.ToInt32(cmbIlce.SelectedValue);
                hsn.IllerID = Convert.ToInt32(cmbIller.SelectedValue);
                hsRepos.Update(hsn);
                MessageBox.Show("Kayıt Güncellendi");
                hastaneListele();
                Tools.Temizle(tbHastane.Controls);
              
               
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme işlemi başarısız");
            }
        }

        private void tbKlinikler_MouseClick(object sender, MouseEventArgs e)
        {
            
         
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("secili kayıt silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes && dvgHastaneler.SelectedRows.Count > 0)
            {
                int id1 = Convert.ToInt32(dvgHastaneler.SelectedRows[0].Cells[0].Value);
                hsRepos.Delete(id1);
                hastaneListele();
                Tools.Temizle(tbHastane.Controls);
            }
           
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbIller_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbIlce.DataSource =ilcRepos.SelectAll().Where(x => x.IllerID == (int)cmbIller.SelectedValue).ToList();
            cmbIlce.DisplayMember = "Ilce";
            cmbIlce.ValueMember = "IlcelerID";



        }

        private void dvgHastaneler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgHastaneler_DoubleClick(object sender, EventArgs e)
        {
            if (dvgHastaneler.SelectedRows.Count > 0)
            {
                hsn = hsRepos.SelectById(Convert.ToInt32(dvgHastaneler.SelectedRows[0].Cells[0].Value));
                cmbIller.SelectedValue = hsn.IllerID;
                cmbIlce.SelectedValue = hsn.IlcelerID;
                txthastane.Text = hsn.HastaneAdı;
               
            }
          
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbdIlce_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbHastane.DataSource = hsRepos.SelectAll().Where(h => h.IlcelerID == (int)cmbddILCE.SelectedValue).ToList();
            cmbHastane.DisplayMember = "HastaneAdı";
            cmbHastane.ValueMember = "HastanelerID";
        }

        private void cmbdIlce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbdIller_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cmbddILCE.DataSource = ilcRepos.SelectAll().Where(x => x.IllerID ==(int) cmbdIller.SelectedValue).ToList();
            cmbddILCE.DisplayMember = "Ilce";
            cmbddILCE.ValueMember = "IlcelerID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dr.Adı = txtDrAd.Text;
            dr.Soyad = txtDrSoyad.Text;
            dr.Unvan = txtDrUnvan.Text;
            dr.Telefon = mskText.Text;
            dr.KliniklerID =(int) cmbdKlinik.SelectedValue;
            dr.HastanelerID = (int)cmbHastane.SelectedValue;
            
            DrRepos.Insert(dr);
            DoktorlarListele();
            Tools.Temizle(tbDoktorlar.Controls);
            mskText.Text = "";
            MessageBox.Show("ekleme işlemi başarıyla gerçekleşmiştir");

           
        }

        private void cmbdKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             DialogResult sonuc = MessageBox.Show("secili kayıt silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (sonuc == DialogResult.Yes && dvgHastaneler.SelectedRows.Count > 0)
             {
                 int id3 = Convert.ToInt32(dvgDoktor.SelectedRows[0].Cells[0].Value);
                 DrRepos.Delete(id3);
                 DoktorlarListele();
                 mskText.Text = "";

                 Tools.Temizle(tbDoktorlar.Controls);
                 MessageBox.Show("Silme işlemi başarıyla gerçekleşmiştir");
             }
        }

        private void txtKlinik_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbHastane_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbdKlinik.Items.Clear();
            cmbdKlinik.Text = "";
            cmbdKlinik.DataSource = krRepos.SelectAll().Where(kk => kk.HastanelerID == (int)cmbHastane.SelectedValue).ToList();
            cmbdKlinik.DisplayMember = "KlinikAdı";
            cmbdKlinik.ValueMember = "KliniklerID";

        
        }

        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
