namespace SEZA
{
    partial class IslemSorgu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.madDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihaztipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemtanimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemtanimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemSorgulamaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEZATEKNİKSERVİSİDataSet1 = new SEZA.SEZATEKNİKSERVİSİDataSet1();
            this.sEZATEKNİKSERVİSİDataSet = new SEZA.SEZATEKNİKSERVİSİDataSet();
            this.sEZATEKNİKSERVİSİDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.islemSorgulamaTableAdapter = new SEZA.SEZATEKNİKSERVİSİDataSet1TableAdapters.IslemSorgulamaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataView1 = new System.Data.DataView();
            this.dataView2 = new System.Data.DataView();
            this.dataView3 = new System.Data.DataView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemSorgulamaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madDataGridViewTextBoxColumn,
            this.msoyadDataGridViewTextBoxColumn,
            this.serinoDataGridViewTextBoxColumn,
            this.cihazidDataGridViewTextBoxColumn,
            this.cihaztipiDataGridViewTextBoxColumn,
            this.problemtanimiDataGridViewTextBoxColumn,
            this.islemtanimiDataGridViewTextBoxColumn,
            this.ıslemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ıslemSorgulamaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // serinoDataGridViewTextBoxColumn
            // 
            this.serinoDataGridViewTextBoxColumn.DataPropertyName = "seri_no";
            this.serinoDataGridViewTextBoxColumn.HeaderText = "seri_no";
            this.serinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serinoDataGridViewTextBoxColumn.Name = "serinoDataGridViewTextBoxColumn";
            this.serinoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cihazidDataGridViewTextBoxColumn
            // 
            this.cihazidDataGridViewTextBoxColumn.DataPropertyName = "cihaz_id";
            this.cihazidDataGridViewTextBoxColumn.HeaderText = "cihaz_id";
            this.cihazidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cihazidDataGridViewTextBoxColumn.Name = "cihazidDataGridViewTextBoxColumn";
            this.cihazidDataGridViewTextBoxColumn.Width = 125;
            // 
            // cihaztipiDataGridViewTextBoxColumn
            // 
            this.cihaztipiDataGridViewTextBoxColumn.DataPropertyName = "cihaz_tipi";
            this.cihaztipiDataGridViewTextBoxColumn.HeaderText = "cihaz_tipi";
            this.cihaztipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cihaztipiDataGridViewTextBoxColumn.Name = "cihaztipiDataGridViewTextBoxColumn";
            this.cihaztipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // problemtanimiDataGridViewTextBoxColumn
            // 
            this.problemtanimiDataGridViewTextBoxColumn.DataPropertyName = "problem_tanimi";
            this.problemtanimiDataGridViewTextBoxColumn.HeaderText = "problem_tanimi";
            this.problemtanimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.problemtanimiDataGridViewTextBoxColumn.Name = "problemtanimiDataGridViewTextBoxColumn";
            this.problemtanimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // islemtanimiDataGridViewTextBoxColumn
            // 
            this.islemtanimiDataGridViewTextBoxColumn.DataPropertyName = "islem_tanimi";
            this.islemtanimiDataGridViewTextBoxColumn.HeaderText = "islem_tanimi";
            this.islemtanimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islemtanimiDataGridViewTextBoxColumn.Name = "islemtanimiDataGridViewTextBoxColumn";
            this.islemtanimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemDataGridViewTextBoxColumn
            // 
            this.ıslemDataGridViewTextBoxColumn.DataPropertyName = "Islem";
            this.ıslemDataGridViewTextBoxColumn.HeaderText = "Islem";
            this.ıslemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemDataGridViewTextBoxColumn.Name = "ıslemDataGridViewTextBoxColumn";
            this.ıslemDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıslemDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemSorgulamaBindingSource
            // 
            this.ıslemSorgulamaBindingSource.DataMember = "IslemSorgulama";
            this.ıslemSorgulamaBindingSource.DataSource = this.sEZATEKNİKSERVİSİDataSet1;
            // 
            // sEZATEKNİKSERVİSİDataSet1
            // 
            this.sEZATEKNİKSERVİSİDataSet1.DataSetName = "SEZATEKNİKSERVİSİDataSet1";
            this.sEZATEKNİKSERVİSİDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEZATEKNİKSERVİSİDataSet
            // 
            this.sEZATEKNİKSERVİSİDataSet.DataSetName = "SEZATEKNİKSERVİSİDataSet";
            this.sEZATEKNİKSERVİSİDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEZATEKNİKSERVİSİDataSetBindingSource
            // 
            this.sEZATEKNİKSERVİSİDataSetBindingSource.DataSource = this.sEZATEKNİKSERVİSİDataSet;
            this.sEZATEKNİKSERVİSİDataSetBindingSource.Position = 0;
            // 
            // islemSorgulamaTableAdapter
            // 
            this.islemSorgulamaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1002, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(54, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Cihaz ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IslemSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 573);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IslemSorgu";
            this.Text = "İşlem Sorgulama";
            this.Load += new System.EventHandler(this.MusteriCihazBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemSorgulamaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sEZATEKNİKSERVİSİDataSetBindingSource;
        private SEZATEKNİKSERVİSİDataSet sEZATEKNİKSERVİSİDataSet;
        private SEZATEKNİKSERVİSİDataSet1 sEZATEKNİKSERVİSİDataSet1;
        private System.Windows.Forms.BindingSource ıslemSorgulamaBindingSource;
        private SEZATEKNİKSERVİSİDataSet1TableAdapters.IslemSorgulamaTableAdapter islemSorgulamaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn madDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihaztipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemtanimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemtanimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Data.DataView dataView1;
        private System.Data.DataView dataView2;
        private System.Data.DataView dataView3;
    }
}