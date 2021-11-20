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
      
        public Juego Juego1;
        int aux;
        int contador;
        Label[,] Matriz;
         Label[,] Matriz1;
         Label[,] Matriz2;
         Label[,] Matriz3;
         Label[,] Matriz4;
         Label[,] Matriz5;
         Label[,] Matriz6;
         Label[,] Matriz7;
         Label[,] Matriz8;
         Label[,] Matriz9;


        public Form_Tableros(int nro_sol)
        {
            InitializeComponent();
            label1.Hide();
            aux = nro_sol;
            Juego1 = new Juego(nro_sol);
            contador = 0;
            Matriz = new Label[8, 8];
            Matriz1 = new Label[8, 8];
            Matriz2 = new Label[8, 8];
            Matriz3 = new Label[8, 8];
            Matriz4 = new Label[8, 8];
            Matriz5 = new Label[8, 8];
            Matriz6 = new Label[8, 8];
            Matriz7 = new Label[8, 8];
            Matriz8 = new Label[8, 8];
            Matriz9 = new Label[8, 8];
            CompletarMatrices();
            if (contador==0)
            {
                label1.Text = "Tablero"+" " + (contador + 1).ToString();
                label1.Show();
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz[i, j]);
                    }
                }
                contador++;
            }
        }

        private void CompletarMatrices()
        {
            int labelsize = panel1.Width / Juego1.MiTablero.Tam;
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
                    Matriz[i, j] = new Label();

                    Matriz1[i, j].Height = labelsize;
                    Matriz2[i, j].Height = labelsize;
                    Matriz3[i, j].Height = labelsize;
                    Matriz4[i, j].Height = labelsize;
                    Matriz5[i, j].Height = labelsize;
                    Matriz6[i, j].Height = labelsize;
                    Matriz7[i, j].Height = labelsize;
                    Matriz8[i, j].Height = labelsize;
                    Matriz9[i, j].Height = labelsize;
                    Matriz[i, j].Height = labelsize;

                    Matriz1[i, j].Width = labelsize;
                    Matriz2[i, j].Width = labelsize;
                    Matriz3[i, j].Width = labelsize;
                    Matriz4[i, j].Width = labelsize;
                    Matriz5[i, j].Width = labelsize;
                    Matriz6[i, j].Width = labelsize;
                    Matriz7[i, j].Width = labelsize;
                    Matriz8[i, j].Width = labelsize;
                    Matriz9[i, j].Width = labelsize;
                    Matriz[i, j].Width = labelsize;

                    //COLOCO CADA BOTON EN UNA POSICION ESPECIFICA
                    Matriz1[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz2[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz3[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz4[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz5[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz6[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz7[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz8[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz9[i, j].Location = new Point(j * labelsize, i * labelsize);
                    Matriz[i, j].Location = new Point(j * labelsize, i * labelsize);


                    Matriz1[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz2[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz3[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz4[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz5[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz6[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz7[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz8[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz9[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Matriz[i, j].BorderStyle = BorderStyle.FixedSingle;
                    
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
                        Matriz[i, j].BackColor = Color.FromArgb(217, 217, 217);

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
                        Matriz[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS

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
                        Matriz[i, j].BackColor = Color.FromArgb(146, 146, 146);//GRIS
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
                        Matriz[i, j].BackColor = Color.FromArgb(217, 217, 217);
                    }

                    

                }
            }
            for (int k = 0; k < aux; k++)
            {
                for (int l = 0; l < 8; l++)
                {
                    for (int n = 0; n < 8; n++)
                    {
                        if (k == 0)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz[l, n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                        else if (k == 1)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz1[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz1[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz1[l,n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                        else if (k == 2)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz2[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz2[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz2[l,n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                        else if (k == 3)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz3[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz3[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz3[l,n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                        else if (k == 4)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz4[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz4[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz4[l,n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                        else if (k == 5)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz5[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz5[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz5[l,n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                        else if (k == 6)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz6[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz6[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz6[l,n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                        else if (k == 7)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz7[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz7[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz7[l,n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                        else if (k == 8)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz8[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz8[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz8[l,n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                        else if (k == 9)
                        {
                            if (Juego1.Sol_Matrices[k, l, n].Ocupados == true)
                            {
                                if (Juego1.Sol_Matrices[k, l, n].Pieza2 == null)
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Caballo.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Alfil.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                                else
                                {
                                    if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Caballo && Juego1.Sol_Matrices[k, l, n].Pieza2 is Alfil)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Alfil && Juego1.Sol_Matrices[k, l, n].Pieza2 is Caballo)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\CaballoAlfil.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Rey)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Rey.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Reina)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Reina.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                    else if (Juego1.Sol_Matrices[k, l, n].Pieza1 is Torre)
                                    {
                                        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Iconos Ajedrez\Torre.jpg");
                                        Matriz9[l,n].BackgroundImage = Image.FromFile(path);
                                        Matriz9[l,n].BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                            else /*if (Juego1.Sol_Matrices[contador, j, k].Legal_Movim == true)*/
                            {
                                Matriz9[l,n].BackColor = Color.FromArgb(0, 102, 255); //AZUL ATAQUE
                            }
                        }
                    }
                }
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Tablero " + (contador+1).ToString();
            label1.Show();
            panel1.Controls.Clear();
            if (contador==0)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz[i,j]);
                    }
                }
                contador++;
            }
            else if (contador==1)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    { 
                        panel1.Controls.Add(Matriz1[i, j]);
                    }
                }
                contador++;
            }
            else if (contador == 2)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz2[i, j]);
                    }
                }
                contador++;
            }
            else if (contador == 3)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz3[i, j]);
                    }
                }
                contador++;
            }
            else if (contador == 4)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz4[i, j]);
                    }
                }
                contador++;
            }
            else if (contador == 5)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz5[i, j]);
                    }
                }
                contador++;
            }
            else if (contador == 6)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz6[i, j]);
                    }
                }
                contador++;
            }
            else if (contador == 7)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz7[i, j]);
                    }
                }
                contador++;
            }
            else if (contador == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz8[i, j]);
                    }
                }
                contador++;
            }
            else if (contador == 9)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz9[i, j]);
                    }
                }
                contador++;
            }
            
            if (contador>=aux)
            {

                button1.Enabled = false;
                contador = aux-1;
            }
            else
            {
                button1.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Tablero " + (contador+1).ToString();
            label1.Show();
            panel1.Controls.Clear();
            
            if (contador == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz[i, j]);
                    }
                }
                contador--;
            }
            else if (contador == 1)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz1[i, j]);
                    }
                }
               contador--;
            }
            else if (contador == 2)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz2[i, j]);
                    }
                }
               contador--;
            }
            else if (contador == 3)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz3[i, j]);
                    }
                }
               contador--;
            }
            else if (contador == 4)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz4[i, j]);
                    }
                }
               contador--;
            }
            else if (contador == 5)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz5[i, j]);
                    }
                }
               contador--;
            }
            else if (contador == 6)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz6[i, j]);
                    }
                }
               contador--;
            }
            else if (contador == 7)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz7[i, j]);
                    }
                }
               contador--;
            }
            else if (contador == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz8[i, j]);
                    }
                }
               contador--;
            }
            else if (contador == 9)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        panel1.Controls.Add(Matriz9[i, j]);
                    }
                }
               contador--;
            }
            
            if (contador < 0)
            {
                button2.Enabled = false;
                contador = 0;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}





