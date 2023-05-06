namespace Abstraccion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL1 = new System.Windows.Forms.Label();
            this.BTN_Demostrar = new System.Windows.Forms.Button();
            this.TXB_Titulo = new System.Windows.Forms.TextBox();
            this.TXB_Costo = new System.Windows.Forms.TextBox();
            this.TXB_Precio = new System.Windows.Forms.TextBox();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.LBL_Costo = new System.Windows.Forms.Label();
            this.LBL_Precio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(292, 220);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(35, 13);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "label1";
            // 
            // BTN_Demostrar
            // 
            this.BTN_Demostrar.Location = new System.Drawing.Point(273, 325);
            this.BTN_Demostrar.Name = "BTN_Demostrar";
            this.BTN_Demostrar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Demostrar.TabIndex = 2;
            this.BTN_Demostrar.Text = "Demostrar";
            this.BTN_Demostrar.UseVisualStyleBackColor = true;
            this.BTN_Demostrar.Click += new System.EventHandler(this.BTN_Demostrar_Click);
            // 
            // TXB_Titulo
            // 
            this.TXB_Titulo.Location = new System.Drawing.Point(28, 87);
            this.TXB_Titulo.Name = "TXB_Titulo";
            this.TXB_Titulo.Size = new System.Drawing.Size(100, 20);
            this.TXB_Titulo.TabIndex = 3;
            // 
            // TXB_Costo
            // 
            this.TXB_Costo.Location = new System.Drawing.Point(260, 129);
            this.TXB_Costo.Name = "TXB_Costo";
            this.TXB_Costo.Size = new System.Drawing.Size(100, 20);
            this.TXB_Costo.TabIndex = 4;
            // 
            // TXB_Precio
            // 
            this.TXB_Precio.Location = new System.Drawing.Point(488, 87);
            this.TXB_Precio.Name = "TXB_Precio";
            this.TXB_Precio.Size = new System.Drawing.Size(100, 20);
            this.TXB_Precio.TabIndex = 5;
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Location = new System.Drawing.Point(38, 129);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(76, 13);
            this.LBL_Titulo.TabIndex = 6;
            this.LBL_Titulo.Text = "Titulo del Libro";
            // 
            // LBL_Costo
            // 
            this.LBL_Costo.AutoSize = true;
            this.LBL_Costo.Location = new System.Drawing.Point(271, 161);
            this.LBL_Costo.Name = "LBL_Costo";
            this.LBL_Costo.Size = new System.Drawing.Size(77, 13);
            this.LBL_Costo.TabIndex = 7;
            this.LBL_Costo.Text = "Costo del Libro";
            this.LBL_Costo.Click += new System.EventHandler(this.label3_Click);
            // 
            // LBL_Precio
            // 
            this.LBL_Precio.AutoSize = true;
            this.LBL_Precio.Location = new System.Drawing.Point(519, 129);
            this.LBL_Precio.Name = "LBL_Precio";
            this.LBL_Precio.Size = new System.Drawing.Size(80, 13);
            this.LBL_Precio.TabIndex = 8;
            this.LBL_Precio.Text = "Precio del Libro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 385);
            this.Controls.Add(this.LBL_Precio);
            this.Controls.Add(this.LBL_Costo);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.TXB_Precio);
            this.Controls.Add(this.TXB_Costo);
            this.Controls.Add(this.TXB_Titulo);
            this.Controls.Add(this.BTN_Demostrar);
            this.Controls.Add(this.LBL1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Button BTN_Demostrar;
        private System.Windows.Forms.TextBox TXB_Titulo;
        private System.Windows.Forms.TextBox TXB_Costo;
        private System.Windows.Forms.TextBox TXB_Precio;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label LBL_Costo;
        private System.Windows.Forms.Label LBL_Precio;
    }
}

