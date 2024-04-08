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
            
            emanetdata.DataSource = dtEmanet;
        }

        private void EmanetIslem_Load(object sender, EventArgs e)
        {

            // emanetler tablosu

            Emanet.tabloKur();
            Emanet.veriGetir(emanetdata);
            emanetdata.DefaultCellStyle.ForeColor = Color.Black;

            dtEmanet = new DataTable();
            dtEmanet.Columns.Add("Alici TC");
            dtEmanet.Columns.Add("Kitap ISBN");
            dtEmanet.Columns.Add("Alım Tarihi");
            dtEmanet.Columns.Add("İade Tarihi");
            emanetdata.DefaultCellStyle.ForeColor= Color.Black;

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

            bool alinmis = false;

            foreach (Emanet em in Emanet.emanetler)
            {
                if (em.AliciTC == Convert.ToInt32(aliciTcTB.Text) && em.KitapIsbn == Convert.ToInt32(kitapIsbnTB.Text))
                {
                    alinmis = true;
                    break;
                }
            }

            if (!alinmis)
            {
                Emanet emanet = new Emanet()
                {
                    AliciTC = Convert.ToInt32(aliciTcTB.Text),
                    KitapIsbn = Convert.ToInt32(kitapIsbnTB.Text),
                    AlinmaTarihi = DateTime.Now,
                    iadeTarihi = iadeDT.Value
                    //iadeTarihi = DateTime.Now.AddDays(Convert.ToInt32(gunTB.Text))
                };
                Emanet.emanetEkle(emanet);
                Emanet.veriGetir(emanetdata);
            }
            else
            {
                MessageBox.Show("Bu kişi bu kitabı almış");
            }

        }

        private void emanetdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aliciTcTB.Text = emanetdata.CurrentRow.Cells[0].Value.ToString();
            kitapIsbnTB.Text = emanetdata.CurrentRow.Cells[1].Value.ToString();
            gunTB.Text = (Convert.ToDateTime(emanetdata.CurrentRow.Cells[3].Value) - Convert.ToDateTime(emanetdata.CurrentRow.Cells[2].Value)).Days.ToString();
            iadeDT.Value = Convert.ToDateTime(emanetdata.CurrentRow.Cells[3].Value);

        }

        private void gunTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                iadeDT.Value = iadeDT.Value.AddDays(Convert.ToInt32(gunTB.Text));

            }
            catch
            {
                iadeDT.Value = DateTime.Now;
            }
        }

        private void iadeAl_btn_Click(object sender, EventArgs e)
        {
            Emanet.emanetKaldir(aliciTcTB.Text, kitapIsbnTB.Text);
            Emanet.veriGetir(emanetdata);
        }

        private void sureUzat_Click(object sender, EventArgs e)
        {
            DateTime aktifAlinma = DateTime.Now;
            bool islemyap = false;

            // Emanet bul ve süresini değişkende tut
            foreach (Emanet em in Emanet.emanetler)
            {
                if (!(em.AliciTC == Convert.ToInt32(aliciTcTB.Text) && em.KitapIsbn == Convert.ToInt32(kitapIsbnTB.Text)))
                {
                    break;
                }
                else
                {
                    aktifAlinma = em.AlinmaTarihi;
                    islemyap = true;
                    break;
                }
            }

            if (islemyap)
            {
                Emanet emanet = new Emanet()
                {
                    AliciTC = Convert.ToInt32(aliciTcTB.Text),
                    KitapIsbn = Convert.ToInt32(kitapIsbnTB.Text),

                    AlinmaTarihi = aktifAlinma,
                    iadeTarihi = iadeDT.Value.AddDays(Convert.ToUInt32(gunTB.Text))
                };

                Emanet.emanetKaldir(aliciTcTB.Text, kitapIsbnTB.Text);
                Emanet.emanetEkle(emanet);
                Emanet.veriGetir(emanetdata);

                guncelle();
            }
            else
            {
                MessageBox.Show("Süresi uzatılacak kitap bulunamadı");

            }


        }
    }
}

