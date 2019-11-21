namespace proyecto_shopsys
{
    partial class ventanaEliminar
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
            this.RBProducto = new System.Windows.Forms.RadioButton();
            this.RBProveedor = new System.Windows.Forms.RadioButton();
            this.RBCliente = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericID = new System.Windows.Forms.NumericUpDown();
            this.BotónEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            this.SuspendLayout();
            // 
            // RBProducto
            // 
            this.RBProducto.AutoSize = true;
            this.RBProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBProducto.Location = new System.Drawing.Point(22, 50);
            this.RBProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBProducto.Name = "RBProducto";
            this.RBProducto.Size = new System.Drawing.Size(91, 24);
            this.RBProducto.TabIndex = 0;
            this.RBProducto.TabStop = true;
            this.RBProducto.Tag = "TBL";
            this.RBProducto.Text = "Producto";
            this.RBProducto.UseVisualStyleBackColor = true;
            // 
            // RBProveedor
            // 
            this.RBProveedor.AutoSize = true;
            this.RBProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBProveedor.Location = new System.Drawing.Point(152, 50);
            this.RBProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBProveedor.Name = "RBProveedor";
            this.RBProveedor.Size = new System.Drawing.Size(99, 24);
            this.RBProveedor.TabIndex = 1;
            this.RBProveedor.TabStop = true;
            this.RBProveedor.Tag = "CAT";
            this.RBProveedor.Text = "Proveedor";
            this.RBProveedor.UseVisualStyleBackColor = true;
            // 
            // RBCliente
            // 
            this.RBCliente.AutoSize = true;
            this.RBCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCliente.Location = new System.Drawing.Point(282, 50);
            this.RBCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBCliente.Name = "RBCliente";
            this.RBCliente.Size = new System.Drawing.Size(76, 24);
            this.RBCliente.TabIndex = 2;
            this.RBCliente.TabStop = true;
            this.RBCliente.Tag = "CAT";
            this.RBCliente.Text = "Cliente";
            this.RBCliente.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBProducto);
            this.panel1.Controls.Add(this.RBCliente);
            this.panel1.Controls.Add(this.RBProveedor);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(49, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 82);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el ID:";
            // 
            // numericID
            // 
            this.numericID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericID.Location = new System.Drawing.Point(206, 114);
            this.numericID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(80, 29);
            this.numericID.TabIndex = 5;
            // 
            // BotónEliminar
            // 
            this.BotónEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BotónEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónEliminar.Location = new System.Drawing.Point(333, 161);
            this.BotónEliminar.Name = "BotónEliminar";
            this.BotónEliminar.Size = new System.Drawing.Size(147, 49);
            this.BotónEliminar.TabIndex = 6;
            this.BotónEliminar.Text = "Eliminar";
            this.BotónEliminar.UseVisualStyleBackColor = false;
            this.BotónEliminar.Click += new System.EventHandler(this.BotónEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "ELIMINAR";
            // 
            // ventanaEliminar
            // 
            this.AcceptButton = this.BotónEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(488, 219);
            this.Controls.Add(this.BotónEliminar);
            this.Controls.Add(this.numericID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(504, 258);
            this.MinimumSize = new System.Drawing.Size(504, 258);
            this.Name = "ventanaEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBProducto;
        private System.Windows.Forms.RadioButton RBProveedor;
        private System.Windows.Forms.RadioButton RBCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericID;
        private System.Windows.Forms.Button BotónEliminar;
        private System.Windows.Forms.Label label2;
    }
}