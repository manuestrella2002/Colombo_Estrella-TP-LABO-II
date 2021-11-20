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
            nro_soluciones.Text = "10";
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Imagenes\Ajedrez.jpg");

            System.Drawing.Image img = System.Drawing.Image.FromFile(path);

            this.BackgroundImage=(img);
            nro_soluciones.DropDownStyle = ComboBoxStyle.DropDownList;
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
            string Justificacion =
                "\t\t\tANALISIS DE COTAS:" + "\n\tCota Superior:\n" 
                + "Tomando en cuenta que el algoritmo es muy extenso y contiene una gran cantidad de funciones, instrucciones if, bucles for y while, etc. "
                + "Para calcular la cota superior, es decir, el analisis del peor caso posible. Describimos el peor caso posible en el cual se buscan 10 soluciones diferentes." +
                "\nCuando se va buscando las soluciones, se utiliza un algoritmo basado en backtracking  y aleatoriedad para encontrar la solucion. La solucion se halla cuando hay 64 casilleros atacados y/o ocupados" 
                + "Cuando no se encuentra una solucion se inicia el backtracking, sacando y colocando las piezas hasta que se de con una buena comfiguracion. El posicionamiento" +
                " de las piezas (donde se colocaran) se busca mediante funciones de tipo random (Aleatorias) que tienen condiciones especificas con respecto a la pieza que se va a colocar.\n Ejemplo: " 
                + "La colocacion de los alfiles y/o caballos en casillas del color correspondiente y la posibilidad de la superposicion de estas piezas.\n" + "Calculamos un promedio de tiempo de ejecucion para estimar cuanto tarda el algoritmo en encontrar 10 soluciones habiendolo hecho 30 veces." 
                + " El promedio de tiempo calculado fue de 0.1896 segundos.";
            string Justificacion2 = "\n\n\tCota Inferior:\n" +
                "Definimos la cota superior como la ejecucion del mejor caso posible donde solamente se busca una sola solucion y es la primera en salir sin llegar a utilizar la funcion de bactracking.\n" +
                "Habiendo analizado todo el codigo, teniendo en cuenta que los ciclos for utilizados para recorrer las distintas matrices tienen un tiempo de ejecucion constante al igual" +
                " que el uso de funciones de librerias, podemos estimar que el algoritmo tiene como cota inferior una camplejidad lineal porque está aumenta con respecto a la cantidad de soluciones a encontrar.\n." +
                "\t \u03A9(n)=n, donde n es el numero de soluciones a encontrar.";
            string justificacion3 = "\n\n\n\tDescripcion de Poda:\n"
                + "La poda que se realizo en este trabajo fue ubicar las piezas de las torres, una en la posicion [0,0] "
                +"para que ocupe toda una fila y una columna, lo mismo con la otra torre en [1,1] y ocupar toda la fila y columna correspondiente, "
                + "tambien se coloco la reina en [2,2] y se resta otra fila y columna de las posibilidades a ocupar. De esta forma se achica el tablero para que a la hora de colocar las demas piezas se pueda cubrir en su totalidad. ";
            MessageBox.Show(Justificacion+Justificacion2+justificacion3,"Analisis de Algoritmo");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
