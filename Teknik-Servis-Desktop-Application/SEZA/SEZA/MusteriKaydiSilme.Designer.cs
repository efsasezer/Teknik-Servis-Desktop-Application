namespace SEZA
{
    partial class MusteriKaydiSilme
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sEZATEKNİKSERVİSİDataSet7 = new SEZA.SEZATEKNİKSERVİSİDataSet7();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new SEZA.SEZATEKNİKSERVİSİDataSet7TableAdapters.MusteriTableAdapter();
            this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(726, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Müşteri ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(95, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Müşteri Kaydı Silme";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriidDataGridViewTextBoxColumn,
            this.madDataGridViewTextBoxColumn,
            this.msoyadDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telefonnumarasiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(314, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(487, 424);
            this.dataGridView1.TabIndex = 45;
            // 
            // sEZATEKNİKSERVİSİDataSet7
            // 
            this.sEZATEKNİKSERVİSİDataSet7.DataSetName = "SEZATEKNİKSERVİSİDataSet7";
            this.sEZATEKNİKSERVİSİDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.sEZATEKNİKSERVİSİDataSet7;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // musteriidDataGridViewTextBoxColumn
            // 
            this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
            this.musteriidDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriidDataGridViewTextBoxColumn.Width = 125;
            // 
            // madDataGridViewTextBoxColumn
            // 
            this.madDataGridViewTextBoxColumn.DataPropertyName = "m_ad";
            this.madDataGridViewTextBoxColumn.HeaderText = "m_ad";
            this.madDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madDataGridViewTextBoxColumn.Name = "madDataGridViewTextBoxColumn";
            this.madDataGridViewTextBoxColumn.Width = 125;
            // 
            // msoyadDataGridViewTextBoxColumn
            // 
            this.msoyadDataGridViewTextBoxColumn.DataPropertyName = "m_soyad";
            this.msoyadDataGridViewTextBoxColumn.HeaderText = "m_soyad";
            this.msoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.msoyadDataGridViewTextBoxColumn.Name = "msoyadDataGridViewTextBoxColumn";
            this.msoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonnumarasiDataGridViewTextBoxColumn
            // 
            this.telefonnumarasiDataGridViewTextBoxColumn.DataPropertyName = "telefon_numarasi";
            this.telefonnumarasiDataGridViewTextBoxColumn.HeaderText = "telefon_numarasi";
            this.telefonnumarasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonnumarasiDataGridViewTextBoxColumn.Name = "telefonnumarasiDataGridViewTextBoxColumn";
            this.telefonnumarasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // MusteriKaydiSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "MusteriKaydiSilme";
            this.Text = "Müşteri Kaydı Silme";
            this.Load += new System.EventHandler(this.MusteriKaydiSilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SEZATEKNİKSERVİSİDataSet7 sEZATEKNİKSERVİSİDataSet7;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private SEZATEKNİKSERVİSİDataSet7TableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}