using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colombo_Estrella_TP_LABO_II
{
    static class Program
    {
        //HAY UNA SOLA COPIA DEL TABLERO EN EL PROGRAMA POR ESO EL STATIC
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Juego Juego1 = new Juego();
            //ESTAS TRES LINEAS ABREN EL FORM
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

        }
    }
}
