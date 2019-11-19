namespace proyecto_shopsys
{
    partial class Agregar_Producto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.numericPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.numericPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxMarca = new System.Windows.Forms.CheckBox();
            this.checkBoxPres = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.numericProveedor = new System.Windows.Forms.NumericUpDown();
            this.ComboMarca = new System.Windows.Forms.ComboBox();
            this.tBLMARCASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_TIENDADataSet = new proyecto_shopsys.DB_TIENDADataSet();
            this.ComboPres = new System.Windows.Forms.ComboBox();
            this.cATTIPOPRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tBL_MARCASTableAdapter = new proyecto_shopsys.DB_TIENDADataSetTableAdapters.TBL_MARCASTableAdapter();
            this.cAT_TIPO_PRODUCTOSTableAdapter = new proyecto_shopsys.DB_TIENDADataSetTableAdapters.CAT_TIPO_PRODUCTOSTableAdapter();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARCASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TIENDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATTIPOPRODUCTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1227, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir nuevo producto";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.24424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.75576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 606F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBProducto, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericPrecioCompra, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericPrecioVenta, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxMarca, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxPres, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.numericProveedor, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ComboMarca, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ComboPres, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 58);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1179, 297);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(4, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 46);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID proveedor";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // TBProducto
            // 
            this.TBProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBProducto.Location = new System.Drawing.Point(321, 5);
            this.TBProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(598, 35);
            this.TBProducto.TabIndex = 4;
            // 
            // numericPrecioCompra
            // 
            this.numericPrecioCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericPrecioCompra.DecimalPlaces = 2;
            this.numericPrecioCompra.Location = new System.Drawing.Point(321, 63);
            this.numericPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericPrecioCompra.Name = "numericPrecioCompra";
            this.numericPrecioCompra.Size = new System.Drawing.Size(598, 35);
            this.numericPrecioCompra.TabIndex = 10;
            // 
            // numericPrecioVenta
            // 
            this.numericPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericPrecioVenta.DecimalPlaces = 2;
            this.numericPrecioVenta.Location = new System.Drawing.Point(321, 118);
            this.numericPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericPrecioVenta.Name = "numericPrecioVenta";
            this.numericPrecioVenta.Size = new System.Drawing.Size(598, 35);
            this.numericPrecioVenta.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Compra";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(4, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio Venta";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(4, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Presentación/Descripción";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(4, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(294, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 55);
            this.label7.TabIndex = 15;
            this.label7.Text = "$";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 46);
            this.label8.TabIndex = 16;
            this.label8.Text = "$";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxMarca
            // 
            this.checkBoxMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMarca.AutoSize = true;
            this.checkBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMarca.Location = new System.Drawing.Point(927, 164);
            this.checkBoxMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMarca.Name = "checkBoxMarca";
            this.checkBoxMarca.Size = new System.Drawing.Size(248, 36);
            this.checkBoxMarca.TabIndex = 17;
            this.checkBoxMarca.Text = "Nueva marca";
            this.checkBoxMarca.UseVisualStyleBackColor = true;
            // 
            // checkBoxPres
            // 
            this.checkBoxPres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPres.AutoSize = true;
            this.checkBoxPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPres.Location = new System.Drawing.Point(927, 210);
            this.checkBoxPres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPres.Name = "checkBoxPres";
            this.checkBoxPres.Size = new System.Drawing.Size(248, 36);
            this.checkBoxPres.TabIndex = 18;
            this.checkBoxPres.Text = "Nueva presentación";
            this.checkBoxPres.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(927, 256);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "Nuevo Proveedor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BotonNuevoProveedor_Click);
            // 
            // numericProveedor
            // 
            this.numericProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericProveedor.Location = new System.Drawing.Point(321, 256);
            this.numericProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericProveedor.Name = "numericProveedor";
            this.numericProveedor.Size = new System.Drawing.Size(598, 35);
            this.numericProveedor.TabIndex = 9;
            // 
            // ComboMarca
            // 
            this.ComboMarca.DataSource = this.tBLMARCASBindingSource;
            this.ComboMarca.DisplayMember = "CMARCA";
            this.ComboMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboMarca.FormattingEnabled = true;
            this.ComboMarca.Location = new System.Drawing.Point(321, 164);
            this.ComboMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboMarca.Name = "ComboMarca";
            this.ComboMarca.Size = new System.Drawing.Size(598, 37);
            this.ComboMarca.TabIndex = 20;
            // 
            // tBLMARCASBindingSource
            // 
            this.tBLMARCASBindingSource.DataMember = "TBL_MARCAS";
            this.tBLMARCASBindingSource.DataSource = this.dB_TIENDADataSet;
            // 
            // dB_TIENDADataSet
            // 
            this.dB_TIENDADataSet.DataSetName = "DB_TIENDADataSet";
            this.dB_TIENDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComboPres
            // 
            this.ComboPres.DataSource = this.cATTIPOPRODUCTOSBindingSource;
            this.ComboPres.DisplayMember = "CTIPO_PRODUCTO";
            this.ComboPres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboPres.FormattingEnabled = true;
            this.ComboPres.Location = new System.Drawing.Point(321, 210);
            this.ComboPres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboPres.Name = "ComboPres";
            this.ComboPres.Size = new System.Drawing.Size(598, 37);
            this.ComboPres.TabIndex = 21;
            // 
            // cATTIPOPRODUCTOSBindingSource
            // 
            this.cATTIPOPRODUCTOSBindingSource.DataMember = "CAT_TIPO_PRODUCTOS";
            this.cATTIPOPRODUCTOSBindingSource.DataSource = this.dB_TIENDADataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(18, 423);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Añadir Producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BotónAgregar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(1024, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BotónCancelar_Click);
            // 
            // tBL_MARCASTableAdapter
            // 
            this.tBL_MARCASTableAdapter.ClearBeforeFill = true;
            // 
            // cAT_TIPO_PRODUCTOSTableAdapter
            // 
            this.cAT_TIPO_PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Agregar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1266, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Agregar_Producto";
            this.Text = "Añadir nuevo producto";
            this.Load += new System.EventHandler(this.Agregar_Producto_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARCASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TIENDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATTIPOPRODUCTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBProducto;
        private System.Windows.Forms.NumericUpDown numericPrecioCompra;
        private System.Windows.Forms.NumericUpDown numericPrecioVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxMarca;
        private System.Windows.Forms.CheckBox checkBoxPres;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericProveedor;
        private System.Windows.Forms.ComboBox ComboMarca;
        private DB_TIENDADataSet dB_TIENDADataSet;
        private System.Windows.Forms.BindingSource tBLMARCASBindingSource;
        private DB_TIENDADataSetTableAdapters.TBL_MARCASTableAdapter tBL_MARCASTableAdapter;
        private System.Windows.Forms.ComboBox ComboPres;
        private System.Windows.Forms.BindingSource cATTIPOPRODUCTOSBindingSource;
        private DB_TIENDADataSetTableAdapters.CAT_TIPO_PRODUCTOSTableAdapter cAT_TIPO_PRODUCTOSTableAdapter;
    }
}