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
    public partial class CrearProductora : Form
    {
        public CrearProductora()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            Productora p = new Productora(Nombre_CP.Text, System.Convert.ToSingle(AñoCP.Text),WebCP.Text);
            CreateOneProductora(p);
        }
    }
}
