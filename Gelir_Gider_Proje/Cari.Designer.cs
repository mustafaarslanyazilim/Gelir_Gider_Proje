namespace Gelir_Gider_Proje
{
    partial class Cari
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtCariSoyad = new System.Windows.Forms.TextBox();
            this.TxtCariAd = new System.Windows.Forms.TextBox();
            this.MskCariID = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnGiderRaporlar = new System.Windows.Forms.Button();
            this.BtnGiderTemizle = new System.Windows.Forms.Button();
            this.BtnGiderGüncelle = new System.Windows.Forms.Button();
            this.BtnGiderSil = new System.Windows.Forms.Button();
            this.BtnGiderKaydet = new System.Windows.Forms.Button();
            this.BtnGiderListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MskCariTel = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gelir_Gider_ProjeDataSet11 = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet11();
            this.tblCariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CariTableAdapter = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet11TableAdapters.Tbl_CariTableAdapter();
            this.cariIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskCariTel);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TxtCariSoyad);
            this.groupBox1.Controls.Add(this.TxtCariAd);
            this.groupBox1.Controls.Add(this.MskCariID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gelir_Gider_Proje.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(769, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TxtCariSoyad
            // 
            this.TxtCariSoyad.Location = new System.Drawing.Point(162, 144);
            this.TxtCariSoyad.Name = "TxtCariSoyad";
            this.TxtCariSoyad.Size = new System.Drawing.Size(173, 34);
            this.TxtCariSoyad.TabIndex = 6;
            // 
            // TxtCariAd
            // 
            this.TxtCariAd.Location = new System.Drawing.Point(162, 86);
            this.TxtCariAd.Name = "TxtCariAd";
            this.TxtCariAd.Size = new System.Drawing.Size(173, 34);
            this.TxtCariAd.TabIndex = 5;
            // 
            // MskCariID
            // 
            this.MskCariID.Location = new System.Drawing.Point(162, 30);
            this.MskCariID.Mask = "00000";
            this.MskCariID.Name = "MskCariID";
            this.MskCariID.Size = new System.Drawing.Size(173, 34);
            this.MskCariID.TabIndex = 4;
            this.MskCariID.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 528);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnGiderRaporlar);
            this.groupBox3.Controls.Add(this.BtnGiderTemizle);
            this.groupBox3.Controls.Add(this.BtnGiderGüncelle);
            this.groupBox3.Controls.Add(this.BtnGiderSil);
            this.groupBox3.Controls.Add(this.BtnGiderKaydet);
            this.groupBox3.Controls.Add(this.BtnGiderListele);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(455, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 303);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // BtnGiderRaporlar
            // 
            this.BtnGiderRaporlar.Location = new System.Drawing.Point(50, 249);
            this.BtnGiderRaporlar.Name = "BtnGiderRaporlar";
            this.BtnGiderRaporlar.Size = new System.Drawing.Size(122, 37);
            this.BtnGiderRaporlar.TabIndex = 5;
            this.BtnGiderRaporlar.Text = "Raporlar";
            this.BtnGiderRaporlar.UseVisualStyleBackColor = true;
            this.BtnGiderRaporlar.Click += new System.EventHandler(this.BtnGiderRaporlar_Click);
            // 
            // BtnGiderTemizle
            // 
            this.BtnGiderTemizle.Location = new System.Drawing.Point(50, 206);
            this.BtnGiderTemizle.Name = "BtnGiderTemizle";
            this.BtnGiderTemizle.Size = new System.Drawing.Size(122, 37);
            this.BtnGiderTemizle.TabIndex = 4;
            this.BtnGiderTemizle.Text = "Temizle";
            this.BtnGiderTemizle.UseVisualStyleBackColor = true;
            this.BtnGiderTemizle.Click += new System.EventHandler(this.BtnGiderTemizle_Click);
            // 
            // BtnGiderGüncelle
            // 
            this.BtnGiderGüncelle.Location = new System.Drawing.Point(50, 163);
            this.BtnGiderGüncelle.Name = "BtnGiderGüncelle";
            this.BtnGiderGüncelle.Size = new System.Drawing.Size(122, 37);
            this.BtnGiderGüncelle.TabIndex = 3;
            this.BtnGiderGüncelle.Text = "Güncelle";
            this.BtnGiderGüncelle.UseVisualStyleBackColor = true;
            this.BtnGiderGüncelle.Click += new System.EventHandler(this.BtnGiderGüncelle_Click);
            // 
            // BtnGiderSil
            // 
            this.BtnGiderSil.Location = new System.Drawing.Point(50, 120);
            this.BtnGiderSil.Name = "BtnGiderSil";
            this.BtnGiderSil.Size = new System.Drawing.Size(122, 37);
            this.BtnGiderSil.TabIndex = 2;
            this.BtnGiderSil.Text = "Sil";
            this.BtnGiderSil.UseVisualStyleBackColor = true;
            this.BtnGiderSil.Click += new System.EventHandler(this.BtnGiderSil_Click);
            // 
            // BtnGiderKaydet
            // 
            this.BtnGiderKaydet.Location = new System.Drawing.Point(50, 77);
            this.BtnGiderKaydet.Name = "BtnGiderKaydet";
            this.BtnGiderKaydet.Size = new System.Drawing.Size(122, 37);
            this.BtnGiderKaydet.TabIndex = 1;
            this.BtnGiderKaydet.Text = "Kaydet";
            this.BtnGiderKaydet.UseVisualStyleBackColor = true;
            this.BtnGiderKaydet.Click += new System.EventHandler(this.BtnGiderKaydet_Click);
            // 
            // BtnGiderListele
            // 
            this.BtnGiderListele.Location = new System.Drawing.Point(50, 34);
            this.BtnGiderListele.Name = "BtnGiderListele";
            this.BtnGiderListele.Size = new System.Drawing.Size(122, 37);
            this.BtnGiderListele.TabIndex = 0;
            this.BtnGiderListele.Text = "Listele";
            this.BtnGiderListele.UseVisualStyleBackColor = true;
            this.BtnGiderListele.Click += new System.EventHandler(this.BtnGiderListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cariIDDataGridViewTextBoxColumn,
            this.cariAdDataGridViewTextBoxColumn,
            this.cariSoyadDataGridViewTextBoxColumn,
            this.cariTelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 337);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(967, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // MskCariTel
            // 
            this.MskCariTel.Location = new System.Drawing.Point(162, 202);
            this.MskCariTel.Mask = "00000000000";
            this.MskCariTel.Name = "MskCariTel";
            this.MskCariTel.Size = new System.Drawing.Size(173, 34);
            this.MskCariTel.TabIndex = 9;
            this.MskCariTel.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gelir_Gider_ProjeDataSet11
            // 
            this.gelir_Gider_ProjeDataSet11.DataSetName = "Gelir_Gider_ProjeDataSet11";
            this.gelir_Gider_ProjeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCariBindingSource
            // 
            this.tblCariBindingSource.DataMember = "Tbl_Cari";
            this.tblCariBindingSource.DataSource = this.gelir_Gider_ProjeDataSet11;
            // 
            // tbl_CariTableAdapter
            // 
            this.tbl_CariTableAdapter.ClearBeforeFill = true;
            // 
            // cariIDDataGridViewTextBoxColumn
            // 
            this.cariIDDataGridViewTextBoxColumn.DataPropertyName = "CariID";
            this.cariIDDataGridViewTextBoxColumn.HeaderText = "CariID";
            this.cariIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cariIDDataGridViewTextBoxColumn.Name = "cariIDDataGridViewTextBoxColumn";
            this.cariIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cariAdDataGridViewTextBoxColumn
            // 
            this.cariAdDataGridViewTextBoxColumn.DataPropertyName = "CariAd";
            this.cariAdDataGridViewTextBoxColumn.HeaderText = "CariAd";
            this.cariAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cariAdDataGridViewTextBoxColumn.Name = "cariAdDataGridViewTextBoxColumn";
            this.cariAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // cariSoyadDataGridViewTextBoxColumn
            // 
            this.cariSoyadDataGridViewTextBoxColumn.DataPropertyName = "CariSoyad";
            this.cariSoyadDataGridViewTextBoxColumn.HeaderText = "CariSoyad";
            this.cariSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cariSoyadDataGridViewTextBoxColumn.Name = "cariSoyadDataGridViewTextBoxColumn";
            this.cariSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // cariTelDataGridViewTextBoxColumn
            // 
            this.cariTelDataGridViewTextBoxColumn.DataPropertyName = "CariTel";
            this.cariTelDataGridViewTextBoxColumn.HeaderText = "CariTel";
            this.cariTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cariTelDataGridViewTextBoxColumn.Name = "cariTelDataGridViewTextBoxColumn";
            this.cariTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // Cari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 528);
            this.Controls.Add(this.groupBox2);
            this.Name = "Cari";
            this.Text = "Cari Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCariBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCariAd;
        private System.Windows.Forms.MaskedTextBox MskCariID;
        private System.Windows.Forms.TextBox TxtCariSoyad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnGiderRaporlar;
        private System.Windows.Forms.Button BtnGiderTemizle;
        private System.Windows.Forms.Button BtnGiderGüncelle;
        private System.Windows.Forms.Button BtnGiderSil;
        private System.Windows.Forms.Button BtnGiderKaydet;
        private System.Windows.Forms.Button BtnGiderListele;
        private System.Windows.Forms.MaskedTextBox MskCariTel;
        private System.Windows.Forms.Button button1;
        private Gelir_Gider_ProjeDataSet11 gelir_Gider_ProjeDataSet11;
        private System.Windows.Forms.BindingSource tblCariBindingSource;
        private Gelir_Gider_ProjeDataSet11TableAdapters.Tbl_CariTableAdapter tbl_CariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariTelDataGridViewTextBoxColumn;
    }
}

