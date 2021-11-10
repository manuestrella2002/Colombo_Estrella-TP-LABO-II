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
        public Label[,] Matriz1 = new Label[8,8];
        public Label[,] Matriz2= new Label[8, 8];
        public Label[,] Matriz3 = new Label[8, 8];
        public Label[,] Matriz4 = new Label[8, 8];
        public Label[,] Matriz5 = new Label[8, 8];
        public Label[,] Matriz6 = new Label[8, 8];
        public Label[,] Matriz7 = new Label[8, 8];
        public Label[,] Matriz8 = new Label[8, 8];
        public Label[,] Matriz9 = new Label[8, 8];
        public Label[,] Matriz10 = new Label[8, 8];

        public Juego Juego1;
        int aux;
        
        int i = 0;
        

        public Form_Tableros(int nro_sol)
        {
            InitializeComponent();
            label1.Hide();
            aux = nro_sol;
            Juego1 = new Juego(nro_sol);
            ArmarMatriz();
            
            if (i>10)
            {
                button1.Hide();
            }
            
        }
        private void ArmarMatriz()
        {
            int labelsize = panel1.Width / Juego1.MiTablero.Tam;

            //EL PANEL TIENE QUE SER UN CUADRADO ENTONCES LE DOY FORMA
            panel1.Height = panel1.Width;
            panel2.Height = panel2.Width;
            panel3.Height = panel3.Width;
            panel4.Height = panel4.Width;
            panel5.Height = panel5.Width;
            panel6.Height = panel6.Width;
            panel7.Height = panel7.Width;
            panel8.Height = panel8.Width;
            panel9.Height = panel9.Width;
            panel10.Height = panel10.Width;

            //CICLO FOR PARA RECORRER ARRAY
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //Creo cada boton y le doy forma
                    Matriz1[i, j] = new Label();
                    Matriz2[i, j] = new Label();
                    Matriz3[i, j] = new Label();
                    Matriz4[i, j] = new Label();
                    Matriz5[i, j] = new Label();
                    Matriz6[i, j] = new Label();
                    Matriz7[i, j] = new Label();
                    Matriz8[i, j] = new Label();
                    Matriz9[i, j] = new Label();
                    Matriz10[i, j] = new Label();

                    Matriz1[i, j].Height = labelsize;
                    Matriz2[i, j].Height = labelsize;
                    Matriz3[i, j].Height = labelsize;
                    Matriz4[i, j].Height = labelsize;
                    Matriz5[i, j].Height = labelsize;
                    Matriz6[i, j].Height = labelsize;
                    Matriz7[i, j].Height = labelsize;
                    Matriz8[i, j].Height = labelsize;
                    Matriz9[i, j].Height = labelsize;
                    Matriz10[i, j].Height = labelsize;

                    Matriz1[i, j].Width = labelsize;
                    Matriz2[i, j].Width = labelsize;
                    Matriz3[i, j].Width = labelsize;
                    Matriz4[i, j].Width = labelsize;
                    Matriz5[i, j].Width = labelsize;
                    Matriz6[i, j].Width = labelsize;
                    Matriz7[i, j].Width = labelsize;
                    Matriz8[i, j].Width = labelsize;
                    Matriz9[i, j].Width = labelsize;
                    Matriz10[i, j].Width = labelsize;

                    //COLOCO CADA BOTON EN UNA POSICION ESPECIFICA
                    Matriz1[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz2[i, j].Location = new Point(j * labelsize , i * labelsize);
                    Matriz3[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz4[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz5[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz6[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz7[i, j].Location = new Point(j * labelsize, i * labelsize );
                    Matriz8[i, j].Location = new Point(j * labelsize, i * labelsize );
                    Matriz9[i, j].Location = new Point(j * labelsize, i * labelsize );
                    Matriz10[i, j].Location = new Point(j * labelsize, i * labelsize);


                    Matriz1[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz2[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz3[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz4[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz5[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz6[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz7[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz8[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz9[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz10[i, j].BorderStyle = BorderStyle.FixedSingle;
                    //AGREGO LOS BOTONES AL PANEL
                    panel1.Controls.Add(Matriz1[i, j]);
                    panel2.Controls.Add(Matriz2[i, j]);
                    panel3.Controls.Add(Matriz3[i, j]);
                    panel4.Controls.Add(Matriz4[i, j]);
                    panel5.Controls.Add(Matriz5[i, j]);
                    panel6.Controls.Add(Matriz6[i, j]);
                    panel7.Controls.Add(Matriz7[i, j]);
                    panel8.Controls.Add(Matriz8[i, j]);
                    panel9.Controls.Add(Matriz9[i, j]);
                    panel10.Controls.Add(Matriz10[i, j]);
                    


                    //LE DOY COLOR A LOS BOTONES 
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Matriz1[i, j].BackColor = Color.FromArgb(217, 217, 217);//BLANCO
                        Matriz2[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz3[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz4[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz5[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz6[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz7[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz8[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz9[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz10[i, j].BackColor = Color.FromArgb(217, 217, 217);

                    }
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        Matriz1[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz2[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz3[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz4[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz5[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz6[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz7[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz8[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz9[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz10[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS

                    }
                    if (i % 2 != 0 && j % 2 == 0)
                    {
                        Matriz1[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz2[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz3[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz4[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz5[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz6[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz7[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz8[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz9[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                        Matriz10[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
                    }
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        Matriz1[i, j].BackColor = Color.FromArgb(217, 217, 217);//BLANCO
                        Matriz2[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz3[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz4[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz5[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz6[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz7[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz8[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz9[i, j].BackColor = Color.FromArgb(217, 217, 217);
                        Matriz10[i, j].BackColor = Color.FromArgb(217, 217, 217);
                    }
                  


                }
            }
        }

        private void InicializarMatriz()
        {
            
            for (int r = 0; r < aux; r++)
            {

                if (r == 0)
                {
                    CompletarMatriz(Matriz1);  
                }
                else if (r==1)
                {
                    CompletarMatriz(Matriz2);
                }
                else if (r == 2)
                {
                    CompletarMatriz(Matriz3);
                }
                else if (r == 3)
                {
                    CompletarMatriz(Matriz4);

                }
                else if (r == 4)
                {
                    CompletarMatriz(Matriz5);
                }
                else if (r == 5)
                {
                    CompletarMatriz(Matriz6);
                }
                else if (r == 6)
                {
                    CompletarMatriz(Matriz7);
                }
                else if (r == 7)
                {
                    CompletarMatriz(Matriz8);
                }
                else if (r == 8)
                {
                    CompletarMatriz(Matriz9);
                }
                else if (r == 9)
                {
                    CompletarMatriz(Matriz10);
                }

            }


        }

        private void CompletarMatriz(Label[,] Matriz_)
        {
            for (int i = 0; i < aux; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (Juego1.Sol_Matrices[i,j,k].Ocupados == true)
                        {
                            if (Juego1.Sol_Matrices[i, j, k].Pieza2 == null)
                            {
                                if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Caballo)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                                else if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Rey)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                                else if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Alfil)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                                else if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Reina)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                                else if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Torre)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                            }
                            else
                            {
                                if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Caballo && Juego1.Sol_Matrices[i, j, k].Pieza2 is Alfil)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                                else if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Alfil && Juego1.Sol_Matrices[i, j, k].Pieza2 is Caballo)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                                else if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Rey)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                                else if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Reina)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                                else if (Juego1.Sol_Matrices[i, j, k].Pieza1 is Torre)
                                {
                                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                    Matriz_[j, k].BackgroundImage = Image.FromFile(path);
                                    Matriz_[j, k].BackgroundImageLayout = ImageLayout.Zoom;
                                }
                            }
                        }
                        else if (Juego1.Sol_Matrices[i, j, k].Legal_Movim == true)
                        {
                            Matriz_[k, j].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            InicializarMatriz();
            
            
            
        }
    }
}





