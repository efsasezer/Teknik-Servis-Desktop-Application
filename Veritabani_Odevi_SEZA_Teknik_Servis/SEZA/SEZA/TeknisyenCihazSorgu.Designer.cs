namespace SEZA
{
    partial class TeknisyenCihazSorgu
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
            this.teknisyenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihaztipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teknisyenCihazSorguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEZATEKNİKSERVİSİDataSet6 = new SEZA.SEZATEKNİKSERVİSİDataSet6();
            this.teknisyen_CihazSorguTableAdapter = new SEZA.SEZATEKNİKSERVİSİDataSet6TableAdapters.Teknisyen_CihazSorguTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknisyenCihazSorguBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teknisyenidDataGridViewTextBoxColumn,
            this.tadDataGridViewTextBoxColumn,
            this.tsoyadDataGridViewTextBoxColumn,
            this.cihazidDataGridViewTextBoxColumn,
            this.cihaztipiDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teknisyenCihazSorguBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // teknisyenidDataGridViewTextBoxColumn
            // 
            this.teknisyenidDataGridViewTextBoxColumn.DataPropertyName = "teknisyen_id";
            this.teknisyenidDataGridViewTextBoxColumn.HeaderText = "teknisyen_id";
            this.teknisyenidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teknisyenidDataGridViewTextBoxColumn.Name = "teknisyenidDataGridViewTextBoxColumn";
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
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // teknisyenCihazSorguBindingSource
            // 
            this.teknisyenCihazSorguBindingSource.DataMember = "Teknisyen_CihazSorgu";
            this.teknisyenCihazSorguBindingSource.DataSource = this.sEZATEKNİKSERVİSİDataSet6;
            // 
            // sEZATEKNİKSERVİSİDataSet6
            // 
            this.sEZATEKNİKSERVİSİDataSet6.DataSetName = "SEZATEKNİKSERVİSİDataSet6";
            this.sEZATEKNİKSERVİSİDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teknisyen_CihazSorguTableAdapter
            // 
            this.teknisyen_CihazSorguTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(979, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(69, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Cihaz ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 51;
            // 
            // TeknisyenCihazSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 572);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeknisyenCihazSorgu";
            this.Text = "Teknisyen-Cihaz Sorgulama";
            this.Load += new System.EventHandler(this.TeknisyenCihazSorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknisyenCihazSorguBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEZATEKNİKSERVİSİDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SEZATEKNİKSERVİSİDataSet6 sEZATEKNİKSERVİSİDataSet6;
        private System.Windows.Forms.BindingSource teknisyenCihazSorguBindingSource;
        private SEZATEKNİKSERVİSİDataSet6TableAdapters.Teknisyen_CihazSorguTableAdapter teknisyen_CihazSorguTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teknisyenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihaztipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}