namespace Gelir_Gider_Proje
{
    partial class Rapor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblToplamGelir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblToplamGider = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNetKalan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gelirIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirToplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGelirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gelir_Gider_ProjeDataSet6 = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet6();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.giderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGiderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gelir_Gider_ProjeDataSet7 = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet7();
            this.tbl_GelirTableAdapter = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet6TableAdapters.Tbl_GelirTableAdapter();
            this.tbl_GiderTableAdapter = new Gelir_Gider_Proje.Gelir_Gider_ProjeDataSet7TableAdapters.Tbl_GiderTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGelirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet6)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGiderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Rapor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Gelir:";
            // 
            // LblToplamGelir
            // 
            this.LblToplamGelir.AutoSize = true;
            this.LblToplamGelir.Location = new System.Drawing.Point(151, 535);
            this.LblToplamGelir.Name = "LblToplamGelir";
            this.LblToplamGelir.Size = new System.Drawing.Size(23, 25);
            this.LblToplamGelir.TabIndex = 2;
            this.LblToplamGelir.Text = "0";
            this.LblToplamGelir.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam Gider:";
            // 
            // LblToplamGider
            // 
            this.LblToplamGider.AutoSize = true;
            this.LblToplamGider.Location = new System.Drawing.Point(362, 535);
            this.LblToplamGider.Name = "LblToplamGider";
            this.LblToplamGider.Size = new System.Drawing.Size(23, 25);
            this.LblToplamGider.TabIndex = 4;
            this.LblToplamGider.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(914, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "NET KALAN:";
            // 
            // LblNetKalan
            // 
            this.LblNetKalan.AutoSize = true;
            this.LblNetKalan.Location = new System.Drawing.Point(1050, 535);
            this.LblNetKalan.Name = "LblNetKalan";
            this.LblNetKalan.Size = new System.Drawing.Size(23, 25);
            this.LblNetKalan.TabIndex = 6;
            this.LblNetKalan.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(11, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 219);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GELİR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gelirIDDataGridViewTextBoxColumn,
            this.gelirTarihDataGridViewTextBoxColumn,
            this.gelirTutarDataGridViewTextBoxColumn,
            this.gelirAciklamaDataGridViewTextBoxColumn,
            this.gelirToplamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblGelirBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 190);
            this.dataGridView1.TabIndex = 0;
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
            // tblGelirBindingSource
            // 
            this.tblGelirBindingSource.DataMember = "Tbl_Gelir";
            this.tblGelirBindingSource.DataSource = this.gelir_Gider_ProjeDataSet6;
            // 
            // gelir_Gider_ProjeDataSet6
            // 
            this.gelir_Gider_ProjeDataSet6.DataSetName = "Gelir_Gider_ProjeDataSet6";
            this.gelir_Gider_ProjeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(11, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1093, 219);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GİDER";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.giderIDDataGridViewTextBoxColumn,
            this.giderTarihDataGridViewTextBoxColumn,
            this.giderTutarDataGridViewTextBoxColumn,
            this.giderAciklamaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblGiderBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1087, 190);
            this.dataGridView2.TabIndex = 0;
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
            // tblGiderBindingSource
            // 
            this.tblGiderBindingSource.DataMember = "Tbl_Gider";
            this.tblGiderBindingSource.DataSource = this.gelir_Gider_ProjeDataSet7;
            // 
            // gelir_Gider_ProjeDataSet7
            // 
            this.gelir_Gider_ProjeDataSet7.DataSetName = "Gelir_Gider_ProjeDataSet7";
            this.gelir_Gider_ProjeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_GelirTableAdapter
            // 
            this.tbl_GelirTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_GiderTableAdapter
            // 
            this.tbl_GiderTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(934, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1116, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblNetKalan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblToplamGider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblToplamGelir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGelirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGiderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelir_Gider_ProjeDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblToplamGelir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblToplamGider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblNetKalan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Gelir_Gider_ProjeDataSet6 gelir_Gider_ProjeDataSet6;
        private System.Windows.Forms.BindingSource tblGelirBindingSource;
        private Gelir_Gider_ProjeDataSet6TableAdapters.Tbl_GelirTableAdapter tbl_GelirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelirToplamDataGridViewTextBoxColumn;
        private Gelir_Gider_ProjeDataSet7 gelir_Gider_ProjeDataSet7;
        private System.Windows.Forms.BindingSource tblGiderBindingSource;
        private Gelir_Gider_ProjeDataSet7TableAdapters.Tbl_GiderTableAdapter tbl_GiderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}