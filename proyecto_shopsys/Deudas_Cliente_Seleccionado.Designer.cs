namespace proyecto_shopsys
{
    partial class Deudas_Cliente_Seleccionado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BotónSaldarDeuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // BotónSaldarDeuda
            // 
            this.BotónSaldarDeuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotónSaldarDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónSaldarDeuda.Location = new System.Drawing.Point(0, 392);
            this.BotónSaldarDeuda.Margin = new System.Windows.Forms.Padding(0);
            this.BotónSaldarDeuda.Name = "BotónSaldarDeuda";
            this.BotónSaldarDeuda.Size = new System.Drawing.Size(800, 58);
            this.BotónSaldarDeuda.TabIndex = 1;
            this.BotónSaldarDeuda.Text = "Saldar Deuda";
            this.BotónSaldarDeuda.UseVisualStyleBackColor = true;
            this.BotónSaldarDeuda.Click += new System.EventHandler(this.BotónSaldarDeuda_Click);
            // 
            // Deudas_Cliente_Seleccionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotónSaldarDeuda);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Deudas_Cliente_Seleccionado";
            this.Text = "Deudas_Cliente_Seleccionado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BotónSaldarDeuda;
    }
}