﻿using CafeAndRestaurant.Lib.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAndRestaurant.Forms
{
    public partial class FrmSiparis : Form
    {
        private List<Menu> menuler = new List<Menu>();
        string[] menuResimIsimleri = { "Balıklar", "FastFood", "Kahvaltı", "Mezeler", "Tatlılar", "Salatalar", "Yemekler", "Çorbalar", "İçecekler" };
        public FrmSiparis()
        {
            InitializeComponent();
        }
        public void JsonConverter(string menuIsmi)
        {
            ///CafeAndRestaurant.Lib.Properties.Resources.Tatlılar
            //string yol = $"C:/Users/win10/Source/Repos/CafeAndRestaurantCheck/CafeAndRestaurant.Lib/Resources/{menuIsmi}.json";
            //string yol = $"../../../CafeAndRestaurant.Lib/Resources/{menuIsmi}.json";
            //string yol = $"{CafeAndRestaurant.Lib.Properties.Resources}.";
            //Stream veri = CafeAndRestaurant.Lib.Properties.Resources.Yemekler;
            //Lib.Properties.Resources.Balıklar
            //var yol =CafeAndRestaurant.Lib.Properties.Resources.Balıklar;
            //var assembly = Assembly.GetExecutingAssembly();
            //var jsonVeri = assembly.GetManifestResourceStream($"CafeAndRestaurant.Lib.Properties.Resources.{menuIsmi}.json");

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/Menuler/{menuIsmi}.json";
            StreamReader fileJson = new StreamReader(path);
            string dosyaİcerigi = fileJson.ReadToEnd();
            menuler = JsonConvert.DeserializeObject<List<Menu>>(dosyaİcerigi);

            MessageBox.Show($"{menuler.Count} ürün içeri aktarıldı");
            foreach (var eleman in menuler)
            {
                MemoryStream stream = new MemoryStream(eleman.Fotograf);
                var groupBox = new GroupBox();
                groupBox.Name = $"grpBox{eleman.UrunAd}";

                var pbox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(210, 160),
                    Image = Image.FromStream(stream)

                };
                pbox.Name = $"{eleman.UrunAd}";
                pbox.Click += new EventHandler(pboxUrunler_Click);
                pbox.Parent = groupBox;
                flpMenuElemanlari.Controls.Add(pbox);

                Label lblDetay = new Label
                {
                    Text = $"{eleman.UrunAd} {eleman.Fiyat} TL",
                    ForeColor = Color.White,
                    //BackColor = Color.Transparent,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    BackColor = Color.Chocolate,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(13, 110),
                    AutoSize = true
                };
                lblDetay.Parent = pbox;
            }
        }
        private List<Menu> siparişler = new List<Menu>();
        private void pboxUrunler_Click(object sender, EventArgs e)
        {
            //flpMenuElemanlari.Controls.Clear();
            PictureBox oPictureBox = (PictureBox)sender;
            foreach (var item in menuler)
            {
                if (oPictureBox.Name == item.UrunAd)
                {
                    MessageBox.Show($"{item.UrunAd}  {item.Fiyat} TL");
                }
                //MessageBox.Show(oPictureBox.Name);
            }
        }
        private void pbox_Click(object sender, EventArgs e)
        {
            flpMenuElemanlari.Controls.Clear();
            PictureBox oPictureBox = (PictureBox)sender;
            foreach (var item in menuResimIsimleri)
            {
                if (oPictureBox.Name == item)
                {
                    JsonConverter(item);
                }
                //MessageBox.Show(oPictureBox.Name);
            }

        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            var path = @"C:\Users\HP\Desktop\MenuAD";
            var resim = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                .Where(x => new string[] { ".bmp", ".jpg", ".png" }
                                .Contains(new FileInfo(x).Extension.ToLower()))
                                .Take(20)
                                .ToList();

            for (int i = 0; i < resim.Count(); i++)
            {
                var groupBox = new GroupBox();
                groupBox.Name = $"grpBox{menuResimIsimleri[i]}";

                var pbox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(220, 170),
                    //ClientSize = new Size(200, 180),
                    ImageLocation = resim[i]
                };
                pbox.Name = $"{menuResimIsimleri[i]}";
                pbox.Click += new EventHandler(pbox_Click);
                pbox.Parent = groupBox;
                flwpMenu.Controls.Add(pbox);

                Label lblDetay = new Label
                {
                    Text = $"{menuResimIsimleri[i]}",
                    ForeColor = Color.Chocolate,
                    //BackColor = Color.Transparent,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    BackColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(7, 7)
                    //Margin = new Thickness(20)
                };

                lblDetay.Parent = pbox;
            }
        }


    }
}
