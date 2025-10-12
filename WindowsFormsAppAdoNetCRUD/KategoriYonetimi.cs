using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNetCRUD
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }

        CategoryDAL DAL = new CategoryDAL();

        void Yukle()
        {
            dgvKategoriler.DataSource = DAL.GetDataTable("select * from categories");
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = "";
            txtAciklama.Text = string.Empty;
            cbDurum.Checked = false;
        }
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

            var sonuc = DAL.Add(kategori);

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

        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells["Name"].Value.ToString();
            txtAciklama.Text = dgvKategoriler.CurrentRow.Cells["Description"].Value.ToString(); 
            cbDurum.Checked = (bool)dgvKategoriler.CurrentRow.Cells["IsActive"].Value;

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

            var kategori = new Category
            {
                Id = (int) dgvKategoriler.CurrentRow.Cells["Id"].Value,
                CreateDate = (DateTime) dgvKategoriler.CurrentRow.Cells["CreateDate"].Value,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
                Name = txtKategoriAdi.Text
            };

            var sonuc = DAL.Update(kategori);

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = DAL.Delete((int)dgvKategoriler.CurrentRow.Cells["Id"].Value);

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
