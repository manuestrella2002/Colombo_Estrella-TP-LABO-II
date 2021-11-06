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
        Juego Juego1 = new Juego();
        int i = 0;
        

        public Form_Tableros()
        {
            InitializeComponent();
            label1.Hide();
            ArmarMatriz();
            
            
        }
        private void ArmarMatriz()
        {
            int labelsize = panel1.Width / Juego1.MiTablero.Tam;

            //EL PANEL TIENE QUE SER UN CUADRADO ENTONCES LE DOY FORMA
            panel1.Height = panel1.Width;
            panel2.Height = panel2.Width;

            //CICLO FOR PARA RECORRER ARRAY
            for (int i = 0; i < Juego1.MiTablero.Tam; i++)
            {
                for (int j = 0; j < Juego1.MiTablero.Tam; j++)
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

        private void InicializarMatriz(int pos)
        {
            //SE CREAN LOS BOTONES Y SE LOS COLOCAN EN EL PANEL

            for (int i = 0; i < 8; i++)
            {
                for (int t = 0; t < 8; t++)
                {
                    Matriz[i, t].BackgroundImage = default;
                    //LE DOY COLOR A LOS BOTONES 
                    if (i % 2 == 0 && t % 2 == 0)
                    {
                        Matriz[i, t].BackColor = Color.FromArgb(217, 217, 217);//BLANCO
                    }
                    if (i % 2 == 0 && t % 2 != 0)
                    {
                        Matriz[i, t].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                    }
                    if (i % 2 != 0 && t % 2 == 0)
                    {
                        Matriz[i, t].BackColor = Color.FromArgb(146, 146, 146);
                    }
                    if (i % 2 != 0 && t % 2 != 0)
                    {
                        Matriz[i, t].BackColor = Color.FromArgb(217, 217, 217);
                    }

                    //MUESTRO EN CADA BOTON LA POSICION QUE OCUPA
                    Matriz[i, t].Text = i + "|" + t;
                }
            }
            
            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j,k].Ocupados==true)
                    {
                        if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza2==null)
                        {
                            if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Caballo)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            else if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Rey)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            else if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Alfil)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            else if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Reina)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            else if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Torre)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                        }
                        else
                        {
                            if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Caballo && Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza2 is Alfil)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            else if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Alfil && Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza2 is Caballo)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            else if(Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Rey)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            else if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Reina)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            else if (Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Pieza1 is Torre)
                            {
                                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                Matriz[j, k].BackgroundImage = Image.FromFile(path);
                                Matriz[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                            }
                        }
                    }
                    else if(Juego1.Soluciones_Encontradas.ElementAt(pos)[j, k].Legal_Movim == true)
                    {
                        Matriz[k, j].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = ("Tablero" + (i+1).ToString());
            InicializarMatriz(i);
            i++;
        }
    }
}





