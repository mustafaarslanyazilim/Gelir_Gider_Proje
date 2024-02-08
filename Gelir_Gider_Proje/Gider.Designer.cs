namespace Gelir_Gider_Proje
{
    partial class Gider
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnGiderRaporlar = new System.Windows.Forms.Button();
            this.BtnGiderTemizle = new System.Windows.Forms.Button();
            this.BtnGiderGüncelle = new System.Windows.Forms.Button();
            this.BtnGiderSil = new System.Windows.Forms.Button();
            this.BtnGiderKaydet = new System.Windows.Forms.Button();
            this.BtnGiderListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MskGiderTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtGiderAciklama = new System.Windows.Forms.TextBox();
            this.MskGiderTutar = new System.Windows.Forms.MaskedTextBox();
            this.TxtGiderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridGİDER = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gelir_Gider_ProjeDataSet10 = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet10();
            this.tblGiderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_GiderTableAdapter = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet10TableAdapters.Tbl_GiderTableAdapter();
            this.giderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGİDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGiderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnGiderRaporlar);
            this.groupBox3.Controls.Add(this.BtnGiderTemizle);
            this.groupBox3.Controls.Add(this.BtnGiderGüncelle);
            this.groupBox3.Controls.Add(this.BtnGiderSil);
            this.groupBox3.Controls.Add(this.BtnGiderKaydet);
            this.groupBox3.Controls.Add(this.BtnGiderListele);
            this.groupBox3.Location = new System.Drawing.Point(448, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 292);
            this.groupBox3.TabIndex = 4;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskGiderTarih);
            this.groupBox1.Controls.Add(this.TxtGiderAciklama);
            this.groupBox1.Controls.Add(this.MskGiderTutar);
            this.groupBox1.Controls.Add(this.TxtGiderID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 293);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gider Tablosu";
            // 
            // MskGiderTarih
            // 
            this.MskGiderTarih.Location = new System.Drawing.Point(113, 83);
            this.MskGiderTarih.Mask = "0/00/0000";
            this.MskGiderTarih.Name = "MskGiderTarih";
            this.MskGiderTarih.Size = new System.Drawing.Size(155, 22);
            this.MskGiderTarih.TabIndex = 7;
            // 
            // TxtGiderAciklama
            // 
            this.TxtGiderAciklama.Location = new System.Drawing.Point(113, 170);
            this.TxtGiderAciklama.Multiline = true;
            this.TxtGiderAciklama.Name = "TxtGiderAciklama";
            this.TxtGiderAciklama.Size = new System.Drawing.Size(249, 67);
            this.TxtGiderAciklama.TabIndex = 6;
            // 
            // MskGiderTutar
            // 
            this.MskGiderTutar.Location = new System.Drawing.Point(113, 127);
            this.MskGiderTutar.Mask = "00000";
            this.MskGiderTutar.Name = "MskGiderTutar";
            this.MskGiderTutar.Size = new System.Drawing.Size(155, 22);
            this.MskGiderTutar.TabIndex = 5;
            this.MskGiderTutar.ValidatingType = typeof(int);
            // 
            // TxtGiderID
            // 
            this.TxtGiderID.Location = new System.Drawing.Point(113, 41);
            this.TxtGiderID.Name = "TxtGiderID";
            this.TxtGiderID.Size = new System.Drawing.Size(100, 22);
            this.TxtGiderID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gider Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gider Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gider Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gider ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridGİDER);
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 187);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gider Kayıtları";
            // 
            // dataGridGİDER
            // 
            this.dataGridGİDER.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGİDER.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridGİDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGİDER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.giderIDDataGridViewTextBoxColumn,
            this.giderTarihDataGridViewTextBoxColumn,
            this.giderTutarDataGridViewTextBoxColumn,
            this.giderAciklamaDataGridViewTextBoxColumn});
            this.dataGridGİDER.DataSource = this.tblGiderBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridGİDER.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridGİDER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGİDER.Location = new System.Drawing.Point(3, 18);
            this.dataGridGİDER.Name = "dataGridGİDER";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGİDER.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridGİDER.RowHeadersWidth = 51;
            this.dataGridGİDER.RowTemplate.Height = 24;
            this.dataGridGİDER.Size = new System.Drawing.Size(866, 166);
            this.dataGridGİDER.TabIndex = 0;
            this.dataGridGİDER.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGİDER_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gelir_Gider_ProjeDataSet10
            // 
            this.gelir_Gider_ProjeDataSet10.DataSetName = "Gelir_Gider_ProjeDataSet10";
            this.gelir_Gider_ProjeDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGiderBindingSource
            // 
            this.tblGiderBindingSource.DataMember = "Tbl_Gider";
            this.tblGiderBindingSource.DataSource = this.gelir_Gider_ProjeDataSet10;
            // 
            // tbl_GiderTableAdapter
            // 
            this.tbl_GiderTableAdapter.ClearBeforeFill = true;
            // 
            // giderIDDataGridViewTextBoxColumn
            // 
            this.giderIDDataGridViewTextBoxColumn.DataPropertyName = "GiderID";
            this.giderIDDataGridViewTextBoxColumn.HeaderText = "GiderID";
            this.giderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giderIDDataGridViewTextBoxColumn.Name = "giderIDDataGridViewTextBoxColumn";
            this.giderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // giderTarihDataGridViewTextBoxColumn
            // 
            this.giderTarihDataGridViewTextBoxColumn.DataPropertyName = "GiderTarih";
            this.giderTarihDataGridViewTextBoxColumn.HeaderText = "GiderTarih";
            this.giderTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giderTarihDataGridViewTextBoxColumn.Name = "giderTarihDataGridViewTextBoxColumn";
            this.giderTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // giderTutarDataGridViewTextBoxColumn
            // 
            this.giderTutarDataGridViewTextBoxColumn.DataPropertyName = "GiderTutar";
            this.giderTutarDataGridViewTextBoxColumn.HeaderText = "GiderTutar";
            this.giderTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giderTutarDataGridViewTextBoxColumn.Name = "giderTutarDataGridViewTextBoxColumn";
            this.giderTutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // giderAciklamaDataGridViewTextBoxColumn
            // 
            this.giderAciklamaDataGridViewTextBoxColumn.DataPropertyName = "GiderAciklama";
            this.giderAciklamaDataGridViewTextBoxColumn.HeaderText = "GiderAciklama";
            this.giderAciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giderAciklamaDataGridViewTextBoxColumn.Name = "giderAciklamaDataGridViewTextBoxColumn";
            this.giderAciklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(883, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Gider";
            this.Text = "Gider";
            this.Load += new System.EventHandler(this.Gider_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGİDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGiderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnGiderRaporlar;
        private System.Windows.Forms.Button BtnGiderTemizle;
        private System.Windows.Forms.Button BtnGiderGüncelle;
        private System.Windows.Forms.Button BtnGiderSil;
        private System.Windows.Forms.Button BtnGiderKaydet;
        private System.Windows.Forms.Button BtnGiderListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtGiderAciklama;
        private System.Windows.Forms.MaskedTextBox MskGiderTutar;
        private System.Windows.Forms.TextBox TxtGiderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridGİDER;
        private System.Windows.Forms.MaskedTextBox MskGiderTarih;
        private System.Windows.Forms.Button button1;
        private Gelir_Gider_ProjeDataSet10 gelir_Gider_ProjeDataSet10;
        private System.Windows.Forms.BindingSource tblGiderBindingSource;
        private Gelir_Gider_ProjeDataSet10TableAdapters.Tbl_GiderTableAdapter tbl_GiderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderAciklamaDataGridViewTextBoxColumn;
    }
}