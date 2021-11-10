using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Security.Permissions;

namespace Colombo_Estrella_TP_LABO_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Imagenes\Ajedrez.jpg");

            System.Drawing.Image img = System.Drawing.Image.FromFile(path);

            this.BackgroundImage=(img);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nro_soluciones.Text==null)
            {
                nro_soluciones.Text = "10";
            }
            Form_Tableros form_Tableros = new Form_Tableros(int.Parse(nro_soluciones.Text));
            form_Tableros.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Justificacion = " ";
            MessageBox.Show(Justificacion);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
