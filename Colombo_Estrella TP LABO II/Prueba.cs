using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colombo_Estrella_TP_LABO_II
{
    public partial class Prueba : Form
    {
        Juego Juego1 = new Juego();
        public Prueba()
        {
            InitializeComponent();
            
        }


        private void ArmarMatriz()
        {
            int Matriz_size = Matriz_Form.Width / Juego1.MiTablero.Tam;

            //EL PANEL TIENE QUE SER UN CUADRADO ENTONCES LE DOY FORMA
            Matriz_Form.Width = Matriz_Form.Height;

            //CICLO FOR PARA RECORRER ARRAY
            for (int i = 0; i < Juego1.MiTablero.Tam; i++)
            {
                for (int j = 0; j < Juego1.MiTablero.Tam; j++)
                {
  
                    //LE DOY COLOR A LOS BOTONES 
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Matriz_Form[j, i].Style.BackColor = Color.FromArgb(217, 217, 217);//BLANCO

                    }
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        Matriz_Form[j, i].Style.BackColor = Color.FromArgb(146, 146, 146);//GRIS

                    }
                    if (i % 2 != 0 && j % 2 == 0)
                    {
                        Matriz_Form[j, i].Style.BackColor = Color.FromArgb(146, 146, 146);//GRIS
                    }
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        Matriz_Form[j, i].Style.BackColor = Color.FromArgb(217, 217, 217);//BLANCO
                    }
                }
            }
        }




        private void Matriz_Form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
