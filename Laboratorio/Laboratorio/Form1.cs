﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Laboratorio.Program;

namespace Laboratorio
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void CrearPelicula_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CrearPelicula());
        }

        private void CrearProductora_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CrearProductora());
        }

        private void ConsultarTitulo_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ConsultaTitulo());
            TituloPelicula("a");
        }

        private void ConsultaFranquicia_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ConsultaFranquicia());
            FranquiciaPelicula("a");
        }

        private void ConsultaAño_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ConsultaAño());
            AñoPelicula(2015,2020);

        }

        private void ConsultaProductora_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ConsultaProductora());
            ProductoraPelicula("b");
        }

        private void ConsultaEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Estadisticas());
        }

        private void ActualizarPelicula_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ActualizaPelicula());
            UpdatePelicula("aa", "z");
        }

        private void ActualizaProductora_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ActualizaProductora());
            UpdateProductora("b", "n");
        }

        private void BorrarPelicula_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new BorraPelicula());
            DeletePelicula("z");
        }

        private void BorrarProductora_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new BorraProductora());
            DeleteProductora("n");
        }
    }
}
