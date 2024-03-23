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
    }
}
