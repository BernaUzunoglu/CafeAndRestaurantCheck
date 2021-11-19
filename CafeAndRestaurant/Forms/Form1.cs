using CafeAndRestaurant.Forms;
using CafeAndRestaurant.Lib.Abstract;
using CafeAndRestaurant.Lib.Concrete;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Drawing.Imaging;
using System.Reflection;
using System.Xml.Serialization;

namespace CafeAndRestaurant
{
    public partial class FrmIlk : Form
    {

        private List<Urun> urunler = new List<Urun>();
        string[] menuResimIsimleri = { "Balýklar", "FastFood", "Kahvaltý", "Mezeler", "Tatlýlar", "Mezeler", "Pastalar", "Salatalar", "Yemekler" };
        public FrmIlk()
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

        List<BinaBilgileri> binaBilgileri = new List<BinaBilgileri>();
        List<string> katAd = new List<string>();
        List<string> katMasa = new List<string>();
        private FrmPersonel _frmPersonel;
        private void btnNext1_Click_1(object sender, EventArgs e)
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
        private void FrmIlk_Load(object sender, EventArgs e)
        {
            UrunContext.Load();
            this.urunler = UrunContext.Urunler; //Referanslarýný eþitledik KisiContext nesnesi programýn basýndan kapanana kadar ramda kalýr.
            ListeyiDoldur();
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

                MessageBox.Show(ex.Message, "Bir hata oluþtu", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            dialog.Title = "Bir fotoðraf seçiniz";
            dialog.Filter = "Resim Dosyalarý | *.jpeg; *.jpg; *.png; *.jfif";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbResim.ImageLocation = dialog.FileName;
            }
        }


        private void bnListele_Click(object sender, EventArgs e)
        {
            var path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Menuler/VeriTabaný.json";

            FileStream fileStream = new FileStream(path2, FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            string dosyaÝcerigi = reader.ReadToEnd();
            urunler = JsonConvert.DeserializeObject<List<Urun>>(dosyaÝcerigi);
            MessageBox.Show($"{urunler.Count}adet ürün içeri aktarýldý");
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
            if (lstUrunler.SelectedItem == null) return; //index çaýþtýðýnda null gelebilir. Hata verme.

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

            DialogResult cevap = MessageBox.Show($"{seciliUrun} yi silmek istiyor musunuz?", "Silme onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                urunler.Remove(seciliUrun);

            }
            ListeyiDoldur();
        }

        private void veriTabanýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Menuler/VeriTabaný.json";

            if (File.Exists(path3))
            {

                File.Delete(path3);

                var path4 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Menuler/VeriTabaný.json";
                FileStream fileStream = new FileStream(path4, FileMode.OpenOrCreate); //dosya varsa içine kaydet yoksa oluþturup kaydet : openorcreate komutu ile 
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(urunler, Formatting.Indented));
                writer.Close();
                writer.Dispose();
                MessageBox.Show($"{urunler.Count}adet ürün dýþarý aktarýldý");
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/Menuler/VeriTabaný.json";
            StreamReader reader = new StreamReader(path);
            string dosyaIcerigi = reader.ReadToEnd();
            urunler = JsonConvert.DeserializeObject<List<Urun>>(dosyaIcerigi);
            reader.Close();
            ListeyiDoldur();
        }
    }
}