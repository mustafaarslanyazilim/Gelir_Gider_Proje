namespace Gelir_Gider_Proje
{
    partial class Gelir
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtGelirAciklama = new System.Windows.Forms.TextBox();
            this.MskGelirTutar = new System.Windows.Forms.MaskedTextBox();
            this.TxtGelirID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridGELİR = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnGelirRaporlar = new System.Windows.Forms.Button();
            this.BtnGelirTemizle = new System.Windows.Forms.Button();
            this.BtnGelirGüncelle = new System.Windows.Forms.Button();
            this.BtnGelirSil = new System.Windows.Forms.Button();
            this.BtnGelirKaydet = new System.Windows.Forms.Button();
            this.BtnGelirListele = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MskToplamGelir = new System.Windows.Forms.MaskedTextBox();
            this.MskGelirTarih = new System.Windows.Forms.MaskedTextBox();
            this.gelir_Gider_ProjeDataSet9 = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet9();
            this.tblGelirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_GelirTableAdapter = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet9TableAdapters.Tbl_GelirTableAdapter();
            this.gelirIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirToplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGELİR)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGelirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskGelirTarih);
            this.groupBox1.Controls.Add(this.MskToplamGelir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtGelirAciklama);
            this.groupBox1.Controls.Add(this.MskGelirTutar);
            this.groupBox1.Controls.Add(this.TxtGelirID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelir Tablosu";
            // 
            // TxtGelirAciklama
            // 
            this.TxtGelirAciklama.Location = new System.Drawing.Point(113, 170);
            this.TxtGelirAciklama.Multiline = true;
            this.TxtGelirAciklama.Name = "TxtGelirAciklama";
            this.TxtGelirAciklama.Size = new System.Drawing.Size(249, 67);
            this.TxtGelirAciklama.TabIndex = 6;
            // 
            // MskGelirTutar
            // 
            this.MskGelirTutar.Location = new System.Drawing.Point(113, 127);
            this.MskGelirTutar.Mask = "00000";
            this.MskGelirTutar.Name = "MskGelirTutar";
            this.MskGelirTutar.Size = new System.Drawing.Size(155, 22);
            this.MskGelirTutar.TabIndex = 5;
            this.MskGelirTutar.ValidatingType = typeof(int);
            // 
            // TxtGelirID
            // 
            this.TxtGelirID.Location = new System.Drawing.Point(113, 41);
            this.TxtGelirID.Name = "TxtGelirID";
            this.TxtGelirID.Size = new System.Drawing.Size(100, 22);
            this.TxtGelirID.TabIndex = 3;
            this.TxtGelirID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gelir Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gelir Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gelir Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gelir ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridGELİR);
            this.groupBox2.Location = new System.Drawing.Point(4, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelir Kayıtları";
            // 
            // dataGridGELİR
            // 
            this.dataGridGELİR.AutoGenerateColumns = false;
            this.dataGridGELİR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGELİR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gelirIDDataGridViewTextBoxColumn,
            this.gelirTarihDataGridViewTextBoxColumn,
            this.gelirTutarDataGridViewTextBoxColumn,
            this.gelirAciklamaDataGridViewTextBoxColumn,
            this.gelirToplamDataGridViewTextBoxColumn});
            this.dataGridGELİR.DataSource = this.tblGelirBindingSource;
            this.dataGridGELİR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGELİR.Location = new System.Drawing.Point(3, 18);
            this.dataGridGELİR.Name = "dataGridGELİR";
            this.dataGridGELİR.RowHeadersWidth = 51;
            this.dataGridGELİR.RowTemplate.Height = 24;
            this.dataGridGELİR.Size = new System.Drawing.Size(896, 194);
            this.dataGridGELİR.TabIndex = 0;
            this.dataGridGELİR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGELİR_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnGelirRaporlar);
            this.groupBox3.Controls.Add(this.BtnGelirTemizle);
            this.groupBox3.Controls.Add(this.BtnGelirGüncelle);
            this.groupBox3.Controls.Add(this.BtnGelirSil);
            this.groupBox3.Controls.Add(this.BtnGelirKaydet);
            this.groupBox3.Controls.Add(this.BtnGelirListele);
            this.groupBox3.Location = new System.Drawing.Point(453, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 292);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // BtnGelirRaporlar
            // 
            this.BtnGelirRaporlar.Location = new System.Drawing.Point(50, 249);
            this.BtnGelirRaporlar.Name = "BtnGelirRaporlar";
            this.BtnGelirRaporlar.Size = new System.Drawing.Size(122, 37);
            this.BtnGelirRaporlar.TabIndex = 5;
            this.BtnGelirRaporlar.Text = "Raporlar";
            this.BtnGelirRaporlar.UseVisualStyleBackColor = true;
            this.BtnGelirRaporlar.Click += new System.EventHandler(this.BtnGelirRaporlar_Click);
            // 
            // BtnGelirTemizle
            // 
            this.BtnGelirTemizle.Location = new System.Drawing.Point(50, 206);
            this.BtnGelirTemizle.Name = "BtnGelirTemizle";
            this.BtnGelirTemizle.Size = new System.Drawing.Size(122, 37);
            this.BtnGelirTemizle.TabIndex = 4;
            this.BtnGelirTemizle.Text = "Temizle";
            this.BtnGelirTemizle.UseVisualStyleBackColor = true;
            this.BtnGelirTemizle.Click += new System.EventHandler(this.BtnGelirTemizle_Click);
            // 
            // BtnGelirGüncelle
            // 
            this.BtnGelirGüncelle.Location = new System.Drawing.Point(50, 163);
            this.BtnGelirGüncelle.Name = "BtnGelirGüncelle";
            this.BtnGelirGüncelle.Size = new System.Drawing.Size(122, 37);
            this.BtnGelirGüncelle.TabIndex = 3;
            this.BtnGelirGüncelle.Text = "Güncelle";
            this.BtnGelirGüncelle.UseVisualStyleBackColor = true;
            this.BtnGelirGüncelle.Click += new System.EventHandler(this.BtnGelirGüncelle_Click);
            // 
            // BtnGelirSil
            // 
            this.BtnGelirSil.Location = new System.Drawing.Point(50, 120);
            this.BtnGelirSil.Name = "BtnGelirSil";
            this.BtnGelirSil.Size = new System.Drawing.Size(122, 37);
            this.BtnGelirSil.TabIndex = 2;
            this.BtnGelirSil.Text = "Sil";
            this.BtnGelirSil.UseVisualStyleBackColor = true;
            this.BtnGelirSil.Click += new System.EventHandler(this.BtnGelirSil_Click);
            // 
            // BtnGelirKaydet
            // 
            this.BtnGelirKaydet.Location = new System.Drawing.Point(50, 77);
            this.BtnGelirKaydet.Name = "BtnGelirKaydet";
            this.BtnGelirKaydet.Size = new System.Drawing.Size(122, 37);
            this.BtnGelirKaydet.TabIndex = 1;
            this.BtnGelirKaydet.Text = "Kaydet";
            this.BtnGelirKaydet.UseVisualStyleBackColor = true;
            this.BtnGelirKaydet.Click += new System.EventHandler(this.BtnGelirKaydet_Click);
            // 
            // BtnGelirListele
            // 
            this.BtnGelirListele.Location = new System.Drawing.Point(50, 34);
            this.BtnGelirListele.Name = "BtnGelirListele";
            this.BtnGelirListele.Size = new System.Drawing.Size(122, 37);
            this.BtnGelirListele.TabIndex = 0;
            this.BtnGelirListele.Text = "Listele";
            this.BtnGelirListele.UseVisualStyleBackColor = true;
            this.BtnGelirListele.Click += new System.EventHandler(this.BtnGelirListele_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Toplam Gelir:";
            // 
            // MskToplamGelir
            // 
            this.MskToplamGelir.Location = new System.Drawing.Point(113, 256);
            this.MskToplamGelir.Mask = "00000";
            this.MskToplamGelir.Name = "MskToplamGelir";
            this.MskToplamGelir.Size = new System.Drawing.Size(155, 22);
            this.MskToplamGelir.TabIndex = 7;
            this.MskToplamGelir.ValidatingType = typeof(int);
            // 
            // MskGelirTarih
            // 
            this.MskGelirTarih.Location = new System.Drawing.Point(114, 82);
            this.MskGelirTarih.Mask = "0/00/0000";
            this.MskGelirTarih.Name = "MskGelirTarih";
            this.MskGelirTarih.Size = new System.Drawing.Size(153, 22);
            this.MskGelirTarih.TabIndex = 8;
            this.MskGelirTarih.ValidatingType = typeof(System.DateTime);
            // 
            // gelir_Gider_ProjeDataSet9
            // 
            this.gelir_Gider_ProjeDataSet9.DataSetName = "Gelir_Gider_ProjeDataSet9";
            this.gelir_Gider_ProjeDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGelirBindingSource
            // 
            this.tblGelirBindingSource.DataMember = "Tbl_Gelir";
            this.tblGelirBindingSource.DataSource = this.gelir_Gider_ProjeDataSet9;
            // 
            // tbl_GelirTableAdapter
            // 
            this.tbl_GelirTableAdapter.ClearBeforeFill = true;
            // 
            // gelirIDDataGridViewTextBoxColumn
            // 
            this.gelirIDDataGridViewTextBoxColumn.DataPropertyName = "GelirID";
            this.gelirIDDataGridViewTextBoxColumn.HeaderText = "GelirID";
            this.gelirIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gelirIDDataGridViewTextBoxColumn.Name = "gelirIDDataGridViewTextBoxColumn";
            this.gelirIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gelirTarihDataGridViewTextBoxColumn
            // 
            this.gelirTarihDataGridViewTextBoxColumn.DataPropertyName = "GelirTarih";
            this.gelirTarihDataGridViewTextBoxColumn.HeaderText = "GelirTarih";
            this.gelirTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gelirTarihDataGridViewTextBoxColumn.Name = "gelirTarihDataGridViewTextBoxColumn";
            this.gelirTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // gelirTutarDataGridViewTextBoxColumn
            // 
            this.gelirTutarDataGridViewTextBoxColumn.DataPropertyName = "GelirTutar";
            this.gelirTutarDataGridViewTextBoxColumn.HeaderText = "GelirTutar";
            this.gelirTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gelirTutarDataGridViewTextBoxColumn.Name = "gelirTutarDataGridViewTextBoxColumn";
            this.gelirTutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // gelirAciklamaDataGridViewTextBoxColumn
            // 
            this.gelirAciklamaDataGridViewTextBoxColumn.DataPropertyName = "GelirAciklama";
            this.gelirAciklamaDataGridViewTextBoxColumn.HeaderText = "GelirAciklama";
            this.gelirAciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gelirAciklamaDataGridViewTextBoxColumn.Name = "gelirAciklamaDataGridViewTextBoxColumn";
            this.gelirAciklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // gelirToplamDataGridViewTextBoxColumn
            // 
            this.gelirToplamDataGridViewTextBoxColumn.DataPropertyName = "GelirToplam";
            this.gelirToplamDataGridViewTextBoxColumn.HeaderText = "GelirToplam";
            this.gelirToplamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gelirToplamDataGridViewTextBoxColumn.Name = "gelirToplamDataGridViewTextBoxColumn";
            this.gelirToplamDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gelir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(891, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Gelir";
            this.Text = "Gelir";
            this.Load += new System.EventHandler(this.Gelir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGELİR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGelirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridGELİR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnGelirRaporlar;
        private System.Windows.Forms.Button BtnGelirTemizle;
        private System.Windows.Forms.Button BtnGelirGüncelle;
        private System.Windows.Forms.Button BtnGelirSil;
        private System.Windows.Forms.Button BtnGelirKaydet;
        private System.Windows.Forms.Button BtnGelirListele;
        private System.Windows.Forms.TextBox TxtGelirID;
        private System.Windows.Forms.TextBox TxtGelirAciklama;
        private System.Windows.Forms.MaskedTextBox MskGelirTutar;
        private System.Windows.Forms.MaskedTextBox MskToplamGelir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskGelirTarih;
        private Gelir_Gider_ProjeDataSet9 gelir_Gider_ProjeDataSet9;
        private System.Windows.Forms.BindingSource tblGelirBindingSource;
        private Gelir_Gider_ProjeDataSet9TableAdapters.Tbl_GelirTableAdapter tbl_GelirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirToplamDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}