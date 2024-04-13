namespace Kitapci
{
    partial class KitapIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            baslikTB = new TextBox();
            yazarTB = new TextBox();
            label2 = new Label();
            kucultme_btn = new Button();
            kapatma_btn = new Button();
            kitapEkle_btn = new Button();
            kitapGnclle_btn = new Button();
            kitapSil_btn = new Button();
            label3 = new Label();
            adetTB = new TextBox();
            kitapdata = new DataGridView();
            basimTB = new TextBox();
            label4 = new Label();
            sayfaTB = new TextBox();
            label5 = new Label();
            yayineviTB = new TextBox();
            label6 = new Label();
            isbnTB = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)kitapdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(925, 12);
            label1.Name = "label1";
            label1.Size = new Size(99, 41);
            label1.TabIndex = 0;
            label1.Text = "Başlık:";
            // 
            // baslikTB
            // 
            baslikTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            baslikTB.Location = new Point(925, 56);
            baslikTB.Name = "baslikTB";
            baslikTB.Size = new Size(286, 43);
            baslikTB.TabIndex = 19;
            // 
            // yazarTB
            // 
            yazarTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            yazarTB.Location = new Point(925, 146);
            yazarTB.Name = "yazarTB";
            yazarTB.Size = new Size(286, 43);
            yazarTB.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(925, 102);
            label2.Name = "label2";
            label2.Size = new Size(93, 41);
            label2.TabIndex = 20;
            label2.Text = "Yazar:";
            // 
            // kucultme_btn
            // 
            kucultme_btn.BackColor = Color.FromArgb(238, 237, 223);
            kucultme_btn.FlatAppearance.BorderSize = 0;
            kucultme_btn.FlatStyle = FlatStyle.Flat;
            kucultme_btn.Image = Properties.Resources.kucultme_icon;
            kucultme_btn.Location = new Point(1231, 5);
            kucultme_btn.Name = "kucultme_btn";
            kucultme_btn.Size = new Size(47, 48);
            kucultme_btn.TabIndex = 27;
            kucultme_btn.UseVisualStyleBackColor = false;
            kucultme_btn.Click += kucultme_btn_Click;
            // 
            // kapatma_btn
            // 
            kapatma_btn.BackColor = Color.FromArgb(238, 237, 223);
            kapatma_btn.FlatAppearance.BorderSize = 0;
            kapatma_btn.FlatStyle = FlatStyle.Flat;
            kapatma_btn.Image = Properties.Resources.kapatma_icon;
            kapatma_btn.Location = new Point(1284, 4);
            kapatma_btn.Name = "kapatma_btn";
            kapatma_btn.Size = new Size(47, 49);
            kapatma_btn.TabIndex = 26;
            kapatma_btn.UseVisualStyleBackColor = false;
            kapatma_btn.Click += kapatma_btn_Click;
            // 
            // kitapEkle_btn
            // 
            kitapEkle_btn.BackColor = Color.LawnGreen;
            kitapEkle_btn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kitapEkle_btn.ForeColor = Color.Black;
            kitapEkle_btn.Location = new Point(924, 662);
            kitapEkle_btn.Name = "kitapEkle_btn";
            kitapEkle_btn.Size = new Size(138, 97);
            kitapEkle_btn.TabIndex = 29;
            kitapEkle_btn.Text = "Kitap Ekle";
            kitapEkle_btn.UseVisualStyleBackColor = false;
            kitapEkle_btn.Click += kitapEkle_btn_Click;
            // 
            // kitapGnclle_btn
            // 
            kitapGnclle_btn.BackColor = Color.Aquamarine;
            kitapGnclle_btn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kitapGnclle_btn.ForeColor = Color.Black;
            kitapGnclle_btn.Location = new Point(1068, 662);
            kitapGnclle_btn.Name = "kitapGnclle_btn";
            kitapGnclle_btn.Size = new Size(143, 97);
            kitapGnclle_btn.TabIndex = 30;
            kitapGnclle_btn.Text = "Kitap Güncelle";
            kitapGnclle_btn.UseVisualStyleBackColor = false;
            kitapGnclle_btn.Click += kitapGnclle_btn_Click;
            // 
            // kitapSil_btn
            // 
            kitapSil_btn.BackColor = Color.Tomato;
            kitapSil_btn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kitapSil_btn.ForeColor = Color.Black;
            kitapSil_btn.Location = new Point(1217, 662);
            kitapSil_btn.Name = "kitapSil_btn";
            kitapSil_btn.Size = new Size(119, 97);
            kitapSil_btn.TabIndex = 31;
            kitapSil_btn.Text = "Kitap Sli";
            kitapSil_btn.UseVisualStyleBackColor = false;
            kitapSil_btn.Click += kitapSil_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(925, 192);
            label3.Name = "label3";
            label3.Size = new Size(88, 41);
            label3.TabIndex = 22;
            label3.Text = "Adet:";
            // 
            // adetTB
            // 
            adetTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            adetTB.Location = new Point(925, 236);
            adetTB.Name = "adetTB";
            adetTB.Size = new Size(286, 43);
            adetTB.TabIndex = 32;
            // 
            // kitapdata
            // 
            kitapdata.BackgroundColor = Color.FromArgb(238, 237, 223);
            kitapdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            kitapdata.DefaultCellStyle = dataGridViewCellStyle1;
            kitapdata.Location = new Point(19, 23);
            kitapdata.Name = "kitapdata";
            kitapdata.RowHeadersWidth = 51;
            kitapdata.Size = new Size(900, 765);
            kitapdata.TabIndex = 33;
            kitapdata.CellClick += kitapdata_CellClick;
            // 
            // basimTB
            // 
            basimTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            basimTB.Location = new Point(925, 506);
            basimTB.Name = "basimTB";
            basimTB.Size = new Size(286, 43);
            basimTB.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(925, 462);
            label4.Name = "label4";
            label4.Size = new Size(149, 41);
            label4.TabIndex = 38;
            label4.Text = "Basım Yılı:";
            // 
            // sayfaTB
            // 
            sayfaTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sayfaTB.Location = new Point(925, 416);
            sayfaTB.Name = "sayfaTB";
            sayfaTB.Size = new Size(286, 43);
            sayfaTB.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(925, 372);
            label5.Name = "label5";
            label5.Size = new Size(176, 41);
            label5.TabIndex = 36;
            label5.Text = "Sayfa Sayısı:";
            // 
            // yayineviTB
            // 
            yayineviTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            yayineviTB.Location = new Point(925, 326);
            yayineviTB.Name = "yayineviTB";
            yayineviTB.Size = new Size(286, 43);
            yayineviTB.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(925, 282);
            label6.Name = "label6";
            label6.Size = new Size(137, 41);
            label6.TabIndex = 34;
            label6.Text = "Yayın Evi:";
            // 
            // isbnTB
            // 
            isbnTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            isbnTB.Location = new Point(925, 596);
            isbnTB.Name = "isbnTB";
            isbnTB.Size = new Size(286, 43);
            isbnTB.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(925, 552);
            label7.Name = "label7";
            label7.Size = new Size(88, 41);
            label7.TabIndex = 40;
            label7.Text = "ISBN:";
            // 
            // KitapIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(238, 237, 223);
            ClientSize = new Size(1347, 798);
            ControlBox = false;
            Controls.Add(isbnTB);
            Controls.Add(label7);
            Controls.Add(basimTB);
            Controls.Add(label4);
            Controls.Add(sayfaTB);
            Controls.Add(label5);
            Controls.Add(yayineviTB);
            Controls.Add(label6);
            Controls.Add(kitapdata);
            Controls.Add(adetTB);
            Controls.Add(kitapSil_btn);
            Controls.Add(kitapGnclle_btn);
            Controls.Add(kitapEkle_btn);
            Controls.Add(kucultme_btn);
            Controls.Add(kapatma_btn);
            Controls.Add(label3);
            Controls.Add(yazarTB);
            Controls.Add(label2);
            Controls.Add(baslikTB);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(238, 237, 223);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KitapIslem";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "EmanetIslem";
            Load += KitapIslem_Load;
            MouseDown += KitapIslem_MouseDown;
            MouseMove += KitapIslem_MouseMove;
            MouseUp += KitapIslem_MouseUp;
            ((System.ComponentModel.ISupportInitialize)kitapdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox baslikTB;
        private TextBox yazarTB;
        private Label label2;
        private Button kucultme_btn;
        private Button kapatma_btn;
        private Button kitapEkle_btn;
        private Button kitapGnclle_btn;
        private Button kitapSil_btn;
        private Label label3;
        private TextBox adetTB;
        private DataGridView kitapdata;
        private TextBox basimTB;
        private Label label4;
        private TextBox sayfaTB;
        private Label label5;
        private TextBox yayineviTB;
        private Label label6;
        private TextBox isbnTB;
        private Label label7;
    }
}
