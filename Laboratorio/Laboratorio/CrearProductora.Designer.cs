namespace Laboratorio
{
    partial class CrearProductora
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
            this.Crear = new System.Windows.Forms.Button();
            this.WebCP = new System.Windows.Forms.TextBox();
            this.AñoCP = new System.Windows.Forms.TextBox();
            this.Nombre_CP = new System.Windows.Forms.TextBox();
            this.Web = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.Label();
            this.NombreP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(221, 406);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(397, 73);
            this.Crear.TabIndex = 56;
            this.Crear.Text = "Insertar";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // WebCP
            // 
            this.WebCP.Location = new System.Drawing.Point(386, 215);
            this.WebCP.Name = "WebCP";
            this.WebCP.Size = new System.Drawing.Size(201, 22);
            this.WebCP.TabIndex = 49;
            // 
            // AñoCP
            // 
            this.AñoCP.Location = new System.Drawing.Point(386, 153);
            this.AñoCP.Name = "AñoCP";
            this.AñoCP.Size = new System.Drawing.Size(201, 22);
            this.AñoCP.TabIndex = 48;
            // 
            // Nombre_CP
            // 
            this.Nombre_CP.Location = new System.Drawing.Point(386, 82);
            this.Nombre_CP.Name = "Nombre_CP";
            this.Nombre_CP.Size = new System.Drawing.Size(201, 22);
            this.Nombre_CP.TabIndex = 47;
            // 
            // Web
            // 
            this.Web.AutoSize = true;
            this.Web.Location = new System.Drawing.Point(251, 220);
            this.Web.Name = "Web";
            this.Web.Size = new System.Drawing.Size(37, 17);
            this.Web.TabIndex = 40;
            this.Web.Text = "Web";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Location = new System.Drawing.Point(250, 156);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(33, 17);
            this.Año.TabIndex = 39;
            this.Año.Text = "Año";
            // 
            // NombreP
            // 
            this.NombreP.AutoSize = true;
            this.NombreP.Location = new System.Drawing.Point(251, 87);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(132, 17);
            this.NombreP.TabIndex = 38;
            this.NombreP.Text = "Nombre Productora";
            // 
            // CrearProductora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 517);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.WebCP);
            this.Controls.Add(this.AñoCP);
            this.Controls.Add(this.Nombre_CP);
            this.Controls.Add(this.Web);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.NombreP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearProductora";
            this.Text = "CrearProductora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.TextBox WebCP;
        private System.Windows.Forms.TextBox AñoCP;
        private System.Windows.Forms.TextBox Nombre_CP;
        private System.Windows.Forms.Label Web;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.Label NombreP;
    }
}