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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            kisilerData = new DataGridView();
            tcNo = new DataGridViewTextBoxColumn();
            isim = new DataGridViewTextBoxColumn();
            soyisim = new DataGridViewTextBoxColumn();
            telNO = new DataGridViewTextBoxColumn();
            ePosta = new DataGridViewTextBoxColumn();
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
            kisilerData.Columns.AddRange(new DataGridViewColumn[] { tcNo, isim, soyisim, telNO, ePosta });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            kisilerData.DefaultCellStyle = dataGridViewCellStyle7;
            kisilerData.Location = new Point(0, 0);
            kisilerData.Name = "kisilerData";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Transparent;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            kisilerData.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            kisilerData.RowHeadersWidth = 51;
            kisilerData.Size = new Size(760, 679);
            kisilerData.TabIndex = 0;
            // 
            // tcNo
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 237, 223);
            tcNo.DefaultCellStyle = dataGridViewCellStyle2;
            tcNo.HeaderText = "TC NO";
            tcNo.MinimumWidth = 6;
            tcNo.Name = "tcNo";
            tcNo.Width = 125;
            // 
            // isim
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(238, 237, 223);
            isim.DefaultCellStyle = dataGridViewCellStyle3;
            isim.HeaderText = "İSİM";
            isim.MinimumWidth = 6;
            isim.Name = "isim";
            isim.Width = 125;
            // 
            // soyisim
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(238, 237, 223);
            soyisim.DefaultCellStyle = dataGridViewCellStyle4;
            soyisim.HeaderText = "SOYİSİM";
            soyisim.MinimumWidth = 6;
            soyisim.Name = "soyisim";
            soyisim.Width = 125;
            // 
            // telNO
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(238, 237, 223);
            telNO.DefaultCellStyle = dataGridViewCellStyle5;
            telNO.HeaderText = "TELEFON NO";
            telNO.MinimumWidth = 6;
            telNO.Name = "telNO";
            telNO.Width = 125;
            // 
            // ePosta
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(238, 237, 223);
            ePosta.DefaultCellStyle = dataGridViewCellStyle6;
            ePosta.HeaderText = "E-POSTA";
            ePosta.MinimumWidth = 6;
            ePosta.Name = "ePosta";
            ePosta.Width = 125;
            // 
            // KisilerIcerik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(kisilerData);
            Margin = new Padding(0);
            Name = "KisilerIcerik";
            Size = new Size(763, 682);
            ((System.ComponentModel.ISupportInitialize)kisilerData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView kisilerData;
        private DataGridViewTextBoxColumn tcNo;
        private DataGridViewTextBoxColumn isim;
        private DataGridViewTextBoxColumn soyisim;
        private DataGridViewTextBoxColumn telNO;
        private DataGridViewTextBoxColumn ePosta;
    }
}
