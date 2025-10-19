using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEntityFrameWorkCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseContext context = new DatabaseContext();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                 string.IsNullOrWhiteSpace(txtSifre.Text) )
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez");
                return;
            }

            var user = context.Users.FirstOrDefault(u => u.IsActive && u.Name == txtKullaniciAdi.Text && u.Password == txtSifre.Text);

            if (user != null)
            {
                groupBox1.Visible = false;
                menuStrip1.Visible = true;
            }
            else 
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi();
            kategoriYonetimi.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            urunYonetimi.ShowDialog();
        }

        private void kuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            menuStrip1.Visible = false;
        }
    }
}
