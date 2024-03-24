namespace Kitapci
{
    partial class EmanetlerIcerik
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            kisilerData = new DataGridView();
            kisiGuncelle_btn = new Button();
            kisiSil_btn = new Button();
            kisiEkle_btn = new Button();
            aliciTc = new DataGridViewTextBoxColumn();
            kitapIsbn = new DataGridViewTextBoxColumn();
            alimTarihi = new DataGridViewTextBoxColumn();
            iadeTarihi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)kisilerData).BeginInit();
            SuspendLayout();
            // 
            // kisilerData
            // 
            kisilerData.BackgroundColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            kisilerData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            kisilerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kisilerData.Columns.AddRange(new DataGridViewColumn[] { aliciTc, kitapIsbn, alimTarihi, iadeTarihi });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            kisilerData.DefaultCellStyle = dataGridViewCellStyle8;
            kisilerData.Location = new Point(1, 2);
            kisilerData.Name = "kisilerData";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Transparent;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            kisilerData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            kisilerData.RowHeadersWidth = 51;
            kisilerData.Size = new Size(760, 592);
            kisilerData.TabIndex = 4;
            // 
            // kisiGuncelle_btn
            // 
            kisiGuncelle_btn.BackColor = Color.LightCoral;
            kisiGuncelle_btn.FlatAppearance.BorderColor = Color.Black;
            kisiGuncelle_btn.FlatStyle = FlatStyle.Flat;
            kisiGuncelle_btn.Font = new Font("Segoe UI", 13.8F);
            kisiGuncelle_btn.Location = new Point(371, 600);
            kisiGuncelle_btn.Name = "kisiGuncelle_btn";
            kisiGuncelle_btn.Size = new Size(154, 81);
            kisiGuncelle_btn.TabIndex = 7;
            kisiGuncelle_btn.Text = "Süre Uzat";
            kisiGuncelle_btn.UseVisualStyleBackColor = false;
            // 
            // kisiSil_btn
            // 
            kisiSil_btn.BackColor = Color.Turquoise;
            kisiSil_btn.FlatAppearance.BorderColor = Color.Black;
            kisiSil_btn.FlatStyle = FlatStyle.Flat;
            kisiSil_btn.Font = new Font("Segoe UI", 13.8F);
            kisiSil_btn.Location = new Point(189, 600);
            kisiSil_btn.Name = "kisiSil_btn";
            kisiSil_btn.Size = new Size(154, 81);
            kisiSil_btn.TabIndex = 6;
            kisiSil_btn.Text = "İade Al";
            kisiSil_btn.UseVisualStyleBackColor = false;
            // 
            // kisiEkle_btn
            // 
            kisiEkle_btn.BackColor = Color.LightGreen;
            kisiEkle_btn.FlatAppearance.BorderColor = Color.Black;
            kisiEkle_btn.FlatStyle = FlatStyle.Flat;
            kisiEkle_btn.Font = new Font("Segoe UI", 13.8F);
            kisiEkle_btn.Location = new Point(4, 600);
            kisiEkle_btn.Name = "kisiEkle_btn";
            kisiEkle_btn.Size = new Size(154, 81);
            kisiEkle_btn.TabIndex = 5;
            kisiEkle_btn.Text = "Ödünç Ver";
            kisiEkle_btn.UseVisualStyleBackColor = false;
            // 
            // aliciTc
            // 
            aliciTc.HeaderText = "Alıcı TC";
            aliciTc.MinimumWidth = 6;
            aliciTc.Name = "aliciTc";
            aliciTc.Width = 125;
            // 
            // kitapIsbn
            // 
            kitapIsbn.HeaderText = "Kitap ISBN";
            kitapIsbn.MinimumWidth = 6;
            kitapIsbn.Name = "kitapIsbn";
            kitapIsbn.Width = 125;
            // 
            // alimTarihi
            // 
            alimTarihi.HeaderText = "Alım Tarihi";
            alimTarihi.MinimumWidth = 6;
            alimTarihi.Name = "alimTarihi";
            alimTarihi.Width = 125;
            // 
            // iadeTarihi
            // 
            iadeTarihi.HeaderText = "İade Tarihi";
            iadeTarihi.MinimumWidth = 6;
            iadeTarihi.Name = "iadeTarihi";
            iadeTarihi.Width = 125;
            // 
            // EmanetlerIcerik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 237, 223);
            Controls.Add(kisilerData);
            Controls.Add(kisiGuncelle_btn);
            Controls.Add(kisiSil_btn);
            Controls.Add(kisiEkle_btn);
            Margin = new Padding(0);
            Name = "EmanetlerIcerik";
            Size = new Size(763, 682);
            ((System.ComponentModel.ISupportInitialize)kisilerData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView kisilerData;
        private Button kisiGuncelle_btn;
        private Button kisiSil_btn;
        private Button kisiEkle_btn;
        private DataGridViewTextBoxColumn aliciTc;
        private DataGridViewTextBoxColumn kitapIsbn;
        private DataGridViewTextBoxColumn alimTarihi;
        private DataGridViewTextBoxColumn iadeTarihi;
    }
}
