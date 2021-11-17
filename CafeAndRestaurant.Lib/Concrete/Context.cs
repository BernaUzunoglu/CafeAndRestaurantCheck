﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAndRestaurant.Lib.Concrete
{
    public  class Context
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/Siparis.json";
        public static List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>();

        
        public static void Load()
        {
            if (File.Exists(_path))
            {
                try
                {
                    FileStream fileStream = new FileStream(_path, FileMode.Open);
                    StreamReader reader = new StreamReader(fileStream);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    reader.Dispose();
                    SiparisDetaylari = JsonConvert.DeserializeObject<List<SiparisDetay>>(dosyaIcerigi);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                Directory.CreateDirectory( $" / Siparis.json");
            }
        }

        public static void Save()
        {
            try
            {
                File.Delete(_path);
                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(SiparisDetaylari, Formatting.Indented));
                writer.Close();
                writer.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        // public List<BinaBilgileri> BinaBilgileri { get; set; } = new List<BinaBilgileri>();

    }
}
