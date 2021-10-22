using System;

namespace Colombo_Estrella_TP_LABO_II
{
    public class Tablero
    {
        //FUNCION PARA OBTENER TAMAÑO DEL TABLERO NxN
        public int Tam { get; set; }

        //FUNCION PARA OBTENER LA CELDA DE LA MATRIZ[i,j]
        public Celda[,] Matriz { get; set; }

        //CONSTRUCTOR DEL TABLERO
        public Tablero(int s)
        {

            Tam = s;

            Matriz = new Celda[Tam, Tam];
            //ASIGNA A CADA LUGAR DE LA MATRIZ[i,j] UNA CELDA CON SU POSICION(i,j)
            for (int i = 0; i < Tam; i++)
            {
                for (int j = 0; j < Tam; j++)
                {
                    Matriz[i, j] = new Celda(i, j);
                }
            }
        }

        //FUNCION PARA MARCAR DE ACUERDO A LA PIEZA QUE SE LE PASA LAS POSICIONES A LAS QUE ATACA
        public void MarcarProx_MovLegal(Celda CeldaActual, string PiezaAjedrez)
        {
            //Paso 1: Borrar todos los movimientos legales previos
            //BASICAMENTE LIMPIA EL TABLERO
            //for (int i = 0; i < Tam; i++)
            //{
            //    for (int j = 0; j < Tam; j++)
            //    {
            //        Matriz[i, j].Legal_Movim = false;
            //        Matriz[i, j].Ocupados = false;
            //    }
            //}

            //CAMBIA LA POSICION DONDE SE COLOCA LA PIEZA A OCUPADO
            Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Ocupados = true;

            switch (PiezaAjedrez)
            {
                case "Caballo1":
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = "Caballo";
                    break;
                case "Caballo2":
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = "Caballo";
                    break;

                case "Torre1":
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = "Torre";
                    break;
                case "Torre2":
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = "Torre";
                    break;
                case "Rey":
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = "Rey";
                    break;
                case "Reina":
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = "Reina";
                    break;
                case "Alfil_Blanco":
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = "Alfil";
                    break;
                case "Alfil_Negro":
                    Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = "Alfil";
                    break;
            }



            //Paso 2: Buscar todos los movientos legales y marcar las celdas como 1
            switch (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza)
            {
                //PENSAMOS HACER DINAMIC CAST PARA CADA UNA DE LAS PIEZAS
                case "Caballo":
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                    }
                    break;

                //case "Caballo2":
                //    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                //    {
                //        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                //    }
                //    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                //    {
                //        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                //    }
                //    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                //    {
                //        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = true;
                //    }
                //    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                //    {
                //        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = true;
                //    }
                //    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                //    {
                //        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                //    }
                //    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                //    {
                //        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                //    }
                //    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                //    {
                //        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = true;
                //    }
                //    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                //    {
                //        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = true;
                //    }
                //    break;

                case "Rey":
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1))
                    {
                        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1].Legal_Movim = true;
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1))
                    {
                        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1].Legal_Movim = true;
                    }
                    break;
                case "Reina":
                    //ABAJO 
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }
                    }
                    //ARRIBA
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }

                    }

                    //PARA LA DERECHA
                    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }
                    //PARA LA IZQUIERDA
                    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }

                    //DIAGONAL HACIA ABAJO DERECHA
                    int r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }

                    }
                    break;

                case "Torre":
                    //ABAJO 
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }
                    }
                    //ARRIBA
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                        }

                    }

                    //PARA LA DERECHA
                    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }
                    //PARA LA IZQUIERDA
                    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                        }
                    }
                    break;

                //case "Torre2":
                //    //ABAJO 
                //    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                //    {
                //        if (VerificarLugar(i, CeldaActual.NroColumna))
                //        {
                //            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                //        }
                //    }
                //    //ARRIBA
                //    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                //    {
                //        if (VerificarLugar(i, CeldaActual.NroColumna))
                //        {
                //            Matriz[i, CeldaActual.NroColumna].Legal_Movim = true;
                //        }

                //    }

                //    //PARA LA DERECHA
                //    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                //    {
                //        if (VerificarLugar(CeldaActual.NroFila, j))
                //        {
                //            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                //        }
                //    }
                //    //PARA LA IZQUIERDA
                //    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                //    {
                //        if (VerificarLugar(CeldaActual.NroFila, j))
                //        {
                //            Matriz[CeldaActual.NroFila, j].Legal_Movim = true;
                //        }
                //    }
                //    break;

                //case "Alfil_Negro":
                case "Alfil":
                    //DIAGONAL HACIA ABAJO DERECHA
                    r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            Matriz[i, r].Legal_Movim = true;
                        }

                    }

                    break;

                    //case "Alfil_Blanco":

                    //    //DIAGONAL HACIA ABAJO DERECHA
                    //    r = CeldaActual.NroColumna;

                    //    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    //    {
                    //        r++;
                    //        if (VerificarLugar(i, r))
                    //        {
                    //            Matriz[i, r].Legal_Movim = true;
                    //        }
                    //    }
                    //    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    //    r = CeldaActual.NroColumna;
                    //    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    //    {
                    //        r--;
                    //        if (VerificarLugar(i, r))
                    //        {
                    //            Matriz[i, r].Legal_Movim = true;
                    //        }
                    //    }
                    //    //DIAGONAL HACIA ARRIBA DERECHA
                    //    r = CeldaActual.NroColumna;
                    //    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    //    {
                    //        r++;
                    //        if (VerificarLugar(i, r))
                    //        {
                    //            Matriz[i, r].Legal_Movim = true;
                    //        }
                    //    }
                    //    //DIAGONAL HACIA ABAJO IZQUIERDA
                    //    r = CeldaActual.NroColumna;
                    //    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    //    {
                    //        r--;
                    //        if (VerificarLugar(i, r))
                    //        {
                    //            Matriz[i, r].Legal_Movim = true;
                    //        }

                    //    }

                    //    break;

            }
        }

        public void DesmarcarLugares(Celda CeldaActual, string PiezaAjedrez)
        {
            {

                //CAMBIA LA POSICION DONDE SE COLOCA LA PIEZA A OCUPADO
                Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Ocupados = false;




                //Paso 2: Buscar todos los movientos legales y marcar las celdas como 1
                switch (PiezaAjedrez)
                {
                    //PENSAMOS HACER DINAMIC CAST PARA CADA UNA DE LAS PIEZAS
                    case "Caballo":
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = null;
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                        }
                        break;

                    //case "Caballo2":
                    //    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                    //    {
                    //        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                    //    }
                    //    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                    //    {
                    //        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                    //    }
                    //    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                    //    {
                    //        Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim = false;
                    //    }
                    //    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                    //    {
                    //        Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim = false;
                    //    }
                    //    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                    //    {
                    //        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                    //    }
                    //    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                    //    {
                    //        Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                    //    }
                    //    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                    //    {
                    //        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim = false;
                    //    }
                    //    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                    //    {
                    //        Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim = false;
                    //    }
                    //    break;

                    case "Rey":
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = null;


                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1))
                        {
                            Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1].Legal_Movim = false;
                        }
                        if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1))
                        {
                            Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1].Legal_Movim = false;
                        }
                        break;
                    case "Reina":
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = null;

                        //ABAJO 
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }
                        }
                        //ARRIBA
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }

                        }

                        //PARA LA DERECHA
                        for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }
                        //PARA LA IZQUIERDA
                        for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }

                        //DIAGONAL HACIA ABAJO DERECHA
                        int r = CeldaActual.NroColumna;

                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA DERECHA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ABAJO IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }

                        }
                        break;

                    case "Torre":
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = null;

                        //ABAJO 
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }
                        }
                        //ARRIBA
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            if (VerificarLugar(i, CeldaActual.NroColumna))
                            {
                                Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                            }

                        }

                        //PARA LA DERECHA
                        for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }
                        //PARA LA IZQUIERDA
                        for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                        {
                            if (VerificarLugar(CeldaActual.NroFila, j))
                            {
                                Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                            }
                        }
                        break;

                    //case "Torre2":
                    //    //ABAJO 
                    //    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    //    {
                    //        if (VerificarLugar(i, CeldaActual.NroColumna))
                    //        {
                    //            Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                    //        }
                    //    }
                    //    //ARRIBA
                    //    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    //    {
                    //        if (VerificarLugar(i, CeldaActual.NroColumna))
                    //        {
                    //            Matriz[i, CeldaActual.NroColumna].Legal_Movim = false;
                    //        }

                    //    }

                    //    //PARA LA DERECHA
                    //    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                    //    {
                    //        if (VerificarLugar(CeldaActual.NroFila, j))
                    //        {
                    //            Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                    //        }
                    //    }
                    //    //PARA LA IZQUIERDA
                    //    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                    //    {
                    //        if (VerificarLugar(CeldaActual.NroFila, j))
                    //        {
                    //            Matriz[CeldaActual.NroFila, j].Legal_Movim = false;
                    //        }
                    //    }
                    //    break;

                    //case "Alfil_Negro":
                    case "Alfil":
                        Matriz[CeldaActual.NroFila, CeldaActual.NroColumna].Pieza = null;

                        //DIAGONAL HACIA ABAJO DERECHA
                        r = CeldaActual.NroColumna;

                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ARRIBA DERECHA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        {
                            r++;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }
                        }
                        //DIAGONAL HACIA ABAJO IZQUIERDA
                        r = CeldaActual.NroColumna;
                        for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        {
                            r--;
                            if (VerificarLugar(i, r))
                            {
                                Matriz[i, r].Legal_Movim = false;
                            }

                        }

                        break;

                        //case "Alfil_Blanco":

                        //    //DIAGONAL HACIA ABAJO DERECHA
                        //    r = CeldaActual.NroColumna;

                        //    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        //    {
                        //        r++;
                        //        if (VerificarLugar(i, r))
                        //        {
                        //            Matriz[i, r].Legal_Movim = false;
                        //        }
                        //    }
                        //    //DIAGONAL HACIA ARRIBA IZQUIERDA
                        //    r = CeldaActual.NroColumna;
                        //    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        //    {
                        //        r--;
                        //        if (VerificarLugar(i, r))
                        //        {
                        //            Matriz[i, r].Legal_Movim = false;
                        //        }
                        //    }
                        //    //DIAGONAL HACIA ARRIBA DERECHA
                        //    r = CeldaActual.NroColumna;
                        //    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                        //    {
                        //        r++;
                        //        if (VerificarLugar(i, r))
                        //        {
                        //            Matriz[i, r].Legal_Movim = false;
                        //        }
                        //    }
                        //    //DIAGONAL HACIA ABAJO IZQUIERDA
                        //    r = CeldaActual.NroColumna;
                        //    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                        //    {
                        //        r--;
                        //        if (VerificarLugar(i, r))
                        //        {
                        //            Matriz[i, r].Legal_Movim = false;
                        //        }

                        //    }

                        //    break;

                }
                for (int i = 0; i < Tam; i++)
                {
                    for (int j = 0; j < Tam; j++)
                    {
                        if (Matriz[i, j].Ocupados == true)
                        {
                            MarcarProx_MovLegal(Matriz[i, j], Matriz[i, j].Pieza);
                        }
                    }
                }

            }
        }

        // FUNCION REINICIA TODO EL TABLERO
        public void ReiniciarTablero()
        {
            for (int i = 0; i < Tam; i++)
            {
                for (int j = 0; j < Tam; j++)
                {
                    Matriz[i, j].Ocupados = false;
                    Matriz[i, j].Legal_Movim = false;
                }
            }
        }

        public void ImprimirTablero()
        {
            for (int i = 0; i < Tam; i++)
            {
                for (int j = 0; j < Tam; j++)
                {
                    Celda C_aux = Matriz[i, j];
                    if (C_aux.Ocupados == true && C_aux.Pieza == "Caballo")
                    {
                        Console.Write("|C|");
                    }
                    else if (C_aux.Ocupados == true && C_aux.Pieza == "Reina")
                    {
                        Console.Write("|R|");
                    }
                    else if (C_aux.Ocupados == true && C_aux.Pieza == "Rey")
                    {
                        Console.Write("|r|");
                    }
                    else if (C_aux.Ocupados == true && C_aux.Pieza == "Torre")
                    {
                        Console.Write("|T|");
                    }
                    else if (C_aux.Ocupados == true && C_aux.Pieza == "Alfil")
                    {
                        Console.Write("|A|");
                    }
                    else if (C_aux.Legal_Movim == true && C_aux.Pieza != "Caballo")
                    {
                        Console.Write("|+|");
                    }
                    else if (C_aux.Legal_Movim == true && C_aux.Pieza != "Torre")
                    {
                        Console.Write("|+|");
                    }
                    else if (C_aux.Legal_Movim == true && C_aux.Pieza != "Rey")
                    {
                        Console.Write("|+|");
                    }
                    else if (C_aux.Legal_Movim == true && C_aux.Pieza != "Reina")
                    {
                        Console.Write("|+|");
                    }
                    else if (C_aux.Legal_Movim == true && C_aux.Pieza != "Alfil")
                    {
                        Console.Write("|+|");
                    }
                    else
                    {
                        //las que se encuentran vacias
                        Console.Write("|.|");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("========================");

        }

        public int CalcularCantMovLegales(Celda CeldaActual, string PiezaAjedrez)
        {
            switch (PiezaAjedrez)
            {
                case "Caballo1":
                    PiezaAjedrez = "Caballo";
                    break;
                case "Caballo2":
                    PiezaAjedrez = "Caballo";
                    break;
                case "Torre1":
                    PiezaAjedrez = "Torre";
                    break;
                case "Torre2":
                    PiezaAjedrez = "Torre";
                    break;
                case "Rey":
                    PiezaAjedrez = "Rey";
                    break;
                case "Reina":
                    PiezaAjedrez = "Reina";
                    break;
                case "Alfil_Blanco":
                    PiezaAjedrez = "Alfil";
                    break;
                case "Alfin_Negro":
                    PiezaAjedrez = "Alfil";
                    break;
            }


            int contador = 0;
            switch (PiezaAjedrez)
            {
                case "Caballo":
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1))
                    {
                        if (Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna - 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1))
                    {
                        if (Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna + 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1))
                    {
                        if (Matriz[CeldaActual.NroFila + 2, CeldaActual.NroColumna - 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1))
                    {
                        if (Matriz[CeldaActual.NroFila - 2, CeldaActual.NroColumna + 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2))
                    {
                        if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 2].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2))
                    {
                        if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 2].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2))
                    {
                        if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 2].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2))
                    {
                        if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 2].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    break;

                case "Rey":
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna))
                    {
                        if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna))
                    {
                        if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1))
                    {
                        if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna - 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1))
                    {
                        if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna + 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna - 1))
                    {
                        if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna - 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila, CeldaActual.NroColumna + 1))
                    {
                        if (Matriz[CeldaActual.NroFila, CeldaActual.NroColumna + 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1))
                    {
                        if (Matriz[CeldaActual.NroFila - 1, CeldaActual.NroColumna + 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    if (VerificarLugar(CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1))
                    {
                        if (Matriz[CeldaActual.NroFila + 1, CeldaActual.NroColumna - 1].Legal_Movim == false)
                        {
                            contador++;
                        }
                    }
                    break;

                case "Reina":
                    //ABAJO 
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            if (Matriz[i, CeldaActual.NroColumna].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //ARRIBA
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            if (Matriz[i, CeldaActual.NroColumna].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }

                    }

                    //PARA LA DERECHA
                    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            if (Matriz[CeldaActual.NroFila, j].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //PARA LA IZQUIERDA
                    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            if (Matriz[CeldaActual.NroFila, j].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }

                    //DIAGONAL HACIA ABAJO DERECHA
                    int r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            if (Matriz[i, r].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            if (Matriz[i, r].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            if (Matriz[i, r].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            if (Matriz[i, r].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }

                    }
                    break;

                case "Torre":
                    //ABAJO 
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            if (Matriz[i, CeldaActual.NroColumna].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //ARRIBA
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        if (VerificarLugar(i, CeldaActual.NroColumna))
                        {
                            if (Matriz[i, CeldaActual.NroColumna].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }

                    }

                    //PARA LA DERECHA
                    for (int j = CeldaActual.NroColumna + 1; j < Tam; j++)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            if (Matriz[CeldaActual.NroFila, j].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //PARA LA IZQUIERDA
                    for (int j = CeldaActual.NroColumna - 1; j >= 0; j--)
                    {
                        if (VerificarLugar(CeldaActual.NroFila, j))
                        {
                            if (Matriz[CeldaActual.NroFila, j].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    break;

                case "Alfil_Negro":

                    //DIAGONAL HACIA ABAJO DERECHA
                    r = CeldaActual.NroColumna;

                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            if (Matriz[i, r].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //DIAGONAL HACIA ARRIBA IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            if (Matriz[i, r].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //DIAGONAL HACIA ARRIBA DERECHA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila - 1; i >= 0; i--)
                    {
                        r++;
                        if (VerificarLugar(i, r))
                        {
                            if (Matriz[i, r].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }
                    }
                    //DIAGONAL HACIA ABAJO IZQUIERDA
                    r = CeldaActual.NroColumna;
                    for (int i = CeldaActual.NroFila + 1; i < Tam; i++)
                    {
                        r--;
                        if (VerificarLugar(i, r))
                        {
                            if (Matriz[i, r].Legal_Movim == false)
                            {
                                contador++;
                            }
                        }

                    }
                    break;

            }

            return contador;
        }


        //VERIFICA SI LA COORDENADA PASADA EXISTE EN EL TABLERO SINO RETORNA FALSE
        private bool VerificarLugar(int x1, int y2)
        {
            if (x1 >= 0 && x1 < Tam && y2 >= 0 && y2 < Tam)
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
