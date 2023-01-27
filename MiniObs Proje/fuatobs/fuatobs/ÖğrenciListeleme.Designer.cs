namespace fuatobs
{
    partial class ÖğrenciListeleme
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
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new fuatobs.fuatobsdbDataSetTableAdapters.OgrenciTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOGRno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.fuatobsdbDataSet3 = new fuatobs.fuatobsdbDataSet3();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter1 = new fuatobs.fuatobsdbDataSet3TableAdapters.OgrenciTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ogrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter2 = new fuatobs.fuatobsdbDataSet4TableAdapters.OgrenciTableAdapter();
            this.ogrenciBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fuatobsdbDataSet5 = new fuatobs.fuatobsdbDataSet5();
            this.ogrenciTableAdapter3 = new fuatobs.fuatobsdbDataSet5TableAdapters.OgrenciTableAdapter();
            this.vOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuatobsdbDataSet12 = new fuatobs.fuatobsdbDataSet12();
            this.vOgrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vOgrenciTableAdapter = new fuatobs.fuatobsdbDataSet12TableAdapters.vOgrenciTableAdapter();
            this.fuatobsdbDataSet13 = new fuatobs.fuatobsdbDataSet13();
            this.vOgrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vOgrenciTableAdapter1 = new fuatobs.fuatobsdbDataSet13TableAdapters.vOgrenciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vOgrenciBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fuatobsdbDataSet14 = new fuatobs.fuatobsdbDataSet14();
            this.vOgrenciTableAdapter2 = new fuatobs.fuatobsdbDataSet14TableAdapters.vOgrenciTableAdapter();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memleketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOgrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOgrenciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOgrenciBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(405, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOGRno
            // 
            this.txtOGRno.Location = new System.Drawing.Point(194, 25);
            this.txtOGRno.Multiline = true;
            this.txtOGRno.Name = "txtOGRno";
            this.txtOGRno.Size = new System.Drawing.Size(184, 37);
            this.txtOGRno.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.txtOGRno);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Listeleme";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(9, 100);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 20);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "label2";
            this.lbl2.Visible = false;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(568, 25);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(142, 37);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // fuatobsdbDataSet3
            // 
            this.fuatobsdbDataSet3.DataSetName = "fuatobsdbDataSet3";
            this.fuatobsdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "Ogrenci";
            this.ogrenciBindingSource1.DataSource = this.fuatobsdbDataSet3;
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1000, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 136);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ogrenciTableAdapter2
            // 
            this.ogrenciTableAdapter2.ClearBeforeFill = true;
            // 
            // ogrenciBindingSource3
            // 
            this.ogrenciBindingSource3.DataMember = "Ogrenci";
            this.ogrenciBindingSource3.DataSource = this.fuatobsdbDataSet5;
            // 
            // fuatobsdbDataSet5
            // 
            this.fuatobsdbDataSet5.DataSetName = "fuatobsdbDataSet5";
            this.fuatobsdbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter3
            // 
            this.ogrenciTableAdapter3.ClearBeforeFill = true;
            // 
            // vOgrenciBindingSource
            // 
            this.vOgrenciBindingSource.DataMember = "vOgrenci";
            // 
            // fuatobsdbDataSet12
            // 
            this.fuatobsdbDataSet12.DataSetName = "fuatobsdbDataSet12";
            this.fuatobsdbDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vOgrenciBindingSource1
            // 
            this.vOgrenciBindingSource1.DataMember = "vOgrenci";
            this.vOgrenciBindingSource1.DataSource = this.fuatobsdbDataSet12;
            // 
            // vOgrenciTableAdapter
            // 
            this.vOgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // fuatobsdbDataSet13
            // 
            this.fuatobsdbDataSet13.DataSetName = "fuatobsdbDataSet13";
            this.fuatobsdbDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vOgrenciBindingSource2
            // 
            this.vOgrenciBindingSource2.DataMember = "vOgrenci";
            this.vOgrenciBindingSource2.DataSource = this.fuatobsdbDataSet13;
            // 
            // vOgrenciTableAdapter1
            // 
            this.vOgrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.memleketDataGridViewTextBoxColumn,
            this.sinifIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1});
            this.dataGridView1.DataSource = this.vOgrenciBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1563, 499);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // vOgrenciBindingSource3
            // 
            this.vOgrenciBindingSource3.DataMember = "vOgrenci";
            this.vOgrenciBindingSource3.DataSource = this.fuatobsdbDataSet14;
            // 
            // fuatobsdbDataSet14
            // 
            this.fuatobsdbDataSet14.DataSetName = "fuatobsdbDataSet14";
            this.fuatobsdbDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vOgrenciTableAdapter2
            // 
            this.vOgrenciTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Soyad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Soyad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cinsiyet";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cinsiyet";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OgrenciNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "OgrenciNo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // memleketDataGridViewTextBoxColumn
            // 
            this.memleketDataGridViewTextBoxColumn.DataPropertyName = "Memleket";
            this.memleketDataGridViewTextBoxColumn.HeaderText = "Memleket";
            this.memleketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memleketDataGridViewTextBoxColumn.Name = "memleketDataGridViewTextBoxColumn";
            this.memleketDataGridViewTextBoxColumn.ReadOnly = true;
            this.memleketDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinifIdDataGridViewTextBoxColumn
            // 
            this.sinifIdDataGridViewTextBoxColumn.DataPropertyName = "SinifId";
            this.sinifIdDataGridViewTextBoxColumn.HeaderText = "SinifId";
            this.sinifIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinifIdDataGridViewTextBoxColumn.Name = "sinifIdDataGridViewTextBoxColumn";
            this.sinifIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sinifIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DogumTarihi";
            this.dataGridViewTextBoxColumn4.HeaderText = "DogumTarihi";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Resim";
            this.dataGridViewImageColumn1.HeaderText = "Resim";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // ÖğrenciListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1541, 645);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ÖğrenciListeleme";
            this.Text = "ÖğrenciListeleme";
            this.Load += new System.EventHandler(this.ÖğrenciListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOgrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOgrenciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOgrenciBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuatobsdbDataSet14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private fuatobsdbDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOGRno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Sil;
        private fuatobsdbDataSet3 fuatobsdbDataSet3;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private fuatobsdbDataSet3TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource2;
        private fuatobsdbDataSet4TableAdapters.OgrenciTableAdapter ogrenciTableAdapter2;
        private fuatobsdbDataSet5 fuatobsdbDataSet5;
        private System.Windows.Forms.BindingSource ogrenciBindingSource3;
        private fuatobsdbDataSet5TableAdapters.OgrenciTableAdapter ogrenciTableAdapter3;
        private System.Windows.Forms.Label lbl2;
       
        private System.Windows.Forms.BindingSource vOgrenciBindingSource;
      
        
        
     

      

        
        private fuatobsdbDataSet12 fuatobsdbDataSet12;
        private System.Windows.Forms.BindingSource vOgrenciBindingSource1;
        private fuatobsdbDataSet12TableAdapters.vOgrenciTableAdapter vOgrenciTableAdapter;
        private fuatobsdbDataSet13 fuatobsdbDataSet13;
        private System.Windows.Forms.BindingSource vOgrenciBindingSource2;
        private fuatobsdbDataSet13TableAdapters.vOgrenciTableAdapter vOgrenciTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private fuatobsdbDataSet14 fuatobsdbDataSet14;
        private System.Windows.Forms.BindingSource vOgrenciBindingSource3;
        private fuatobsdbDataSet14TableAdapters.vOgrenciTableAdapter vOgrenciTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn memleketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}