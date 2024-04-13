using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Kitapci
{
    public partial class KitapIslem : Form
    {
        public KitapIslem()
        {
            InitializeComponent();
        }

        private void kitapEkle_btn_Click(object sender, EventArgs e)
        {
            Kitap yeniKitap = new Kitap();
            yeniKitap.ISBN = Convert.ToInt32(isbnTB.Text);
            yeniKitap.Baslik = baslikTB.Text;
            yeniKitap.Yazar = yazarTB.Text;
            yeniKitap.Adet = Convert.ToInt32(adetTB.Text);
            yeniKitap.Yayinevi = yayineviTB.Text;
            yeniKitap.SayfaSayisi = Convert.ToInt32(sayfaTB.Text);
            yeniKitap.BasimYili = Convert.ToInt32(basimTB.Text);

            Kitap.AddKitap(yeniKitap);
            MessageBox.Show("Yeni kitap eklendi!");
            ClearTextBoxes();
            Kitap.GetData();
        }

        private void kitapGnclle_btn_Click(object sender, EventArgs e)
        {
            int isbn = Convert.ToInt32(isbnTB.Text);
            Kitap eskiKitap = Kitap.GetKitap(isbn);

            if (eskiKitap != null)
            {
                Kitap.RemoveKitap(isbn);
                eskiKitap.Baslik = baslikTB.Text;
                eskiKitap.Yazar = yazarTB.Text;
                eskiKitap.Adet = Convert.ToInt32(adetTB.Text);
                eskiKitap.Yayinevi = yayineviTB.Text;
                eskiKitap.SayfaSayisi = Convert.ToInt32(sayfaTB.Text);
                eskiKitap.BasimYili = Convert.ToInt32(basimTB.Text);

                Kitap.AddKitap(eskiKitap);
                Kitap.GetData();

                MessageBox.Show("Kitap güncellendi!");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Güncellenecek kitap bulunamadı!");
            }
        }

        private void kitapSil_btn_Click(object sender, EventArgs e)
        {
            int isbn = Convert.ToInt32(isbnTB.Text);
            Kitap eskiKitap = Kitap.GetKitap(isbn);

            if (eskiKitap != null)
            {
                Kitap.RemoveKitap(isbn);
                MessageBox.Show("Kitap silindi!");
                ClearTextBoxes();
                Kitap.GetData();
            }
            else
            {
                MessageBox.Show("Silinecek kitap bulunamadı!");
            }
        }

        private void ClearTextBoxes()
        {
            isbnTB.Clear();
            baslikTB.Clear();
            yazarTB.Clear();
            adetTB.Clear();
            yayineviTB.Clear();
            sayfaTB.Clear();
            basimTB.Clear();
        }

        private void KitapIslem_Load(object sender, EventArgs e)
        {
            Kitap.ConnectToDatabase();
            Kitap.AddTable(kitapdata);
            Kitap.GetData();
            kitapdata.DefaultCellStyle.ForeColor = Color.Black;
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
        private void KitapIslem_MouseDown(object sender, MouseEventArgs e)
        {
            positionX = e.X;
            positionY = e.Y;
            hareketBasladi = true;
        }

        private void KitapIslem_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareketBasladi)
            {
                int xDegisim = e.X - positionX;
                int yDegisim = e.Y - positionY;
                this.Location = new Point(this.Location.X + xDegisim,
                                          this.Location.Y + yDegisim);
            }
        }

        private void KitapIslem_MouseUp(object sender, MouseEventArgs e)
        {
            hareketBasladi = false;
        }

        private void kitapdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && kitapdata.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = kitapdata.SelectedRows[0];

                string isbn = selectedRow.Cells["ISBN"].Value.ToString();
                string baslik = selectedRow.Cells["Baslik"].Value.ToString();
                string yazar = selectedRow.Cells["Yazar"].Value.ToString();
                string adet = selectedRow.Cells["Adet"].Value.ToString();
                string yayinevi = selectedRow.Cells["Yayinevi"].Value.ToString();
                string sayfaSayisi = selectedRow.Cells["SayfaSayisi"].Value.ToString();
                string basimYili = selectedRow.Cells["BasimYili"].Value.ToString();

                isbnTB.Text = isbn;
                baslikTB.Text = baslik;
                yazarTB.Text = yazar;
                adetTB.Text = adet;
                yayineviTB.Text = yayinevi;
                sayfaTB.Text = sayfaSayisi;
                basimTB.Text = basimYili;
            }
        }

    }
}
