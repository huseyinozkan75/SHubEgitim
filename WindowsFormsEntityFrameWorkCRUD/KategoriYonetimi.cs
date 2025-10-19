using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsEntityFrameWorkCRUD
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }

        DatabaseContext context = new DatabaseContext();    // veritabanı tablolarmızı temsil eden sınıfımızdan bir nesne türettik.
        // entity framework ile veritabanı işlemlerimizi bu nesne üzerinden yapacağız.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez");
                return;
            }

            var kategori = new Category
            {
                CreateDate = DateTime.Now,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
                Name = txtKategoriAdi.Text
            };

            context.Categories.Add(kategori);

            var sonuc = context.SaveChanges();  // context.SaveChanges() metodu, context üzerinde yapılan değişiklikleri
                                                // sql veritabanına kaydeder ve etkilenen kayıt sayısını
                                                // int olarak döner.

            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        void Yukle()
        {
            dgvKategoriler.DataSource = context.Categories.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = "";
            txtAciklama.Text = string.Empty;
            cbDurum.Checked = false;
        }

        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells["Name"].Value.ToString();
            txtAciklama.Text = dgvKategoriler.CurrentRow.Cells["Description"].Value.ToString();
            cbDurum.Checked = (bool)dgvKategoriler.CurrentRow.Cells["IsActive"].Value;
            */

            var id = (int)dgvKategoriler.CurrentRow.Cells["Id"].Value;
            var kayit = context.Categories.Find(id); // Find metodu ile birincil anahtar üzerinden
                                                     // kayıt bulma işlemi yapıyoruz.
            
            txtKategoriAdi.Text = kayit.Name;
            txtAciklama.Text = kayit.Description;
            cbDurum.Checked = kayit.IsActive;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez");
                return;
            }

            var id = (int)dgvKategoriler.CurrentRow.Cells["Id"].Value;
            var kayit = context.Categories.Find(id); // Find metodu ile veritabanından güncellenecek kaydı
                                                     // getiriyoruz.

            kayit.Name = txtKategoriAdi.Text;        // Kaydın bilgilerini güncelle.
            kayit.Description = txtAciklama.Text;
            kayit.IsActive = cbDurum.Checked;

            var sonuc = context.SaveChanges();  // değişiklikleri veritabanına kaydet.
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Silme Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Silme Başarısız");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = (int) dgvKategoriler.CurrentRow.Cells["Id"].Value;
            var kayit = context.Categories.Find(id); // Find metodu ile veritabanından
                                                     // silinecek kaydı getiriyoruz.                                                    // getiriyoruz.

            context.Categories.Remove(kayit);        // EF Remove ile silinecek kaydı işaretler.

            var sonuc = context.SaveChanges();       // değişiklikleri veritabanına kaydet.
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }

        }
    }
}
