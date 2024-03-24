using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitapci
{
    public partial class EmanetIslem : Form
    {
        public EmanetIslem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
        }

        private void EmanetIslem_Load(object sender, EventArgs e)
        {
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
    }
}
