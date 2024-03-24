namespace Kitapci
{
    partial class KitaplarIcerik
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            kisilerData = new DataGridView();
            baslik = new DataGridViewTextBoxColumn();
            yazar = new DataGridViewTextBoxColumn();
            yayinEvi = new DataGridViewTextBoxColumn();
            sayfaSayisi = new DataGridViewTextBoxColumn();
            basimYili = new DataGridViewTextBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)kisilerData).BeginInit();
            SuspendLayout();
            // 
            // kisilerData
            // 
            kisilerData.BackgroundColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            kisilerData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            kisilerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kisilerData.Columns.AddRange(new DataGridViewColumn[] { baslik, yazar, yayinEvi, sayfaSayisi, basimYili, isbn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            kisilerData.DefaultCellStyle = dataGridViewCellStyle2;
            kisilerData.Location = new Point(1, 2);
            kisilerData.Name = "kisilerData";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            kisilerData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            kisilerData.RowHeadersWidth = 51;
            kisilerData.Size = new Size(760, 677);
            kisilerData.TabIndex = 4;
            // 
            // baslik
            // 
            baslik.HeaderText = "Başlık";
            baslik.MinimumWidth = 6;
            baslik.Name = "baslik";
            baslik.Width = 125;
            // 
            // yazar
            // 
            yazar.HeaderText = "Yazar";
            yazar.MinimumWidth = 6;
            yazar.Name = "yazar";
            yazar.Width = 125;
            // 
            // yayinEvi
            // 
            yayinEvi.HeaderText = "Yayın Evi";
            yayinEvi.MinimumWidth = 6;
            yayinEvi.Name = "yayinEvi";
            yayinEvi.Width = 125;
            // 
            // sayfaSayisi
            // 
            sayfaSayisi.HeaderText = "Sayfa Sayisi";
            sayfaSayisi.MinimumWidth = 6;
            sayfaSayisi.Name = "sayfaSayisi";
            sayfaSayisi.Width = 125;
            // 
            // basimYili
            // 
            basimYili.HeaderText = "Basım Yılı";
            basimYili.MinimumWidth = 6;
            basimYili.Name = "basimYili";
            basimYili.Width = 125;
            // 
            // isbn
            // 
            isbn.HeaderText = "ISBN";
            isbn.MinimumWidth = 6;
            isbn.Name = "isbn";
            isbn.Width = 125;
            // 
            // KitaplarIcerik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 237, 223);
            Controls.Add(kisilerData);
            Margin = new Padding(0);
            Name = "KitaplarIcerik";
            Size = new Size(763, 682);
            ((System.ComponentModel.ISupportInitialize)kisilerData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView kisilerData;
        private DataGridViewTextBoxColumn baslik;
        private DataGridViewTextBoxColumn yazar;
        private DataGridViewTextBoxColumn yayinEvi;
        private DataGridViewTextBoxColumn sayfaSayisi;
        private DataGridViewTextBoxColumn basimYili;
        private DataGridViewTextBoxColumn isbn;
    }
}
