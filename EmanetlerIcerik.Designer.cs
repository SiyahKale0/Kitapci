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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            kisilerData = new DataGridView();
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
            kisilerData.Columns.AddRange(new DataGridViewColumn[] { aliciTc, kitapIsbn, alimTarihi, iadeTarihi });
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
            Margin = new Padding(0);
            Name = "EmanetlerIcerik";
            Size = new Size(763, 682);
            ((System.ComponentModel.ISupportInitialize)kisilerData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView kisilerData;
        private DataGridViewTextBoxColumn aliciTc;
        private DataGridViewTextBoxColumn kitapIsbn;
        private DataGridViewTextBoxColumn alimTarihi;
        private DataGridViewTextBoxColumn iadeTarihi;
    }
}
