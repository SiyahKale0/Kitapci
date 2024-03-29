using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci
{
    public class Emanet
    {
        public static List<Emanet> emanetler = new List<Emanet>();

        private int _AliciTC;
        private int _KitapIsbn;
        private DateTime _alimTaihi;
        private DateTime _iadeTarihi;

        public int AliciTC { get { return _AliciTC; } set { _AliciTC = value; } }
        public int KitapIsbn{ get { return _KitapIsbn; } set { _KitapIsbn = value; } }
        public DateTime AlinmaTarihi { get { return _alimTaihi; } set { _alimTaihi = value; } }
        public DateTime iadeTarihi { get { return _iadeTarihi; } set { _iadeTarihi = value; } }

        public void tabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] { _AliciTC, _KitapIsbn, _alimTaihi, _iadeTarihi });
        }

    }
}
