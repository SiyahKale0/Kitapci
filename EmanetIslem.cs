using System.Data;
using System.Text;
using System.Text.Json;

namespace Kitapci
{
    public partial class EmanetIslem : Form
    {

        public EmanetIslem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
        }
        DataTable dtEmanet;
        public void guncelle()
        {
            dtEmanet.Rows.Clear(); // DataTable'ı temizle
            foreach (Emanet emanet in Emanet.emanetler)
            {
                emanet.tabloyaEkle(dtEmanet);
            }

            emanetlerData.DataSource = dtEmanet;
        }
        private void EmanetIslem_Load(object sender, EventArgs e)
        {

            // emanetler tablosu
            dtEmanet = new DataTable();
            dtEmanet.Columns.Add("Alici TC");
            dtEmanet.Columns.Add("Kitap ISBN");
            dtEmanet.Columns.Add("Alım Tarihi");
            dtEmanet.Columns.Add("İade Tarihi");
            emanetlerData.DefaultCellStyle.ForeColor = Color.Black;

            if (File.Exists("emanetler.json"))
            {
                string data = File.ReadAllText("emanetler.json");
                Emanet.emanetler = JsonSerializer.Deserialize<List<Emanet>>(data);
                guncelle();
            }


        }

        private void kucultme_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kapatma_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private int positionX;
        private int positionY;
        private bool hareketBasladi = false;
        private void EmanetIslem_MouseDown(object sender, MouseEventArgs e)
        {
            positionX = e.X;
            positionY = e.Y;
            hareketBasladi = true;
        }

        private void EmanetIslem_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareketBasladi)
            {
                int xDegisim = e.X - positionX;
                int yDegisim = e.Y - positionY;
                this.Location = new Point(this.Location.X + xDegisim,
                                          this.Location.Y + yDegisim);
            }

        }

        private void EmanetIslem_MouseUp(object sender, MouseEventArgs e)
        {
            hareketBasladi = false;
        }

        private void oduncVer_btn_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet()
            {
                AliciTC = Convert.ToInt32(aliciTcTB.Text),
                KitapIsbn = Convert.ToInt32(kitapIsbnTB.Text),
                AlinmaTarihi = DateTime.Now,
                iadeTarihi = DateTime.Now.AddDays(Convert.ToInt32(gunTB.Text))
            };
            Emanet.emanetler.Add(emanet);

            string yazilacak = JsonSerializer.Serialize<List<Emanet>>(Emanet.emanetler);
            File.WriteAllText("emanetler.json", yazilacak, Encoding.UTF8);
            guncelle();
        }
    }
}

