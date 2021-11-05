using System;
using System.Collections.Generic;
using System.Linq;

namespace Colombo_Estrella_TP_LABO_II
{
    public class Juego
    {
       public static Tablero MiTablero = new Tablero(8);

        static Caballo Caballo1 = new Caballo();
        static Caballo Caballo2 = new Caballo();
        static Torre Torre1 = new Torre();
        static Torre Torre2 = new Torre();
        static Alfil Alfil_Blanco = new Alfil(Pieza_Ajedrez.Color_Pieza.BLANCO);
        static Alfil Alfil_Negro = new Alfil(Pieza_Ajedrez.Color_Pieza.NEGRO);
        static Reina reina = new Reina();
        static Rey rey = new Rey();

        List<Pieza_Ajedrez> Lista_Piezas = new List<Pieza_Ajedrez>()
        {
           reina,
           Torre1,
           Torre2,
           Alfil_Negro,
           Caballo1,
           Caballo2,
           rey,
           Alfil_Blanco
        };

        List<Celda> Lista_Celdas_Ocupadas = new List<Celda>();


        List<Pieza_Ajedrez> Lista_Piezas_Sacadas = new List<Pieza_Ajedrez>();

        List<Tablero> Soluciones_Encontradas = new List<Tablero>();

        int Cont = 0;

        public Juego()
        {
            //ENCUENTRA SOLO UNA SOLUCION
            //Crear Tablero
            for (int i = 0; i < 10; i++)
            {
                Poda();
                //MiTablero.ImprimirTablero();
                Backtracking1();
                Soluciones_Encontradas.Add(MiTablero);
                MiTablero.ImprimirTablero();
                ReiniciarListas();
                MiTablero.ReiniciarTablero();
            }


            //for (int i = 0; i < Soluciones_Encontradas.Count; i++)
            //{
            //    Console.WriteLine("Solucion {0}", i);
            //    Soluciones_Encontradas[i].ImprimirTablero();
            //}


        }
        public void Poda()
        {
            //METODO DE PODA
            //COLOCAMOS REINA EN ALGUNO DE LOS CUATRO CUADRADOS CENTRALES
            Lista_Piezas.Remove(reina);
            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[2, 2], reina);


            //COLOCAMOS TORRE EN LA ESQUINA SUPERIOR IZQUIERDA POSICION(0,0)
            Lista_Piezas.Remove(Torre1);
            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[0, 0], Torre1);

            ////COLOCAMOS TORRE EN LA ESQUINA SUPERIOR IZQUIERDA POSICION(7,7)
            Lista_Piezas.Remove(Torre2);
            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[1, 1], Torre2);

        }

        //COLOCA LAS PIEZAS EN EL TABLERO
        public void EncontrarSolucion1()
        {
            int i, j, pos;
            Random aux1 = new Random(Guid.NewGuid().GetHashCode());
            Random aux2 = new Random();




            while (Lista_Piezas.Count != 0)
            {
                //if (Lista_Piezas.Count == 1)
                //{
                //    Unapieza();
                //    return;
                //}
                i = aux1.Next(3, 8);
                j = aux2.Next(3, 8);

                pos = VerificarMejorFicha(MiTablero.Matriz[i, j]);

                if (pos == -1)
                {
                    return;
                }
                else
                {
                    if (Condiciones(i, j, pos) == false)
                    {
                        if (/*MiTablero.Matriz[i, j].Ocupados == false && */Lista_Piezas.ElementAt(pos) == Alfil_Blanco)
                        {
                            if (VerificarAlfiles(MiTablero.Matriz[i, j], pos) && MiTablero.Matriz[i, j].Ocupados == false)
                            {
                                MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                                //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                                Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                                ControlListas();
                                Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[i, j]);
                                Lista_Piezas.RemoveAt(pos);
                                //MiTablero.ImprimirTablero();
                            }
                            else
                            {
                                do
                                {
                                    i = aux1.Next(3, 8);
                                    j = aux2.Next(3, 8);
                                } while (MiTablero.Matriz[i, j].Color == Celda.Color_Celda.NEGRO);

                                if (Condiciones(i, j, pos) == false)
                                {
                                    while (MiTablero.Matriz[i, j].Ocupados == true && MiTablero.Matriz[i, j].Color == Celda.Color_Celda.NEGRO)
                                    {
                                        i = aux1.Next(3, 8);
                                        j = aux2.Next(3, 8);
                                    }
                                    MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                                    //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                                    Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                                    ControlListas();
                                    Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[i, j]);
                                    Lista_Piezas.RemoveAt(pos);
                                    //MiTablero.ImprimirTablero();
                                }

                            }
                        }
                        else if (/*MiTablero.Matriz[i, j].Ocupados == false &&*/ Lista_Piezas.ElementAt(pos) == Alfil_Negro)
                        {
                            if (VerificarAlfiles(MiTablero.Matriz[i, j], pos) && MiTablero.Matriz[i, j].Ocupados == false)
                            {
                                MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                                //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                                Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                                Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[i, j]);
                                ControlListas();
                                Lista_Piezas.RemoveAt(pos);
                                //MiTablero.ImprimirTablero();
                            }
                            else
                            {
                                do
                                {
                                    i = aux1.Next(3, 8);
                                    j = aux2.Next(3, 8);
                                } while (MiTablero.Matriz[i, j].Color == Celda.Color_Celda.BLANCO);

                                if (Condiciones(i, j, pos) == false)
                                {
                                    while (MiTablero.Matriz[i, j].Ocupados == true && MiTablero.Matriz[i, j].Color == Celda.Color_Celda.BLANCO)
                                    {
                                        i = aux1.Next(3, 8);
                                        j = aux2.Next(3, 8);
                                    }
                                    MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                                    //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                                    Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                                    Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[i, j]);
                                    ControlListas();
                                    Lista_Piezas.RemoveAt(pos);
                                    //MiTablero.ImprimirTablero();
                                }

                            }
                        }
                        else
                        {
                            while (MiTablero.Matriz[i, j].Ocupados == true)
                            {
                                i = aux1.Next(3, 8);
                                j = aux2.Next(3, 8);

                            }


                            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                            //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                            Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                            Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[i, j]);
                            ControlListas();
                            Lista_Piezas.RemoveAt(pos);
                            //MiTablero.ImprimirTablero();
                        }
                    }
                }
            }
        }
        public void Backtracking1()
        {
            //SI LA SOLUCION YA EXISTE SE TERMINA EL PROGRAMA
            if (VerificarSolucion() == true)
            {
                Cont++;
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
                        ControlListas();
                        //QUITA DE LA LISTA DE PIEZAS SACADAS (LISTA DE PIEZAS SACADAS ES LA LISTA D EPIEZAS QUE SE VAN COLOCANDO) LAS QUE SE SACAN DEL TABLERO 
                        f = 0;
                        while (f != r)
                        {
                            MiTablero.DesmarcarLugares(MiTablero.Matriz[Lista_Celdas_Ocupadas.Last().NroFila, Lista_Celdas_Ocupadas.Last().NroColumna], Lista_Celdas_Ocupadas.Last().Pieza1);
                            Lista_Celdas_Ocupadas.RemoveAt(Lista_Celdas_Ocupadas.Count - 1);
                            Lista_Piezas_Sacadas.RemoveAt(Lista_Piezas_Sacadas.Count - 1);
                            f++;
                        }
                        r++;

                    }
                    //ESTAS FUNCION COLOCA LAS PIEZAS DISPONIBLES EN EL TABLERO
                    //MiTablero.ImprimirTablero();
                    EncontrarSolucion1();
                    if (r > Lista_Piezas_Sacadas.Count)
                    {
                        r = 1;

                    }
                }
            }
        }

        public void Unapieza()
        {
            List<Celda> Lugares = new List<Celda>();
            List<int> Cant_Lugares = new List<int>();
            for (int i = 3; i < 8; i++)
            {
                for (int j = 3; j < 8; j++)
                {
                    if (MiTablero.Matriz[i, j].Ocupados == false)
                    {
                        MiTablero.Matriz[i, j].aux = MiTablero.CalcularCantMovLegales(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(0));
                        Lugares.Add(MiTablero.Matriz[i, j]);
                        Cant_Lugares.Add(MiTablero.Matriz[i, j].aux);
                    }
                }
            }

            int pos = Cant_Lugares.IndexOf(Cant_Lugares.Max());

            MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[Lugares.ElementAt(pos).NroFila, Lugares.ElementAt(pos).NroColumna], Lista_Piezas.ElementAt(0));
            Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[Lugares.ElementAt(pos).NroFila, Lugares.ElementAt(pos).NroColumna]);
            Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(0));
            Lista_Piezas.RemoveAt(0);
            //MiTablero.ImprimirTablero();

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
            //if (PodaDeSoluciones()==false)
            //{
            //    return false;
            //}
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

        bool VerificarAlfiles(Celda Celda_Actual, int pos)
        {
            if (Lista_Piezas.ElementAt(pos) is Alfil aux1 && aux1.Color_ == Pieza_Ajedrez.Color_Pieza.BLANCO && Celda_Actual.Color == Celda.Color_Celda.BLANCO)
            {
                return true;
            }
            else if (Lista_Piezas.ElementAt(pos) is Alfil aux2 && aux2.Color_ == Pieza_Ajedrez.Color_Pieza.NEGRO && Celda_Actual.Color == Celda.Color_Celda.NEGRO)
            {
                return true;
            }
            else if (Lista_Piezas.ElementAt(pos) is CaballoAlfil aux3 && aux3.Color_ == Pieza_Ajedrez.Color_Pieza.BLANCO && Celda_Actual.Color == Celda.Color_Celda.BLANCO)
            {
                return true;
            }
            else if (Lista_Piezas.ElementAt(pos) is CaballoAlfil aux4 && aux4.Color_ == Pieza_Ajedrez.Color_Pieza.NEGRO && Celda_Actual.Color == Celda.Color_Celda.NEGRO)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        bool PodaDeSoluciones()
        {
            int cont1 = 0;
            if (Lista_Piezas.Count == 1 && Lista_Piezas.Contains(rey))
            {
                for (int i = 0; i < MiTablero.Tam; i++)
                {
                    for (int j = 0; j < MiTablero.Tam; j++)
                    {
                        if (MiTablero.Matriz[i, j].Legal_Movim == false)
                        {
                            cont1++;
                            if (cont1 >= 10)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;

        }

        bool Condiciones(int i, int j, int pos)
        {
            if (MiTablero.Matriz[i, j].Ocupados == true && MiTablero.Matriz[i, j].Pieza1 is Caballo && Lista_Piezas.ElementAt(pos) == Alfil_Blanco && MiTablero.Matriz[i, j].Color == Celda.Color_Celda.BLANCO)
            {
                MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[i, j]);
                ControlListas();
                Lista_Piezas.RemoveAt(pos);
                //MiTablero.ImprimirTablero();
                return true;
            }
            else if (MiTablero.Matriz[i, j].Ocupados == true && MiTablero.Matriz[i, j].Pieza1 is Caballo && Lista_Piezas.ElementAt(pos) == Alfil_Negro && MiTablero.Matriz[i, j].Color == Celda.Color_Celda.NEGRO)
            {
                MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[i, j]);
                ControlListas();
                Lista_Piezas.RemoveAt(pos);
                //MiTablero.ImprimirTablero();
                return true;
            }
            else if (MiTablero.Matriz[i, j].Ocupados == true && MiTablero.Matriz[i, j].Pieza1 == Alfil_Blanco && Lista_Piezas.ElementAt(pos) is Caballo /*&& MiTablero.Matriz[i, j].Color == Celda.Color_Celda.BLANCO*/)
            {
                MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[i, j]);
                ControlListas();
                Lista_Piezas.RemoveAt(pos);
                //MiTablero.ImprimirTablero();
                return true;
            }
            else if (MiTablero.Matriz[i, j].Ocupados == true && MiTablero.Matriz[i, j].Pieza1 == Alfil_Negro && Lista_Piezas.ElementAt(pos) is Caballo /*&& MiTablero.Matriz[i, j].Color == Celda.Color_Celda.NEGRO*/)
            {
                MiTablero.MarcarProx_MovLegal(MiTablero.Matriz[i, j], Lista_Piezas.ElementAt(pos));
                //SE AGREGAN A LA LISTA_PIEZAS SACADAS LAS QUE SE PONEN EN EL TABLERO
                Lista_Piezas_Sacadas.Add(Lista_Piezas.ElementAt(pos));
                Lista_Celdas_Ocupadas.Add(MiTablero.Matriz[i, j]);
                ControlListas();
                Lista_Piezas.RemoveAt(pos);
                //MiTablero.ImprimirTablero();
                return true;
            }
            else
            {
                return false;
            }
        }

        void ControlListas()
        {
            int cont_Reina = 0;
            int cont_Rey = 0;
            int cont_Torre = 0;
            int cont_Caballo = 0;
            int cont_Alfil_B = 0;
            int cont_Alfil_N = 0;

            for (int i = 0; i < Lista_Piezas.Count; i++)
            {
                if (Lista_Piezas[i] is Reina)
                {
                    cont_Reina++;
                }
                else if (Lista_Piezas[i] is Rey)
                {
                    cont_Rey++;
                }
                else if (Lista_Piezas[i] is Caballo)
                {
                    cont_Caballo++;
                }
                else if (Lista_Piezas[i] is Alfil M && M.Color_ == Pieza_Ajedrez.Color_Pieza.BLANCO)
                {
                    cont_Alfil_B++;
                }
                else if (Lista_Piezas[i] is Alfil T && T.Color_ == Pieza_Ajedrez.Color_Pieza.NEGRO)
                {
                    cont_Alfil_N++;
                }
                else if (Lista_Piezas[i] is Torre)
                {
                    cont_Torre++;
                }
            }

            if (cont_Reina > 1 || cont_Alfil_B > 1 || cont_Alfil_N > 1 || cont_Caballo > 2 || cont_Rey > 1 || cont_Torre > 2)
            {
                Lista_Piezas.Remove(Lista_Piezas.Last());
            }

            cont_Reina = 0;
            cont_Rey = 0;
            cont_Torre = 0;
            cont_Caballo = 0;
            cont_Alfil_B = 0;
            cont_Alfil_N = 0;

            for (int i = 0; i < Lista_Piezas_Sacadas.Count; i++)
            {
                if (Lista_Piezas_Sacadas[i] is Reina)
                {
                    cont_Reina++;
                }
                else if (Lista_Piezas_Sacadas[i] is Rey)
                {
                    cont_Rey++;
                }
                else if (Lista_Piezas_Sacadas[i] is Caballo)
                {
                    cont_Caballo++;
                }
                else if (Lista_Piezas_Sacadas[i] is Alfil M && M.Color_ == Pieza_Ajedrez.Color_Pieza.BLANCO)
                {
                    cont_Alfil_B++;
                }
                else if (Lista_Piezas_Sacadas[i] is Alfil T && T.Color_ == Pieza_Ajedrez.Color_Pieza.NEGRO)
                {
                    cont_Alfil_N++;
                }
                else if (Lista_Piezas_Sacadas[i] is Torre)
                {
                    cont_Torre++;
                }

                if (cont_Reina > 1 || cont_Alfil_B > 1 || cont_Alfil_N > 1 || cont_Caballo > 2 || cont_Rey > 1 || cont_Torre > 2)
                {
                    Lista_Piezas_Sacadas.Remove(Lista_Piezas.Last());
                }
            }

        }

        void ReiniciarListas()
        {
            Lista_Piezas.RemoveRange(0, Lista_Piezas.Count);
            Lista_Piezas_Sacadas.RemoveRange(0, Lista_Piezas_Sacadas.Count);
            Lista_Celdas_Ocupadas.RemoveRange(0, Lista_Celdas_Ocupadas.Count);
            Lista_Piezas.Add(Caballo1);
            Lista_Piezas.Add(Caballo2);
            Lista_Piezas.Add(reina);
            Lista_Piezas.Add(rey);
            Lista_Piezas.Add(Alfil_Blanco);
            Lista_Piezas.Add(Alfil_Negro);
            Lista_Piezas.Add(Torre1);
            Lista_Piezas.Add(Torre2);
        }
    }
}
