using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kitapci
{
    public partial class EmanetIslem : Form
    {
        public EmanetIslem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            dtEmanet = new DataTable();
            dtEmanet.Columns.Add("Alici TC");
            dtEmanet.Columns.Add("Kitap ISBN");
            dtEmanet.Columns.Add("Alım Tarihi");
            dtEmanet.Columns.Add("İade Tarihi");
        }

        DataTable dtEmanet;

        public void guncelle()
        {
            dtEmanet.Rows.Clear(); // Clear DataTable
            Emanet.GetData();
        }

        private void EmanetIslem_Load(object sender, EventArgs e)
        {
            Emanet.AddTable(emanetdata);
            Emanet.GetData();
            emanetdata.DefaultCellStyle.ForeColor = Color.Black;
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
            bool alinmis = Emanet.GetEmanetDate(Convert.ToInt32(aliciTcTB.Text), Convert.ToInt32(kitapIsbnTB.Text)) != null;

            if (!alinmis)
            {
                Emanet emanet = new Emanet()
                {
                    AliciTC = Convert.ToInt32(aliciTcTB.Text),
                    KitapIsbn = Convert.ToInt32(kitapIsbnTB.Text),
                    AlinmaTarihi = DateTime.Now,
                    IadeTarihi = iadeDT.Value
                };
                Emanet.AddEmanet(emanet);
                Emanet.GetData();
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
            Emanet.RemoveEmanet(aliciTcTB.Text, kitapIsbnTB.Text);
            Emanet.GetData();
        }

        private void sureUzat_Click(object sender, EventArgs e)
        {
            DateTime? aktifAlinma = Emanet.GetEmanetDate(Convert.ToInt32(aliciTcTB.Text), Convert.ToInt32(kitapIsbnTB.Text));

            if (aktifAlinma != null)
            {
                Emanet emanet = new Emanet()
                {
                    AliciTC = Convert.ToInt32(aliciTcTB.Text),
                    KitapIsbn = Convert.ToInt32(kitapIsbnTB.Text),
                    AlinmaTarihi = aktifAlinma.Value,
                    IadeTarihi = iadeDT.Value.AddDays(Convert.ToInt32(gunTB.Text))
                };

                Emanet.RemoveEmanet(aliciTcTB.Text, kitapIsbnTB.Text);
                Emanet.AddEmanet(emanet);
                Emanet.GetData();

                guncelle();
            }
            else
            {
                MessageBox.Show("Süresi uzatılacak kitap bulunamadı");
            }
        }
    }
}
