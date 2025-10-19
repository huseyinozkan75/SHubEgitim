using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsEntityFrameWorkCRUD
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }

        DatabaseContext context = new DatabaseContext();    // veritabanı tablolarmızı temsil eden sınıfımızdan bir nesne türettik.
                                                            // entity framework ile veritabanı işlemlerimizi bu nesne üzerinden yapacağız.

        void Yukle()
        {
            dgvKullanicilar.DataSource = context.Users.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKullaniciAdi.Text = "";
            txtKullaniciSoyadi.Text = "";
            txtEposta.Text = "";
            txtSifre.Text = "";
            cbDurum.Checked = false;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciSoyadi.Text) ||
                string.IsNullOrWhiteSpace(txtEposta.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
                return;
            }

            int id = (int)dgvKullanicilar.CurrentRow.Cells["Id"].Value;
            var user = context.Users.Find(id);

            user.Name = txtKullaniciAdi.Text;
            user.SurName = txtKullaniciSoyadi.Text;
            user.Email = txtEposta.Text;
            user.IsActive = cbDurum.Checked;
            user.Password = txtSifre.Text;


            try
            {
                var sonuc = context.SaveChanges();

                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Güncelleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Kayıt Güncelleme Başarısız");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Hata Oluştu: " + exp.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
             string.IsNullOrWhiteSpace(txtKullaniciSoyadi.Text) ||
             string.IsNullOrWhiteSpace(txtEposta.Text) ||
             string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
                return;
            }


            var user = new User
            {
                CreateDate = DateTime.Now,
                IsActive = cbDurum.Checked,
                Name = txtKullaniciAdi.Text,
                SurName = txtKullaniciSoyadi.Text,
                Email = txtEposta.Text,
                Password = txtSifre.Text
            };

            try
            {

                context.Users.Add(user);
                var sonuc = context.SaveChanges();

                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Ekleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Kayıt Ekleme Başarısız");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = (int)dgvKullanicilar.CurrentRow.Cells["Id"].Value;
            var user = context.Users.Find(id);

            txtKullaniciAdi.Text = user.Name;
            txtKullaniciSoyadi.Text = user.SurName;
            txtEposta.Text = user.Email;
            txtSifre.Text = user.Password;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void dgvKullanicilar_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dgvKullanicilar.CurrentRow.Cells["Id"].Value;
            var user = context.Users.Find(id);

            context.Users.Remove(user);
            var sonuc = context.SaveChanges();
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
    }
}
