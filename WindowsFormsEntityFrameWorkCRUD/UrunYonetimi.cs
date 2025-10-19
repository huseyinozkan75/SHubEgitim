using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsEntityFrameWorkCRUD
{
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }

        DatabaseContext context = new DatabaseContext();    // veritabanı tablolarmızı temsil eden sınıfımızdan bir nesne türettik.
                                                            // entity framework ile veritabanı işlemlerimizi bu nesne üzerinden yapacağız.

        void Yukle()
        {
            dgvUrunler.DataSource = context.Products.ToList();
            cbKategoriler.DataSource = context.Categories.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtUrunAdi.Text = "";
            txtStok.Text = "";
            txtFiyat.Text = "";
            txtAciklama.Text = string.Empty;
            cbDurum.Checked = false;
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) ||
                 string.IsNullOrWhiteSpace(txtStok.Text) ||
                 string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
                return;
            }


            var urun = new Product
            {
                CreateDate = DateTime.Now,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
                Name = txtUrunAdi.Text,
                Price = Convert.ToDecimal(txtFiyat.Text),
                Stock = Convert.ToInt32(txtStok.Text),
                CategoryId = (int) cbKategoriler.SelectedValue
            };

            try
            {
                context.Products.Add(urun);
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(txtUrunAdi.Text)  ||
                 string.IsNullOrWhiteSpace(txtStok.Text)     ||
                 string.IsNullOrWhiteSpace(txtFiyat.Text) )
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
                return;
            }

            var id = (int) dgvUrunler.CurrentRow.Cells["Id"].Value;
            var product = context.Products.Find(id);
            
            product.Name = txtUrunAdi.Text;
            product.Description = txtAciklama.Text;
            product.IsActive = cbDurum.Checked;
            product.Price = Convert.ToDecimal(txtFiyat.Text);
            product.Stock = Convert.ToInt32(txtStok.Text);
            product.CategoryId = (int)cbKategoriler.SelectedValue;

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
                MessageBox.Show($"Hata Oluştu!\nHata Açıklaması: {exp}");
            }

        }

        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = (int)dgvUrunler.CurrentRow.Cells["Id"].Value;
            var kayit = context.Products.Find(id); // Find metodu ile birincil anahtar üzerinden
                                                   // kayıt bulma işlemi yapıyoruz.

            txtUrunAdi.Text = kayit.Name;
            txtAciklama.Text = kayit.Description;
            cbDurum.Checked = (bool) kayit.IsActive;
            cbKategoriler.SelectedValue = (bool) dgvUrunler.CurrentRow.Cells["CategoryId"].Value;
            txtFiyat.Text = Convert.ToString(kayit.Price);
            txtStok.Text = Convert.ToString(kayit.Stock);

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = (int)dgvUrunler.CurrentRow.Cells["Id"].Value;
            var product = context.Products.Find(id);

            context.Products.Remove(product);
            try
            {
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
            catch (Exception exp)
            {
                MessageBox.Show($"Hata Oluştu!\nHata Açıklaması: {exp}");
            }
        }

        private void dgvUrunler_Click(object sender, EventArgs e)
        {
            try
            {

                txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells["Name"].Value.ToString();
                txtAciklama.Text = Convert.ToString(dgvUrunler.CurrentRow.Cells["Description"]?.Value ?? string.Empty);

                cbDurum.Checked = (bool)dgvUrunler.CurrentRow.Cells["IsActive"].Value;
                txtFiyat.Text = dgvUrunler.CurrentRow.Cells["Price"].Value.ToString();
                txtStok.Text = dgvUrunler.CurrentRow.Cells["Stock"].Value.ToString();

                btnEkle.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception exc)
            {

                MessageBox.Show($"Hata Oluştu!\nHata Açıklaması: {exc}");
            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = context.Products.Where(p=>p.Name.Contains(txtAra.Text) || 
            p.Description.Contains(txtAra.Text) ).ToList();

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = context.Products.Where(p => p.Name.Contains(txtAra.Text) ||
            p.Description.Contains(txtAra.Text)).ToList();
        }
    }
}
