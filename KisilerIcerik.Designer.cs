﻿namespace Kitapci
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 331);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "KisilerİcerikAktif";
            // 
            // KisilerIcerik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "KisilerIcerik";
            Size = new Size(763, 682);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
