namespace Kitapci
{
    public partial class Yonetim : Form
    {
        public Yonetim()
        {
            InitializeComponent();
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
    }
}
