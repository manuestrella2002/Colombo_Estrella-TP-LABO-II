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
            Form_Tableros form_Tableros = new Form_Tableros();
            form_Tableros.Show();
            
        }
    }
}
