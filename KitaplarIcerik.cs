namespace Kitapci
{
    public partial class KitaplarIcerik : UserControl
    {
        public KitaplarIcerik()
        {
            InitializeComponent();
        }

        public DataGridView kitaplardata { get { return kitaplarData; } }
    }
}
