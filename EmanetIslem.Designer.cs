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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            kucultme_btn = new Button();
            kapatma_btn = new Button();
            kisilerData = new DataGridView();
            aliciTc = new DataGridViewTextBoxColumn();
            kitapIsbn = new DataGridViewTextBoxColumn();
            alimTarihi = new DataGridViewTextBoxColumn();
            iadeTarihi = new DataGridViewTextBoxColumn();
            oduncVer_btn = new Button();
            iadeAl_btn = new Button();
            sureUzat = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)kisilerData).BeginInit();
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(925, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 43);
            textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(925, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 43);
            textBox2.TabIndex = 21;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker2.Location = new Point(925, 326);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(286, 43);
            dateTimePicker2.TabIndex = 25;
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
            kisilerData.Columns.AddRange(new DataGridViewColumn[] { aliciTc, kitapIsbn, alimTarihi, iadeTarihi });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(238, 237, 223);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            kisilerData.DefaultCellStyle = dataGridViewCellStyle5;
            kisilerData.Location = new Point(12, 12);
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
            kisilerData.Size = new Size(898, 736);
            kisilerData.TabIndex = 28;
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(925, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 43);
            textBox3.TabIndex = 32;
            // 
            // EmanetIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(238, 237, 223);
            ClientSize = new Size(1332, 776);
            ControlBox = false;
            Controls.Add(textBox3);
            Controls.Add(sureUzat);
            Controls.Add(iadeAl_btn);
            Controls.Add(oduncVer_btn);
            Controls.Add(kisilerData);
            Controls.Add(kucultme_btn);
            Controls.Add(kapatma_btn);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
            ((System.ComponentModel.ISupportInitialize)kisilerData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Button kucultme_btn;
        private Button kapatma_btn;
        private DataGridView kisilerData;
        private DataGridViewTextBoxColumn aliciTc;
        private DataGridViewTextBoxColumn kitapIsbn;
        private DataGridViewTextBoxColumn alimTarihi;
        private DataGridViewTextBoxColumn iadeTarihi;
        private Button oduncVer_btn;
        private Button iadeAl_btn;
        private Button sureUzat;
        private Label label3;
        private TextBox textBox3;
    }
}