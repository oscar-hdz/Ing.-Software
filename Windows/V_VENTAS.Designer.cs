namespace Prueba_proyecto
{
    partial class V_VENTAS
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
            this.dB_TIENDADataSet = new Prueba_proyecto.DB_TIENDADataSet();
            this.vVENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vVENTASTableAdapter = new Prueba_proyecto.DB_TIENDADataSetTableAdapters.VVENTASTableAdapter();
            this.pRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TIENDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVENTASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUCTODataGridViewTextBoxColumn,
            this.nOMBRECLIENTEDataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vVENTASBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(878, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dB_TIENDADataSet
            // 
            this.dB_TIENDADataSet.DataSetName = "DB_TIENDADataSet";
            this.dB_TIENDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vVENTASBindingSource
            // 
            this.vVENTASBindingSource.DataMember = "VVENTAS";
            this.vVENTASBindingSource.DataSource = this.dB_TIENDADataSet;
            // 
            // vVENTASTableAdapter
            // 
            this.vVENTASTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTODataGridViewTextBoxColumn
            // 
            this.pRODUCTODataGridViewTextBoxColumn.DataPropertyName = "PRODUCTO";
            this.pRODUCTODataGridViewTextBoxColumn.HeaderText = "PRODUCTO";
            this.pRODUCTODataGridViewTextBoxColumn.Name = "pRODUCTODataGridViewTextBoxColumn";
            this.pRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRECLIENTEDataGridViewTextBoxColumn
            // 
            this.nOMBRECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE CLIENTE";
            this.nOMBRECLIENTEDataGridViewTextBoxColumn.HeaderText = "NOMBRE CLIENTE";
            this.nOMBRECLIENTEDataGridViewTextBoxColumn.Name = "nOMBRECLIENTEDataGridViewTextBoxColumn";
            this.nOMBRECLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            this.cANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 444);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TIENDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVENTASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_TIENDADataSet dB_TIENDADataSet;
        private System.Windows.Forms.BindingSource vVENTASBindingSource;
        private DB_TIENDADataSetTableAdapters.VVENTASTableAdapter vVENTASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
    }
}