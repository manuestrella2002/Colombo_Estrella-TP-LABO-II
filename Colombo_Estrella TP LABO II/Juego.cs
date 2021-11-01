using System;
using System.Collections.Generic;
using System.Linq;

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

        List<Tablero> Soluciones_Encontradas= new List<Tablero>();

        int cont = 0;

        public Juego()
        {
            //ENCUENTRA SOLO UNA SOLUCION
            //Crear Tablero
            for (int i = 0; i < 10; i++)
            {
                Poda();
                Backtracking();
                Soluciones_Encontradas.Add(MiTablero);
                MiTablero.ReiniciarTablero();
            }

            //
            for (int i = 0; i < Soluciones_Encontradas.Count; i++)
            {
                Console.WriteLine("Solucion %d", i);
                Soluciones_Encontradas[i].ImprimirTablero();
            }

            //Poda();
            //Backtracking();
            //MiTablero.ImprimirTablero();
        }
        public void Poda()
        {
            string Pieza;
            //METODO DE PODA
            //COLOCAMOS REINA EN ALGUNO DE LOS CUATRO CUADRADOS CENTRALES
            Pieza = "Reina";
            Lista_Piezas.Remove(Pieza);
            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[3, 3], Pieza);


            //COLOCAMOS TORRE EN LA ESQUINA SUPERIOR IZQUIERDA POSICION(0,0)
            Pieza = "Torre1";
            Lista_Piezas.Remove(Pieza);
            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[0, 0], Pieza);

            ////COLOCAMOS TORRE EN LA ESQUINA SUPERIOR IZQUIERDA POSICION(7,7)
            Pieza = "Torre2";
            Lista_Piezas.Remove(Pieza);
            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[7, 7], Pieza);

        }

        //COLOCA LAS PIEZAS EN EL TABLERO
        public void EncontrarSolucion()
        {
            int pos;
            //SI ES LA PRIMERA VEZ QUE COLCA LAS FICHAS DIRECTAMENTE SE RECORRE DE [0,0] A [7,7]
            //SI ES DESPUES DE LA 1ERA VEZ SE RECORRE A LA INVERSA
            if (cont == 0)
            {
                //RECORRE LA MATRIZ
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (MiTablero.Matriz[i,j].Ocupados==true && )
                        {

                        }
                        if (MiTablero.Matriz[i, j].Ocupados == false && MiTablero.Matriz[i, j].Legal_Movim == false)
                        {
                            //SE OBTIENE LA POSICION DE LA PIEZA EN LA LISTA_PIEZAS DE LA QUE CUBRE MAYOR LUGARES DE ATAQUE
                            pos = VerificarMejorFicha(MiTablero.Matriz[i, j]);

                            //ENTREGA -1 SI NO HAY MAS PIEZAS EN LA LISTA Y SE SALE DE LA FUNICION Y VUELVE A LA DE BACKTRACKING
                            if (pos != -1)
                            {
                                if (Lista_Piezas.ElementAt(pos) == "Alfil_Negro" || Lista_Piezas.ElementAt(pos) == "Alfil_Blanco")
                                {
                                    if (VerificarAlfiles(MiTablero.Matriz[i,j],pos))
                                    {
                                        //SE MARCAN LOS LUGARES
                                        MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                                        //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                                        Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                                        Lista_Piezas.RemoveAt(pos);
                                    }
                                }
                                else
                                {
                                    //SE MARCAN LOS LUGARES
                                    MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                                    //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                                    Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                                    Lista_Piezas.RemoveAt(pos);
                                }
                                
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
            else if(cont %2 ==0)
            {
                for (int i = 7; i >= 0; i--)
                {
                    for (int j = 7; j >= 0; j--)
                    {
                        if (MiTablero.Matriz[i, j].Ocupados == false && MiTablero.Matriz[i, j].Legal_Movim == false)
                        {
                            pos = VerificarMejorFicha(MiTablero.Matriz[i, j]);
                            if (pos != -1)
                            {
                                MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                                Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                                Lista_Piezas.RemoveAt(pos);
                                MiTablero.ImprimirTablero();
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 7; j >= 0; j--)
                    {
                        if (MiTablero.Matriz[i, j].Ocupados == false && MiTablero.Matriz[i, j].Legal_Movim == false)
                        {
                            pos = VerificarMejorFicha(MiTablero.Matriz[i, j]);
                            if (pos != -1)
                            {
                                MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                                Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                                Lista_Piezas.RemoveAt(pos);
                                MiTablero.ImprimirTablero();
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }

        public void Backtracking()
        {
            //SI LA SOLUCION YA EXISTE SE TERMINA EL PROGRAMA
            if (VerificarSolucion() == true)
            {
                return;
            }
            else
            {
                int r = 1;
                int f = 0;
                //CICLO WHILE PARA SACAR PIEZAS
                while (VerificarSolucion() != true)
                {
                    //COMO EN LA PRIMER PARTE NO HAY PIEZAS SACADAS DIRECTAMENTE PASA A LA FUNCION DE COLCARLAS
                    //ES LA FUNCION EncontrarSolucion()
                    if (Lista_Piezas_Sacadas.Count != 0)
                    {
                        //SE AGREGAN A LA LISTA DE´PIEZAS A LAS QUE PUSE ULTIMAS SI NO HAY SOLUCION AL COLOCAR TODAS
                        //LA 1ERA VEZ NO SACA NINGUNA, EN LA 2DA SACA UNA SOLAMENTE, Y EN LA 3RA SACA DOS ASI HASTA QUE SACA TODAS 
                        Lista_Piezas.AddRange(Lista_Piezas_Sacadas.GetRange(Lista_Piezas_Sacadas.Count() - r, r));
                        //QUITA DE LA LISTA DE PIEZAS SACADAS (LISTA DE PIEZAS SACADAS ES LA LISTA D EPIEZAS QUE SE VAN COLOCANDO) LAS QUE SE SACAN DEL TABLERO 
                        Lista_Piezas_Sacadas.RemoveRange(Lista_Piezas_Sacadas.Count() - r, r);
                        f = 0;
                        //RECORREMOS A LA INVERSA LA MATRIZ PARA SACAR LA ULTIMA PIEZA QUE PUSO 
                        for (int i = 7; i >= 0; i--)
                        {
                            for (int j = 7; j >= 0; j--)
                            {
                                //SI EL LUGAR ESTA OCIUPADO POR UNA PIEZA LA SACA Y DESMARCA LOS LUGARES, NOTAR QUE SI ES LA REYNA, LAS TORRES O EL REY
                                //NO LAS SACARA YA QUE SON CRITERIO DE PODA
                                if (MiTablero.Matriz[i, j].Ocupados == true && MiTablero.Matriz[i, j].Pieza != "Reina" && MiTablero.Matriz[i, j].Pieza != "Torre")
                                {
                                    //FUNCION PARA SACAR Y DESMARCAR PIEZAS Y LUGARES
                                    MiTablero.DesmarcarLugares(MiTablero.Matriz[i, j], MiTablero.Matriz[i, j].Pieza);
                                    //INDICA LA CANTIDAD DE VECES A SACAR LAS FICHAS QUE ESTAN EN EL TABLERO
                                    //SACA LA MISMA CANTIDAD DE PIEZAS QUE LAS QUE SACA DE LISTA_PIEZAS_SACADAS
                                    f++;
                                    if (f == r)
                                    {
                                        cont++;
                                        break;
                                        
                                    }
                                }
                            }
                            if (f == r)
                            {
                                MiTablero.ImprimirTablero();
                                break;
                            }
                        }
                        r++;
                    }
                    //ESTAS FUNCION COLOCA LAS PIEZAS DISPONIBLES EN EL TABLERO
                    EncontrarSolucion();
                    MiTablero.ImprimirTablero();
                    if (r > Lista_Piezas_Sacadas.Count)
                    {
                        r = 1;

                    }
                }
            }
        }

        public int VerificarMejorFicha(Celda CeldaActual)
        {
            List<int> Cant_Lugares_A_Ocupar = new List<int>();

            for (int i = 0; i < Lista_Piezas.Count; i++)
            {
                Cant_Lugares_A_Ocupar.Add(MiTablero.CalcularCantMovLegales(CeldaActual, Lista_Piezas[i]) + 1);
            }

            if (Cant_Lugares_A_Ocupar.Count() == 0)
            {
                return -1;
            }
            return Cant_Lugares_A_Ocupar.IndexOf(Cant_Lugares_A_Ocupar.Max());
        }

        //FUNCION PARA VER SI ESTAN TODOS LOS CASILLEROS ATACADOS
        //PUSIMOS 63 CASILLEROS PORQUE NOS FALTA  LA FUNCION DE PODER SUPERPONER EL CABALLO Y EL ALFIL
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
            if (contador == 63)
            {
               
                    for (int i = 0; i < Soluciones_Encontradas.Count; i++)
                    {
                        if (Soluciones_Encontradas[i] == MiTablero)
                        {
                            return false;
                        }
                    }
                
                return true;
            }
            else
            {
                return false;
            }
        }

        bool VerificarAlfiles(Celda Celda_Actual,int pos)
        {
            if (Lista_Piezas.ElementAt(pos)=="Alfil_Blanco")
            {
                if (Celda_Actual.Color=="Blanco")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Celda_Actual.Color == "Negro")
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
}
