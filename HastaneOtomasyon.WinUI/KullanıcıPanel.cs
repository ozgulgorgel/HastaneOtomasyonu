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
    public partial class KullanıcıPanel : Form
    { 
        HastanelerContext context = new HastanelerContext();
        HastanelerRepository hsRepos = new HastanelerRepository();
        İllerRepository ilRepos = new İllerRepository();
        İlcelerRepository ilcRepos = new İlcelerRepository();
        KliniklerRepository krRepos = new KliniklerRepository();
        DoktorlarRepository DrRepos = new DoktorlarRepository();
        RandevularRepository ranRepos = new RandevularRepository();
        Hastaneler hsn = new Hastaneler();
        Ilceler ilcc = new Ilceler();
        Iller iln = new Iller();
        Doktorlar dr = new Doktorlar();
        Randevular rand = new Randevular();

        public KullanıcıPanel()
        {
            InitializeComponent();
        }
       void randevulistelet()
        {
            var deger =
                (from hg in context.Hastanelers
                 join q in context.Randevulars
                 on hg.HastanelerID equals q.HastanelerID
                 join w in context.Doktorlars
                 on q.DoktorlarId equals w.DoktorlarId
                 join v in context.Kliniklers
                 on q.KliniklerID equals v.KliniklerID
                 select new
                 {
                     hastaneadı = hg.HastaneAdı,
                     klinik = v.KlinikAdı,
                     doktor = w.Adı,

                 }).ToList();
                dataGridView1.DataSource = deger;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rand.HastanelerID = Convert.ToInt32(cmbKhast.SelectedValue);
            rand.KliniklerID = Convert.ToInt32(cmbKklinik.SelectedValue);
            rand.DoktorlarId = Convert.ToInt32(cmbKdoktor.SelectedValue);
            ranRepos.Insert(rand);
            MessageBox.Show("randevu alınmıştır");
            tabControl1.SelectedTab = tabPage2;   
        }
        void sehirDoldur()
        {
            cmbKSehir.Text = "";
            cmbKSehir.DataSource = ilRepos.SelectAll();
            cmbKSehir.DisplayMember = "Il";
            cmbKSehir.ValueMember = "IllerID";
        }

        private void cmbKSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void KullanıcıPanel_Load(object sender, EventArgs e)
        {
            sehirDoldur();
            randevulistelet();
        }

        private void cmbKSehir_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbKilce.Text = "";
            cmbKilce.DataSource = ilcRepos.SelectAll().Where(a => a.IllerID == (int)cmbKSehir.SelectedValue).ToList();
            cmbKilce.DisplayMember = "Ilce";
            cmbKilce.ValueMember = "IlcelerID";

        }

        private void cmbKilce_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void cmbKilce_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbKilce.Text = "";
            cmbKhast.DataSource = hsRepos.SelectAll().Where(hss => hss.IlcelerID == (int)cmbKilce.SelectedValue).ToList();
            cmbKhast.DisplayMember = "HastaneAdı";
            cmbKhast.ValueMember = "HastanelerID";
        }

        private void cmbKhast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKhast_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbKklinik.DataSource = krRepos.SelectAll().Where(p => p.HastanelerID == (int)cmbKhast.SelectedValue).ToList();
            cmbKklinik.DisplayMember = "KlinikAdı";
            cmbKklinik.ValueMember = "KliniklerID";
        }

        private void cmbKklinik_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbKdoktor.DataSource = DrRepos.SelectAll().Where(c => c.KliniklerID == (int)cmbKklinik.SelectedValue).ToList();
            cmbKdoktor.DisplayMember = "Adı";
            cmbKdoktor.ValueMember = "DoktorlarId";

        }

        private void cmbKklinik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
