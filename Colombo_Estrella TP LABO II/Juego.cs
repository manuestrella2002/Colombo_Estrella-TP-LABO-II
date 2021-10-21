using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombo_Estrella_TP_LABO_II
{
    public class Juego
    {
        Tablero MiTablero = new Tablero(8);
        List<string> Lista_Piezas = new List<string>()
        {
           "Caballo1",
           "Caballo2",
           "Torre1",
           "Torre2",
           "Alfil_Negro",
           "Alfil_Blanco",
           "Reina",
           "Rey"
        };

        List<string> Lista_Piezas_Sacadas = new List<string>()
        {
           
        };


        public Juego()
        {
            //Crear Tablero
          
            Poda();
            MiTablero.ImprimirTablero();
            EncontrarSolucion();
            //Backtracking();
            MiTablero.ImprimirTablero();


        }
        public void Poda()
        {
            Random myObject = new Random();
            int ranNum1 = myObject.Next(3, 4);
            int ranNum2 = myObject.Next(3, 4);
            string Pieza;
            //METODO DE PODA
            //COLOCAMOS REINA EN ALGUNO DE LOS CUATRO CUADRADOS CENTRALES
            Pieza = "Reina";
            Lista_Piezas.Remove(Pieza);
            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[ranNum1, ranNum2], Pieza);


            //COLOCAMOS TORRE EN LA ESQUINA SUPERIOR IZQUIERDA POSICION(0,0)
            Pieza = "Torre1";
            Lista_Piezas.Remove(Pieza);
            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[0, 0], Pieza);

            //COLOCAMOS TORRE EN LA ESQUINA SUPERIOR IZQUIERDA POSICION(7,7)
            Pieza = "Torre2";
            Lista_Piezas.Remove(Pieza);
            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[7, 7], Pieza);

        }

        public void EncontrarSolucion()
        {
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (MiTablero.Matriz[i, j].Ocupados == false && MiTablero.Matriz[i, j].Legal_Movim == false)
                    {
                        int pos = VerificarMejorFicha(MiTablero.Matriz[i,j]);
                      
                        if (pos == -1)
                        {
                            Backtracking();
                            break;
                        }

                            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                            Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                            Lista_Piezas.RemoveAt(pos);
                            MiTablero.ImprimirTablero();
                        
                    }
                }
                
            }
            //Backtracking();
        }

        public void Backtracking()
        {
            if (VerificarSolucion())
            {
                MiTablero.ImprimirTablero();
                return;
            }
            else
            {
                int i = 1;
                while (VerificarSolucion()!=true)
                {
                    //MiTablero.ImprimirTablero();
                    if (Lista_Piezas_Sacadas.Count()==0)
                    {
                        break;
                    }
                    Lista_Piezas.AddRange(Lista_Piezas_Sacadas.GetRange(Lista_Piezas_Sacadas.Count() - i, i));
                    Lista_Piezas_Sacadas.RemoveRange(Lista_Piezas_Sacadas.Count() - i, i);

                    i++;

                    EncontrarSolucion();
                    if (i>Lista_Piezas_Sacadas.Count)
                    {
                        return;
                    }
                }
            }

        }

       public int VerificarMejorFicha(Celda CeldaActual)
       {
            List<int> Cant_Lugares_A_Ocupar = new List<int>();
            //ARREGLAR ESTA FUNCION DEPENDIENDO DE QUE PIEZA ESTA EN LA LISTA

            for (int i = 0; i < Lista_Piezas.Count; i++)
            {
                Cant_Lugares_A_Ocupar.Add(MiTablero.CalcularCantMovLegales(CeldaActual, Lista_Piezas[i])+1);
            }
            if (Cant_Lugares_A_Ocupar.Count() == 0)
            {
                return -1;
            }

          

            return Cant_Lugares_A_Ocupar.IndexOf(Cant_Lugares_A_Ocupar.Max());

           
       }


        public bool VerificarSolucion()
        {
            int contador = 0;
            for (int i = 0; i < MiTablero.Tam; i++)
            {
                for (int j = 0; j < MiTablero.Tam; j++)
                {
                    if (MiTablero.Matriz[i, j].Ocupados == true || MiTablero.Matriz[i, j].Legal_Movim == true)
                    {
                        contador++;
                    }
                }
            }
            if (contador == 64)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
