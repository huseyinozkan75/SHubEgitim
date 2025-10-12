using System;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNetCRUD
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }


        UserDAL dAL = new UserDAL();

        void Yukle()
        {
            dgvKullanicilar.DataSource = dAL.GetAll();
            // dgvUrunler.DataSource = dAL.GetDataTable("select * from products");
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKullaniciAdi.Text = "";
            txtKullaniciSoyadi.Text = "";
            txtEposta.Text = "";
            txtSifre.Text = "";
            cbDurum.Checked = false;
        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciSoyadi.Text) ||
                string.IsNullOrWhiteSpace(txtEposta.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) )
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
                return;
            }


            var user = new User
            {
                CreateDate = DateTime.Now,
                IsActive = cbDurum.Checked,
                Name = txtKullaniciAdi .Text,
                SurName = txtKullaniciSoyadi.Text,
                Email= txtEposta.Text,
                Password= txtSifre.Text
            };

            try
            {
                var sonuc = dAL.Add(user);

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

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKullaniciAdi .Text = dgvKullanicilar.CurrentRow.Cells["Name"].Value.ToString();
            txtKullaniciSoyadi.Text = dgvKullanicilar.CurrentRow.Cells["SurName"].Value.ToString();

            txtEposta.Text = dgvKullanicilar.CurrentRow.Cells["Email"].Value.ToString();
            txtSifre.Text = dgvKullanicilar.CurrentRow.Cells["Password"].Value.ToString();

            cbDurum.Checked = (bool)dgvKullanicilar.CurrentRow.Cells["IsActive"].Value;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
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

            var user = new User
            {
                Id = (int) dgvKullanicilar.CurrentRow.Cells["Id"].Value,
                CreateDate = DateTime.Now,
                IsActive = cbDurum.Checked,
                Name = txtKullaniciAdi.Text,
                SurName = txtKullaniciSoyadi.Text,
                Email = txtEposta.Text,
                Password = txtSifre.Text              
            };

            try
            {
                var sonuc = dAL.Update(user);

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = dAL.Delete((int)dgvKullanicilar.CurrentRow.Cells["Id"].Value);

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
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }
    }
}
