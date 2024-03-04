namespace SEZA
{
    partial class TeknisyenKaydiSilme
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
            this.teknisyenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzmanlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calismasaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teknisyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEZATEKNİKSERVİSİDataSet8 = new SEZA.SEZATEKNİKSERVİSİDataSet8();
            this.teknisyenTableAdapter = new SEZA.SEZATEKNİKSERVİSİDataSet8TableAdapters.TeknisyenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknisyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(772, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 49;
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
            this.label2.Location = new System.Drawing.Point(28, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Teknisyen ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(120, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Teknisyen Kaydı Silme";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teknisyenidDataGridViewTextBoxColumn,
            this.tadDataGridViewTextBoxColumn,
            this.tsoyadDataGridViewTextBoxColumn,
            this.tcinsiyetDataGridViewTextBoxColumn,
            this.tyasDataGridViewTextBoxColumn,
            this.uzmanlikDataGridViewTextBoxColumn,
            this.tmaasDataGridViewTextBoxColumn,
            this.calismasaatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teknisyenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(360, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(487, 254);
            this.dataGridView1.TabIndex = 50;
            // 
            // teknisyenidDataGridViewTextBoxColumn
            // 
            this.teknisyenidDataGridViewTextBoxColumn.DataPropertyName = "teknisyen_id";
            this.teknisyenidDataGridViewTextBoxColumn.HeaderText = "teknisyen_id";
            this.teknisyenidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teknisyenidDataGridViewTextBoxColumn.Name = "teknisyenidDataGridViewTextBoxColumn";
            this.teknisyenidDataGridViewTextBoxColumn.ReadOnly = true;
            this.teknisyenidDataGridViewTextBoxColumn.Width = 125;
            // 
            // tadDataGridViewTextBoxColumn
            // 
            this.tadDataGridViewTextBoxColumn.DataPropertyName = "t_ad";
            this.tadDataGridViewTextBoxColumn.HeaderText = "t_ad";
            this.tadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tadDataGridViewTextBoxColumn.Name = "tadDataGridViewTextBoxColumn";
            this.tadDataGridViewTextBoxColumn.Width = 125;
            // 
            // tsoyadDataGridViewTextBoxColumn
            // 
            this.tsoyadDataGridViewTextBoxColumn.DataPropertyName = "t_soyad";
            this.tsoyadDataGridViewTextBoxColumn.HeaderText = "t_soyad";
            this.tsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tsoyadDataGridViewTextBoxColumn.Name = "tsoyadDataGridViewTextBoxColumn";
            this.tsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // tcinsiyetDataGridViewTextBoxColumn
            // 
            this.tcinsiyetDataGridViewTextBoxColumn.DataPropertyName = "t_cinsiyet";
            this.tcinsiyetDataGridViewTextBoxColumn.HeaderText = "t_cinsiyet";
            this.tcinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcinsiyetDataGridViewTextBoxColumn.Name = "tcinsiyetDataGridViewTextBoxColumn";
            this.tcinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // tyasDataGridViewTextBoxColumn
            // 
            this.tyasDataGridViewTextBoxColumn.DataPropertyName = "t_yas";
            this.tyasDataGridViewTextBoxColumn.HeaderText = "t_yas";
            this.tyasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tyasDataGridViewTextBoxColumn.Name = "tyasDataGridViewTextBoxColumn";
            this.tyasDataGridViewTextBoxColumn.Width = 125;
            // 
            // uzmanlikDataGridViewTextBoxColumn
            // 
            this.uzmanlikDataGridViewTextBoxColumn.DataPropertyName = "uzmanlik";
            this.uzmanlikDataGridViewTextBoxColumn.HeaderText = "uzmanlik";
            this.uzmanlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uzmanlikDataGridViewTextBoxColumn.Name = "uzmanlikDataGridViewTextBoxColumn";
            this.uzmanlikDataGridViewTextBoxColumn.Width = 125;
            // 
            // tmaasDataGridViewTextBoxColumn
            // 
            this.tmaasDataGridViewTextBoxColumn.DataPropertyName = "t_maas";
            this.tmaasDataGridViewTextBoxColumn.HeaderText = "t_maas";
            this.tmaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tmaasDataGridViewTextBoxColumn.Name = "tmaasDataGridViewTextBoxColumn";
            this.tmaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // calismasaatiDataGridViewTextBoxColumn
            // 
            this.calismasaatiDataGridViewTextBoxColumn.DataPropertyName = "calisma_saati";
            this.calismasaatiDataGridViewTextBoxColumn.HeaderText = "calisma_saati";
            this.calismasaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calismasaatiDataGridViewTextBoxColumn.Name = "calismasaatiDataGridViewTextBoxColumn";
            this.calismasaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // teknisyenBindingSource
            // 
            this.teknisyenBindingSource.DataMember = "Teknisyen";
            this.teknisyenBindingSource.DataSource = this.sEZATEKNİKSERVİSİDataSet8;
            // 
            // sEZATEKNİKSERVİSİDataSet8
            // 
            this.sEZATEKNİKSERVİSİDataSet8.DataSetName = "SEZATEKNİKSERVİSİDataSet8";
            this.sEZATEKNİKSERVİSİDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teknisyenTableAdapter
            // 
            this.teknisyenTableAdapter.ClearBeforeFill = true;
            // 
            // TeknisyenKaydiSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 565);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "TeknisyenKaydiSilme";
            this.Text = "Teknisyen Kaydı Silme";
            this.Load += new System.EventHandler(this.TeknisyenKaydiSilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknisyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet8)).EndInit();
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
        private SEZATEKNİKSERVİSİDataSet8 sEZATEKNİKSERVİSİDataSet8;
        private System.Windows.Forms.BindingSource teknisyenBindingSource;
        private SEZATEKNİKSERVİSİDataSet8TableAdapters.TeknisyenTableAdapter teknisyenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teknisyenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzmanlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calismasaatiDataGridViewTextBoxColumn;
    }
}