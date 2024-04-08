namespace Kitapci
{
    public partial class Yonetim : Form
    {
        public static int islemModu = -1;
        public Yonetim()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
        }


        private void kapatma_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kisiler_btn_Click(object sender, EventArgs e)
        {
            icerik.Controls.Clear();
            var kisilerIcerik = new KisilerIcerik();
            icerik.Controls.Add(kisilerIcerik);
        }

        private void kitaplar_btn_Click(object sender, EventArgs e)
        {
            icerik.Controls.Clear();
            var kitaplarIcerik = new KitaplarIcerik();
            icerik.Controls.Add(kitaplarIcerik);
        }

        public void emanetisemgetir()
        {
            icerik.Controls.Clear();
            var emanetlerIcerik = new EmanetlerIcerik();
            icerik.Controls.Add(emanetlerIcerik);

            Emanet.tabloKur();
            Emanet.veriGetir(emanetlerIcerik.emanetlerdata);
        }



        private void emanetler_btn_Click(object sender, EventArgs e)
        {
            emanetisemgetir();
        }

        private void Yonetim_Load(object sender, EventArgs e)
        {
            islemModu = 0;

            emanetisemgetir();

        }

        private void islemler_btn_Click(object sender, EventArgs e)
        {
            switch (islemModu)
            {
                case 0:
                    var emanetIslem = new EmanetIslem();
                    emanetIslem.Show();
                    break;
            }
        }
        private int positionX;
        private int positionY;
        private bool hareketBasladi = false;
        private void yonetim_MouseDown(object sender, MouseEventArgs e)
        {
            positionX = e.X;
            positionY = e.Y;
            hareketBasladi = true;
        }

        private void yonetim_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareketBasladi)
            {
                int xDegisim = e.X - positionX;
                int yDegisim = e.Y - positionY;
                this.Location = new Point(this.Location.X + xDegisim,
                                          this.Location.Y + yDegisim);
            }

        }

        private void yonetim_MouseUp(object sender, MouseEventArgs e)
        {
            hareketBasladi = false;
        }
    }
}
