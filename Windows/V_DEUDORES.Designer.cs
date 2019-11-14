namespace Prueba_proyecto
{
    partial class V_DEUDORES
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
            this.cLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDEUDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_TIENDADataSet = new Prueba_proyecto.DB_TIENDADataSet();
            this.vDEUDORESTableAdapter = new Prueba_proyecto.DB_TIENDADataSetTableAdapters.VDEUDORESTableAdapter();
            this.sPDVERDEUDACLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPD_VER_DEUDA_CLIENTETableAdapter = new Prueba_proyecto.DB_TIENDADataSetTableAdapters.SPD_VER_DEUDA_CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDEUDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TIENDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDVERDEUDACLIENTEBindingSource)).BeginInit();
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
            this.cLIENTEDataGridViewTextBoxColumn,
            this.cTELEFONODataGridViewTextBoxColumn,
            this.totalAPagarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vDEUDORESBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // cLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEDataGridViewTextBoxColumn";
            this.cLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTELEFONODataGridViewTextBoxColumn
            // 
            this.cTELEFONODataGridViewTextBoxColumn.DataPropertyName = "CTELEFONO";
            this.cTELEFONODataGridViewTextBoxColumn.HeaderText = "CTELEFONO";
            this.cTELEFONODataGridViewTextBoxColumn.Name = "cTELEFONODataGridViewTextBoxColumn";
            this.cTELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAPagarDataGridViewTextBoxColumn
            // 
            this.totalAPagarDataGridViewTextBoxColumn.DataPropertyName = "Total a pagar";
            this.totalAPagarDataGridViewTextBoxColumn.HeaderText = "Total a pagar";
            this.totalAPagarDataGridViewTextBoxColumn.Name = "totalAPagarDataGridViewTextBoxColumn";
            this.totalAPagarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDEUDORESBindingSource
            // 
            this.vDEUDORESBindingSource.DataMember = "VDEUDORES";
            this.vDEUDORESBindingSource.DataSource = this.dB_TIENDADataSet;
            // 
            // dB_TIENDADataSet
            // 
            this.dB_TIENDADataSet.DataSetName = "DB_TIENDADataSet";
            this.dB_TIENDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDEUDORESTableAdapter
            // 
            this.vDEUDORESTableAdapter.ClearBeforeFill = true;
            // 
            // sPDVERDEUDACLIENTEBindingSource
            // 
            this.sPDVERDEUDACLIENTEBindingSource.DataMember = "SPD_VER_DEUDA_CLIENTE";
            this.sPDVERDEUDACLIENTEBindingSource.DataSource = this.dB_TIENDADataSet;
            // 
            // sPD_VER_DEUDA_CLIENTETableAdapter
            // 
            this.sPD_VER_DEUDA_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // V_DEUDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "V_DEUDORES";
            this.Text = "Deudores";
            this.Load += new System.EventHandler(this.V_DEUDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDEUDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TIENDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDVERDEUDACLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_TIENDADataSet dB_TIENDADataSet;
        private System.Windows.Forms.BindingSource vDEUDORESBindingSource;
        private DB_TIENDADataSetTableAdapters.VDEUDORESTableAdapter vDEUDORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPDVERDEUDACLIENTEBindingSource;
        private DB_TIENDADataSetTableAdapters.SPD_VER_DEUDA_CLIENTETableAdapter sPD_VER_DEUDA_CLIENTETableAdapter;
    }
}