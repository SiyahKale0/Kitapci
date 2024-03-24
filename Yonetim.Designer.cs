namespace Kitapci
{
    partial class Yonetim
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logo_txt = new Label();
            baslik_txt = new Label();
            kapatma_btn = new Button();
            kucultme_btn = new Button();
            kisiler_btn = new Button();
            kitaplar_btn = new Button();
            emanetler_btn = new Button();
            icerik = new Panel();
            SuspendLayout();
            // 
            // logo_txt
            // 
            logo_txt.AutoSize = true;
            logo_txt.BackColor = Color.Transparent;
            logo_txt.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            logo_txt.ForeColor = Color.FromArgb(80, 70, 70);
            logo_txt.Location = new Point(44, -16);
            logo_txt.Name = "logo_txt";
            logo_txt.Size = new Size(155, 106);
            logo_txt.TabIndex = 0;
            logo_txt.Text = "📖";
            // 
            // baslik_txt
            // 
            baslik_txt.AutoSize = true;
            baslik_txt.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            baslik_txt.ForeColor = Color.FromArgb(80, 70, 70);
            baslik_txt.Location = new Point(11, 90);
            baslik_txt.Name = "baslik_txt";
            baslik_txt.Size = new Size(210, 74);
            baslik_txt.TabIndex = 1;
            baslik_txt.Text = " Kütüphane \r\nYönetim";
            baslik_txt.TextAlign = ContentAlignment.TopCenter;
            // 
            // kapatma_btn
            // 
            kapatma_btn.BackColor = Color.FromArgb(238, 237, 223);
            kapatma_btn.FlatAppearance.BorderSize = 0;
            kapatma_btn.FlatStyle = FlatStyle.Flat;
            kapatma_btn.Image = Properties.Resources.kapatma_icon;
            kapatma_btn.Location = new Point(955, -2);
            kapatma_btn.Name = "kapatma_btn";
            kapatma_btn.Size = new Size(47, 49);
            kapatma_btn.TabIndex = 11;
            kapatma_btn.UseVisualStyleBackColor = false;
            kapatma_btn.Click += kapatma_Click;
            // 
            // kucultme_btn
            // 
            kucultme_btn.BackColor = Color.FromArgb(238, 237, 223);
            kucultme_btn.FlatAppearance.BorderSize = 0;
            kucultme_btn.FlatStyle = FlatStyle.Flat;
            kucultme_btn.Image = Properties.Resources.kucultme_icon;
            kucultme_btn.Location = new Point(902, -1);
            kucultme_btn.Name = "kucultme_btn";
            kucultme_btn.Size = new Size(47, 48);
            kucultme_btn.TabIndex = 12;
            kucultme_btn.UseVisualStyleBackColor = false;
            kucultme_btn.Click += kucult_Click;
            // 
            // kisiler_btn
            // 
            kisiler_btn.BackColor = Color.FromArgb(255, 196, 156);
            kisiler_btn.FlatAppearance.BorderColor = Color.Black;
            kisiler_btn.FlatStyle = FlatStyle.Flat;
            kisiler_btn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kisiler_btn.ForeColor = Color.FromArgb(80, 70, 70);
            kisiler_btn.Location = new Point(21, 187);
            kisiler_btn.Name = "kisiler_btn";
            kisiler_btn.Size = new Size(191, 101);
            kisiler_btn.TabIndex = 14;
            kisiler_btn.Text = "Kişiler";
            kisiler_btn.UseVisualStyleBackColor = false;
            kisiler_btn.Click += kisiler_btn_Click;
            // 
            // kitaplar_btn
            // 
            kitaplar_btn.BackColor = Color.FromArgb(255, 196, 156);
            kitaplar_btn.FlatAppearance.BorderColor = Color.Black;
            kitaplar_btn.FlatStyle = FlatStyle.Flat;
            kitaplar_btn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kitaplar_btn.ForeColor = Color.FromArgb(80, 70, 70);
            kitaplar_btn.Location = new Point(21, 322);
            kitaplar_btn.Name = "kitaplar_btn";
            kitaplar_btn.Size = new Size(191, 101);
            kitaplar_btn.TabIndex = 15;
            kitaplar_btn.Text = "Kitaplar";
            kitaplar_btn.UseVisualStyleBackColor = false;
            kitaplar_btn.Click += kitaplar_btn_Click;
            // 
            // emanetler_btn
            // 
            emanetler_btn.BackColor = Color.FromArgb(255, 196, 156);
            emanetler_btn.FlatAppearance.BorderColor = Color.Black;
            emanetler_btn.FlatStyle = FlatStyle.Flat;
            emanetler_btn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emanetler_btn.ForeColor = Color.FromArgb(80, 70, 70);
            emanetler_btn.Location = new Point(21, 458);
            emanetler_btn.Name = "emanetler_btn";
            emanetler_btn.Size = new Size(191, 101);
            emanetler_btn.TabIndex = 16;
            emanetler_btn.Text = "Emanetler";
            emanetler_btn.UseVisualStyleBackColor = false;
            emanetler_btn.Click += emanetler_btn_Click;
            // 
            // icerik
            // 
            icerik.Location = new Point(227, 53);
            icerik.Name = "icerik";
            icerik.Size = new Size(763, 682);
            icerik.TabIndex = 17;
            // 
            // Yonetim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(238, 237, 223);
            ClientSize = new Size(1002, 747);
            Controls.Add(icerik);
            Controls.Add(emanetler_btn);
            Controls.Add(kitaplar_btn);
            Controls.Add(kisiler_btn);
            Controls.Add(kucultme_btn);
            Controls.Add(kapatma_btn);
            Controls.Add(baslik_txt);
            Controls.Add(logo_txt);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Yonetim";
            Text = "Kütüphane Yöntim Sistemi";
            TopMost = true;
            Load += Yonetim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logo_txt;
        private Label baslik_txt;
        private Button kapatma_btn;
        private Button kucultme_btn;
        private Button kisiler_btn;
        private Button kitaplar_btn;
        private Button emanetler_btn;
        private Panel icerik;
    }
}
