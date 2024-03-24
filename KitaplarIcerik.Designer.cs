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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            kisilerData = new DataGridView();
            baslik = new DataGridViewTextBoxColumn();
            yazar = new DataGridViewTextBoxColumn();
            yayinEvi = new DataGridViewTextBoxColumn();
            sayfaSayisi = new DataGridViewTextBoxColumn();
            basimYili = new DataGridViewTextBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            kitapGuncelle_btn = new Button();
            kitapSil_btn = new Button();
            kitapEkle_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)kisilerData).BeginInit();
            SuspendLayout();
            // 
            // kisilerData
            // 
            kisilerData.BackgroundColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            kisilerData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            kisilerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kisilerData.Columns.AddRange(new DataGridViewColumn[] { baslik, yazar, yayinEvi, sayfaSayisi, basimYili, isbn });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            kisilerData.DefaultCellStyle = dataGridViewCellStyle5;
            kisilerData.Location = new Point(1, 2);
            kisilerData.Name = "kisilerData";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Transparent;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            kisilerData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            kisilerData.RowHeadersWidth = 51;
            kisilerData.Size = new Size(760, 592);
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
            // kitapGuncelle_btn
            // 
            kitapGuncelle_btn.BackColor = Color.Turquoise;
            kitapGuncelle_btn.FlatAppearance.BorderColor = Color.Black;
            kitapGuncelle_btn.FlatStyle = FlatStyle.Flat;
            kitapGuncelle_btn.Font = new Font("Segoe UI", 13.8F);
            kitapGuncelle_btn.Location = new Point(371, 600);
            kitapGuncelle_btn.Name = "kitapGuncelle_btn";
            kitapGuncelle_btn.Size = new Size(154, 81);
            kitapGuncelle_btn.TabIndex = 7;
            kitapGuncelle_btn.Text = "Kitap Güncelle";
            kitapGuncelle_btn.UseVisualStyleBackColor = false;
            // 
            // kitapSil_btn
            // 
            kitapSil_btn.BackColor = Color.LightCoral;
            kitapSil_btn.FlatAppearance.BorderColor = Color.Black;
            kitapSil_btn.FlatStyle = FlatStyle.Flat;
            kitapSil_btn.Font = new Font("Segoe UI", 13.8F);
            kitapSil_btn.Location = new Point(189, 600);
            kitapSil_btn.Name = "kitapSil_btn";
            kitapSil_btn.Size = new Size(154, 81);
            kitapSil_btn.TabIndex = 6;
            kitapSil_btn.Text = "Kitap Sil";
            kitapSil_btn.UseVisualStyleBackColor = false;
            // 
            // kitapEkle_btn
            // 
            kitapEkle_btn.BackColor = Color.LightGreen;
            kitapEkle_btn.FlatAppearance.BorderColor = Color.Black;
            kitapEkle_btn.FlatStyle = FlatStyle.Flat;
            kitapEkle_btn.Font = new Font("Segoe UI", 13.8F);
            kitapEkle_btn.Location = new Point(4, 600);
            kitapEkle_btn.Name = "kitapEkle_btn";
            kitapEkle_btn.Size = new Size(154, 81);
            kitapEkle_btn.TabIndex = 5;
            kitapEkle_btn.Text = "Kitap Ekle";
            kitapEkle_btn.UseVisualStyleBackColor = false;
            // 
            // KitaplarIcerik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 237, 223);
            Controls.Add(kisilerData);
            Controls.Add(kitapGuncelle_btn);
            Controls.Add(kitapSil_btn);
            Controls.Add(kitapEkle_btn);
            Margin = new Padding(0);
            Name = "KitaplarIcerik";
            Size = new Size(763, 682);
            ((System.ComponentModel.ISupportInitialize)kisilerData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView kisilerData;
        private Button kitapGuncelle_btn;
        private Button kitapSil_btn;
        private Button kitapEkle_btn;
        private DataGridViewTextBoxColumn baslik;
        private DataGridViewTextBoxColumn yazar;
        private DataGridViewTextBoxColumn yayinEvi;
        private DataGridViewTextBoxColumn sayfaSayisi;
        private DataGridViewTextBoxColumn basimYili;
        private DataGridViewTextBoxColumn isbn;
    }
}
