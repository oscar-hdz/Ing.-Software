namespace proyecto_shopsys
{
    partial class NuevoCliente
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
            this.BoxClase = new System.Windows.Forms.ComboBox();
            this.TBNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBApellidoP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBApellidoMaterno = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BotónCancelar = new System.Windows.Forms.Button();
            this.BotónAñadirCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxClase
            // 
            this.BoxClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxClase.FormattingEnabled = true;
            this.BoxClase.Items.AddRange(new object[] {
            "Cliente",
            "Proveedor"});
            this.BoxClase.Location = new System.Drawing.Point(547, 43);
            this.BoxClase.Name = "BoxClase";
            this.BoxClase.Size = new System.Drawing.Size(345, 37);
            this.BoxClase.TabIndex = 0;
            this.BoxClase.SelectedIndexChanged += new System.EventHandler(this.BoxClase_SelectedIndexChanged);
            // 
            // TBNombres
            // 
            this.TBNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombres.Location = new System.Drawing.Point(547, 128);
            this.TBNombres.Name = "TBNombres";
            this.TBNombres.Size = new System.Drawing.Size(345, 35);
            this.TBNombres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre(s)";
            // 
            // TBApellidoP
            // 
            this.TBApellidoP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellidoP.Location = new System.Drawing.Point(547, 198);
            this.TBApellidoP.Name = "TBApellidoP";
            this.TBApellidoP.Size = new System.Drawing.Size(345, 35);
            this.TBApellidoP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido Paterno";
            // 
            // TBApellidoMaterno
            // 
            this.TBApellidoMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellidoMaterno.Location = new System.Drawing.Point(547, 274);
            this.TBApellidoMaterno.Name = "TBApellidoMaterno";
            this.TBApellidoMaterno.Size = new System.Drawing.Size(345, 35);
            this.TBApellidoMaterno.TabIndex = 3;
            // 
            // TBTelefono
            // 
            this.TBTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefono.Location = new System.Drawing.Point(547, 344);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(345, 35);
            this.TBTelefono.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teléfono";
            // 
            // TBEmail
            // 
            this.TBEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmail.Location = new System.Drawing.Point(547, 422);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(345, 35);
            this.TBEmail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // BotónCancelar
            // 
            this.BotónCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BotónCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónCancelar.Location = new System.Drawing.Point(13, 514);
            this.BotónCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotónCancelar.Name = "BotónCancelar";
            this.BotónCancelar.Size = new System.Drawing.Size(220, 76);
            this.BotónCancelar.TabIndex = 5;
            this.BotónCancelar.Text = "Cancelar";
            this.BotónCancelar.UseVisualStyleBackColor = false;
            this.BotónCancelar.Click += new System.EventHandler(this.BotónCancelar_Click);
            // 
            // BotónAñadirCliente
            // 
            this.BotónAñadirCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BotónAñadirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónAñadirCliente.Location = new System.Drawing.Point(825, 514);
            this.BotónAñadirCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotónAñadirCliente.Name = "BotónAñadirCliente";
            this.BotónAñadirCliente.Size = new System.Drawing.Size(220, 76);
            this.BotónAñadirCliente.TabIndex = 4;
            this.BotónAñadirCliente.Text = "Añadir";
            this.BotónAñadirCliente.UseVisualStyleBackColor = false;
            this.BotónAñadirCliente.Click += new System.EventHandler(this.BotónAgregar_Click);
            // 
            // NuevoCliente
            // 
            this.AcceptButton = this.BotónAñadirCliente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1058, 604);
            this.Controls.Add(this.BotónCancelar);
            this.Controls.Add(this.BotónAñadirCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBApellidoP);
            this.Controls.Add(this.TBApellidoMaterno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBNombres);
            this.Controls.Add(this.BoxClase);
            this.MaximumSize = new System.Drawing.Size(1080, 660);
            this.MinimumSize = new System.Drawing.Size(1080, 660);
            this.Name = "NuevoCliente";
            this.Text = "Nueva Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BoxClase;
        private System.Windows.Forms.TextBox TBNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBApellidoP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBApellidoMaterno;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BotónCancelar;
        private System.Windows.Forms.Button BotónAñadirCliente;
    }
}