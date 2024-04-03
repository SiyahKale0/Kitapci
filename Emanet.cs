using System.Data;
<<<<<<< HEAD
using System.Text;
using System.Text.Json;
=======
>>>>>>> 87730fb (Proje dosyası ekle.)

namespace Kitapci
{
    public class Emanet
    {
        public static List<Emanet> emanetler = new List<Emanet>();
<<<<<<< HEAD
        public static DataTable dtEmanet = new DataTable();

=======
>>>>>>> 87730fb (Proje dosyası ekle.)

        private int _AliciTC;
        private int _KitapIsbn;
        private DateTime _alimTaihi;
        private DateTime _iadeTarihi;

        public int AliciTC { get { return _AliciTC; } set { _AliciTC = value; } }
        public int KitapIsbn { get { return _KitapIsbn; } set { _KitapIsbn = value; } }
        public DateTime AlinmaTarihi { get { return _alimTaihi; } set { _alimTaihi = value; } }
        public DateTime iadeTarihi { get { return _iadeTarihi; } set { _iadeTarihi = value; } }

<<<<<<< HEAD
        public static void tabloKur()
        {
            Emanet.dtEmanet.Rows.Clear(); // DataTable'ı temizle
            if (Emanet.dtEmanet.Columns.Contains("Alici TC") == false)
                Emanet.dtEmanet.Columns.Add("Alici TC");
            if (Emanet.dtEmanet.Columns.Contains("Kitap ISBN") == false)
                Emanet.dtEmanet.Columns.Add("Kitap ISBN");
            if (Emanet.dtEmanet.Columns.Contains("Alım Tarihi") == false)
                Emanet.dtEmanet.Columns.Add("Alım Tarihi");
            if (Emanet.dtEmanet.Columns.Contains("İade Tarihi") == false)
                Emanet.dtEmanet.Columns.Add("İade Tarihi");
        }

        public static void veriGetir(DataGridView emanetdata)
        {
            if (File.Exists("emanetler.json"))
            {
                var data = File.ReadAllText("emanetler.json");
                Emanet.emanetler = JsonSerializer.Deserialize<List<Emanet>>(data);
            }

            Emanet.tabloKur(); // DataTable'ı oluştur veya temizle

            foreach (Emanet emanet in Emanet.emanetler)
            {
                dtEmanet.Rows.Add(new object[] { emanet._AliciTC, emanet._KitapIsbn, emanet._alimTaihi, emanet._iadeTarihi });
            }

            emanetdata.DataSource = Emanet.dtEmanet;
        }

        public static void emanetEkle(Emanet emanet)
        {
            Emanet.emanetler.Add(emanet);
            string yazilacak = JsonSerializer.Serialize<List<Emanet>>(Emanet.emanetler);
            File.WriteAllText("emanetler.json", yazilacak, Encoding.UTF8);
        }

        public static void emanetKaldir(string aliciTC, string kitapIsbn)
        {
            Emanet.emanetler.RemoveAll(x => x._AliciTC.ToString() == aliciTC && x._KitapIsbn.ToString() == kitapIsbn);
            string yazilacak = JsonSerializer.Serialize<List<Emanet>>(Emanet.emanetler);
            File.WriteAllText("emanetler.json", yazilacak, Encoding.UTF8);
        }
=======
        public void tabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] { _AliciTC, _KitapIsbn, _alimTaihi, _iadeTarihi });
        }

>>>>>>> 87730fb (Proje dosyası ekle.)
    }
}
