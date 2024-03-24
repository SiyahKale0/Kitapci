namespace Kitapci
{
    partial class KisilerIcerik
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            kisilerData = new DataGridView();
            tcNo = new DataGridViewTextBoxColumn();
            isim = new DataGridViewTextBoxColumn();
            soyisim = new DataGridViewTextBoxColumn();
            telNO = new DataGridViewTextBoxColumn();
            ePosta = new DataGridViewTextBoxColumn();
            kisiEkle_btn = new Button();
            kisiSil_btn = new Button();
            kisiGuncelle_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)kisilerData).BeginInit();
            SuspendLayout();
            // 
            // kisilerData
            // 
            kisilerData.BackgroundColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            kisilerData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            kisilerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kisilerData.Columns.AddRange(new DataGridViewColumn[] { tcNo, isim, soyisim, telNO, ePosta });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            kisilerData.DefaultCellStyle = dataGridViewCellStyle15;
            kisilerData.Location = new Point(0, 0);
            kisilerData.Name = "kisilerData";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.Transparent;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            kisilerData.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            kisilerData.RowHeadersWidth = 51;
            kisilerData.Size = new Size(760, 592);
            kisilerData.TabIndex = 0;
            // 
            // tcNo
            // 
            dataGridViewCellStyle10.BackColor = Color.FromArgb(238, 237, 223);
            tcNo.DefaultCellStyle = dataGridViewCellStyle10;
            tcNo.HeaderText = "TC NO";
            tcNo.MinimumWidth = 6;
            tcNo.Name = "tcNo";
            tcNo.Width = 125;
            // 
            // isim
            // 
            dataGridViewCellStyle11.BackColor = Color.FromArgb(238, 237, 223);
            isim.DefaultCellStyle = dataGridViewCellStyle11;
            isim.HeaderText = "İSİM";
            isim.MinimumWidth = 6;
            isim.Name = "isim";
            isim.Width = 125;
            // 
            // soyisim
            // 
            dataGridViewCellStyle12.BackColor = Color.FromArgb(238, 237, 223);
            soyisim.DefaultCellStyle = dataGridViewCellStyle12;
            soyisim.HeaderText = "SOYİSİM";
            soyisim.MinimumWidth = 6;
            soyisim.Name = "soyisim";
            soyisim.Width = 125;
            // 
            // telNO
            // 
            dataGridViewCellStyle13.BackColor = Color.FromArgb(238, 237, 223);
            telNO.DefaultCellStyle = dataGridViewCellStyle13;
            telNO.HeaderText = "TELEFON NO";
            telNO.MinimumWidth = 6;
            telNO.Name = "telNO";
            telNO.Width = 125;
            // 
            // ePosta
            // 
            dataGridViewCellStyle14.BackColor = Color.FromArgb(238, 237, 223);
            ePosta.DefaultCellStyle = dataGridViewCellStyle14;
            ePosta.HeaderText = "E-POSTA";
            ePosta.MinimumWidth = 6;
            ePosta.Name = "ePosta";
            ePosta.Width = 125;
            // 
            // kisiEkle_btn
            // 
            kisiEkle_btn.BackColor = Color.LightGreen;
            kisiEkle_btn.FlatAppearance.BorderColor = Color.Black;
            kisiEkle_btn.FlatStyle = FlatStyle.Flat;
            kisiEkle_btn.Font = new Font("Segoe UI", 13.8F);
            kisiEkle_btn.Location = new Point(3, 598);
            kisiEkle_btn.Name = "kisiEkle_btn";
            kisiEkle_btn.Size = new Size(154, 81);
            kisiEkle_btn.TabIndex = 1;
            kisiEkle_btn.Text = "Kişi Ekle";
            kisiEkle_btn.UseVisualStyleBackColor = false;
            // 
            // kisiSil_btn
            // 
            kisiSil_btn.BackColor = Color.LightCoral;
            kisiSil_btn.FlatAppearance.BorderColor = Color.Black;
            kisiSil_btn.FlatStyle = FlatStyle.Flat;
            kisiSil_btn.Font = new Font("Segoe UI", 13.8F);
            kisiSil_btn.Location = new Point(188, 598);
            kisiSil_btn.Name = "kisiSil_btn";
            kisiSil_btn.Size = new Size(154, 81);
            kisiSil_btn.TabIndex = 2;
            kisiSil_btn.Text = "Kişi Sil";
            kisiSil_btn.UseVisualStyleBackColor = false;
            // 
            // kisiGuncelle_btn
            // 
            kisiGuncelle_btn.BackColor = Color.Turquoise;
            kisiGuncelle_btn.FlatAppearance.BorderColor = Color.Black;
            kisiGuncelle_btn.FlatStyle = FlatStyle.Flat;
            kisiGuncelle_btn.Font = new Font("Segoe UI", 13.8F);
            kisiGuncelle_btn.Location = new Point(370, 598);
            kisiGuncelle_btn.Name = "kisiGuncelle_btn";
            kisiGuncelle_btn.Size = new Size(154, 81);
            kisiGuncelle_btn.TabIndex = 3;
            kisiGuncelle_btn.Text = "Kişi Güncelle";
            kisiGuncelle_btn.UseVisualStyleBackColor = false;
            // 
            // KisilerIcerik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(kisiGuncelle_btn);
            Controls.Add(kisiSil_btn);
            Controls.Add(kisiEkle_btn);
            Controls.Add(kisilerData);
            Margin = new Padding(0);
            Name = "KisilerIcerik";
            Size = new Size(763, 682);
            ((System.ComponentModel.ISupportInitialize)kisilerData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView kisilerData;
        private Button kisiEkle_btn;
        private Button kisiSil_btn;
        private Button kisiGuncelle_btn;
        private DataGridViewTextBoxColumn tcNo;
        private DataGridViewTextBoxColumn isim;
        private DataGridViewTextBoxColumn soyisim;
        private DataGridViewTextBoxColumn telNO;
        private DataGridViewTextBoxColumn ePosta;
    }
}
