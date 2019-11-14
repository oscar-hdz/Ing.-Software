namespace Prueba_proyecto
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
            this.BotónCancelar = new System.Windows.Forms.Button();
            this.BotónAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBApellidoP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dB_TIENDADataSet = new Prueba_proyecto.DB_TIENDADataSet();
            this.tBLPRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_PRODUCTOSTableAdapter = new Prueba_proyecto.DB_TIENDADataSetTableAdapters.TBL_PRODUCTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TIENDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPRODUCTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BotónCancelar
            // 
            this.BotónCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BotónCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotónCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BotónCancelar.FlatAppearance.BorderSize = 10;
            this.BotónCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotónCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónCancelar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BotónCancelar.Location = new System.Drawing.Point(15, 470);
            this.BotónCancelar.Name = "BotónCancelar";
            this.BotónCancelar.Size = new System.Drawing.Size(226, 58);
            this.BotónCancelar.TabIndex = 25;
            this.BotónCancelar.Text = "Cancelar";
            this.BotónCancelar.UseVisualStyleBackColor = false;
            // 
            // BotónAgregar
            // 
            this.BotónAgregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BotónAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BotónAgregar.FlatAppearance.BorderSize = 10;
            this.BotónAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotónAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónAgregar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BotónAgregar.Location = new System.Drawing.Point(567, 470);
            this.BotónAgregar.Name = "BotónAgregar";
            this.BotónAgregar.Size = new System.Drawing.Size(226, 58);
            this.BotónAgregar.TabIndex = 24;
            this.BotónAgregar.Text = "Agregar";
            this.BotónAgregar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // TBEmail
            // 
            this.TBEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmail.Location = new System.Drawing.Point(340, 349);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(392, 35);
            this.TBEmail.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Teléfono";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefono.Location = new System.Drawing.Point(340, 287);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(392, 35);
            this.TBTelefono.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellido Materno";
            // 
            // TBApellidoMaterno
            // 
            this.TBApellidoMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellidoMaterno.Location = new System.Drawing.Point(340, 218);
            this.TBApellidoMaterno.Name = "TBApellidoMaterno";
            this.TBApellidoMaterno.Size = new System.Drawing.Size(392, 35);
            this.TBApellidoMaterno.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Marca";
            // 
            // TBApellidoP
            // 
            this.TBApellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellidoP.Location = new System.Drawing.Point(340, 155);
            this.TBApellidoP.Name = "TBApellidoP";
            this.TBApellidoP.Size = new System.Drawing.Size(392, 35);
            this.TBApellidoP.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Precio Compra";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(340, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 35);
            this.textBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Producto";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBLPRODUCTOSBindingSource;
            this.comboBox1.DisplayMember = "CPRODUCTO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 28);
            this.comboBox1.TabIndex = 26;
            // 
            // dB_TIENDADataSet
            // 
            this.dB_TIENDADataSet.DataSetName = "DB_TIENDADataSet";
            this.dB_TIENDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLPRODUCTOSBindingSource
            // 
            this.tBLPRODUCTOSBindingSource.DataMember = "TBL_PRODUCTOS";
            this.tBLPRODUCTOSBindingSource.DataSource = this.dB_TIENDADataSet;
            // 
            // tBL_PRODUCTOSTableAdapter
            // 
            this.tBL_PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Agregar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 549);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BotónCancelar);
            this.Controls.Add(this.BotónAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBApellidoMaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBApellidoP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(834, 605);
            this.Name = "Agregar_Producto";
            this.Text = "Agregar_Producto";
            this.Load += new System.EventHandler(this.Agregar_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TIENDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPRODUCTOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotónCancelar;
        private System.Windows.Forms.Button BotónAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBApellidoMaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBApellidoP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private DB_TIENDADataSet dB_TIENDADataSet;
        private System.Windows.Forms.BindingSource tBLPRODUCTOSBindingSource;
        private DB_TIENDADataSetTableAdapters.TBL_PRODUCTOSTableAdapter tBL_PRODUCTOSTableAdapter;
    }
}