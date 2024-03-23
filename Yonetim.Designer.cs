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
            button1 = new Button();
            SuspendLayout();
            // 
            // logo_txt
            // 
            logo_txt.AutoSize = true;
            logo_txt.BackColor = Color.Transparent;
            logo_txt.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            logo_txt.ForeColor = Color.FromArgb(80, 70, 70);
            logo_txt.Location = new Point(35, -17);
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
            baslik_txt.Location = new Point(2, 89);
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
            kapatma_btn.Location = new Point(1001, 12);
            kapatma_btn.Name = "kapatma_btn";
            kapatma_btn.Size = new Size(47, 49);
            kapatma_btn.TabIndex = 11;
            kapatma_btn.UseVisualStyleBackColor = false;
            kapatma_btn.Click += kapatma_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(238, 237, 223);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.kucultme_icon;
            button1.Location = new Point(948, 13);
            button1.Name = "button1";
            button1.Size = new Size(47, 48);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            // 
            // Yonetim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(238, 237, 223);
            ClientSize = new Size(1060, 665);
            Controls.Add(button1);
            Controls.Add(kapatma_btn);
            Controls.Add(baslik_txt);
            Controls.Add(logo_txt);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Yonetim";
            Text = "Kütüphane Yöntim Sistemi";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logo_txt;
        private Label baslik_txt;
        private Button kapatma_btn;
        private Button button1;
    }
}
