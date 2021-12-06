using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAndRestaurant.Lib.Concrete
{
    public class UrunContext
    {
        //private static string _path =
        //  //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/KisiEnvanteri/db.json";
        //  "C:/KisiEnvanteri/db.json";
        
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/CafeAndRestaurantCheck/Menuler/Deneme.json";
        public static List<Urun> Urunler { get; set; } = new List<Urun>();

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
                    Urunler = JsonConvert.DeserializeObject<List<Urun>>(dosyaIcerigi);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                Directory.CreateDirectory("C:/CafeAndRestaurantCheck/Menuler/");
            }
        }
        public static void Save()
        {
            try
            {

                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(Urunler, Formatting.Indented));
                writer.Close();
                writer.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
