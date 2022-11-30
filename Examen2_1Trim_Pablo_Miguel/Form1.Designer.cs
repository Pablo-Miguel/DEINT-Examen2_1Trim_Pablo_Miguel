namespace Examen2_1Trim_Pablo_Miguel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnadirProd = new System.Windows.Forms.Button();
            this.btnEliminarFab = new System.Windows.Forms.Button();
            this.btnMostrarProdFab = new System.Windows.Forms.Button();
            this.btnVentaMayMen = new System.Windows.Forms.Button();
            this.btnFabSinPrecio = new System.Windows.Forms.Button();
            this.btnProdOrd = new System.Windows.Forms.Button();
            this.btnMostrarProd = new System.Windows.Forms.Button();
            this.btnMostrarFab = new System.Windows.Forms.Button();
            this.dgTiendaVista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiendaVista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnadirProd
            // 
            this.btnAnadirProd.Location = new System.Drawing.Point(12, 12);
            this.btnAnadirProd.Name = "btnAnadirProd";
            this.btnAnadirProd.Size = new System.Drawing.Size(105, 59);
            this.btnAnadirProd.TabIndex = 0;
            this.btnAnadirProd.Text = "Añadir productos";
            this.btnAnadirProd.UseVisualStyleBackColor = true;
            this.btnAnadirProd.Click += new System.EventHandler(this.btnAnadirProd_Click);
            // 
            // btnEliminarFab
            // 
            this.btnEliminarFab.Location = new System.Drawing.Point(12, 77);
            this.btnEliminarFab.Name = "btnEliminarFab";
            this.btnEliminarFab.Size = new System.Drawing.Size(105, 59);
            this.btnEliminarFab.TabIndex = 1;
            this.btnEliminarFab.Text = "Eliminar fabricante";
            this.btnEliminarFab.UseVisualStyleBackColor = true;
            this.btnEliminarFab.Click += new System.EventHandler(this.btnEliminarFab_Click);
            // 
            // btnMostrarProdFab
            // 
            this.btnMostrarProdFab.Location = new System.Drawing.Point(12, 142);
            this.btnMostrarProdFab.Name = "btnMostrarProdFab";
            this.btnMostrarProdFab.Size = new System.Drawing.Size(186, 59);
            this.btnMostrarProdFab.TabIndex = 2;
            this.btnMostrarProdFab.Text = "Mostrar productos fabricante";
            this.btnMostrarProdFab.UseVisualStyleBackColor = true;
            this.btnMostrarProdFab.Click += new System.EventHandler(this.btnMostrarProdFab_Click);
            // 
            // btnVentaMayMen
            // 
            this.btnVentaMayMen.Location = new System.Drawing.Point(12, 207);
            this.btnVentaMayMen.Name = "btnVentaMayMen";
            this.btnVentaMayMen.Size = new System.Drawing.Size(186, 59);
            this.btnVentaMayMen.TabIndex = 3;
            this.btnVentaMayMen.Text = "Precio de venta mayor y menor";
            this.btnVentaMayMen.UseVisualStyleBackColor = true;
            this.btnVentaMayMen.Click += new System.EventHandler(this.btnVentaMayMen_Click);
            // 
            // btnFabSinPrecio
            // 
            this.btnFabSinPrecio.Location = new System.Drawing.Point(12, 272);
            this.btnFabSinPrecio.Name = "btnFabSinPrecio";
            this.btnFabSinPrecio.Size = new System.Drawing.Size(186, 59);
            this.btnFabSinPrecio.TabIndex = 4;
            this.btnFabSinPrecio.Text = "Fabricantes sin precio";
            this.btnFabSinPrecio.UseVisualStyleBackColor = true;
            this.btnFabSinPrecio.Click += new System.EventHandler(this.btnFabSinPrecio_Click);
            // 
            // btnProdOrd
            // 
            this.btnProdOrd.Location = new System.Drawing.Point(12, 337);
            this.btnProdOrd.Name = "btnProdOrd";
            this.btnProdOrd.Size = new System.Drawing.Size(186, 59);
            this.btnProdOrd.TabIndex = 5;
            this.btnProdOrd.Text = "Productos ordenados ascendente";
            this.btnProdOrd.UseVisualStyleBackColor = true;
            this.btnProdOrd.Click += new System.EventHandler(this.btnProdOrd_Click);
            // 
            // btnMostrarProd
            // 
            this.btnMostrarProd.Location = new System.Drawing.Point(123, 12);
            this.btnMostrarProd.Name = "btnMostrarProd";
            this.btnMostrarProd.Size = new System.Drawing.Size(75, 59);
            this.btnMostrarProd.TabIndex = 6;
            this.btnMostrarProd.Text = "Mostrar productos";
            this.btnMostrarProd.UseVisualStyleBackColor = true;
            this.btnMostrarProd.Click += new System.EventHandler(this.btnMostrarProd_Click);
            // 
            // btnMostrarFab
            // 
            this.btnMostrarFab.Location = new System.Drawing.Point(123, 77);
            this.btnMostrarFab.Name = "btnMostrarFab";
            this.btnMostrarFab.Size = new System.Drawing.Size(75, 59);
            this.btnMostrarFab.TabIndex = 7;
            this.btnMostrarFab.Text = "Mostrar fabricantes";
            this.btnMostrarFab.UseVisualStyleBackColor = true;
            this.btnMostrarFab.Click += new System.EventHandler(this.btnMostrarFab_Click);
            // 
            // dgTiendaVista
            // 
            this.dgTiendaVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTiendaVista.Location = new System.Drawing.Point(204, 12);
            this.dgTiendaVista.Name = "dgTiendaVista";
            this.dgTiendaVista.Size = new System.Drawing.Size(584, 426);
            this.dgTiendaVista.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgTiendaVista);
            this.Controls.Add(this.btnMostrarFab);
            this.Controls.Add(this.btnMostrarProd);
            this.Controls.Add(this.btnProdOrd);
            this.Controls.Add(this.btnFabSinPrecio);
            this.Controls.Add(this.btnVentaMayMen);
            this.Controls.Add(this.btnMostrarProdFab);
            this.Controls.Add(this.btnEliminarFab);
            this.Controls.Add(this.btnAnadirProd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgTiendaVista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnadirProd;
        private System.Windows.Forms.Button btnEliminarFab;
        private System.Windows.Forms.Button btnMostrarProdFab;
        private System.Windows.Forms.Button btnVentaMayMen;
        private System.Windows.Forms.Button btnFabSinPrecio;
        private System.Windows.Forms.Button btnProdOrd;
        private System.Windows.Forms.Button btnMostrarProd;
        private System.Windows.Forms.Button btnMostrarFab;
        private System.Windows.Forms.DataGridView dgTiendaVista;
    }
}

