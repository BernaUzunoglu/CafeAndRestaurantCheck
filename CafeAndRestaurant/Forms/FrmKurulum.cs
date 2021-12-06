using CafeAndRestaurant.Lib.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAndRestaurant.Forms
{
    public partial class FrmKurulum : Form
    {
        private List<Urun> urunler = new List<Urun>();
        public FrmKurulum()
        {
            InitializeComponent();
            for (int i = 1; i <= 20; i++)
            {
                cbBahçe.Items.Add(i);
                cbZemin.Items.Add(i);
                cbKat1.Items.Add(i);
                cbKat2.Items.Add(i);
                cbKat3.Items.Add(i);
                cbKat4.Items.Add(i);
                cbTeras.Items.Add(i);
            }
        }
        private void FrmKurulum_Load(object sender, EventArgs e)
        {
            UrunContext.Load();
            this.urunler = UrunContext.Urunler; //Referanslarını eşitledik KisiContext nesnesi programın basından kapanana kadar ramda kalır.
            ListeyiDoldur();

        }
        List<BinaBilgileri> binaBilgileri = new List<BinaBilgileri>();
        List<string> katAd = new List<string>();
        List<string> katMasa = new List<string>();
        private FrmPersonel _frmPersonel;
        private void btnNext1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string bilgi = checkedListBox1.CheckedItems[i].ToString();
                katAd.Add(bilgi);
            }

            foreach (Control control in pnlCombolar.Controls)
            {
                if (control is ComboBox && control.Text != "")
                    katMasa.Add(control.Text);
            }
            katMasa.Reverse();

            for (int i = 0; i < katAd.Count; i++)
            {
                binaBilgileri.Add(new BinaBilgileri()
                {
                    BinaBolumAdi = katAd[i],
                    MasaAdet = katMasa[i]
                });
            }
            _frmPersonel = new FrmPersonel();

            foreach (BinaBilgileri item in binaBilgileri)
            {

                _frmPersonel.BinaBilgileri.Add(item);
            }
            FrmPersonel frmPersonel = new FrmPersonel();
            frmPersonel.BinaBilgileri = _frmPersonel.BinaBilgileri;
            FrmGiris frmGiris = new FrmGiris(_frmPersonel.BinaBilgileri);
            //frmGiris.Show();
            frmPersonel.Show();
            this.Hide();
        }
        private void ListeyiDoldur()
        {
            lstUrunler.Items.Clear();

            foreach (Urun item in urunler)
            {
                if (item.UrunKategori == cmbKategori.Text)
                {
                    lstUrunler.Items.Add(item);
                }
            }

            UrunContext.Save();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun yeniUrun = new Urun();
            try
            {
                yeniUrun.UrunAd = txtUrunAd.Text;
                yeniUrun.Fiyat = txtFiyat.Text + $" TL ";
                yeniUrun.UrunKategori = cmbKategori.Text;
                // Id = txtId.Text

                if (pbResim.Image != null)
                {
                    MemoryStream resimStream = new MemoryStream();
                    pbResim.Image.Save(resimStream, ImageFormat.Jpeg);
                    yeniUrun.Fotograf = resimStream.ToArray();
                }


                //urunler.Add(yeniUrun);
                ListeyiDoldur();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            };
            if (pbResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbResim.Image.Save(resimStream, ImageFormat.Jpeg);

                yeniUrun.Fotograf = resimStream.ToArray();
            }
            urunler.Add(yeniUrun);
            ListeyiDoldur();
            UrunContext.Save();

        }
        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg; *.png; *.jfif";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbResim.ImageLocation = dialog.FileName;
            }
        }


        private void bnListele_Click(object sender, EventArgs e)
        {
            var path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Menuler/VeriTabanı.json";

            FileStream fileStream = new FileStream(path2, FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            string dosyaİcerigi = reader.ReadToEnd();
            urunler = JsonConvert.DeserializeObject<List<Urun>>(dosyaİcerigi);
            MessageBox.Show($"{urunler.Count}adet ürün içeri aktarıldı");
            reader.Close();
            lstUrunler.Items.Clear();

            foreach (Urun item in urunler)
            {
                lstUrunler.Items.Add(item);

            }
        }

        //private Urun seciliUrun;
        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return; //index çaıştığında null gelebilir. Hata verme.

            // seciliUrun = lstUrunler.SelectedItem as Urun;
            Urun seciliUrun = (Urun)lstUrunler.SelectedItem;
            txtUrunAd.Text = seciliUrun.UrunAd;
            txtFiyat.Text = seciliUrun.Fiyat;
            cmbKategori.SelectedValue = seciliUrun.UrunKategori;

            if (seciliUrun.Fotograf != null)
            {
                MemoryStream stream = new MemoryStream(seciliUrun.Fotograf);
                pbResim.Image = Image.FromStream(stream);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urun seciliUrun = (Urun)lstUrunler.SelectedItem;

            if (seciliUrun == null) return;
            seciliUrun.UrunAd = txtUrunAd.Text;
            seciliUrun.Fiyat = txtFiyat.Text;
            seciliUrun.UrunKategori = cmbKategori.Text;

            if (pbResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbResim.Image.Save(resimStream, ImageFormat.Jpeg);
                seciliUrun.Fotograf = resimStream.ToArray();
            }
            ListeyiDoldur();
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Urun seciliUrun = (Urun)lstUrunler.SelectedItem;

            if (seciliUrun == null) return;

            DialogResult cevap = MessageBox.Show($"{seciliUrun} yi silmek istiyor musunuz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                urunler.Remove(seciliUrun);

            }
            ListeyiDoldur();
        }

        private void veriTabanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Menuler/VeriTabanı.json";

            if (File.Exists(path3))
            {

                File.Delete(path3);

                var path4 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Menuler/VeriTabanı.json";
                FileStream fileStream = new FileStream(path4, FileMode.OpenOrCreate); //dosya varsa içine kaydet yoksa oluşturup kaydet : openorcreate komutu ile 
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(urunler, Formatting.Indented));
                writer.Close();
                writer.Dispose();
                MessageBox.Show($"{urunler.Count}adet ürün dışarı aktarıldı");
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/Menuler/VeriTabanı.json";
            StreamReader reader = new StreamReader(path);
            string dosyaIcerigi = reader.ReadToEnd();
            urunler = JsonConvert.DeserializeObject<List<Urun>>(dosyaIcerigi);
            reader.Close();
            ListeyiDoldur();
        }

        //private void btnKaydet_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnGuncelle_Click(object sender, EventArgs e)
        //{

        //}

        //private void bnListele_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnSil_Click(object sender, EventArgs e)
        //{

        //}

        //private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void veriTabanıToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //}

        //private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void pbResim_Click(object sender, EventArgs e)
        //{

        //}



        //private void btnNext1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
