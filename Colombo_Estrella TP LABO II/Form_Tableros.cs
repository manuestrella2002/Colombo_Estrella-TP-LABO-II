using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Security.Permissions;

namespace Colombo_Estrella_TP_LABO_II
{
    public partial class Form_Tableros : Form
    {
        public Label[,] Matriz = new Label[8,8];

        public Form_Tableros()
        {
            InitializeComponent();
            ArmarMatriz();
            Juego juego1 = new Juego();
            
        }

        private void ArmarMatriz()
        {
            //SE CREAN LOS BOTONES Y SE LOS COLOCAN EN EL PANEL
            int labelsize = panel1.Width / 8;

            //EL PANEL TIENE QUE SER UN CUADRADO ENTONCES LE DOY FORMA
            panel1.Height = panel1.Width;

            //CICLO FOR PARA RECORRER ARRAY
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //Creo cada boton y le doy forma
                    Matriz[i, j] = new Label();
                    Matriz[i, j].Height = labelsize;
                    Matriz[i, j].Width = labelsize;

                    Matriz[i, j].Tag = new Point(j, i);
                    //COLOCO CADA BOTON EN UNA POSICION ESPECIFICA
                    Matriz[i, j].Location = new Point(j * labelsize, i * labelsize);



                    //AGREGO LOS BOTONES AL PANEL
                    panel1.Controls.Add(Matriz[i, j]);

                    //LE DOY COLOR A LOS BOTONES 
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Matriz[i, j].BackColor = Color.FromArgb(217, 217, 217);//BLANCO
                    }
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        Matriz[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                    }
                    if (i % 2 != 0 && j % 2 == 0)
                    {
                        Matriz[i, j].BackColor = Color.FromArgb(146, 146, 146);
                    }
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        Matriz[i, j].BackColor = Color.FromArgb(217, 217, 217);
                    }

                    //MUESTRO EN CADA BOTON LA POSICION QUE OCUPA
                    Matriz[i, j].Text = i + "|" + j;

               }
            }

        }
    }
}





