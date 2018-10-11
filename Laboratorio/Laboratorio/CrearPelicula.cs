using System;
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
    public partial class CrearPelicula : Form
    {
        public CrearPelicula()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            string[] actores = new string[10];
            Actores a = new Actores(actores);
            Pelicula p = new Pelicula(Nombre_P.Text,Genero_P.Text,Nombre_D.Text,
                Franquicia_P.Text,Pais_P.Text,Año_P.Text, System.Convert.ToSingle(Duracion_P.Text),Productora_P.Text,a);
            CreateOnePelicula(p);
        }
    }
}
