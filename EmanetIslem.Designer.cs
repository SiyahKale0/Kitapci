namespace Kitapci
{
    partial class EmanetIslem
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            aliciTcTB = new TextBox();
            kitapIsbnTB = new TextBox();
            label2 = new Label();
            iadeDT = new DateTimePicker();
            label4 = new Label();
            kucultme_btn = new Button();
            kapatma_btn = new Button();
            emanetlerData = new DataGridView();
            oduncVer_btn = new Button();
            iadeAl_btn = new Button();
            sureUzat = new Button();
            label3 = new Label();
            gunTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)emanetlerData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(925, 12);
            label1.Name = "label1";
            label1.Size = new Size(121, 41);
            label1.TabIndex = 0;
            label1.Text = "Alıcı TC:";
            // 
            // aliciTcTB
            // 
            aliciTcTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            aliciTcTB.Location = new Point(925, 56);
            aliciTcTB.Name = "aliciTcTB";
            aliciTcTB.Size = new Size(286, 43);
            aliciTcTB.TabIndex = 19;
            // 
            // kitapIsbnTB
            // 
            kitapIsbnTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kitapIsbnTB.Location = new Point(925, 146);
            kitapIsbnTB.Name = "kitapIsbnTB";
            kitapIsbnTB.Size = new Size(286, 43);
            kitapIsbnTB.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(925, 102);
            label2.Name = "label2";
            label2.Size = new Size(163, 41);
            label2.TabIndex = 20;
            label2.Text = "Kitap ISBN:";
            // 
            // iadeDT
            // 
            iadeDT.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            iadeDT.Location = new Point(925, 326);
            iadeDT.Name = "iadeDT";
            iadeDT.Size = new Size(286, 43);
            iadeDT.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(925, 282);
            label4.Name = "label4";
            label4.Size = new Size(159, 41);
            label4.TabIndex = 24;
            label4.Text = "İade Tarihi:";
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
            // emanetlerData
            // 
            emanetlerData.BackgroundColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            emanetlerData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            emanetlerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            emanetlerData.DefaultCellStyle = dataGridViewCellStyle2;
            emanetlerData.Location = new Point(12, 12);
            emanetlerData.Name = "emanetlerData";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            emanetlerData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            emanetlerData.RowHeadersWidth = 51;
            emanetlerData.Size = new Size(898, 736);
            emanetlerData.TabIndex = 28;
            // 
            // oduncVer_btn
            // 
            oduncVer_btn.BackColor = Color.LawnGreen;
            oduncVer_btn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            oduncVer_btn.ForeColor = Color.Black;
            oduncVer_btn.Location = new Point(932, 387);
            oduncVer_btn.Name = "oduncVer_btn";
            oduncVer_btn.Size = new Size(156, 97);
            oduncVer_btn.TabIndex = 29;
            oduncVer_btn.Text = "Ödünç Ver";
            oduncVer_btn.UseVisualStyleBackColor = false;
            oduncVer_btn.Click += oduncVer_btn_Click;
            // 
            // iadeAl_btn
            // 
            iadeAl_btn.BackColor = Color.Aquamarine;
            iadeAl_btn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            iadeAl_btn.ForeColor = Color.Black;
            iadeAl_btn.Location = new Point(932, 490);
            iadeAl_btn.Name = "iadeAl_btn";
            iadeAl_btn.Size = new Size(156, 97);
            iadeAl_btn.TabIndex = 30;
            iadeAl_btn.Text = "İade Al";
            iadeAl_btn.UseVisualStyleBackColor = false;
            // 
            // sureUzat
            // 
            sureUzat.BackColor = Color.Tomato;
            sureUzat.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sureUzat.ForeColor = Color.Black;
            sureUzat.Location = new Point(932, 593);
            sureUzat.Name = "sureUzat";
            sureUzat.Size = new Size(156, 97);
            sureUzat.TabIndex = 31;
            sureUzat.Text = "Süre Uzat";
            sureUzat.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(925, 192);
            label3.Name = "label3";
            label3.Size = new Size(260, 41);
            label3.TabIndex = 22;
            label3.Text = "Alı Konulacak gün:";
            // 
            // gunTB
            // 
            gunTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            gunTB.Location = new Point(925, 236);
            gunTB.Name = "gunTB";
            gunTB.Size = new Size(286, 43);
            gunTB.TabIndex = 32;
            // 
            // EmanetIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(238, 237, 223);
            ClientSize = new Size(1332, 776);
            ControlBox = false;
            Controls.Add(gunTB);
            Controls.Add(sureUzat);
            Controls.Add(iadeAl_btn);
            Controls.Add(oduncVer_btn);
            Controls.Add(emanetlerData);
            Controls.Add(kucultme_btn);
            Controls.Add(kapatma_btn);
            Controls.Add(iadeDT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(kitapIsbnTB);
            Controls.Add(label2);
            Controls.Add(aliciTcTB);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(238, 237, 223);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmanetIslem";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "EmanetIslem";
            Load += EmanetIslem_Load;
            MouseDown += EmanetIslem_MouseDown;
            MouseMove += EmanetIslem_MouseMove;
            MouseUp += EmanetIslem_MouseUp;
            ((System.ComponentModel.ISupportInitialize)emanetlerData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox aliciTcTB;
        private TextBox kitapIsbnTB;
        private Label label2;
        private DateTimePicker iadeDT;
        private Label label4;
        private Button kucultme_btn;
        private Button kapatma_btn;
        private DataGridView emanetlerData;
        private Button oduncVer_btn;
        private Button iadeAl_btn;
        private Button sureUzat;
        private Label label3;
        private TextBox gunTB;
    }
}