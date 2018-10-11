namespace Laboratorio
{
    partial class Programa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrearPelicula = new System.Windows.Forms.Button();
            this.CrearProductora = new System.Windows.Forms.Button();
            this.ConsultarTitulo = new System.Windows.Forms.Button();
            this.ConsultaFranquicia = new System.Windows.Forms.Button();
            this.ConsultaAño = new System.Windows.Forms.Button();
            this.ConsultaProductora = new System.Windows.Forms.Button();
            this.ConsultaEstadisticas = new System.Windows.Forms.Button();
            this.ActualizarPelicula = new System.Windows.Forms.Button();
            this.ActualizaProductora = new System.Windows.Forms.Button();
            this.BorrarPelicula = new System.Windows.Forms.Button();
            this.BorrarProductora = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BorrarProductora);
            this.panel1.Controls.Add(this.BorrarPelicula);
            this.panel1.Controls.Add(this.ActualizaProductora);
            this.panel1.Controls.Add(this.ActualizarPelicula);
            this.panel1.Controls.Add(this.ConsultaEstadisticas);
            this.panel1.Controls.Add(this.ConsultaProductora);
            this.panel1.Controls.Add(this.ConsultaAño);
            this.panel1.Controls.Add(this.ConsultaFranquicia);
            this.panel1.Controls.Add(this.ConsultarTitulo);
            this.panel1.Controls.Add(this.CrearProductora);
            this.panel1.Controls.Add(this.CrearPelicula);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 564);
            this.panel1.TabIndex = 0;
            // 
            // CrearPelicula
            // 
            this.CrearPelicula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CrearPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CrearPelicula.Location = new System.Drawing.Point(0, 3);
            this.CrearPelicula.Name = "CrearPelicula";
            this.CrearPelicula.Size = new System.Drawing.Size(313, 45);
            this.CrearPelicula.TabIndex = 0;
            this.CrearPelicula.Text = "Crear Pelicula";
            this.CrearPelicula.UseVisualStyleBackColor = true;
            this.CrearPelicula.Click += new System.EventHandler(this.CrearPelicula_Click);
            // 
            // CrearProductora
            // 
            this.CrearProductora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CrearProductora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CrearProductora.Location = new System.Drawing.Point(0, 54);
            this.CrearProductora.Name = "CrearProductora";
            this.CrearProductora.Size = new System.Drawing.Size(313, 45);
            this.CrearProductora.TabIndex = 1;
            this.CrearProductora.Text = "Crear Productora";
            this.CrearProductora.UseVisualStyleBackColor = true;
            this.CrearProductora.Click += new System.EventHandler(this.CrearProductora_Click);
            // 
            // ConsultarTitulo
            // 
            this.ConsultarTitulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ConsultarTitulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ConsultarTitulo.Location = new System.Drawing.Point(0, 105);
            this.ConsultarTitulo.Name = "ConsultarTitulo";
            this.ConsultarTitulo.Size = new System.Drawing.Size(313, 45);
            this.ConsultarTitulo.TabIndex = 2;
            this.ConsultarTitulo.Text = "Consultar Pelicula por Titulo";
            this.ConsultarTitulo.UseVisualStyleBackColor = true;
            this.ConsultarTitulo.Click += new System.EventHandler(this.ConsultarTitulo_Click);
            // 
            // ConsultaFranquicia
            // 
            this.ConsultaFranquicia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ConsultaFranquicia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ConsultaFranquicia.Location = new System.Drawing.Point(0, 156);
            this.ConsultaFranquicia.Name = "ConsultaFranquicia";
            this.ConsultaFranquicia.Size = new System.Drawing.Size(313, 45);
            this.ConsultaFranquicia.TabIndex = 3;
            this.ConsultaFranquicia.Text = "Consultar Pelicula por Franquicia";
            this.ConsultaFranquicia.UseVisualStyleBackColor = true;
            this.ConsultaFranquicia.Click += new System.EventHandler(this.ConsultaFranquicia_Click);
            // 
            // ConsultaAño
            // 
            this.ConsultaAño.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ConsultaAño.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ConsultaAño.Location = new System.Drawing.Point(0, 207);
            this.ConsultaAño.Name = "ConsultaAño";
            this.ConsultaAño.Size = new System.Drawing.Size(313, 45);
            this.ConsultaAño.TabIndex = 4;
            this.ConsultaAño.Text = "Consultar Pelicula por Año";
            this.ConsultaAño.UseVisualStyleBackColor = true;
            this.ConsultaAño.Click += new System.EventHandler(this.ConsultaAño_Click);
            // 
            // ConsultaProductora
            // 
            this.ConsultaProductora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ConsultaProductora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ConsultaProductora.Location = new System.Drawing.Point(0, 258);
            this.ConsultaProductora.Name = "ConsultaProductora";
            this.ConsultaProductora.Size = new System.Drawing.Size(313, 45);
            this.ConsultaProductora.TabIndex = 5;
            this.ConsultaProductora.Text = "Consultar Pelicula por Productora";
            this.ConsultaProductora.UseVisualStyleBackColor = true;
            this.ConsultaProductora.Click += new System.EventHandler(this.ConsultaProductora_Click);
            // 
            // ConsultaEstadisticas
            // 
            this.ConsultaEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ConsultaEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ConsultaEstadisticas.Location = new System.Drawing.Point(0, 309);
            this.ConsultaEstadisticas.Name = "ConsultaEstadisticas";
            this.ConsultaEstadisticas.Size = new System.Drawing.Size(313, 45);
            this.ConsultaEstadisticas.TabIndex = 6;
            this.ConsultaEstadisticas.Text = "Estadisticas Productora";
            this.ConsultaEstadisticas.UseVisualStyleBackColor = true;
            this.ConsultaEstadisticas.Click += new System.EventHandler(this.ConsultaEstadisticas_Click);
            // 
            // ActualizarPelicula
            // 
            this.ActualizarPelicula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ActualizarPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ActualizarPelicula.Location = new System.Drawing.Point(0, 360);
            this.ActualizarPelicula.Name = "ActualizarPelicula";
            this.ActualizarPelicula.Size = new System.Drawing.Size(313, 45);
            this.ActualizarPelicula.TabIndex = 7;
            this.ActualizarPelicula.Text = "Actualizar Pelicula";
            this.ActualizarPelicula.UseVisualStyleBackColor = true;
            this.ActualizarPelicula.Click += new System.EventHandler(this.ActualizarPelicula_Click);
            // 
            // ActualizaProductora
            // 
            this.ActualizaProductora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ActualizaProductora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ActualizaProductora.Location = new System.Drawing.Point(0, 411);
            this.ActualizaProductora.Name = "ActualizaProductora";
            this.ActualizaProductora.Size = new System.Drawing.Size(313, 45);
            this.ActualizaProductora.TabIndex = 8;
            this.ActualizaProductora.Text = "Actualizar Productora";
            this.ActualizaProductora.UseVisualStyleBackColor = true;
            this.ActualizaProductora.Click += new System.EventHandler(this.ActualizaProductora_Click);
            // 
            // BorrarPelicula
            // 
            this.BorrarPelicula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BorrarPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BorrarPelicula.Location = new System.Drawing.Point(0, 462);
            this.BorrarPelicula.Name = "BorrarPelicula";
            this.BorrarPelicula.Size = new System.Drawing.Size(313, 45);
            this.BorrarPelicula.TabIndex = 9;
            this.BorrarPelicula.Text = "Borrar Pelicula";
            this.BorrarPelicula.UseVisualStyleBackColor = true;
            this.BorrarPelicula.Click += new System.EventHandler(this.BorrarPelicula_Click);
            // 
            // BorrarProductora
            // 
            this.BorrarProductora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BorrarProductora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BorrarProductora.Location = new System.Drawing.Point(0, 513);
            this.BorrarProductora.Name = "BorrarProductora";
            this.BorrarProductora.Size = new System.Drawing.Size(313, 45);
            this.BorrarProductora.TabIndex = 10;
            this.BorrarProductora.Text = "Borrar Productora";
            this.BorrarProductora.UseVisualStyleBackColor = true;
            this.BorrarProductora.Click += new System.EventHandler(this.BorrarProductora_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(313, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(870, 564);
            this.panelContenedor.TabIndex = 11;
            // 
            // Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 564);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "Programa";
            this.Text = "Programa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BorrarProductora;
        private System.Windows.Forms.Button BorrarPelicula;
        private System.Windows.Forms.Button ActualizaProductora;
        private System.Windows.Forms.Button ActualizarPelicula;
        private System.Windows.Forms.Button ConsultaEstadisticas;
        private System.Windows.Forms.Button ConsultaProductora;
        private System.Windows.Forms.Button ConsultaAño;
        private System.Windows.Forms.Button ConsultaFranquicia;
        private System.Windows.Forms.Button ConsultarTitulo;
        private System.Windows.Forms.Button CrearProductora;
        private System.Windows.Forms.Button CrearPelicula;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

